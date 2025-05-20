namespace WinFormsApp
{
    partial class EditEquipmentDetails
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
            btnEdit = new Button();
            btnClose = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            ddlStatus = new ComboBox();
            ddlCondition = new ComboBox();
            ddlCategory = new ComboBox();
            txtDescription = new TextBox();
            label6 = new Label();
            txtName = new TextBox();
            txtRentalRate = new TextBox();
            txtEquipmentID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(31, 42, 85);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(12, 422);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(107, 31);
            btnEdit.TabIndex = 41;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(31, 42, 85);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(351, 422);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(107, 31);
            btnClose.TabIndex = 40;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(ddlStatus);
            groupBox1.Controls.Add(ddlCondition);
            groupBox1.Controls.Add(ddlCategory);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtRentalRate);
            groupBox1.Controls.Add(txtEquipmentID);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(19, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(439, 386);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
            groupBox1.Text = "Return Record Info";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 278);
            label7.Name = "label7";
            label7.Size = new Size(149, 20);
            label7.TabIndex = 41;
            label7.Text = "Equpment Condition:";
            // 
            // ddlStatus
            // 
            ddlStatus.BackColor = Color.FromArgb(31, 42, 85);
            ddlStatus.Font = new Font("Segoe UI", 10.2F);
            ddlStatus.ForeColor = Color.White;
            ddlStatus.FormattingEnabled = true;
            ddlStatus.Location = new Point(179, 321);
            ddlStatus.Name = "ddlStatus";
            ddlStatus.Size = new Size(248, 31);
            ddlStatus.TabIndex = 40;
            ddlStatus.Text = "Chose a status";
            // 
            // ddlCondition
            // 
            ddlCondition.BackColor = Color.FromArgb(31, 42, 85);
            ddlCondition.Font = new Font("Segoe UI", 10.2F);
            ddlCondition.ForeColor = Color.White;
            ddlCondition.FormattingEnabled = true;
            ddlCondition.Location = new Point(179, 273);
            ddlCondition.Name = "ddlCondition";
            ddlCondition.Size = new Size(248, 31);
            ddlCondition.TabIndex = 39;
            ddlCondition.Text = "Chose a status";
            // 
            // ddlCategory
            // 
            ddlCategory.BackColor = Color.FromArgb(31, 42, 85);
            ddlCategory.Font = new Font("Segoe UI", 10.2F);
            ddlCategory.ForeColor = Color.White;
            ddlCategory.FormattingEnabled = true;
            ddlCategory.Location = new Point(179, 225);
            ddlCategory.Name = "ddlCategory";
            ddlCategory.Size = new Size(248, 31);
            ddlCategory.TabIndex = 38;
            ddlCategory.Text = "Chose a status";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(179, 90);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(248, 27);
            txtDescription.TabIndex = 37;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 326);
            label6.Name = "label6";
            label6.Size = new Size(128, 20);
            label6.TabIndex = 29;
            label6.Text = "Equipment Status:";
            // 
            // txtName
            // 
            txtName.Location = new Point(179, 181);
            txtName.Name = "txtName";
            txtName.Size = new Size(248, 27);
            txtName.TabIndex = 27;
            // 
            // txtRentalRate
            // 
            txtRentalRate.Location = new Point(179, 137);
            txtRentalRate.Name = "txtRentalRate";
            txtRentalRate.Size = new Size(248, 27);
            txtRentalRate.TabIndex = 26;
            // 
            // txtEquipmentID
            // 
            txtEquipmentID.Enabled = false;
            txtEquipmentID.Location = new Point(179, 47);
            txtEquipmentID.Name = "txtEquipmentID";
            txtEquipmentID.Size = new Size(248, 27);
            txtEquipmentID.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 230);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 22;
            label1.Text = "Category:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 50);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 18;
            label2.Text = "Equipment ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 97);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 19;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 140);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 20;
            label4.Text = "Rental Rate:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 184);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 21;
            label5.Text = "Name:";
            // 
            // EditEquipmentDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(470, 465);
            Controls.Add(btnEdit);
            Controls.Add(btnClose);
            Controls.Add(groupBox1);
            Name = "EditEquipmentDetails";
            Text = "EditEquipmentDetails";
            Load += EditEquipmentDetails_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEdit;
        private Button btnClose;
        private GroupBox groupBox1;
        private Label label7;
        private ComboBox ddlStatus;
        private ComboBox ddlCondition;
        private ComboBox ddlCategory;
        private TextBox txtDescription;
        private Label label6;
        private TextBox txtName;
        private TextBox txtRentalRate;
        private TextBox txtEquipmentID;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}