namespace WinFormsApp
{
    partial class ViewReturnRecord
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
            txtCondition = new TextBox();
            dtpReturnDate = new DateTimePicker();
            label6 = new Label();
            txtUserID = new TextBox();
            txtTransactioID = new TextBox();
            txtEquipmentID = new TextBox();
            txtReturnRecordID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnClose = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCondition);
            groupBox1.Controls.Add(dtpReturnDate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtUserID);
            groupBox1.Controls.Add(txtTransactioID);
            groupBox1.Controls.Add(txtEquipmentID);
            groupBox1.Controls.Add(txtReturnRecordID);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 306);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Return Record Info";
            // 
            // txtCondition
            // 
            txtCondition.Enabled = false;
            txtCondition.Location = new Point(179, 262);
            txtCondition.Name = "txtCondition";
            txtCondition.Size = new Size(248, 27);
            txtCondition.TabIndex = 36;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Enabled = false;
            dtpReturnDate.Location = new Point(179, 92);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(248, 27);
            dtpReturnDate.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 265);
            label6.Name = "label6";
            label6.Size = new Size(153, 20);
            label6.TabIndex = 29;
            label6.Text = "Equipment Condition:";
            // 
            // txtUserID
            // 
            txtUserID.Enabled = false;
            txtUserID.Location = new Point(179, 181);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(248, 27);
            txtUserID.TabIndex = 27;
            // 
            // txtTransactioID
            // 
            txtTransactioID.Enabled = false;
            txtTransactioID.Location = new Point(179, 137);
            txtTransactioID.Name = "txtTransactioID";
            txtTransactioID.Size = new Size(248, 27);
            txtTransactioID.TabIndex = 26;
            // 
            // txtEquipmentID
            // 
            txtEquipmentID.Enabled = false;
            txtEquipmentID.Location = new Point(179, 225);
            txtEquipmentID.Name = "txtEquipmentID";
            txtEquipmentID.Size = new Size(248, 27);
            txtEquipmentID.TabIndex = 25;
            // 
            // txtReturnRecordID
            // 
            txtReturnRecordID.Enabled = false;
            txtReturnRecordID.Location = new Point(179, 47);
            txtReturnRecordID.Name = "txtReturnRecordID";
            txtReturnRecordID.Size = new Size(248, 27);
            txtReturnRecordID.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 225);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 22;
            label1.Text = "Equipment ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 50);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 18;
            label2.Text = "Return Record ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 97);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 19;
            label3.Text = "Return Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 140);
            label4.Name = "label4";
            label4.Size = new Size(152, 20);
            label4.TabIndex = 20;
            label4.Text = "Rental Transaction ID:";
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
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(31, 42, 85);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(353, 324);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(107, 31);
            btnClose.TabIndex = 25;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // ViewReturnRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(472, 373);
            Controls.Add(btnClose);
            Controls.Add(groupBox1);
            Name = "ViewReturnRecord";
            Text = "ViewReturnRecord";
            Load += ViewReturnRecord_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpReturnDate;
        private Label label6;
        private TextBox txtUserID;
        private TextBox txtTransactioID;
        private TextBox txtEquipmentID;
        private TextBox txtReturnRecordID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnClose;
        private TextBox txtCondition;
    }
}