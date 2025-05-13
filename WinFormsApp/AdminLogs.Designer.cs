namespace WinFormsApp
{
    partial class AdminLogs
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
            groupBox1 = new GroupBox();
            btnRefresh = new Button();
            btnSearch = new Button();
            ddlAction = new ComboBox();
            label2 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            dgvLogs = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(31, 42, 85);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(1100, 371);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(107, 31);
            btnHome.TabIndex = 36;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(ddlAction);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(795, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(412, 350);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter Logs";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.WhiteSmoke;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            btnRefresh.ForeColor = Color.FromArgb(1, 90, 132);
            btnRefresh.Location = new Point(6, 314);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 29);
            btnRefresh.TabIndex = 17;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(31, 42, 85);
            btnSearch.Location = new Point(299, 312);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(107, 31);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search/Filter";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // ddlAction
            // 
            ddlAction.BackColor = Color.FromArgb(31, 42, 85);
            ddlAction.Font = new Font("Segoe UI", 10.2F);
            ddlAction.ForeColor = Color.White;
            ddlAction.FormattingEnabled = true;
            ddlAction.Items.AddRange(new object[] { "Modified", "Created" });
            ddlAction.Location = new Point(179, 71);
            ddlAction.Name = "ddlAction";
            ddlAction.Size = new Size(227, 31);
            ddlAction.TabIndex = 15;
            ddlAction.Text = "Chose a Action";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 74);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 2;
            label2.Text = "Filter by Action:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(179, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(227, 27);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(154, 25);
            label1.TabIndex = 0;
            label1.Text = "Search by User ID: ";
            // 
            // dgvLogs
            // 
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Location = new Point(12, 12);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.RowHeadersWidth = 51;
            dgvLogs.Size = new Size(777, 350);
            dgvLogs.TabIndex = 32;
            // 
            // AdminLogs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1219, 414);
            Controls.Add(btnHome);
            Controls.Add(groupBox1);
            Controls.Add(dgvLogs);
            Name = "AdminLogs";
            Text = "AdminLogs";
            Load += AdminLogs_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHome;
        private GroupBox groupBox1;
        private Button btnSearch;
        private ComboBox ddlAction;
        private Label label2;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dgvLogs;
        private Button btnRefresh;
    }
}