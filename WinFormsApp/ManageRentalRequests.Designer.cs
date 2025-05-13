namespace WinFormsApp
{
    partial class ManageRentalRequests
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
            groupBox1 = new GroupBox();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            dtpRequestDate = new DateTimePicker();
            label8 = new Label();
            ddlStatus = new ComboBox();
            txtUserID = new TextBox();
            txtEquipmentID = new TextBox();
            txtRequestID = new TextBox();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpEndDate);
            groupBox1.Controls.Add(dtpStartDate);
            groupBox1.Controls.Add(dtpRequestDate);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(ddlStatus);
            groupBox1.Controls.Add(txtUserID);
            groupBox1.Controls.Add(txtEquipmentID);
            groupBox1.Controls.Add(txtRequestID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 378);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Request Info";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Enabled = false;
            dtpEndDate.Location = new Point(164, 278);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(248, 27);
            dtpEndDate.TabIndex = 25;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Enabled = false;
            dtpStartDate.Location = new Point(164, 237);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(248, 27);
            dtpStartDate.TabIndex = 24;
            // 
            // dtpRequestDate
            // 
            dtpRequestDate.Enabled = false;
            dtpRequestDate.Location = new Point(164, 195);
            dtpRequestDate.Name = "dtpRequestDate";
            dtpRequestDate.Size = new Size(248, 27);
            dtpRequestDate.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 242);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 20;
            label8.Text = "Start Date:";
            // 
            // ddlStatus
            // 
            ddlStatus.BackColor = Color.FromArgb(31, 42, 85);
            ddlStatus.Font = new Font("Segoe UI", 10.2F);
            ddlStatus.ForeColor = Color.White;
            ddlStatus.FormattingEnabled = true;
            ddlStatus.Items.AddRange(new object[] { "Pendding", "Approved", "Rejected", "Returned", "Cancelled" });
            ddlStatus.Location = new Point(164, 324);
            ddlStatus.Name = "ddlStatus";
            ddlStatus.Size = new Size(248, 31);
            ddlStatus.TabIndex = 17;
            ddlStatus.Text = "Chose a status";
            // 
            // txtUserID
            // 
            txtUserID.Enabled = false;
            txtUserID.Location = new Point(164, 148);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(248, 27);
            txtUserID.TabIndex = 14;
            // 
            // txtEquipmentID
            // 
            txtEquipmentID.Enabled = false;
            txtEquipmentID.Location = new Point(164, 105);
            txtEquipmentID.Name = "txtEquipmentID";
            txtEquipmentID.Size = new Size(248, 27);
            txtEquipmentID.TabIndex = 13;
            // 
            // txtRequestID
            // 
            txtRequestID.Enabled = false;
            txtRequestID.Location = new Point(164, 58);
            txtRequestID.Name = "txtRequestID";
            txtRequestID.Size = new Size(248, 27);
            txtRequestID.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 329);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 11;
            label7.Text = "Status:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 283);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 9;
            label1.Text = "End Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 61);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 5;
            label2.Text = "Request ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 108);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 6;
            label3.Text = "Equipment ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 151);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 7;
            label4.Text = "User ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 195);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 8;
            label5.Text = "Request Date:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(31, 42, 85);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(12, 406);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 31);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(31, 42, 85);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(339, 406);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 31);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnClose_Click;
            // 
            // ManageRentalRequests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(458, 460);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Name = "ManageRentalRequests";
            Text = "ManageRentalRequests";
            Load += ManageRentalRequests_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSave;
        private Button btnCancel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUserID;
        private TextBox txtEquipmentID;
        private TextBox txtRequestID;
        private Label label7;
        private Label label1;
        private ComboBox ddlStatus;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpRequestDate;
        private Label label8;
    }
}