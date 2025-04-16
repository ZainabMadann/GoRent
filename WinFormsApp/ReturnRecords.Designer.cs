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
            btnDeleteReturnRecord = new Button();
            btnHome = new Button();
            btnEditReturnRecord = new Button();
            btnCreateReturnRecord = new Button();
            groupBox1 = new GroupBox();
            btnRefresh = new Button();
            btnSearch = new Button();
            cmbUserRoles = new ComboBox();
            label2 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            dgvReturnRecord = new DataGridView();
            btnCreateTransaction = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReturnRecord).BeginInit();
            SuspendLayout();
            // 
            // btnDeleteReturnRecord
            // 
            btnDeleteReturnRecord.BackColor = Color.Red;
            btnDeleteReturnRecord.ForeColor = Color.White;
            btnDeleteReturnRecord.Location = new Point(541, 443);
            btnDeleteReturnRecord.Name = "btnDeleteReturnRecord";
            btnDeleteReturnRecord.Size = new Size(156, 31);
            btnDeleteReturnRecord.TabIndex = 31;
            btnDeleteReturnRecord.Text = "Delete Record";
            btnDeleteReturnRecord.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(31, 42, 85);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(799, 443);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(107, 31);
            btnHome.TabIndex = 30;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnEditReturnRecord
            // 
            btnEditReturnRecord.BackColor = Color.FromArgb(31, 42, 85);
            btnEditReturnRecord.ForeColor = Color.White;
            btnEditReturnRecord.Location = new Point(217, 443);
            btnEditReturnRecord.Name = "btnEditReturnRecord";
            btnEditReturnRecord.Size = new Size(156, 31);
            btnEditReturnRecord.TabIndex = 29;
            btnEditReturnRecord.Text = "Edit Record";
            btnEditReturnRecord.UseVisualStyleBackColor = false;
            // 
            // btnCreateReturnRecord
            // 
            btnCreateReturnRecord.BackColor = Color.FromArgb(31, 42, 85);
            btnCreateReturnRecord.ForeColor = Color.White;
            btnCreateReturnRecord.Location = new Point(40, 443);
            btnCreateReturnRecord.Name = "btnCreateReturnRecord";
            btnCreateReturnRecord.Size = new Size(171, 31);
            btnCreateReturnRecord.TabIndex = 28;
            btnCreateReturnRecord.Text = "Create Record";
            btnCreateReturnRecord.UseVisualStyleBackColor = false;
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
            groupBox1.Location = new Point(21, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(885, 72);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter Return Records";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.WhiteSmoke;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            btnRefresh.ForeColor = Color.FromArgb(1, 90, 132);
            btnRefresh.Location = new Point(748, 29);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 29);
            btnRefresh.TabIndex = 32;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
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
            // dgvReturnRecord
            // 
            dgvReturnRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReturnRecord.Location = new Point(21, 87);
            dgvReturnRecord.Name = "dgvReturnRecord";
            dgvReturnRecord.RowHeadersWidth = 51;
            dgvReturnRecord.Size = new Size(885, 350);
            dgvReturnRecord.TabIndex = 26;
            // 
            // btnCreateTransaction
            // 
            btnCreateTransaction.BackColor = Color.FromArgb(31, 42, 85);
            btnCreateTransaction.ForeColor = Color.White;
            btnCreateTransaction.Location = new Point(379, 443);
            btnCreateTransaction.Name = "btnCreateTransaction";
            btnCreateTransaction.Size = new Size(156, 31);
            btnCreateTransaction.TabIndex = 32;
            btnCreateTransaction.Text = "Create Transaction";
            btnCreateTransaction.UseVisualStyleBackColor = false;
            // 
            // ReturnRecords
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(931, 486);
            Controls.Add(btnCreateTransaction);
            Controls.Add(btnDeleteReturnRecord);
            Controls.Add(btnHome);
            Controls.Add(btnEditReturnRecord);
            Controls.Add(btnCreateReturnRecord);
            Controls.Add(groupBox1);
            Controls.Add(dgvReturnRecord);
            Name = "ReturnRecords";
            Text = "ReturnRecords";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReturnRecord).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDeleteReturnRecord;
        private Button btnHome;
        private Button btnEditReturnRecord;
        private Button btnCreateReturnRecord;
        private GroupBox groupBox1;
        private Button btnSearch;
        private ComboBox cmbUserRoles;
        private Label label2;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dgvReturnRecord;
        private Button btnRefresh;
        private Button btnCreateTransaction;
    }
}