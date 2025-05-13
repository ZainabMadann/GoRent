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
    public partial class ManageRentalRequests : Form
    {
        CourseDBContext context;
        int rentalID;
        RentalRequest rentalRequest;
        public ManageRentalRequests(int rentalID)
        {
            InitializeComponent();
            context = new CourseDBContext();
            this.rentalID = rentalID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ManageRentalRequests_Load(object sender, EventArgs e)
        {
            try
            {
                // Get the selected rental request from the database
                rentalRequest = context.RentalRequests.Single(x => x.RentalRequestId == rentalID);

                // Load statuses into the dropdown
                ddlStatus.DataSource = context.RequestStatuses.ToList();
                ddlStatus.DisplayMember = "Name";
                ddlStatus.ValueMember = "RequestStatusId";
                ddlStatus.SelectedValue = rentalRequest.RequestStatusId;

                // Fill form fields with rental request data
                txtRequestID.Text = rentalRequest.RentalRequestId.ToString();
                txtEquipmentID.Text = rentalRequest.EquipmentId.ToString();
                txtUserID.Text = rentalRequest.UserId.ToString();
                dtpRequestDate.Value = rentalRequest.RequestDate;
                dtpStartDate.Value = rentalRequest.StartDate;
                dtpEndDate.Value = rentalRequest.EndDate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                rentalRequest.RequestStatusId = (int)ddlStatus.SelectedValue;

                // Update then Save the changes to the database
                context.Update(rentalRequest);
                context.SaveChanges();

                // Show confirmation and close the form
                MessageBox.Show("Rental request updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
