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
    public partial class CreateReturnRecord : Form
    {
        CourseDBContext context;
        ReturnRecord record;
        int recordID;
        bool isNew;
        private RentalTransaction transaction;

        // Constructor for editing a Return Record
        public CreateReturnRecord(int recordID)
        {
            InitializeComponent();
            context = new CourseDBContext();
            this.recordID = recordID;
            isNew = false;
        }

        //Constructor for creating a Return Record
        public CreateReturnRecord(RentalTransaction transaction)
        {
            InitializeComponent();
            context = new CourseDBContext();
            this.transaction = transaction;
            isNew = true;
        }

        private void CreateReturnRecord_Load(object sender, EventArgs e)
        {
            try
            {
                // Populate the dropdown list with equipment conditions
                ddlCondition.DataSource = context.EquipmentConditions.ToList();
                ddlCondition.DisplayMember = "Name";
                ddlCondition.ValueMember = "EquipmentConditionId";
                ddlCondition.SelectedItem = null;

                // If editing an existing return record
                if (!isNew)
                {
                    // Retrieve the return record from the database
                    record = context.ReturnRecords.Single(x => x.ReturnRecordId == recordID);

                    // Set form fields based on the retrieved record
                    txtReturnRecordID.Text = record.ReturnRecordId.ToString();
                    txtReturnTransactionID.Text = record.RentalTransactionId.ToString();
                    txtEquipmentID.Text = record.EquipmentId.ToString();
                    txtUserID.Text = record.UserId.ToString();
                    dtpReturnDate.Value = record.ReturnDate;
                    ddlCondition.SelectedValue = record.EquipmentConditionId;

                    // Disable fields that should not be edited
                    txtReturnRecordID.Enabled = false;
                    txtReturnTransactionID.Enabled = false;
                    txtEquipmentID.Enabled = false;
                    txtUserID.Enabled = false;

                    // Change the button text to indicate editing
                    btnCreate.Text = "Edit";
                }
                else
                {
                    // Set form fields based on the transaction
                    dtpReturnDate.Value = DateTime.Today;
                    txtReturnTransactionID.Text = transaction.RentalTransactionId.ToString();
                    txtEquipmentID.Text = transaction.EquipmentId.ToString();
                    txtUserID.Text = transaction.UserId.ToString();

                    // Disable fields that should not be edited
                    dtpReturnDate.Enabled = false;
                    txtReturnRecordID.Enabled = false;
                    txtReturnTransactionID.Enabled = false;
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
                if (!isNew)
                {
                    // Validate Return Date (cannot be in the future)
                    if (dtpReturnDate.Value > DateTime.Now)
                    {
                        MessageBox.Show("Return date cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Validate Condition selection
                    if (ddlCondition.SelectedValue == null)
                    {
                        MessageBox.Show("Please select the equipment condition.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Update return record fields
                    record.ReturnDate = dtpReturnDate.Value;
                    record.EquipmentConditionId = Convert.ToInt32(ddlCondition.SelectedValue);

                    // Update and Save changes to the database
                    context.Update(record);
                    context.SaveChanges();

                    // Setting the dialog result to OK to refresh the grid in the parent form
                    DialogResult = DialogResult.OK;

                    // Show success message
                    MessageBox.Show("Return record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Validate Condition selection
                    if (ddlCondition.SelectedValue == null)
                    {
                        MessageBox.Show("Please select the equipment condition.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    //Creating a new Return Record
                    ReturnRecord record = new ReturnRecord();

                    // Setting the values of the Return REcord with the fields
                    record.RentalTransactionId = Convert.ToInt32(txtReturnTransactionID.Text);
                    record.EquipmentId = Convert.ToInt32(txtEquipmentID.Text);
                    record.UserId = Convert.ToInt32(txtUserID.Text);
                    record.ReturnDate = dtpReturnDate.Value;
                    record.EquipmentConditionId = Convert.ToInt32(ddlCondition.SelectedValue);

                    // adding and saving the changes to the db
                    context.ReturnRecords.Add(record);
                    context.SaveChanges();

                    //setting the dialog result to ok so that when going back to the Transaction form i refersh the grid view
                    DialogResult = DialogResult.OK;
                    // Displaying a successful message
                    MessageBox.Show("Return Record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating the return record:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
