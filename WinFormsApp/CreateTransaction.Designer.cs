namespace WinFormsApp
{
    partial class CreateTransaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancel = new Button();
            btnCreate = new Button();
            groupBox1 = new GroupBox();
            txtRentalStartDate = new TextBox();
            txtUserID = new TextBox();
            txtEquipmentID = new TextBox();
            txtRentalRequentID = new TextBox();
            txtRequestTransactionID = new TextBox();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            txtTotalCost = new TextBox();
            txtRentalEndDate = new TextBox();
            ddlPaymentStatus = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(31, 42, 85);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(387, 462);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 31);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(31, 42, 85);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(12, 462);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(107, 31);
            btnCreate.TabIndex = 23;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ddlPaymentStatus);
            groupBox1.Controls.Add(txtRentalEndDate);
            groupBox1.Controls.Add(txtTotalCost);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtRentalStartDate);
            groupBox1.Controls.Add(txtUserID);
            groupBox1.Controls.Add(txtEquipmentID);
            groupBox1.Controls.Add(txtRentalRequentID);
            groupBox1.Controls.Add(txtRequestTransactionID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(482, 444);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transaction Info";
            // 
            // txtRentalStartDate
            // 
            txtRentalStartDate.Enabled = false;
            txtRentalStartDate.Location = new Point(219, 229);
            txtRentalStartDate.Name = "txtRentalStartDate";
            txtRentalStartDate.Size = new Size(240, 27);
            txtRentalStartDate.TabIndex = 16;
            // 
            // txtUserID
            // 
            txtUserID.Enabled = false;
            txtUserID.Location = new Point(219, 188);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(240, 27);
            txtUserID.TabIndex = 15;
            // 
            // txtEquipmentID
            // 
            txtEquipmentID.Enabled = false;
            txtEquipmentID.Location = new Point(219, 144);
            txtEquipmentID.Name = "txtEquipmentID";
            txtEquipmentID.Size = new Size(240, 27);
            txtEquipmentID.TabIndex = 14;
            // 
            // txtRentalRequentID
            // 
            txtRentalRequentID.Enabled = false;
            txtRentalRequentID.Location = new Point(219, 101);
            txtRentalRequentID.Name = "txtRentalRequentID";
            txtRentalRequentID.Size = new Size(240, 27);
            txtRentalRequentID.TabIndex = 13;
            // 
            // txtRequestTransactionID
            // 
            txtRequestTransactionID.Enabled = false;
            txtRequestTransactionID.Location = new Point(219, 58);
            txtRequestTransactionID.Name = "txtRequestTransactionID";
            txtRequestTransactionID.Size = new Size(240, 27);
            txtRequestTransactionID.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 276);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 11;
            label7.Text = "Total Cost:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 232);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 9;
            label1.Text = "Rental Start Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 61);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 5;
            label2.Text = "Request Transaction ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 104);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 6;
            label3.Text = "Rental Request ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 147);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 7;
            label4.Text = "Equipment ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 191);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 8;
            label5.Text = "User ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 317);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 17;
            label6.Text = "Rental End Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 359);
            label8.Name = "label8";
            label8.Size = new Size(112, 20);
            label8.TabIndex = 18;
            label8.Text = "Payment Status:";
            // 
            // txtTotalCost
            // 
            txtTotalCost.Enabled = false;
            txtTotalCost.Location = new Point(219, 273);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.Size = new Size(240, 27);
            txtTotalCost.TabIndex = 19;
            // 
            // txtRentalEndDate
            // 
            txtRentalEndDate.Enabled = false;
            txtRentalEndDate.Location = new Point(219, 314);
            txtRentalEndDate.Name = "txtRentalEndDate";
            txtRentalEndDate.Size = new Size(240, 27);
            txtRentalEndDate.TabIndex = 20;
            // 
            // ddlPaymentStatus
            // 
            ddlPaymentStatus.FormattingEnabled = true;
            ddlPaymentStatus.Location = new Point(217, 356);
            ddlPaymentStatus.Name = "ddlPaymentStatus";
            ddlPaymentStatus.Size = new Size(242, 28);
            ddlPaymentStatus.TabIndex = 21;
            ddlPaymentStatus.Text = "Status";
            // 
            // CreateTransaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(506, 505);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(groupBox1);
            Name = "CreateTransaction";
            Text = "CreateTransaction";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancel;
        private Button btnCreate;
        private GroupBox groupBox1;
        private TextBox txtRentalStartDate;
        private TextBox txtUserID;
        private TextBox txtEquipmentID;
        private TextBox txtRentalRequentID;
        private TextBox txtRequestTransactionID;
        private Label label7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtRentalEndDate;
        private TextBox txtTotalCost;
        private Label label8;
        private Label label6;
        private ComboBox ddlPaymentStatus;
    }
}