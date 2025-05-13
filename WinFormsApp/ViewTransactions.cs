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
    public partial class ViewTransactions : Form
    {
        CourseDBContext context;
        int requestID;
        RentalTransaction transaction;
        public ViewTransactions(int requestID) // taking the rental request id and storing it
        {
            InitializeComponent();
            context = new CourseDBContext();
            this.requestID = requestID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewTransactions_Load(object sender, EventArgs e)
        {
            //retreving the rental transaction
            transaction = context.RentalTransactions.Single(x => x.RentalRequestId == requestID);

            //assiging the data to the fields
            txtTransactionID.Text = transaction.RentalTransactionId.ToString();
            txtRentalRequestID.Text = transaction.RentalRequestId.ToString();
            txtEquipmentID.Text = transaction.EquipmentId.ToString();
            txtUserID.Text = transaction.UserId.ToString();
            dtpStartDate.Value = transaction.RentalStartDate;
            dtpEndDate.Value = transaction.RentalEndDate;
            txtTotalCost.Text = transaction.TotalCost.ToString();
            txtPaymentStatus.Text = transaction.PaymentStatus.ToString();
        }
    }
}
