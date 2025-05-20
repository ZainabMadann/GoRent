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
    public partial class Home : Form
    {
        FormsIdentityContext IdentityContext = new FormsIdentityContext();
        public Home()
        {
            InitializeComponent();
        }

        private void btnRentalRequestsPage_Click(object sender, EventArgs e)
        {
            RentalRequests rentalRequests = new RentalRequests();
            rentalRequests.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btnRentalRecords_Click(object sender, EventArgs e)
        {
            ReturnRecords returnRecords = new ReturnRecords();
            returnRecords.Show();
            this.Hide();
        }

        private void btnRentalTransactions_Click(object sender, EventArgs e)
        {
            RentalTransactions returnTransactions = new RentalTransactions();
            returnTransactions.Show();
            this.Hide();
        }

        private void btnEquipments_Click(object sender, EventArgs e)
        {
            Equipment equipment = new Equipment();
            equipment.Show();
            this.Hide();
        }

        private void btnAdminLogs_Click(object sender, EventArgs e)
        {
            AdminLogs adminLogs = new AdminLogs();
            adminLogs.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (Global.RoleName != "Admin")
            {
                btnAdminLogs.Visible = false;
            }
        }
    }
}
