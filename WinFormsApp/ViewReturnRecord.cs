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
    public partial class ViewReturnRecord : Form
    {
        CourseDBContext context;
        int requestID;
        RentalTransaction transaction;
        ReturnRecord record;
        public ViewReturnRecord(int requestID) //retreving the id so that i can use it to get the return record
        {
            InitializeComponent();
            context = new CourseDBContext();
            this.requestID = requestID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewReturnRecord_Load(object sender, EventArgs e)
        {
            try
            {
                // Get the rental transaction based on the request ID
                transaction = context.RentalTransactions.Single(x => x.RentalRequestId == requestID);
                int transactionID = transaction.RentalTransactionId;

                // Get the return record linked to the transaction
                record = context.ReturnRecords.Single(x => x.RentalTransactionId == transactionID);

                // Get the name of the equipment condition
                int conditionID = record.EquipmentConditionId;
                string condition = context.EquipmentConditions.Single(x => x.EquipmentConditionId == conditionID).Name;

                // Populate form fields with return record data
                txtReturnRecordID.Text = record.ReturnRecordId.ToString();
                dtpReturnDate.Value = record.ReturnDate;
                txtTransactioID.Text = record.RentalTransactionId.ToString();
                txtUserID.Text = record.UserId.ToString();
                txtEquipmentID.Text = record.EquipmentId.ToString();
                txtCondition.Text = condition;
            }
            catch (Exception ex)
            {
                // Show error message if something goes wrong during data loading
                MessageBox.Show(ex.Message);
            }
        }

    }
}
