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
    public partial class RentalRequests : Form
    {
        public RentalRequests()
        {
            InitializeComponent();
        }

        private void RentalRequests_Load(object sender, EventArgs e)
        {

        }

        private void cmbUserRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnViewTransactions_Click(object sender, EventArgs e)
        {
            ViewTransactions viewTransactions = new ViewTransactions();
            viewTransactions.ShowDialog();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnManageRentalRequests_Click(object sender, EventArgs e)
        {
            ManageRentalRequests manageRentalRequests = new ManageRentalRequests();
            manageRentalRequests.ShowDialog();
            this.Hide();
        }
    }
}
