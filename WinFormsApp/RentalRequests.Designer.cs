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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnRefresh = new Button();
            btnSearch = new Button();
            ddlStatus = new ComboBox();
            label2 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            btnManageRentalRequests = new Button();
            btnViewTransactions = new Button();
            btnHome = new Button();
            dgvRentalRequests = new DataGridView();
            dgvConfirmedRntalRequest = new DataGridView();
            btnViewRentalRecord = new Button();
            label3 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            btnRefereshConfirmed = new Button();
            btnFilterConfirmed = new Button();
            txtUserConfirmed = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            txtEmailConfirmed = new TextBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRentalRequests).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvConfirmedRntalRequest).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(ddlStatus);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(812, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(453, 267);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter Rental Requests";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.WhiteSmoke;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            btnRefresh.ForeColor = Color.FromArgb(1, 90, 132);
            btnRefresh.Location = new Point(6, 231);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 29);
            btnRefresh.TabIndex = 27;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(31, 42, 85);
            btnSearch.Location = new Point(340, 229);
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
            ddlStatus.Location = new Point(257, 123);
            ddlStatus.Name = "ddlStatus";
            ddlStatus.Size = new Size(190, 31);
            ddlStatus.TabIndex = 15;
            ddlStatus.Text = "Chose a status";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 129);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 2;
            label2.Text = "Filter by status:";
            label2.Click += label2_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(257, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(190, 27);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(218, 25);
            label1.TabIndex = 0;
            label1.Text = "Search by CustomerName: ";
            // 
            // btnManageRentalRequests
            // 
            btnManageRentalRequests.BackColor = Color.FromArgb(31, 42, 85);
            btnManageRentalRequests.Location = new Point(12, 320);
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
            btnViewTransactions.Location = new Point(12, 684);
            btnViewTransactions.Name = "btnViewTransactions";
            btnViewTransactions.Size = new Size(199, 31);
            btnViewTransactions.TabIndex = 18;
            btnViewTransactions.Text = "View Transactions";
            btnViewTransactions.UseVisualStyleBackColor = false;
            btnViewTransactions.Click += btnViewTransactions_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(31, 42, 85);
            btnHome.Location = new Point(1152, 684);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(107, 31);
            btnHome.TabIndex = 19;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // dgvRentalRequests
            // 
            dgvRentalRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRentalRequests.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRentalRequests.Location = new Point(12, 47);
            dgvRentalRequests.Name = "dgvRentalRequests";
            dgvRentalRequests.RowHeadersWidth = 51;
            dgvRentalRequests.Size = new Size(794, 267);
            dgvRentalRequests.TabIndex = 20;
            // 
            // dgvConfirmedRntalRequest
            // 
            dgvConfirmedRntalRequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvConfirmedRntalRequest.DefaultCellStyle = dataGridViewCellStyle4;
            dgvConfirmedRntalRequest.Location = new Point(12, 413);
            dgvConfirmedRntalRequest.Name = "dgvConfirmedRntalRequest";
            dgvConfirmedRntalRequest.RowHeadersWidth = 51;
            dgvConfirmedRntalRequest.Size = new Size(794, 247);
            dgvConfirmedRntalRequest.TabIndex = 21;
            // 
            // btnViewRentalRecord
            // 
            btnViewRentalRecord.BackColor = Color.FromArgb(31, 42, 85);
            btnViewRentalRecord.Location = new Point(217, 684);
            btnViewRentalRecord.Name = "btnViewRentalRecord";
            btnViewRentalRecord.Size = new Size(199, 31);
            btnViewRentalRecord.TabIndex = 22;
            btnViewRentalRecord.Text = "View Return Record";
            btnViewRentalRecord.UseVisualStyleBackColor = false;
            btnViewRentalRecord.Click += btnViewRentalRecord_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 9);
            label3.Name = "label3";
            label3.Size = new Size(249, 35);
            label3.TabIndex = 23;
            label3.Text = "All Rental Requests:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 375);
            label4.Name = "label4";
            label4.Size = new Size(286, 35);
            label4.TabIndex = 24;
            label4.Text = "Confirmed Rental Requests:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtEmailConfirmed);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(btnRefereshConfirmed);
            groupBox2.Controls.Add(btnFilterConfirmed);
            groupBox2.Controls.Add(txtUserConfirmed);
            groupBox2.Controls.Add(label6);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(812, 413);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(453, 247);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filter confirmed Rental Requests";
            // 
            // btnRefereshConfirmed
            // 
            btnRefereshConfirmed.BackColor = Color.WhiteSmoke;
            btnRefereshConfirmed.FlatAppearance.BorderSize = 0;
            btnRefereshConfirmed.FlatStyle = FlatStyle.Flat;
            btnRefereshConfirmed.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            btnRefereshConfirmed.ForeColor = Color.FromArgb(1, 90, 132);
            btnRefereshConfirmed.Location = new Point(6, 209);
            btnRefereshConfirmed.Margin = new Padding(3, 4, 3, 4);
            btnRefereshConfirmed.Name = "btnRefereshConfirmed";
            btnRefereshConfirmed.Size = new Size(120, 29);
            btnRefereshConfirmed.TabIndex = 27;
            btnRefereshConfirmed.Text = "Refresh";
            btnRefereshConfirmed.UseVisualStyleBackColor = false;
            btnRefereshConfirmed.Click += btnRefereshConfirmed_Click;
            // 
            // btnFilterConfirmed
            // 
            btnFilterConfirmed.BackColor = Color.FromArgb(31, 42, 85);
            btnFilterConfirmed.Location = new Point(340, 207);
            btnFilterConfirmed.Name = "btnFilterConfirmed";
            btnFilterConfirmed.Size = new Size(107, 31);
            btnFilterConfirmed.TabIndex = 16;
            btnFilterConfirmed.Text = "Search/Filter";
            btnFilterConfirmed.UseVisualStyleBackColor = false;
            btnFilterConfirmed.Click += btnFilterConfirmed_Click;
            // 
            // txtUserConfirmed
            // 
            txtUserConfirmed.Location = new Point(257, 26);
            txtUserConfirmed.Name = "txtUserConfirmed";
            txtUserConfirmed.Size = new Size(190, 27);
            txtUserConfirmed.TabIndex = 1;
            // 
            // label6
            // 
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 29);
            label6.Name = "label6";
            label6.Size = new Size(218, 25);
            label6.TabIndex = 0;
            label6.Text = "Search by Customer Name: ";
            // 
            // label5
            // 
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 76);
            label5.Name = "label5";
            label5.Size = new Size(139, 25);
            label5.TabIndex = 28;
            label5.Text = "Search by Email: ";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(257, 75);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(190, 27);
            txtEmail.TabIndex = 29;
            // 
            // txtEmailConfirmed
            // 
            txtEmailConfirmed.Location = new Point(257, 80);
            txtEmailConfirmed.Name = "txtEmailConfirmed";
            txtEmailConfirmed.Size = new Size(190, 27);
            txtEmailConfirmed.TabIndex = 31;
            // 
            // label7
            // 
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(19, 82);
            label7.Name = "label7";
            label7.Size = new Size(139, 25);
            label7.TabIndex = 30;
            label7.Text = "Search by Email: ";
            // 
            // RentalRequests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1277, 727);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnViewRentalRecord);
            Controls.Add(dgvConfirmedRntalRequest);
            Controls.Add(dgvRentalRequests);
            Controls.Add(btnHome);
            Controls.Add(btnViewTransactions);
            Controls.Add(btnManageRentalRequests);
            Controls.Add(groupBox1);
            ForeColor = Color.White;
            Name = "RentalRequests";
            Text = "RentalRequests";
            Load += RentalRequests_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRentalRequests).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvConfirmedRntalRequest).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtSearch;
        private Label label2;
        private ComboBox ddlStatus;
        private Button btnSearch;
        private Button btnManageRentalRequests;
        private Button btnViewTransactions;
        private Button btnHome;
        private Button btnRefresh;
        private DataGridView dgvRentalRequests;
        private DataGridView dgvConfirmedRntalRequest;
        private Button btnViewRentalRecord;
        private Label label3;
        private Label label4;
        private GroupBox groupBox2;
        private Button btnRefereshConfirmed;
        private Button btnFilterConfirmed;
        private TextBox txtUserConfirmed;
        private Label label6;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtEmailConfirmed;
        private Label label7;
    }
}