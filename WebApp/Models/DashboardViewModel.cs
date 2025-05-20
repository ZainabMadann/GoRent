using System;

namespace WebApp.Models
{
    public class DashboardViewModel
    {
        public int TotalEquipment { get; set; }
        public int TotalCategories { get; set; }
        public int TotalRequests { get; set; }


        public List<RequestStatusStat> RequestStatusBreakdown { get; set; } = new();

        public int OverdueRequests { get; set; }
        public double AverageOverdueDays { get; set; }
        public string MostOverdueItem { get; set; } = "N/A";

        public List<CategoryStat> EquipmentPerCategory { get; set; } = new();

        public decimal TotalRevenue { get; set; }
        public decimal PendingPayments { get; set; }
        public decimal NetProfit => TotalRevenue - PendingPayments;

        public int TotalTransactions { get; set; }
        public int PaidTransactions { get; set; }
        public int PendingTransactions { get; set; }

        public List<RecentActivity> RecentActivities { get; set; } = new();
    }

    public class RequestStatusStat
    {
        public string Status { get; set; } = string.Empty;
        public int Count { get; set; }
    }

    public class CategoryStat
    {
        public string Name { get; set; } = string.Empty;
        public int Count { get; set; }
    }

    public class RecentActivity
    {
        public DateTime Date { get; set; }
        public string User { get; set; } = "";
        public string Description { get; set; } = "";
    }
}