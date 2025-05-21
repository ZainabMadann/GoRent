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
    public partial class CreateTransaction : Form
    {
        CourseDBContext context;
        int transactionID;
        RentalRequest request;
        RentalTransaction transaction;
        bool isNew;

        // this constructor for editing transaction
        public CreateTransaction(int transactionID)
        {
            InitializeComponent();
            context = new CourseDBContext();
            this.transactionID = transactionID;
            isNew = false;
        }

        //this constructor for creating transaction for rental requests that does not have transaction
        public CreateTransaction(RentalRequest request)
        {
            InitializeComponent();
            context = new CourseDBContext();
            this.request = request;
            isNew = true;
        }

        private void CreateTransaction_Load(object sender, EventArgs e)
        {
            try
            {
                // Checking if user is editing or creating a transaction
                if (!isNew)
                {
                    // Retrieve the existing transaction from the database
                    transaction = context.RentalTransactions.Single(x => x.RentalTransactionId == transactionID);

                    // Setting the values of the transaction to the text fields
                    txtRequestTransactionID.Text = transaction.RentalTransactionId.ToString();
                    txtRentalRequentID.Text = transaction.RentalRequestId.ToString();
                    txtEquipmentID.Text = transaction.EquipmentId.ToString();
                    txtUserID.Text = transaction.UserId.ToString();
                    dtpStartDate.Value = transaction.RentalStartDate;
                    txtTotalCost.Text = transaction.TotalCost.ToString();
                    dtpEndDate.Value = transaction.RentalEndDate;
                    ddlPaymentStatus.Text = transaction.PaymentStatus.ToString();

                    // Disable fields that should not be edited
                    txtRequestTransactionID.Enabled = false;
                    txtRentalRequentID.Enabled = false;
                    txtEquipmentID.Enabled = false;
                    txtUserID.Enabled = false;
                    dtpStartDate.Enabled = false;

                    // Set the button text to "Edit"
                    btnCreate.Text = "Edit";
                }
                // if creating a transaction
                else
                {

                    //retrieving the the data that the user does not need to type
                    txtRentalRequentID.Text = request.RentalRequestId.ToString();
                    dtpStartDate.Value = request.StartDate;
                    dtpEndDate.Value = request.EndDate;
                    txtEquipmentID.Text = request.EquipmentId.ToString();
                    txtUserID.Text = request.UserId.ToString();

                    // Make the fields uneditable
                    txtRentalRequentID.Enabled = false;
                    dtpStartDate.Enabled = false;
                    txtEquipmentID.Enabled = false;
                    txtUserID.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // editing a transaction
                if (!isNew)
                {
                    // Validate RentalEndDate
                    if (dtpEndDate.Value < dtpStartDate.Value)
                    {
                        MessageBox.Show("End date cannot be before start date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validate TotalCost
                    if (!decimal.TryParse(txtTotalCost.Text, out decimal totalCost) || totalCost < 0)
                    {
                        MessageBox.Show("Please enter a valid positive number for total cost.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validate PaymentStatus
                    if (string.IsNullOrWhiteSpace(ddlPaymentStatus.Text) || ddlPaymentStatus.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select a payment status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Update transaction fields
                    transaction.RentalEndDate = dtpEndDate.Value;
                    transaction.TotalCost = totalCost;
                    transaction.PaymentStatus = ddlPaymentStatus.Text;

                    // Update and Save changes to the database
                    context.Update(transaction);
                    //AuditLogger.AddAuditLogs(context, Global.Email); 
                    context.SaveChanges(); 

                    //setting the dialog result to ok so that when going back to the Transaction form i refersh the grid view
                    DialogResult = DialogResult.OK;
                    // Displaying a successful message
                    MessageBox.Show("Rental transaction updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // if creating a transaction
                else
                {
                    // Validate total cost
                    if (!decimal.TryParse(txtTotalCost.Text, out decimal totalCost) || totalCost < 0)
                    {
                        MessageBox.Show("Please enter a valid positive number for total cost.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validate RentalEndDate
                    if (dtpEndDate.Value < dtpStartDate.Value)
                    {
                        MessageBox.Show("End date cannot be before start date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validate PaymentStatus
                    if (string.IsNullOrWhiteSpace(ddlPaymentStatus.Text) || ddlPaymentStatus.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select a payment status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    //Create a transaction and then set its value to the fields value
                    RentalTransaction transaction = new RentalTransaction();

                    transaction.RentalStartDate = dtpStartDate.Value;
                    transaction.RentalEndDate = dtpEndDate.Value;
                    transaction.TotalCost = totalCost;
                    transaction.PaymentStatus = ddlPaymentStatus.Text;
                    transaction.RentalRequestId = Convert.ToInt32(txtRentalRequentID.Text);
                    transaction.UserId = Convert.ToInt32(txtUserID.Text);
                    transaction.EquipmentId = Convert.ToInt32(txtEquipmentID.Text);

                    //add and save the transaction
                    context.RentalTransactions.Add(transaction);
                    //AuditLogger.AddAuditLogs(context, Global.Email);
                    context.SaveChanges(); 

                    //setting the dialog result to ok so that when going back to the Transaction form i refersh the grid view
                    DialogResult = DialogResult.OK;
                    // Displaying a successful message
                    MessageBox.Show("Rental transaction added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
