using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Dashboard : Form
    {
        CourseDBContext context;
        public Dashboard()
        {
            InitializeComponent();
            context = new CourseDBContext();
        }

        private void lblTopSellingProduct_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //calling the LoadStatistcs method
            LoadStatistcs();
        }

        // loading the labels with the right information
        public void LoadStatistcs()
        {
            lblTotalEquipment.Text = context.Equipment.Count().ToString();
            lblApprovedRentals.Text = context.RentalRequests.Where(x => x.RequestStatus.Name == "Approved").Count().ToString();
            lblTotalSales.Text = context.RentalTransactions.Sum(x => x.TotalCost).ToString("C");
            lblRentedEquipment.Text = context.RentalTransactions.Count().ToString();
            lblCancelledRentals.Text = context.RentalRequests.Where(x => x.RequestStatus.Name == "Cancelled").Count().ToString();
            lblMostRentedItem.Text = context.RentalTransactions
                .GroupBy(x => x.Equipment.Name)
                .OrderByDescending(g => g.Count())
                .Select(g => g.Key)
                .FirstOrDefault() ?? "No Rentals Yet";

            var currentMonth = DateTime.Now.Month;
            var currentYear = DateTime.Now.Year;
            lblTotalMonth.Text = context.RentalTransactions
                .Where(x => x.RentalStartDate.Month == currentMonth && x.RentalStartDate.Year == currentYear)
                .Sum(x => x.TotalCost)
                .ToString("C");

            lblPendingRequests.Text = context.RentalRequests
             .Where(x => x.RequestStatus.Name == "Pending")
             .Count()
             .ToString();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
