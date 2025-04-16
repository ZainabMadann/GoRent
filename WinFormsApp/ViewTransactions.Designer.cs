namespace WinFormsApp
{
    partial class ViewTransactions
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
            btnClose = new Button();
            groupBox1 = new GroupBox();
            ddlPaymentStatus = new ComboBox();
            label8 = new Label();
            txtRentalEndDate = new TextBox();
            label7 = new Label();
            txtTotalCost = new TextBox();
            label6 = new Label();
            txtStartDate = new TextBox();
            txtUserID = new TextBox();
            txtEquipmentID = new TextBox();
            txtRentalRequestID = new TextBox();
            txtRentalTransactionID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(31, 42, 85);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(316, 468);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(107, 31);
            btnClose.TabIndex = 24;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ddlPaymentStatus);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtRentalEndDate);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTotalCost);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtStartDate);
            groupBox1.Controls.Add(txtUserID);
            groupBox1.Controls.Add(txtEquipmentID);
            groupBox1.Controls.Add(txtRentalRequestID);
            groupBox1.Controls.Add(txtRentalTransactionID);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(23, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 453);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transaction Info";
            // 
            // ddlPaymentStatus
            // 
            ddlPaymentStatus.Enabled = false;
            ddlPaymentStatus.FormattingEnabled = true;
            ddlPaymentStatus.Location = new Point(158, 344);
            ddlPaymentStatus.Name = "ddlPaymentStatus";
            ddlPaymentStatus.Size = new Size(213, 28);
            ddlPaymentStatus.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 347);
            label8.Name = "label8";
            label8.Size = new Size(112, 20);
            label8.TabIndex = 33;
            label8.Text = "Payment Status:";
            // 
            // txtRentalEndDate
            // 
            txtRentalEndDate.Enabled = false;
            txtRentalEndDate.Location = new Point(158, 302);
            txtRentalEndDate.Name = "txtRentalEndDate";
            txtRentalEndDate.Size = new Size(213, 27);
            txtRentalEndDate.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 305);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 31;
            label7.Text = "End Date:";
            // 
            // txtTotalCost
            // 
            txtTotalCost.Enabled = false;
            txtTotalCost.Location = new Point(158, 262);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.Size = new Size(213, 27);
            txtTotalCost.TabIndex = 30;
            txtTotalCost.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 265);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 29;
            label6.Text = "Total Cost:";
            // 
            // txtStartDate
            // 
            txtStartDate.Enabled = false;
            txtStartDate.Location = new Point(158, 222);
            txtStartDate.Name = "txtStartDate";
            txtStartDate.Size = new Size(213, 27);
            txtStartDate.TabIndex = 28;
            // 
            // txtUserID
            // 
            txtUserID.Enabled = false;
            txtUserID.Location = new Point(158, 181);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(213, 27);
            txtUserID.TabIndex = 27;
            // 
            // txtEquipmentID
            // 
            txtEquipmentID.Enabled = false;
            txtEquipmentID.Location = new Point(158, 137);
            txtEquipmentID.Name = "txtEquipmentID";
            txtEquipmentID.Size = new Size(213, 27);
            txtEquipmentID.TabIndex = 26;
            // 
            // txtRentalRequestID
            // 
            txtRentalRequestID.Enabled = false;
            txtRentalRequestID.Location = new Point(158, 94);
            txtRentalRequestID.Name = "txtRentalRequestID";
            txtRentalRequestID.Size = new Size(213, 27);
            txtRentalRequestID.TabIndex = 25;
            // 
            // txtRentalTransactionID
            // 
            txtRentalTransactionID.Enabled = false;
            txtRentalTransactionID.Location = new Point(158, 47);
            txtRentalTransactionID.Name = "txtRentalTransactionID";
            txtRentalTransactionID.Size = new Size(213, 27);
            txtRentalTransactionID.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 225);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 22;
            label1.Text = "Start Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 50);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 18;
            label2.Text = "Transaction ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 97);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 19;
            label3.Text = "Request ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 140);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 20;
            label4.Text = "Equipment ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 184);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 21;
            label5.Text = "User ID:";
            // 
            // ViewTransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(446, 508);
            Controls.Add(btnClose);
            Controls.Add(groupBox1);
            Name = "ViewTransactions";
            Text = "ViewTransactions";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private GroupBox groupBox1;
        private TextBox txtStartDate;
        private TextBox txtUserID;
        private TextBox txtEquipmentID;
        private TextBox txtRentalRequestID;
        private TextBox txtRentalTransactionID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTotalCost;
        private Label label6;
        private TextBox txtRentalEndDate;
        private Label label7;
        private ComboBox ddlPaymentStatus;
        private Label label8;
    }
}