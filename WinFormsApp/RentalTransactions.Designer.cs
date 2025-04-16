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
            cmbUserRoles = new ComboBox();
            label2 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            dgvRentalTransaction = new DataGridView();
            btnDeleteRentalTransaction = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRentalTransaction).BeginInit();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(31, 42, 85);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(886, 442);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(107, 31);
            btnHome.TabIndex = 24;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnEditRentalTransaction
            // 
            btnEditRentalTransaction.BackColor = Color.FromArgb(31, 42, 85);
            btnEditRentalTransaction.ForeColor = Color.White;
            btnEditRentalTransaction.Location = new Point(217, 442);
            btnEditRentalTransaction.Name = "btnEditRentalTransaction";
            btnEditRentalTransaction.Size = new Size(156, 31);
            btnEditRentalTransaction.TabIndex = 23;
            btnEditRentalTransaction.Text = "Edit Transaction";
            btnEditRentalTransaction.UseVisualStyleBackColor = false;
            // 
            // btnCreateRentalTransaction
            // 
            btnCreateRentalTransaction.BackColor = Color.FromArgb(31, 42, 85);
            btnCreateRentalTransaction.ForeColor = Color.White;
            btnCreateRentalTransaction.Location = new Point(40, 442);
            btnCreateRentalTransaction.Name = "btnCreateRentalTransaction";
            btnCreateRentalTransaction.Size = new Size(171, 31);
            btnCreateRentalTransaction.TabIndex = 22;
            btnCreateRentalTransaction.Text = "Create Transaction";
            btnCreateRentalTransaction.UseVisualStyleBackColor = false;
            btnCreateRentalTransaction.Click += btnCreateRentalTransaction_Click;
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
            groupBox1.Location = new Point(21, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(972, 72);
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
            btnRefresh.Location = new Point(837, 26);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 29);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(31, 42, 85);
            btnSearch.Location = new Point(724, 25);
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
            // dgvRentalTransaction
            // 
            dgvRentalTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalTransaction.Location = new Point(21, 86);
            dgvRentalTransaction.Name = "dgvRentalTransaction";
            dgvRentalTransaction.RowHeadersWidth = 51;
            dgvRentalTransaction.Size = new Size(972, 350);
            dgvRentalTransaction.TabIndex = 20;
            // 
            // btnDeleteRentalTransaction
            // 
            btnDeleteRentalTransaction.BackColor = Color.Red;
            btnDeleteRentalTransaction.ForeColor = Color.White;
            btnDeleteRentalTransaction.Location = new Point(573, 442);
            btnDeleteRentalTransaction.Name = "btnDeleteRentalTransaction";
            btnDeleteRentalTransaction.Size = new Size(156, 31);
            btnDeleteRentalTransaction.TabIndex = 25;
            btnDeleteRentalTransaction.Text = "Delete transaction";
            btnDeleteRentalTransaction.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(31, 42, 85);
            button1.ForeColor = Color.White;
            button1.Location = new Point(381, 442);
            button1.Name = "button1";
            button1.Size = new Size(186, 31);
            button1.TabIndex = 26;
            button1.Text = "Create Return Record";
            button1.UseVisualStyleBackColor = false;
            // 
            // RentalTransactions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1005, 485);
            Controls.Add(button1);
            Controls.Add(btnDeleteRentalTransaction);
            Controls.Add(btnHome);
            Controls.Add(btnEditRentalTransaction);
            Controls.Add(btnCreateRentalTransaction);
            Controls.Add(groupBox1);
            Controls.Add(dgvRentalTransaction);
            Name = "RentalTransactions";
            Text = "RentalTransactions";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRentalTransaction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHome;
        private Button btnEditRentalTransaction;
        private Button btnCreateRentalTransaction;
        private GroupBox groupBox1;
        private Button btnSearch;
        private ComboBox cmbUserRoles;
        private Label label2;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dgvRentalTransaction;
        private Button btnDeleteRentalTransaction;
        private Button btnRefresh;
        private Button button1;
    }
}