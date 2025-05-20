using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;
using ClassLibrary.Model;

namespace WebApp.Controllers
{
    public class DashboardController : Controller
    {
        private readonly CourseDBContext _context;

        public DashboardController(CourseDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = new DashboardViewModel();

            // Equipment and Category
            model.TotalEquipment = _context.Equipment.Count();
            model.TotalCategories = _context.Categories.Count();

            // Request Status Breakdown
            model.TotalRequests = _context.RentalRequests.Count();
            model.RequestStatusBreakdown = _context.RentalRequests
                .Include(r => r.RequestStatus)
                .GroupBy(r => r.RequestStatus.Description)
                .Select(g => new RequestStatusStat
                {
                    Status = g.Key,
                    Count = g.Count()
                }).ToList();

            // Overdue
            var overdue = _context.RentalRequests
                .Include(r => r.Equipment)
                .Where(r => r.RequestStatusId == 2 && r.EndDate < DateTime.Today)
                .ToList();

            model.OverdueRequests = overdue.Count;
            model.AverageOverdueDays = overdue.Any()
                ? overdue.Average(r => (DateTime.Today - r.EndDate).TotalDays)
                : 0;
            model.MostOverdueItem = overdue
                .OrderByDescending(r => (DateTime.Today - r.EndDate).TotalDays)
                .FirstOrDefault()?.Equipment?.Name ?? "N/A";

            // Equipment per category
            model.EquipmentPerCategory = _context.Equipment
                .Include(e => e.Category)
                .GroupBy(e => e.Category.Name)
                .Select(g => new CategoryStat
                {
                    Name = g.Key,
                    Count = g.Count()
                }).ToList();

            // Transactions
            var transactions = _context.RentalTransactions.ToList();
            model.TotalTransactions = transactions.Count;
            model.PaidTransactions = transactions.Count(t => t.PaymentStatus == "Paid");
            model.PendingTransactions = transactions.Count(t => t.PaymentStatus.ToLower() == "pending");

            model.TotalRevenue = transactions
                .Where(t => t.PaymentStatus == "Paid")
                .Sum(t => t.TotalCost);

            model.PendingPayments = transactions
                .Where(t => t.PaymentStatus.ToLower() == "pending")
                .Sum(t => t.TotalCost);

            // Recent
            model.RecentActivities = _context.RentalRequests
                .Include(r => r.Equipment)
                .Include(r => r.User)
                .OrderByDescending(r => r.RequestDate)
                .Take(10)
                .Select(r => new RecentActivity
                {
                    Date = r.RequestDate,
                    User = r.User.Name ?? r.User.Email,
                    Description = $"Requested {r.Equipment.Name}"
                }).ToList();

            return View("Dashboard", model);
        }
    }
}
