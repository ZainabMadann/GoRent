namespace WinFormsApp
{
    partial class RentalRequests
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
            dgvRentalRequests = new DataGridView();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            cmbUserRoles = new ComboBox();
            label2 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            btnManageRentalRequests = new Button();
            btnViewTransactions = new Button();
            btnHome = new Button();
            btnDeleteRentalRequest = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRentalRequests).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRentalRequests
            // 
            dgvRentalRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalRequests.Location = new Point(12, 90);
            dgvRentalRequests.Name = "dgvRentalRequests";
            dgvRentalRequests.RowHeadersWidth = 51;
            dgvRentalRequests.Size = new Size(873, 350);
            dgvRentalRequests.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(cmbUserRoles);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(873, 72);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter Rental Requests";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(31, 42, 85);
            btnSearch.Location = new Point(635, 26);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(107, 31);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search/Filter";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cmbUserRoles
            // 
            cmbUserRoles.BackColor = Color.FromArgb(31, 42, 85);
            cmbUserRoles.Font = new Font("Segoe UI", 10.2F);
            cmbUserRoles.ForeColor = Color.White;
            cmbUserRoles.FormattingEnabled = true;
            cmbUserRoles.Location = new Point(409, 26);
            cmbUserRoles.Name = "cmbUserRoles";
            cmbUserRoles.Size = new Size(167, 31);
            cmbUserRoles.TabIndex = 15;
            cmbUserRoles.Text = "Chose a status";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(273, 28);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 2;
            label2.Text = "Filter by status:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(93, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(135, 27);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 0;
            label1.Text = "Search: ";
            // 
            // btnManageRentalRequests
            // 
            btnManageRentalRequests.BackColor = Color.FromArgb(31, 42, 85);
            btnManageRentalRequests.Location = new Point(31, 460);
            btnManageRentalRequests.Name = "btnManageRentalRequests";
            btnManageRentalRequests.Size = new Size(199, 31);
            btnManageRentalRequests.TabIndex = 17;
            btnManageRentalRequests.Text = "Manage Rental Requests";
            btnManageRentalRequests.UseVisualStyleBackColor = false;
            btnManageRentalRequests.Click += btnManageRentalRequests_Click;
            // 
            // btnViewTransactions
            // 
            btnViewTransactions.BackColor = Color.FromArgb(31, 42, 85);
            btnViewTransactions.Location = new Point(236, 460);
            btnViewTransactions.Name = "btnViewTransactions";
            btnViewTransactions.Size = new Size(156, 31);
            btnViewTransactions.TabIndex = 18;
            btnViewTransactions.Text = "View transactions";
            btnViewTransactions.UseVisualStyleBackColor = false;
            btnViewTransactions.Click += btnViewTransactions_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(31, 42, 85);
            btnHome.Location = new Point(778, 460);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(107, 31);
            btnHome.TabIndex = 19;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnDeleteRentalRequest
            // 
            btnDeleteRentalRequest.BackColor = Color.Red;
            btnDeleteRentalRequest.ForeColor = Color.White;
            btnDeleteRentalRequest.Location = new Point(398, 460);
            btnDeleteRentalRequest.Name = "btnDeleteRentalRequest";
            btnDeleteRentalRequest.Size = new Size(175, 31);
            btnDeleteRentalRequest.TabIndex = 26;
            btnDeleteRentalRequest.Text = "Delete Rental Request";
            btnDeleteRentalRequest.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.WhiteSmoke;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            btnRefresh.ForeColor = Color.FromArgb(1, 90, 132);
            btnRefresh.Location = new Point(748, 26);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 29);
            btnRefresh.TabIndex = 27;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // RentalRequests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(897, 503);
            Controls.Add(btnDeleteRentalRequest);
            Controls.Add(btnHome);
            Controls.Add(btnViewTransactions);
            Controls.Add(btnManageRentalRequests);
            Controls.Add(groupBox1);
            Controls.Add(dgvRentalRequests);
            ForeColor = Color.White;
            Name = "RentalRequests";
            Text = "RentalRequests";
            Load += RentalRequests_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRentalRequests).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRentalRequests;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtSearch;
        private Label label2;
        private ComboBox cmbUserRoles;
        private Button btnSearch;
        private Button btnManageRentalRequests;
        private Button btnViewTransactions;
        private Button btnHome;
        private Button btnDeleteRentalRequest;
        private Button btnRefresh;
    }
}