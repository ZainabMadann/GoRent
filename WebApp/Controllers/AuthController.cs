using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System.Linq;
using ClassLibrary.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace WebApp.Controllers
{
    public class AuthController : Controller
    {
        private readonly CourseDBContext _context;

        public AuthController(CourseDBContext context)
        {
            _context = context;
        }

        // GET: /Auth/Register
        public IActionResult Register()
        {
            return View("~/Views/Auth/Register.cshtml");
        }

        // POST: /Auth/Register
        [HttpPost]
        public IActionResult Register(string fullName, string email, string password)
        {
            if (_context.Users.Any(u => u.Email == email))
            {
                ModelState.AddModelError("", "Email already exists");
                return View();
            }

            var passwordHasher = new PasswordHasher<User>();
            var user = new User
            {
                Name = fullName,
                Email = email,
                Role = "Customer"
            };

            user.Password = passwordHasher.HashPassword(user, password);
            _context.Users.Add(user);
            _context.SaveChanges();

            // Log registration
            _context.Logs.Add(new Log
            {
                Action = "REGISTER",
                UserId = user.UserId,
                EntityChanged = "User",
                OriginalValue = "-",
                CurrentValue = "New user registered",
                TimeStamp = DateTime.Now
            });
            _context.SaveChanges();

            TempData["Message"] = "Registration successful. Please log in.";
            return RedirectToAction("Login");
        }

        // GET: /Auth/Login
        public IActionResult Login()
        {
            return View("~/Views/Auth/Login.cshtml");
        }

        // POST: /Auth/Login
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email);
            if (user == null)
            {
                // Log failed login (user not found)
                _context.Logs.Add(new Log
                {
                    Action = "FAILED_LOGIN",
                    UserId = null,
                    EntityChanged = "Auth",
                    OriginalValue = "-",
                    CurrentValue = $"Failed login - unknown user ({email})",
                    TimeStamp = DateTime.Now
                });
                _context.SaveChanges();

                ModelState.AddModelError("", "Invalid email or password");
                return View();
            }

            var passwordHasher = new PasswordHasher<User>();
            var result = passwordHasher.VerifyHashedPassword(user, user.Password, password);

            if (result == PasswordVerificationResult.Failed)
            {
                // Log failed login
                _context.Logs.Add(new Log
                {
                    Action = "FAILED_LOGIN",
                    UserId = user.UserId,
                    EntityChanged = "Auth",
                    OriginalValue = "-",
                    CurrentValue = "Invalid password attempt",
                    TimeStamp = DateTime.Now
                });
                _context.SaveChanges();

                ModelState.AddModelError("", "Invalid email or password");
                return View();
            }

            // Log successful login
            _context.Logs.Add(new Log
            {
                Action = "LOGIN",
                UserId = user.UserId,
                EntityChanged = "Auth",
                OriginalValue = "-",
                CurrentValue = "User logged in",
                TimeStamp = DateTime.Now
            });
            _context.SaveChanges();

            HttpContext.Session.SetString("UserId", user.UserId.ToString());
            HttpContext.Session.SetString("Role", user.Role);
            HttpContext.Session.SetString("Name", user.Name);
            TempData.Remove("Message");

            return RedirectToAction("Profile");
        }

        // GET: /Auth/Profile
        public IActionResult Profile()
        {
            var userIdStr = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(userIdStr))
                return RedirectToAction("Login");

            int userId = int.Parse(userIdStr);
            var user = _context.Users.Find(userId);

            return View(user);
        }

        // GET: /Auth/Logout
        public IActionResult Logout()
        {
            var userIdStr = HttpContext.Session.GetString("UserId");

            if (!string.IsNullOrEmpty(userIdStr) && int.TryParse(userIdStr, out int userId))
            {
                // Log logout
                _context.Logs.Add(new Log
                {
                    Action = "LOGOUT",
                    UserId = userId,
                    EntityChanged = "Auth",
                    OriginalValue = "-",
                    CurrentValue = "User logged out",
                    TimeStamp = DateTime.Now
                });
                _context.SaveChanges();
            }

            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        // POST: /Auth/UpdateProfile
        [HttpPost]
        public IActionResult UpdateProfile(string fullName, string email)
        {
            var userIdStr = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(userIdStr))
                return RedirectToAction("Login");

            int userId = int.Parse(userIdStr);
            var user = _context.Users.Find(userId);
            if (user == null)
                return RedirectToAction("Login");

            if (email != user.Email && _context.Users.Any(u => u.Email == email))
            {
                TempData["Error"] = "The email is already used by another user.";
                return RedirectToAction("Profile");
            }

            string oldName = user.Name;
            string oldEmail = user.Email;

            user.Name = fullName;
            user.Email = email;
            _context.Users.Update(user);
            _context.SaveChanges();

            // Log profile update
            _context.Logs.Add(new Log
            {
                Action = "UPDATE_PROFILE",
                UserId = user.UserId,
                EntityChanged = "User",
                OriginalValue = $"Name: {oldName}, Email: {oldEmail}",
                CurrentValue = $"Name: {fullName}, Email: {email}",
                TimeStamp = DateTime.Now
            });
            _context.SaveChanges();

            HttpContext.Session.SetString("Name", user.Name);
            TempData["Message"] = "Profile updated successfully.";

            return RedirectToAction("Profile");
        }

        // POST: /Auth/ChangePassword
        [HttpPost]
        public IActionResult ChangePassword(string currentPassword, string newPassword, string confirmPassword)
        {
            var userIdStr = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(userIdStr))
                return RedirectToAction("Login");

            int userId = int.Parse(userIdStr);
            var user = _context.Users.Find(userId);
            if (user == null)
                return RedirectToAction("Login");

            if (newPassword != confirmPassword)
            {
                TempData["Error"] = "New password and confirmation do not match.";
                return RedirectToAction("Profile");
            }

            var passwordHasher = new PasswordHasher<User>();
            var result = passwordHasher.VerifyHashedPassword(user, user.Password, currentPassword);
            if (result == PasswordVerificationResult.Failed)
            {
                TempData["Error"] = "Current password is incorrect.";
                return RedirectToAction("Profile");
            }

            user.Password = passwordHasher.HashPassword(user, newPassword);
            _context.Users.Update(user);
            _context.SaveChanges();

            // Log password change
            _context.Logs.Add(new Log
            {
                Action = "CHANGE_PASSWORD",
                UserId = user.UserId,
                EntityChanged = "User",
                OriginalValue = "-",
                CurrentValue = "Password changed",
                TimeStamp = DateTime.Now
            });
            _context.SaveChanges();

            TempData["Message"] = "Password changed successfully.";
            return RedirectToAction("Profile");
        }
    }
}
