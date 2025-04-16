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
        public RentalTransactions()
        {
            InitializeComponent();
        }

        private void btnCreateRentalTransaction_Click(object sender, EventArgs e)
        {
            CreateTransaction createTransaction = new CreateTransaction();
            createTransaction.ShowDialog();
            this.Close();
        }
    }
}
