using ClassLibrary.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly CourseDBContext _context;

        public FeedbackController(CourseDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitFeedback(int RentalTransactionId, int Rating, string Comment)
        {
            var userIdStr = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(userIdStr) || !int.TryParse(userIdStr, out int userId))
                return Unauthorized();

            var transaction = _context.RentalTransactions
                .Include(rt => rt.Equipment)
                .Include(rt => rt.User)
                .FirstOrDefault(rt => rt.RentalTransactionId == RentalTransactionId && rt.UserId == userId);

            if (transaction == null)
            {
                TempData["Error"] = "You can only review equipment you've rented.";
                return RedirectToAction("Details", "Equipment", new { id = 0 });
            }

            var feedback = new Feedback
            {
                Rating = Rating,
                Comment = Comment,
                UserId = userId,
                RentalTransactionId = RentalTransactionId
            };

            _context.Feedbacks.Add(feedback);
            _context.SaveChanges();

            // Notify all Admins and Managers
            var currentUser = _context.Users.FirstOrDefault(u => u.UserId == userId);
            var equipmentName = transaction.Equipment?.Name ?? "equipment";
            var userName = currentUser?.Name ?? currentUser?.Email;

            var message = $"{userName} submitted feedback for '{equipmentName}'.";

            var recipients = _context.Users
                .Where(u => u.Role == "Admin" || u.Role == "Manager")
                .ToList();

            foreach (var manager in recipients)
            {
                var notification = new Notification
                {
                    Massege = message,
                    Date = DateTime.Today,
                    UserId = manager.UserId,
                    IsRead = false
                };
                _context.Notifications.Add(notification);
            }

            _context.SaveChanges();

            TempData["Success"] = "Feedback submitted!";
            return RedirectToAction("Details", "Equipment", new { id = transaction.EquipmentId });
        }


        public IActionResult ManageComments()
        {
            var feedbacks = _context.Feedbacks
                .Include(f => f.RentalTransaction).ThenInclude(rt => rt.Equipment)
                .Include(f => f.User)
                .ToList();

            return View("ManageComments", feedbacks);
        }

        public IActionResult CommentDetails(int id)
        {
            var feedback = _context.Feedbacks
                .Include(f => f.User)
                .Include(f => f.RentalTransaction)
                .FirstOrDefault(f => f.FeedbackId == id);

            if (feedback == null)
                return NotFound();

            return View("CommentDetails", feedback);
        }


        [HttpPost]
        public IActionResult ToggleVisibility(int id)
        {
            var feedback = _context.Feedbacks
                .Include(f => f.User)
                .Include(f => f.RentalTransaction)
                .ThenInclude(rt => rt.Equipment)
                .FirstOrDefault(f => f.FeedbackId == id);

            if (feedback == null)
                return NotFound();

            feedback.IsHidden = !feedback.IsHidden;
            _context.SaveChanges();

            // Send notification to the feedback's author
            var statusText = feedback.IsHidden ? "hidden" : "visible";
            var equipmentName = feedback.RentalTransaction?.Equipment?.Name ?? "equipment";

            var notification = new Notification
            {
                UserId = feedback.UserId,
                Massege = $"Your feedback for '{equipmentName}' has been marked as {statusText} by a manager.",
                Date = DateTime.Today,
                IsRead = false
            };

            _context.Notifications.Add(notification);
            _context.SaveChanges();

            return RedirectToAction("CommentDetails", new { id });
        }

    }
}
