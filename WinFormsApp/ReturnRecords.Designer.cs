namespace WinFormsApp
{
    partial class ReturnRecords
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
            btnEditReturnRecord = new Button();
            btnCreateReturnRecord = new Button();
            groupBox1 = new GroupBox();
            txtEmail = new TextBox();
            label7 = new Label();
            btnRefresh = new Button();
            btnSearch = new Button();
            ddlCondition = new ComboBox();
            label2 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            dgvReturnRecord = new DataGridView();
            dgvRentalTransaction = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            txtTransactionEmail = new TextBox();
            label8 = new Label();
            btnTransactionRefersh = new Button();
            btnTransactionFilter = new Button();
            ddlTransactionStatus = new ComboBox();
            label5 = new Label();
            txtTransactionSearch = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReturnRecord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRentalTransaction).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(31, 42, 85);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(1131, 688);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(107, 31);
            btnHome.TabIndex = 30;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnEditReturnRecord
            // 
            btnEditReturnRecord.BackColor = Color.FromArgb(31, 42, 85);
            btnEditReturnRecord.ForeColor = Color.White;
            btnEditReturnRecord.Location = new Point(12, 324);
            btnEditReturnRecord.Name = "btnEditReturnRecord";
            btnEditReturnRecord.Size = new Size(156, 31);
            btnEditReturnRecord.TabIndex = 29;
            btnEditReturnRecord.Text = "Edit Record";
            btnEditReturnRecord.UseVisualStyleBackColor = false;
            btnEditReturnRecord.Click += btnEditReturnRecord_Click;
            // 
            // btnCreateReturnRecord
            // 
            btnCreateReturnRecord.BackColor = Color.FromArgb(31, 42, 85);
            btnCreateReturnRecord.ForeColor = Color.White;
            btnCreateReturnRecord.Location = new Point(12, 688);
            btnCreateReturnRecord.Name = "btnCreateReturnRecord";
            btnCreateReturnRecord.Size = new Size(156, 31);
            btnCreateReturnRecord.TabIndex = 28;
            btnCreateReturnRecord.Text = "Create Record";
            btnCreateReturnRecord.UseVisualStyleBackColor = false;
            btnCreateReturnRecord.Click += btnCreateReturnRecord_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(ddlCondition);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(813, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 271);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter Return Records";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(229, 75);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 27);
            txtEmail.TabIndex = 34;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 76);
            label7.Name = "label7";
            label7.Size = new Size(154, 25);
            label7.TabIndex = 33;
            label7.Text = "Search by Email:";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.WhiteSmoke;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            btnRefresh.ForeColor = Color.FromArgb(1, 90, 132);
            btnRefresh.Location = new Point(6, 234);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 29);
            btnRefresh.TabIndex = 32;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(31, 42, 85);
            btnSearch.Location = new Point(312, 234);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(107, 31);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search/Filter";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // ddlCondition
            // 
            ddlCondition.BackColor = Color.FromArgb(31, 42, 85);
            ddlCondition.Font = new Font("Segoe UI", 10.2F);
            ddlCondition.ForeColor = Color.White;
            ddlCondition.FormattingEnabled = true;
            ddlCondition.Location = new Point(230, 119);
            ddlCondition.Name = "ddlCondition";
            ddlCondition.Size = new Size(180, 31);
            ddlCondition.TabIndex = 15;
            ddlCondition.Text = "Chose a Condition";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 122);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 2;
            label2.Text = "Filter by Condition:";
            label2.Click += label2_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(230, 29);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 27);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(218, 25);
            label1.TabIndex = 0;
            label1.Text = "Search by Customer Name: ";
            // 
            // dgvReturnRecord
            // 
            dgvReturnRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReturnRecord.Location = new Point(12, 47);
            dgvReturnRecord.Name = "dgvReturnRecord";
            dgvReturnRecord.RowHeadersWidth = 51;
            dgvReturnRecord.Size = new Size(796, 271);
            dgvReturnRecord.TabIndex = 26;
            // 
            // dgvRentalTransaction
            // 
            dgvRentalTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalTransaction.Location = new Point(12, 411);
            dgvRentalTransaction.Name = "dgvRentalTransaction";
            dgvRentalTransaction.RowHeadersWidth = 51;
            dgvRentalTransaction.Size = new Size(796, 271);
            dgvRentalTransaction.TabIndex = 31;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(249, 35);
            label3.TabIndex = 32;
            label3.Text = "All Return Record:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 373);
            label4.Name = "label4";
            label4.Size = new Size(485, 35);
            label4.TabIndex = 33;
            label4.Text = "Transactions that does not have return records:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTransactionEmail);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnTransactionRefersh);
            groupBox2.Controls.Add(btnTransactionFilter);
            groupBox2.Controls.Add(ddlTransactionStatus);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtTransactionSearch);
            groupBox2.Controls.Add(label6);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(819, 411);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 271);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Filter Transaction";
            // 
            // txtTransactionEmail
            // 
            txtTransactionEmail.Location = new Point(225, 73);
            txtTransactionEmail.Name = "txtTransactionEmail";
            txtTransactionEmail.Size = new Size(185, 27);
            txtTransactionEmail.TabIndex = 36;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 74);
            label8.Name = "label8";
            label8.Size = new Size(154, 25);
            label8.TabIndex = 35;
            label8.Text = "Search by Email:";
            // 
            // btnTransactionRefersh
            // 
            btnTransactionRefersh.BackColor = Color.WhiteSmoke;
            btnTransactionRefersh.FlatAppearance.BorderSize = 0;
            btnTransactionRefersh.FlatStyle = FlatStyle.Flat;
            btnTransactionRefersh.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            btnTransactionRefersh.ForeColor = Color.FromArgb(1, 90, 132);
            btnTransactionRefersh.Location = new Point(6, 235);
            btnTransactionRefersh.Margin = new Padding(3, 4, 3, 4);
            btnTransactionRefersh.Name = "btnTransactionRefersh";
            btnTransactionRefersh.Size = new Size(120, 29);
            btnTransactionRefersh.TabIndex = 18;
            btnTransactionRefersh.Text = "Refresh";
            btnTransactionRefersh.UseVisualStyleBackColor = false;
            btnTransactionRefersh.Click += btnTransactionRefersh_Click;
            // 
            // btnTransactionFilter
            // 
            btnTransactionFilter.BackColor = Color.FromArgb(31, 42, 85);
            btnTransactionFilter.Location = new Point(312, 233);
            btnTransactionFilter.Name = "btnTransactionFilter";
            btnTransactionFilter.Size = new Size(107, 31);
            btnTransactionFilter.TabIndex = 16;
            btnTransactionFilter.Text = "Search/Filter";
            btnTransactionFilter.UseVisualStyleBackColor = false;
            btnTransactionFilter.Click += btnTransactionFilter_Click;
            // 
            // ddlTransactionStatus
            // 
            ddlTransactionStatus.BackColor = Color.FromArgb(31, 42, 85);
            ddlTransactionStatus.Font = new Font("Segoe UI", 10.2F);
            ddlTransactionStatus.ForeColor = Color.White;
            ddlTransactionStatus.FormattingEnabled = true;
            ddlTransactionStatus.Items.AddRange(new object[] { "Paid", "Unpaid", "Pending" });
            ddlTransactionStatus.Location = new Point(227, 122);
            ddlTransactionStatus.Name = "ddlTransactionStatus";
            ddlTransactionStatus.Size = new Size(183, 31);
            ddlTransactionStatus.TabIndex = 15;
            ddlTransactionStatus.Text = "Chose a status";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 128);
            label5.Name = "label5";
            label5.Size = new Size(130, 25);
            label5.TabIndex = 2;
            label5.Text = "Filter by status:";
            // 
            // txtTransactionSearch
            // 
            txtTransactionSearch.Location = new Point(226, 29);
            txtTransactionSearch.Name = "txtTransactionSearch";
            txtTransactionSearch.Size = new Size(183, 27);
            txtTransactionSearch.TabIndex = 1;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 29);
            label6.Name = "label6";
            label6.Size = new Size(226, 25);
            label6.TabIndex = 0;
            label6.Text = "Search by Customer Name: ";
            // 
            // ReturnRecords
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1250, 731);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvRentalTransaction);
            Controls.Add(btnHome);
            Controls.Add(btnEditReturnRecord);
            Controls.Add(btnCreateReturnRecord);
            Controls.Add(groupBox1);
            Controls.Add(dgvReturnRecord);
            Name = "ReturnRecords";
            Text = "ReturnRecords";
            Load += ReturnRecords_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReturnRecord).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRentalTransaction).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnHome;
        private Button btnEditReturnRecord;
        private Button btnCreateReturnRecord;
        private GroupBox groupBox1;
        private Button btnSearch;
        private ComboBox ddlCondition;
        private Label label2;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dgvReturnRecord;
        private Button btnRefresh;
        private DataGridView dgvRentalTransaction;
        private Label label3;
        private Label label4;
        private GroupBox groupBox2;
        private Button btnTransactionRefersh;
        private Button btnTransactionFilter;
        private ComboBox ddlTransactionStatus;
        private Label label5;
        private TextBox txtTransactionSearch;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtTransactionEmail;
        private Label label8;
    }
}