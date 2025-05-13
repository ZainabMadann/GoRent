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
    public partial class RentalRequests : Form
    {
        CourseDBContext context;
        public RentalRequests()
        {
            InitializeComponent();
            context = new CourseDBContext();
        }

        private void RentalRequests_Load(object sender, EventArgs e)
        {
            try
            {
                //populating the status drop dwon list with the status
                ddlStatus.DataSource = context.RequestStatuses.ToList();
                ddlStatus.DisplayMember = "Name";
                ddlStatus.ValueMember = "RequestStatusId";
                ddlStatus.SelectedItem = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //refereshing the normal grid view using the RefereshGridView metod
            RefereshGridView();
            dgvRentalRequests.DefaultCellStyle.ForeColor = Color.Black;
            dgvRentalRequests.DefaultCellStyle.BackColor = Color.White;
            dgvRentalRequests.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvRentalRequests.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;

            //refereshing the normal grid view using the RefereshConfirmedGridView metod
            RefereshConfirmedGridView();
            dgvConfirmedRntalRequest.DefaultCellStyle.ForeColor = Color.Black;
            dgvConfirmedRntalRequest.DefaultCellStyle.BackColor = Color.White;
            dgvConfirmedRntalRequest.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvConfirmedRntalRequest.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
        }

        // the Referesh method for populating the grid view
        private void RefereshGridView()
        {
            dgvRentalRequests.DataSource = null;

            try
            {
                //making a variable qurayable so that i can use multiple qurys
                var rentalsToshow = context.RentalRequests
                .Include(x => x.User)
                .Include(x => x.Equipment)
                .Include(x => x.RentalTransactions)
                .AsQueryable();

                // see what the user enter in the text view so that it filter the rental request by the customer name
                if (txtSearch.Text != "")
                {
                    rentalsToshow = rentalsToshow.Where(x => x.User.Name.Contains(txtSearch.Text));
                }


                if(txtEmail.Text != "")
                {
                    rentalsToshow = rentalsToshow.Where(x => x.User.Email.Contains(txtEmail.Text));
                }

                // see what the user selected from the status drop list so that it filter the rental requests by status
                if (ddlStatus.SelectedValue != null)
                {
                    rentalsToshow = rentalsToshow.Where(x => x.RequestStatus.RequestStatusId == Convert.ToInt32(ddlStatus.SelectedValue));
                }

                // see if there are records and if there is use projection 
                if (rentalsToshow.Count() < 1)
                {
                    MessageBox.Show("No record found");
                }
                else
                {
                    dgvRentalRequests.DataSource = rentalsToshow
                        .Select(x => new
                        {
                            RentalRequestID = x.RentalRequestId,
                            CustomerName = x.User.Name,
                            CustomerEmail = x.User.Email,
                            Equipment = x.Equipment.Name,
                            RequestDate = x.RequestDate.ToString("yyyy-MM-dd"),
                            StartDate = x.StartDate.ToString("yyyy-MM-dd"),
                            EndDate = x.EndDate.ToString("yyyy-MM-dd"),
                            TotalCost = x.RentalTransactions
                             .OrderByDescending(rt => rt.RentalTransactionId)
                             .Select(rt => rt.TotalCost)
                             .FirstOrDefault()
                        }).ToList();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        // the Referesh method for populating the confirmed request grid view
        private void RefereshConfirmedGridView()
        {
            dgvConfirmedRntalRequest.DataSource = null;

            try
            {
                //making a variable qurayable so that i can use multiple qurys
                var confirmedRentalsToshow = context.RentalRequests
                .Where(x => x.RequestStatus.Name == "Approved")
                .AsQueryable();

                // see what the user enter in the text view so that it filter the rental request by the customer name
                if (txtUserConfirmed.Text != "")
                {
                    confirmedRentalsToshow = confirmedRentalsToshow.Where(x => x.User.Name.Contains(txtUserConfirmed.Text));
                }

                if(txtEmailConfirmed.Text != "")
                {
                    confirmedRentalsToshow = confirmedRentalsToshow.Where(x => x.User.Email.Contains(txtEmailConfirmed.Text));
                }
                // see if there are records and if there is use projection
                if (confirmedRentalsToshow.Count() < 1)
                {
                    MessageBox.Show("No record found");
                }
                else
                {
                    dgvConfirmedRntalRequest.DataSource = confirmedRentalsToshow
                        .Select(x => new
                        {
                            RentalRequestID = x.RentalRequestId,
                            CustomerName = x.User.Name,
                            CustomerEMail = x.User.Email,
                            Equipment = x.Equipment.Name,
                            RequestDate = x.RequestDate.ToString("yyyy-MM-dd"),
                            StartDate = x.StartDate.ToString("yyyy-MM-dd"),
                            EndDate = x.EndDate.ToString("yyyy-MM-dd"),
                            TotalCost = x.RentalTransactions
                             .OrderByDescending(rt => rt.RentalTransactionId)
                             .Select(rt => rt.TotalCost)
                             .FirstOrDefault()
                        }).ToList();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cmbUserRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnViewTransactions_Click(object sender, EventArgs e)
        {
            // store the id of the row that the user selected for view
            int requestID = Convert.ToInt32(dgvConfirmedRntalRequest.SelectedCells[0].OwningRow.Cells[0].Value);
            // pass te id and move to the view transaction page if the user click the button
            ViewTransactions viewTransactions = new ViewTransactions(requestID);
            viewTransactions.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // move to the home page if the user click the button
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // call the method to referesh the grid view with the applyed filters
            RefereshGridView();
        }

        private void btnManageRentalRequests_Click(object sender, EventArgs e)
        {
            // store the id of the row that the user selected for editing
            int rentalID = Convert.ToInt32(dgvRentalRequests.SelectedCells[0].OwningRow.Cells[0].Value);
            // pass the id and display the Manage rental request form
            ManageRentalRequests manageRentalRequests = new ManageRentalRequests(rentalID);
            manageRentalRequests.ShowDialog();

            // only referesh the grid view if the user made some changes
            if (manageRentalRequests.DialogResult == DialogResult.OK)
            {
                RefereshGridView();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //clear the text and the drop list and show all the requests
            txtSearch.Text = "";
            txtEmail.Text = "";
            ddlStatus.SelectedItem = null;
            RefereshGridView();
        }

        private void btnFilterConfirmed_Click(object sender, EventArgs e)
        {
            //Referesh the grid view with the applyed filters
            RefereshConfirmedGridView();
        }

        private void btnRefereshConfirmed_Click(object sender, EventArgs e)
        {
            //clear the text  and show all the COnfirmed requests
            txtUserConfirmed.Text = "";
            txtEmailConfirmed.Text = "";
            RefereshConfirmedGridView();
        }

        private void btnViewRentalRecord_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the rental request ID from the selected row in the DataGridView
                int requestID = Convert.ToInt32(dgvConfirmedRntalRequest.SelectedCells[0].OwningRow.Cells[0].Value);

                // Find the rental transaction ID(s) related to this rental request
                var rentalTransactionIds = context.RentalTransactions
                    .Where(t => t.RentalRequestId == requestID)
                    .Select(t => t.RentalTransactionId)
                    .ToList();

                // Check if any return record exists for the retrieved transaction IDs
                bool hasReturnRecord = context.ReturnRecords
                    .Any(r => rentalTransactionIds.Contains(r.RentalTransactionId));

                if (hasReturnRecord)
                {
                    // Open the return record form if one exists
                    ViewReturnRecord viewReturnRecord = new ViewReturnRecord(requestID);
                    viewReturnRecord.ShowDialog();
                }
                else
                {
                    // Show message if no return record was found
                    MessageBox.Show("No return record found for this rental request.", "Return Record Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle any unexpected errors
                MessageBox.Show("An error occurred while trying to view the return record:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
