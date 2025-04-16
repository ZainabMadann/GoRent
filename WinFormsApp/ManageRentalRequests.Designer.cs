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
            txtEndDate = new TextBox();
            txtRequestDate = new TextBox();
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
            txtStatusID = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtStatusID);
            groupBox1.Controls.Add(txtEndDate);
            groupBox1.Controls.Add(txtRequestDate);
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
            groupBox1.Size = new Size(400, 384);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Request Info";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtEndDate
            // 
            txtEndDate.Enabled = false;
            txtEndDate.Location = new Point(164, 233);
            txtEndDate.Name = "txtEndDate";
            txtEndDate.Size = new Size(213, 27);
            txtEndDate.TabIndex = 16;
            // 
            // txtRequestDate
            // 
            txtRequestDate.Enabled = false;
            txtRequestDate.Location = new Point(164, 192);
            txtRequestDate.Name = "txtRequestDate";
            txtRequestDate.Size = new Size(213, 27);
            txtRequestDate.TabIndex = 15;
            // 
            // txtUserID
            // 
            txtUserID.Enabled = false;
            txtUserID.Location = new Point(164, 148);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(213, 27);
            txtUserID.TabIndex = 14;
            // 
            // txtEquipmentID
            // 
            txtEquipmentID.Enabled = false;
            txtEquipmentID.Location = new Point(164, 105);
            txtEquipmentID.Name = "txtEquipmentID";
            txtEquipmentID.Size = new Size(213, 27);
            txtEquipmentID.TabIndex = 13;
            // 
            // txtRequestID
            // 
            txtRequestID.Enabled = false;
            txtRequestID.Location = new Point(164, 58);
            txtRequestID.Name = "txtRequestID";
            txtRequestID.Size = new Size(213, 27);
            txtRequestID.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 280);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 11;
            label7.Text = "Status ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 236);
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
            btnSave.Location = new Point(12, 417);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(107, 31);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(31, 42, 85);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(305, 417);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 31);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnClose_Click;
            // 
            // txtStatusID
            // 
            txtStatusID.Enabled = false;
            txtStatusID.Location = new Point(164, 277);
            txtStatusID.Name = "txtStatusID";
            txtStatusID.Size = new Size(213, 27);
            txtStatusID.TabIndex = 17;
            // 
            // ManageRentalRequests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(424, 466);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Name = "ManageRentalRequests";
            Text = "ManageRentalRequests";
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
        private TextBox txtEndDate;
        private TextBox txtRequestDate;
        private TextBox txtUserID;
        private TextBox txtEquipmentID;
        private TextBox txtRequestID;
        private Label label7;
        private Label label1;
        private TextBox txtStatusID;
    }
}