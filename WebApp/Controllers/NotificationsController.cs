using ClassLibrary.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Controllers
{
    public class NotificationsController : Controller
    {
        private readonly CourseDBContext _context;

        public NotificationsController(CourseDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var userIdStr = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(userIdStr) || !int.TryParse(userIdStr, out int userId))
                return RedirectToAction("Login", "Auth");

            var notifications = _context.Notifications
                .Where(n => n.UserId == userId)
                .OrderByDescending(n => n.Date)
                .ToList();

            return View("Notifications", notifications);
        }

        [HttpPost]
        public IActionResult MarkAsRead(int id)
        {
            var notification = _context.Notifications.FirstOrDefault(n => n.NotificationId == id);
            if (notification != null && !notification.IsRead)
            {
                notification.IsRead = true;
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
