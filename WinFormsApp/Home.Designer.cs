namespace WinFormsApp
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            btnRentalRequestsPage = new Button();
            btnDashboard = new Button();
            btnReturnRecords = new Button();
            btnRentalTransactions = new Button();
            btnEquipments = new Button();
            btnAdminLogs = new Button();
            btnLogout = new Button();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRentalRequestsPage
            // 
            btnRentalRequestsPage.BackColor = Color.FromArgb(31, 42, 85);
            btnRentalRequestsPage.ForeColor = Color.White;
            btnRentalRequestsPage.Location = new Point(6, 106);
            btnRentalRequestsPage.Name = "btnRentalRequestsPage";
            btnRentalRequestsPage.Size = new Size(431, 46);
            btnRentalRequestsPage.TabIndex = 0;
            btnRentalRequestsPage.Text = "Rental Requests";
            btnRentalRequestsPage.UseVisualStyleBackColor = false;
            btnRentalRequestsPage.Click += btnRentalRequestsPage_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(31, 42, 85);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(6, 45);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(431, 46);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnReturnRecords
            // 
            btnReturnRecords.BackColor = Color.FromArgb(31, 42, 85);
            btnReturnRecords.ForeColor = Color.White;
            btnReturnRecords.Location = new Point(6, 230);
            btnReturnRecords.Name = "btnReturnRecords";
            btnReturnRecords.Size = new Size(431, 46);
            btnReturnRecords.TabIndex = 2;
            btnReturnRecords.Text = "Return Records";
            btnReturnRecords.UseVisualStyleBackColor = false;
            btnReturnRecords.Click += btnRentalRecords_Click;
            // 
            // btnRentalTransactions
            // 
            btnRentalTransactions.BackColor = Color.FromArgb(31, 42, 85);
            btnRentalTransactions.ForeColor = Color.White;
            btnRentalTransactions.Location = new Point(6, 169);
            btnRentalTransactions.Name = "btnRentalTransactions";
            btnRentalTransactions.Size = new Size(431, 46);
            btnRentalTransactions.TabIndex = 3;
            btnRentalTransactions.Text = "Rental Transactions";
            btnRentalTransactions.UseVisualStyleBackColor = false;
            btnRentalTransactions.Click += btnRentalTransactions_Click;
            // 
            // btnEquipments
            // 
            btnEquipments.BackColor = Color.FromArgb(31, 42, 85);
            btnEquipments.ForeColor = Color.White;
            btnEquipments.Location = new Point(6, 292);
            btnEquipments.Name = "btnEquipments";
            btnEquipments.Size = new Size(431, 46);
            btnEquipments.TabIndex = 4;
            btnEquipments.Text = "Equipments";
            btnEquipments.UseVisualStyleBackColor = false;
            btnEquipments.Click += btnEquipments_Click;
            // 
            // btnAdminLogs
            // 
            btnAdminLogs.BackColor = Color.FromArgb(31, 42, 85);
            btnAdminLogs.ForeColor = Color.White;
            btnAdminLogs.Location = new Point(6, 354);
            btnAdminLogs.Name = "btnAdminLogs";
            btnAdminLogs.Size = new Size(431, 46);
            btnAdminLogs.TabIndex = 5;
            btnAdminLogs.Text = "Admin Logs";
            btnAdminLogs.UseVisualStyleBackColor = false;
            btnAdminLogs.Click += btnAdminLogs_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(644, 426);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(114, 32);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDashboard);
            groupBox1.Controls.Add(btnRentalRequestsPage);
            groupBox1.Controls.Add(btnEquipments);
            groupBox1.Controls.Add(btnAdminLogs);
            groupBox1.Controls.Add(btnRentalTransactions);
            groupBox1.Controls.Add(btnReturnRecords);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(310, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(443, 408);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Home Page";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(770, 469);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(btnLogout);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRentalRequestsPage;
        private Button btnDashboard;
        private Button btnReturnRecords;
        private Button btnRentalTransactions;
        private Button btnEquipments;
        private Button btnAdminLogs;
        private Button btnLogout;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
    }
}