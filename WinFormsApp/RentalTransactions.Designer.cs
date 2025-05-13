namespace WinFormsApp
{
    partial class RentalTransactions
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
            btnHome = new Button();
            btnEditRentalTransaction = new Button();
            btnCreateRentalTransaction = new Button();
            groupBox1 = new GroupBox();
            btnRefresh = new Button();
            btnSearch = new Button();
            ddlStatus = new ComboBox();
            label2 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            dgvRentalTransaction = new DataGridView();
            dgvRentalRequests = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            btnRefereshRequests = new Button();
            btnFilterRequests = new Button();
            ddlRequestsStatus = new ComboBox();
            label5 = new Label();
            txtSearchRequests = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtEmailRequests = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRentalTransaction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRentalRequests).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(31, 42, 85);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(1208, 722);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(107, 31);
            btnHome.TabIndex = 24;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnEditRentalTransaction
            // 
            btnEditRentalTransaction.BackColor = Color.FromArgb(31, 42, 85);
            btnEditRentalTransaction.ForeColor = Color.White;
            btnEditRentalTransaction.Location = new Point(21, 329);
            btnEditRentalTransaction.Name = "btnEditRentalTransaction";
            btnEditRentalTransaction.Size = new Size(156, 31);
            btnEditRentalTransaction.TabIndex = 23;
            btnEditRentalTransaction.Text = "Edit Transaction";
            btnEditRentalTransaction.UseVisualStyleBackColor = false;
            btnEditRentalTransaction.Click += btnEditRentalTransaction_Click;
            // 
            // btnCreateRentalTransaction
            // 
            btnCreateRentalTransaction.BackColor = Color.FromArgb(31, 42, 85);
            btnCreateRentalTransaction.ForeColor = Color.White;
            btnCreateRentalTransaction.Location = new Point(21, 722);
            btnCreateRentalTransaction.Name = "btnCreateRentalTransaction";
            btnCreateRentalTransaction.Size = new Size(171, 31);
            btnCreateRentalTransaction.TabIndex = 22;
            btnCreateRentalTransaction.Text = "Create Transaction";
            btnCreateRentalTransaction.UseVisualStyleBackColor = false;
            btnCreateRentalTransaction.Click += btnCreateRentalTransaction_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(ddlStatus);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(885, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 283);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter Transaction";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.WhiteSmoke;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            btnRefresh.ForeColor = Color.FromArgb(1, 90, 132);
            btnRefresh.Location = new Point(6, 247);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 29);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(31, 42, 85);
            btnSearch.Location = new Point(314, 245);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(107, 31);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search/Filter";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // ddlStatus
            // 
            ddlStatus.BackColor = Color.FromArgb(31, 42, 85);
            ddlStatus.Font = new Font("Segoe UI", 10.2F);
            ddlStatus.ForeColor = Color.White;
            ddlStatus.FormattingEnabled = true;
            ddlStatus.Items.AddRange(new object[] { "Paid", "Unpaid", "Pending" });
            ddlStatus.Location = new Point(244, 126);
            ddlStatus.Name = "ddlStatus";
            ddlStatus.Size = new Size(177, 31);
            ddlStatus.TabIndex = 15;
            ddlStatus.Text = "Chose a status";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 132);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 2;
            label2.Text = "Filter by status:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(244, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(177, 27);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(219, 25);
            label1.TabIndex = 0;
            label1.Text = "Search by Customer Name: ";
            // 
            // dgvRentalTransaction
            // 
            dgvRentalTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalTransaction.Location = new Point(21, 40);
            dgvRentalTransaction.Name = "dgvRentalTransaction";
            dgvRentalTransaction.RowHeadersWidth = 51;
            dgvRentalTransaction.Size = new Size(858, 283);
            dgvRentalTransaction.TabIndex = 20;
            // 
            // dgvRentalRequests
            // 
            dgvRentalRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalRequests.Location = new Point(21, 416);
            dgvRentalRequests.Name = "dgvRentalRequests";
            dgvRentalRequests.RowHeadersWidth = 51;
            dgvRentalRequests.Size = new Size(858, 300);
            dgvRentalRequests.TabIndex = 25;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 2);
            label3.Name = "label3";
            label3.Size = new Size(249, 35);
            label3.TabIndex = 24;
            label3.Text = "All Rental Transaction:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(21, 378);
            label4.Name = "label4";
            label4.Size = new Size(486, 35);
            label4.TabIndex = 26;
            label4.Text = "Rental Requests That does not have Transactions:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtEmailRequests);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnRefereshRequests);
            groupBox2.Controls.Add(btnFilterRequests);
            groupBox2.Controls.Add(ddlRequestsStatus);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtSearchRequests);
            groupBox2.Controls.Add(label6);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(885, 416);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(430, 300);
            groupBox2.TabIndex = 27;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filter Rental Requests";
            // 
            // btnRefereshRequests
            // 
            btnRefereshRequests.BackColor = Color.WhiteSmoke;
            btnRefereshRequests.FlatAppearance.BorderSize = 0;
            btnRefereshRequests.FlatStyle = FlatStyle.Flat;
            btnRefereshRequests.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            btnRefereshRequests.ForeColor = Color.FromArgb(1, 90, 132);
            btnRefereshRequests.Location = new Point(6, 264);
            btnRefereshRequests.Margin = new Padding(3, 4, 3, 4);
            btnRefereshRequests.Name = "btnRefereshRequests";
            btnRefereshRequests.Size = new Size(120, 29);
            btnRefereshRequests.TabIndex = 27;
            btnRefereshRequests.Text = "Refresh";
            btnRefereshRequests.UseVisualStyleBackColor = false;
            btnRefereshRequests.Click += btnRefereshRequests_Click;
            // 
            // btnFilterRequests
            // 
            btnFilterRequests.BackColor = Color.FromArgb(31, 42, 85);
            btnFilterRequests.Location = new Point(317, 262);
            btnFilterRequests.Name = "btnFilterRequests";
            btnFilterRequests.Size = new Size(107, 31);
            btnFilterRequests.TabIndex = 16;
            btnFilterRequests.Text = "Search/Filter";
            btnFilterRequests.UseVisualStyleBackColor = false;
            btnFilterRequests.Click += btnFilterRequests_Click;
            // 
            // ddlRequestsStatus
            // 
            ddlRequestsStatus.BackColor = Color.FromArgb(31, 42, 85);
            ddlRequestsStatus.Font = new Font("Segoe UI", 10.2F);
            ddlRequestsStatus.ForeColor = Color.White;
            ddlRequestsStatus.FormattingEnabled = true;
            ddlRequestsStatus.Location = new Point(244, 126);
            ddlRequestsStatus.Name = "ddlRequestsStatus";
            ddlRequestsStatus.Size = new Size(180, 31);
            ddlRequestsStatus.TabIndex = 15;
            ddlRequestsStatus.Text = "Chose a status";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 129);
            label5.Name = "label5";
            label5.Size = new Size(130, 25);
            label5.TabIndex = 2;
            label5.Text = "Filter by status:";
            // 
            // txtSearchRequests
            // 
            txtSearchRequests.Location = new Point(244, 26);
            txtSearchRequests.Name = "txtSearchRequests";
            txtSearchRequests.Size = new Size(177, 27);
            txtSearchRequests.TabIndex = 1;
            // 
            // label6
            // 
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 29);
            label6.Name = "label6";
            label6.Size = new Size(219, 25);
            label6.TabIndex = 0;
            label6.Text = "Search by Customer Name: ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(244, 76);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(177, 27);
            txtEmail.TabIndex = 20;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 77);
            label7.Name = "label7";
            label7.Size = new Size(163, 25);
            label7.TabIndex = 19;
            label7.Text = "Search by Email:";
            // 
            // txtEmailRequests
            // 
            txtEmailRequests.Location = new Point(244, 75);
            txtEmailRequests.Name = "txtEmailRequests";
            txtEmailRequests.Size = new Size(177, 27);
            txtEmailRequests.TabIndex = 29;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(19, 76);
            label8.Name = "label8";
            label8.Size = new Size(163, 25);
            label8.TabIndex = 28;
            label8.Text = "Search by Email:";
            // 
            // RentalTransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1327, 765);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvRentalRequests);
            Controls.Add(btnHome);
            Controls.Add(btnEditRentalTransaction);
            Controls.Add(btnCreateRentalTransaction);
            Controls.Add(groupBox1);
            Controls.Add(dgvRentalTransaction);
            Name = "RentalTransactions";
            Text = "RentalTransactions";
            Load += RentalTransactions_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRentalTransaction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRentalRequests).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHome;
        private Button btnEditRentalTransaction;
        private Button btnCreateRentalTransaction;
        private GroupBox groupBox1;
        private Button btnSearch;
        private ComboBox ddlStatus;
        private Label label2;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dgvRentalTransaction;
        private Button btnRefresh;
        private DataGridView dgvRentalRequests;
        private Label label3;
        private Label label4;
        private GroupBox groupBox2;
        private Button btnRefereshRequests;
        private Button btnFilterRequests;
        private ComboBox ddlRequestsStatus;
        private Label label5;
        private TextBox txtSearchRequests;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtEmailRequests;
        private Label label8;
    }
}