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
            btnRentalRequestsPage = new Button();
            btnDashboard = new Button();
            btnReturnRecords = new Button();
            btnRentalTransactions = new Button();
            btnEquipments = new Button();
            btnAdminLogs = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnRentalRequestsPage
            // 
            btnRentalRequestsPage.BackColor = Color.FromArgb(31, 42, 85);
            btnRentalRequestsPage.ForeColor = Color.White;
            btnRentalRequestsPage.Location = new Point(68, 93);
            btnRentalRequestsPage.Name = "btnRentalRequestsPage";
            btnRentalRequestsPage.Size = new Size(163, 58);
            btnRentalRequestsPage.TabIndex = 0;
            btnRentalRequestsPage.Text = "Rental Requests";
            btnRentalRequestsPage.UseVisualStyleBackColor = false;
            btnRentalRequestsPage.Click += btnRentalRequestsPage_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(31, 42, 85);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(359, 93);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(163, 58);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnReturnRecords
            // 
            btnReturnRecords.BackColor = Color.FromArgb(31, 42, 85);
            btnReturnRecords.ForeColor = Color.White;
            btnReturnRecords.Location = new Point(68, 179);
            btnReturnRecords.Name = "btnReturnRecords";
            btnReturnRecords.Size = new Size(163, 58);
            btnReturnRecords.TabIndex = 2;
            btnReturnRecords.Text = "Return Records";
            btnReturnRecords.UseVisualStyleBackColor = false;
            btnReturnRecords.Click += btnRentalRecords_Click;
            // 
            // btnRentalTransactions
            // 
            btnRentalTransactions.BackColor = Color.FromArgb(31, 42, 85);
            btnRentalTransactions.ForeColor = Color.White;
            btnRentalTransactions.Location = new Point(359, 179);
            btnRentalTransactions.Name = "btnRentalTransactions";
            btnRentalTransactions.Size = new Size(163, 58);
            btnRentalTransactions.TabIndex = 3;
            btnRentalTransactions.Text = "Rental Transactions";
            btnRentalTransactions.UseVisualStyleBackColor = false;
            btnRentalTransactions.Click += btnRentalTransactions_Click;
            // 
            // btnEquipments
            // 
            btnEquipments.BackColor = Color.FromArgb(31, 42, 85);
            btnEquipments.ForeColor = Color.White;
            btnEquipments.Location = new Point(68, 262);
            btnEquipments.Name = "btnEquipments";
            btnEquipments.Size = new Size(163, 58);
            btnEquipments.TabIndex = 4;
            btnEquipments.Text = "Equipments";
            btnEquipments.UseVisualStyleBackColor = false;
            btnEquipments.Click += btnEquipments_Click;
            // 
            // btnAdminLogs
            // 
            btnAdminLogs.BackColor = Color.FromArgb(31, 42, 85);
            btnAdminLogs.ForeColor = Color.White;
            btnAdminLogs.Location = new Point(359, 262);
            btnAdminLogs.Name = "btnAdminLogs";
            btnAdminLogs.Size = new Size(163, 58);
            btnAdminLogs.TabIndex = 5;
            btnAdminLogs.Text = "Admin Logs";
            btnAdminLogs.UseVisualStyleBackColor = false;
            btnAdminLogs.Click += btnAdminLogs_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(31, 42, 85);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(217, 359);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(163, 58);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(620, 502);
            Controls.Add(btnLogout);
            Controls.Add(btnAdminLogs);
            Controls.Add(btnEquipments);
            Controls.Add(btnRentalTransactions);
            Controls.Add(btnReturnRecords);
            Controls.Add(btnDashboard);
            Controls.Add(btnRentalRequestsPage);
            Name = "Home";
            Text = "Home";
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
    }
}