using Microsoft.AspNetCore.Mvc;
using ClassLibrary.Model;

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
            //return View();
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

            var user = new User
            {
                Name = fullName,
                Email = email,
                Password = password, // Hashing is recommended for production
                Role = "Customer"
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            TempData["Message"] = "Registration successful. Please log in.";
            return RedirectToAction("Login");
        }

        // GET: /Auth/Login
        public IActionResult Login()
        {
            //return View();
            return View("~/Views/Auth/Login.cshtml");

        }

        // POST: /Auth/Login
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user == null)
            {
                ModelState.AddModelError("", "Invalid email or password");
                return View();
            }

            HttpContext.Session.SetString("UserId", user.UserId.ToString());
            HttpContext.Session.SetString("Role", user.Role);
            HttpContext.Session.SetString("Name", user.Name);

            return RedirectToAction("Profile");
        }

        // GET: /Auth/Profile
        public IActionResult Profile()
        {
            var userIdStr = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(userIdStr)) return RedirectToAction("Login");

            int userId = int.Parse(userIdStr);
            var user = _context.Users.Find(userId);

            return View(user);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
