namespace WinFormsApp
{
    partial class CreateReturnRecord
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
            txtConditionID = new TextBox();
            txtReturnDate = new TextBox();
            txtUserID = new TextBox();
            txtEquipmentID = new TextBox();
            txtReturnTransactionID = new TextBox();
            txtReturnRecordID = new TextBox();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(31, 42, 85);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(381, 350);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 31);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(31, 42, 85);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(11, 350);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(107, 31);
            btnCreate.TabIndex = 26;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtConditionID);
            groupBox1.Controls.Add(txtReturnDate);
            groupBox1.Controls.Add(txtUserID);
            groupBox1.Controls.Add(txtEquipmentID);
            groupBox1.Controls.Add(txtReturnTransactionID);
            groupBox1.Controls.Add(txtReturnRecordID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 329);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Transaction Info";
            // 
            // txtConditionID
            // 
            txtConditionID.Enabled = false;
            txtConditionID.Location = new Point(219, 273);
            txtConditionID.Name = "txtConditionID";
            txtConditionID.Size = new Size(240, 27);
            txtConditionID.TabIndex = 19;
            // 
            // txtReturnDate
            // 
            txtReturnDate.Enabled = false;
            txtReturnDate.Location = new Point(219, 229);
            txtReturnDate.Name = "txtReturnDate";
            txtReturnDate.Size = new Size(240, 27);
            txtReturnDate.TabIndex = 16;
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
            // txtReturnTransactionID
            // 
            txtReturnTransactionID.Enabled = false;
            txtReturnTransactionID.Location = new Point(219, 101);
            txtReturnTransactionID.Name = "txtReturnTransactionID";
            txtReturnTransactionID.Size = new Size(240, 27);
            txtReturnTransactionID.TabIndex = 13;
            // 
            // txtReturnRecordID
            // 
            txtReturnRecordID.Enabled = false;
            txtReturnRecordID.Location = new Point(219, 58);
            txtReturnRecordID.Name = "txtReturnRecordID";
            txtReturnRecordID.Size = new Size(240, 27);
            txtReturnRecordID.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 276);
            label7.Name = "label7";
            label7.Size = new Size(96, 20);
            label7.TabIndex = 11;
            label7.Text = "Condition ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 232);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 9;
            label1.Text = "Return Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 61);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 5;
            label2.Text = "Return Record ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 104);
            label3.Name = "label3";
            label3.Size = new Size(153, 20);
            label3.TabIndex = 6;
            label3.Text = "Return Transaction ID:";
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
            // CreateReturnRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(500, 390);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(groupBox1);
            Name = "CreateReturnRecord";
            Text = "CreateReturnRecord";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancel;
        private Button btnCreate;
        private GroupBox groupBox1;
        private TextBox txtConditionID;
        private TextBox txtReturnDate;
        private TextBox txtUserID;
        private TextBox txtEquipmentID;
        private TextBox txtReturnTransactionID;
        private TextBox txtReturnRecordID;
        private Label label7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}