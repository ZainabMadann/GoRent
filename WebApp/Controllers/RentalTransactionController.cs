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

            return View("TransactionDetails", transaction); 
        }

        [HttpGet]
        public IActionResult MyTransactions()
        {
            var userIdStr = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(userIdStr)) return Unauthorized();

            int userId = int.Parse(userIdStr);

            var transactions = _context.RentalTransactions
                .Where(t => t.UserId == userId)
                .Include(t => t.Equipment)
                .Include(t => t.RentalRequest)
                .OrderByDescending(t => t.RentalTransactionId)
                .ToList();

            return PartialView("_MyTransactionsPartial", transactions);
        }
        [HttpGet]
        public IActionResult ManageTransactions()
        {
            var allTransactions = _context.RentalTransactions
                .Include(t => t.Equipment)
                .Include(t => t.User)
                .Include(t => t.RentalRequest)
                .OrderByDescending(t => t.RentalTransactionId)
                .ToList();

            ViewBag.Users = _context.Users.ToList();
            ViewBag.Equipment = _context.Equipment.ToList();
            ViewBag.RentalRequests = _context.RentalRequests.ToList();

            return View("ManageTransactions", allTransactions);
        }




        [HttpPost]
        public IActionResult UpdateTransaction(int RentalTransactionId, string? PaymentStatus, decimal? TotalCost, bool cancel = false)
        {
            var transaction = _context.RentalTransactions.FirstOrDefault(t => t.RentalTransactionId == RentalTransactionId);
            if (transaction == null) return NotFound();

            if (cancel)
            {
                transaction.PaymentStatus = "Cancelled";
            }
            else
            {
                transaction.PaymentStatus = PaymentStatus ?? transaction.PaymentStatus;
                transaction.TotalCost = TotalCost ?? transaction.TotalCost;
            }

            _context.SaveChanges();
            TempData["Message"] = cancel ? "Transaction cancelled." : "Transaction updated.";
            return RedirectToAction("Details", new { id = RentalTransactionId });
        }

        [HttpPost]
        public IActionResult CreateTransaction(int RentalRequestId, int EquipmentId, int UserId, decimal TotalCost, string PaymentStatus)
        {
            var request = _context.RentalRequests.FirstOrDefault(r => r.RentalRequestId == RentalRequestId);
            if (request == null)
            {
                TempData["Error"] = "Rental request not found.";
                return RedirectToAction("ManageTransactions");
            }

            var transaction = new RentalTransaction
            {
                RentalRequestId = RentalRequestId,
                EquipmentId = EquipmentId,
                UserId = UserId,
                TotalCost = TotalCost,
                PaymentStatus = PaymentStatus,
                RentalStartDate = request.StartDate,
                RentalEndDate = request.EndDate
            };

            _context.RentalTransactions.Add(transaction);
            _context.SaveChanges();

            TempData["Message"] = "Rental transaction created successfully.";
            return RedirectToAction("ManageTransactions");
        }
        [HttpGet]
        public IActionResult FilterTransactions(string searchTerm, string filterStatus)
        {
            var transactionsQuery = _context.RentalTransactions
                .Include(t => t.Equipment)
                .Include(t => t.User)
                .Include(t => t.RentalRequest)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = searchTerm.ToLower();

                transactionsQuery = transactionsQuery.Where(t =>
                    t.RentalTransactionId.ToString().Contains(searchTerm) ||
                    t.TotalCost.ToString().Contains(searchTerm) ||
                    t.PaymentStatus.ToLower().Contains(searchTerm) ||
                    t.Equipment.Name.ToLower().Contains(searchTerm) ||
                    t.User.Email.ToLower().Contains(searchTerm) ||
                    t.RentalRequestId.ToString().Contains(searchTerm)
                );
            }

            if (!string.IsNullOrWhiteSpace(filterStatus) && filterStatus != "all")
            {
                transactionsQuery = transactionsQuery.Where(t =>
                    t.PaymentStatus.ToLower() == filterStatus.ToLower());
            }

            var filteredList = transactionsQuery
                .OrderByDescending(t => t.RentalTransactionId)
                .ToList();

            return PartialView("_FilteredTransactionPartial", filteredList);
        }


        [HttpGet]
        public IActionResult FilterMyTransactions(string searchTerm, string filterStatus)
        {
            var userIdStr = HttpContext.Session.GetString("UserId");
            if (string.IsNullOrEmpty(userIdStr)) return Unauthorized();

            int userId = int.Parse(userIdStr);

            var transactionsQuery = _context.RentalTransactions
                .Where(t => t.UserId == userId)
                .Include(t => t.Equipment)
                .Include(t => t.RentalRequest)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                searchTerm = searchTerm.ToLower();

                transactionsQuery = transactionsQuery.Where(t =>
                    t.RentalTransactionId.ToString().Contains(searchTerm) ||
                    t.TotalCost.ToString().Contains(searchTerm) ||
                    t.PaymentStatus.ToLower().Contains(searchTerm) ||
                    t.Equipment.Name.ToLower().Contains(searchTerm) ||
                    t.RentalRequestId.ToString().Contains(searchTerm)
                );
            }

            if (!string.IsNullOrWhiteSpace(filterStatus) && filterStatus != "all")
            {
                transactionsQuery = transactionsQuery.Where(t =>
                    t.PaymentStatus.ToLower() == filterStatus.ToLower());
            }

            var filteredTransactions = transactionsQuery
                .OrderByDescending(t => t.RentalTransactionId)
                .ToList();

            return PartialView("_MyTransactionsPartial", filteredTransactions);
        }




    }
}
