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
            var feedback = _context.Feedbacks.Find(id);
            if (feedback == null)
                return NotFound();

            feedback.IsHidden = !feedback.IsHidden;
            _context.SaveChanges();

            return RedirectToAction("CommentDetails", new { id });
        }
    }
}
