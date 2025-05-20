using ClassLibrary.Model; // Import the data model
using Microsoft.EntityFrameworkCore; // For Include() and async operations
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
    public partial class ReturnRecords : Form
    {
        CourseDBContext context; // Entity Framework database context

        public ReturnRecords()
        {
            InitializeComponent(); // Initialize the UI components
            context = new CourseDBContext(); // Create a new database context instance
        }

        // Called when Search button is clicked - refreshes the return records grid
        private void btnSearch_Click(object sender, EventArgs e)
        {
            RefereshGridView();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        // Form load event - loads data into dropdowns and initializes grids
        private void ReturnRecords_Load(object sender, EventArgs e)
        {
            // Load equipment condition options into dropdown
            ddlCondition.DataSource = context.EquipmentConditions.ToList();
            ddlCondition.DisplayMember = "Name";
            ddlCondition.ValueMember = "EquipmentConditionId";
            ddlCondition.SelectedItem = null;

            RefereshGridView(); // Load return records
            RefereshTransactionGridView(); // Load rental transactions
        }

        // Refresh the return records DataGridView with optional filters
        private void RefereshGridView()
        {
            dgvReturnRecord.DataSource = null; // Clear current data

            var returnRecordToShow = context.ReturnRecords.AsQueryable(); // Query all return records

            // Filter by user name if search text is entered
            if (txtSearch.Text != "")
            {
                returnRecordToShow = returnRecordToShow.Where(x => x.User.Name.Contains(txtSearch.Text));
            }

            if(txtEmail.Text != "")
            {
                returnRecordToShow = returnRecordToShow.Where(x => x.User.Email.Contains(txtEmail.Text));
            }

            // Filter by selected equipment condition
            if (ddlCondition.SelectedValue != null)
            {
                returnRecordToShow = returnRecordToShow.Where(x => x.EquipmentConditionId == Convert.ToInt32(ddlCondition.SelectedValue));
            }

            // If no records found, show message
            if (returnRecordToShow.Count() < 1)
            {
                MessageBox.Show("No record found");
            }
            else
            {
                // Populate DataGridView with selected return record data
                dgvReturnRecord.DataSource = returnRecordToShow
                    .Select(x => new
                    {
                        ReturnRecordID = x.ReturnRecordId,
                        ReturnDate = x.ReturnDate.ToString("yyyy-MM-dd"),
                        RentalTransactionID = x.RentalTransactionId,
                        EquipmentName = x.Equipment.Name,
                        CustomerName = x.User.Name,
                        CustomerEmai = x.User.Email,
                        EquipmentCondition = x.EquipmentCondition.Name
                    }).ToList();
            }
        }

        // Refresh the rental transactions DataGridView with optional filters
        private void RefereshTransactionGridView()
        {
            dgvRentalTransaction.DataSource = null; // Clear current data

            try
            {
                // Load related data and exclude transactions already returned
                var transactionsToShow = context.RentalTransactions
                    .Include(x => x.RentalRequest)
                    .Include(x => x.Equipment)
                    .Include(x => x.User)
                    .Include(x => x.ReturnRecords) // Ensure return records are loaded
                    .Where(x => !x.ReturnRecords.Any()) // Exclude already returned transactions
                    .AsQueryable();

                // Filter by customer name
                if (!string.IsNullOrWhiteSpace(txtTransactionSearch.Text))
                {
                    transactionsToShow = transactionsToShow.Where(x => x.User.Name.Contains(txtTransactionSearch.Text));
                }

                if(txtTransactionEmail.Text != "")
                {
                    transactionsToShow = transactionsToShow.Where(x => x.User.Email.Contains(txtTransactionEmail.Text));
                }
                // Filter by payment status
                if (ddlTransactionStatus.SelectedItem != null)
                {
                    string selectedStatus = ddlTransactionStatus.SelectedItem.ToString();
                    transactionsToShow = transactionsToShow.Where(x => x.PaymentStatus == selectedStatus);
                }

                // Show message if no results
                if (!transactionsToShow.Any())
                {
                    MessageBox.Show("No record found");
                }
                else
                {
                    // Populate DataGridView with selected transaction data
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
                            CUstomerEmail = x.User.Email
                        }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Display any exception messages
            }
        }

        // Refresh return records (clear filters)
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = ""; // Clear text input
            txtEmail.Text = "";
            ddlCondition.SelectedItem = null; // Reset dropdown
            RefereshGridView(); // Reload grid
        }

        // Navigate to home screen
        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home(); // Create Home form
            home.Show(); // Show Home form
            this.Close(); // Close current form
        }

        // Open selected return record for editing
        private void btnEditReturnRecord_Click(object sender, EventArgs e)
        {
            int returnID = Convert.ToInt32(dgvReturnRecord.SelectedCells[0].OwningRow.Cells[0].Value);
            CreateReturnRecord editReturnRecord = new CreateReturnRecord(returnID); // Open record in edit mode
            editReturnRecord.ShowDialog(); // Show as modal
            if (editReturnRecord.DialogResult == DialogResult.OK)
            {
                RefereshGridView(); // Refresh grid after edit
            }
        }

        // Create a return record from a selected transaction
        private void btnCreateReturnRecord_Click(object sender, EventArgs e)
        {
            int transactionID = Convert.ToInt32(dgvRentalTransaction.SelectedCells[0].OwningRow.Cells[0].Value);
            RentalTransaction transaction = context.RentalTransactions.Single(x => x.RentalTransactionId == transactionID);
            CreateReturnRecord createReturnRecord = new CreateReturnRecord(transaction); // Open form with transaction data
            createReturnRecord.ShowDialog(); // Show as modal
            if (createReturnRecord.DialogResult == DialogResult.OK)
            {
                RefereshGridView(); // Refresh return records
                RefereshTransactionGridView(); // Refresh transactions
            }
        }

        // Clear transaction search filters and refresh
        private void btnTransactionRefersh_Click(object sender, EventArgs e)
        {
            txtTransactionSearch.Text = "";
            txtTransactionEmail.Text = "";
            ddlTransactionStatus.SelectedItem = null;
            RefereshTransactionGridView();
        }

        // Apply transaction filters
        private void btnTransactionFilter_Click(object sender, EventArgs e)
        {
            RefereshTransactionGridView();
        }
    }
}
