using ClassLibrary.Model;
using Microsoft.EntityFrameworkCore;
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
    public partial class RentalTransactions : Form
    {
        CourseDBContext context;

        public RentalTransactions()
        {
            InitializeComponent();
            context = new CourseDBContext();
        }

        // Event handler: When Create Rental Transaction button is clicked
        private void btnCreateRentalTransaction_Click(object sender, EventArgs e)
        {
            // Get selected rental request ID from the grid
            int rentalID = Convert.ToInt32(dgvRentalRequests.SelectedCells[0].OwningRow.Cells[0].Value);
            // Fetch corresponding rental request from the database
            RentalRequest rental = context.RentalRequests.Single(x => x.RentalRequestId == rentalID);
            // Open CreateTransaction form in dialog mode
            CreateTransaction createTransaction = new CreateTransaction(rental);
            createTransaction.ShowDialog();

            // Refresh both grids if transaction was successfully created
            if (createTransaction.DialogResult == DialogResult.OK)
            {
                RefereshGridView();
                RefereshRentalGridView();
            }
        }

        // Form Load Event: populate dropdowns and load initial data
        private void RentalTransactions_Load(object sender, EventArgs e)
        {
            try
            {
                // Populate the request status dropdown for filtering
                ddlRequestsStatus.DataSource = context.RequestStatuses.ToList();
                ddlRequestsStatus.DisplayMember = "Name";
                ddlRequestsStatus.ValueMember = "RequestStatusId";
                ddlRequestsStatus.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Load data into both DataGridViews
            RefereshGridView();
            RefereshRentalGridView();
        }

        // Load rental transactions into the transaction DataGridView
        private void RefereshGridView()
        {
            dgvRentalTransaction.DataSource = null;

            try
            {
                var transactionsToShow = context.RentalTransactions.AsQueryable();

                // Filter by customer name
                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    transactionsToShow = transactionsToShow.Where(x => x.User.Name.Contains(txtSearch.Text));
                }

                if(txtEmail.Text != "")
                {
                    transactionsToShow = transactionsToShow.Where(x => x.User.Email.Contains(txtEmail.Text));
                }

                // Filter by payment status
                if (ddlStatus.SelectedItem != null)
                {
                    string selectedStatus = ddlStatus.SelectedItem.ToString();
                    transactionsToShow = transactionsToShow.Where(x => x.PaymentStatus == selectedStatus);
                }

                // Display message if no matching records
                if (!transactionsToShow.Any())
                {
                    MessageBox.Show("No record found");
                }
                else
                {
                    // Populate DataGridView with formatted data
                    dgvRentalTransaction.DataSource = transactionsToShow
                        .Select(x => new
                        {
                            TransactionID = x.RentalTransactionId,
                            RentalStartDate = x.RentalStartDate,
                            TotalCost = x.TotalCost,
                            RentalEndDate = x.RentalEndDate,
                            PaymentStatus = x.PaymentStatus,
                            RentalRequestID = x.RentalRequest.RentalRequestId,
                            EquipmentID = x.Equipment.Name,
                            CustomerName = x.User.Name,
                            CustomerEmail = x.User.Email
                        }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Load rental requests into the requests DataGridView (only those without transactions)
        private void RefereshRentalGridView()
        {
            dgvRentalRequests.DataSource = null;

            try
            {
                var rentalsToShow = context.RentalRequests
                    .Include(x => x.User)
                    .Include(x => x.Equipment)
                    .Include(x => x.RequestStatus)
                    .Where(x => !x.RentalTransactions.Any()) // Exclude already-processed requests
                    .AsQueryable();

                // Filter by customer name
                if (!string.IsNullOrWhiteSpace(txtSearchRequests.Text))
                {
                    rentalsToShow = rentalsToShow.Where(x => x.User.Name.Contains(txtSearchRequests.Text));
                }

                if(txtEmailRequests.Text != "")
                {
                    rentalsToShow = rentalsToShow.Where(x => x.User.Email.Contains(txtEmailRequests.Text));
                }

                // Filter by request status
                if (ddlRequestsStatus.SelectedValue != null)
                {
                    int selectedStatusId = Convert.ToInt32(ddlRequestsStatus.SelectedValue);
                    rentalsToShow = rentalsToShow.Where(x => x.RequestStatus.RequestStatusId == selectedStatusId);
                }

                // Display message if no matching records
                if (!rentalsToShow.Any())
                {
                    MessageBox.Show("No record found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Populate DataGridView with formatted data
                    dgvRentalRequests.DataSource = rentalsToShow
                        .Select(x => new
                        {
                            RentalRequestID = x.RentalRequestId,
                            CustomerName = x.User.Name,
                            CustomerEmail = x.User.Email,
                            Equipment = x.Equipment.Name,
                            RequestDate = x.RequestDate.ToString("yyyy-MM-dd"),
                            StartDate = x.StartDate.ToString("yyyy-MM-dd"),
                            EndDate = x.EndDate.ToString("yyyy-MM-dd"),
                            RequestStatus = x.RequestStatus.Name
                        })
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Search transactions by customer name and payment status
        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefereshGridView();
        }

        // Clear transaction filters and reload all data
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtEmail.Text = "";
            ddlStatus.SelectedItem = null;
            RefereshGridView();
        }

        // Navigate to Home form
        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        // Edit selected transaction
        private void btnEditRentalTransaction_Click(object sender, EventArgs e)
        {
            int transactionID = Convert.ToInt32(dgvRentalTransaction.SelectedCells[0].OwningRow.Cells[0].Value);
            CreateTransaction editTransaction = new CreateTransaction(transactionID);
            editTransaction.ShowDialog();

            if (editTransaction.DialogResult == DialogResult.OK)
            {
                RefereshGridView();
            }
        }

        // Apply filters to rental requests
        private void btnFilterRequests_Click(object sender, EventArgs e)
        {
            RefereshRentalGridView();
        }

        // Clear request filters and reload all pending rental requests
        private void btnRefereshRequests_Click(object sender, EventArgs e)
        {
            txtSearchRequests.Text = "";
            txtEmailRequests.Text = "";
            ddlRequestsStatus.SelectedItem = null;
            RefereshRentalGridView();
        }
    }
}
