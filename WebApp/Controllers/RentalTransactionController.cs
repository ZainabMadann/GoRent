using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Model;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class RentalTransactionController : Controller
    {
        private readonly CourseDBContext _context;

        public RentalTransactionController(CourseDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var transactions = _context.RentalTransactions
                .Include(t => t.Equipment)
                .Include(t => t.User)
                .Include(t => t.RentalRequest)
                .ToList();

            return View(transactions);
        }

        [HttpGet]
        public IActionResult Payment(int rentalRequestId)
        {
            var request = _context.RentalRequests
                .Include(r => r.Equipment)
                .FirstOrDefault(r => r.RentalRequestId == rentalRequestId);

            if (request == null)
                return NotFound("Rental request not found.");

            var days = (request.EndDate - request.StartDate).Days;
            var pricePerDay = request.Equipment?.RentalRate ?? 0;
            var total = days * pricePerDay;

            var viewModel = new PaymentViewModel
            {
                RentalRequestId = rentalRequestId,
                Amount = total
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ProcessPayment(PaymentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Payment", model);
            }

            var request = _context.RentalRequests
                .Include(r => r.Equipment)
                .Include(r => r.User)
                .FirstOrDefault(r => r.RentalRequestId == model.RentalRequestId);

            if (request == null)
                return NotFound("Rental request not found.");

            var transaction = new RentalTransaction
            {
                RentalStartDate = request.StartDate,
                RentalEndDate = request.EndDate,
                TotalCost = model.Amount,
                PaymentStatus = "Paid",
                RentalRequestId = request.RentalRequestId,
                EquipmentId = request.EquipmentId,
                UserId = request.UserId
            };

            _context.RentalTransactions.Add(transaction);
            _context.SaveChanges();

            TempData["Message"] = "Payment successful and rental transaction created!";
            return RedirectToAction("Profile", "Auth");
        }

        public IActionResult Details(int id)
        {
            var transaction = _context.RentalTransactions
                .Include(t => t.Equipment)
                .Include(t => t.User)
                .Include(t => t.RentalRequest)
                .FirstOrDefault(t => t.RentalTransactionId == id);

            if (transaction == null)
                return NotFound();

            return View(transaction);
        }
    }
}
