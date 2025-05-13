namespace WinFormsApp
{
    partial class Equipment
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
            ddlStatus = new ComboBox();
            label2 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            dgvEquipment = new DataGridView();
            btnEditEquipment = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).BeginInit();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(31, 42, 85);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(1087, 335);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(107, 31);
            btnHome.TabIndex = 24;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(ddlStatus);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(790, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(404, 317);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter Equipment";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.WhiteSmoke;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            btnRefresh.ForeColor = Color.FromArgb(1, 90, 132);
            btnRefresh.Location = new Point(6, 281);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(120, 29);
            btnRefresh.TabIndex = 25;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(31, 42, 85);
            btnSearch.Location = new Point(291, 279);
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
            ddlStatus.Location = new Point(163, 70);
            ddlStatus.Name = "ddlStatus";
            ddlStatus.Size = new Size(230, 31);
            ddlStatus.TabIndex = 15;
            ddlStatus.Text = "Chose a status";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 73);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 2;
            label2.Text = "Filter by status:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(163, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(230, 27);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 0;
            label1.Text = "Search by Name: ";
            // 
            // dgvEquipment
            // 
            dgvEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipment.Location = new Point(12, 12);
            dgvEquipment.Name = "dgvEquipment";
            dgvEquipment.RowHeadersWidth = 51;
            dgvEquipment.Size = new Size(772, 317);
            dgvEquipment.TabIndex = 20;
            // 
            // btnEditEquipment
            // 
            btnEditEquipment.BackColor = Color.FromArgb(31, 42, 85);
            btnEditEquipment.ForeColor = Color.White;
            btnEditEquipment.Location = new Point(12, 335);
            btnEditEquipment.Name = "btnEditEquipment";
            btnEditEquipment.Size = new Size(153, 31);
            btnEditEquipment.TabIndex = 25;
            btnEditEquipment.Text = "Edit Equipment";
            btnEditEquipment.UseVisualStyleBackColor = false;
            btnEditEquipment.Click += btnEditEquipment_Click;
            // 
            // Equipment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1207, 372);
            Controls.Add(btnEditEquipment);
            Controls.Add(btnHome);
            Controls.Add(groupBox1);
            Controls.Add(dgvEquipment);
            Name = "Equipment";
            Text = "Equipment";
            Load += Equipment_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHome;
        private GroupBox groupBox1;
        private Button btnSearch;
        private ComboBox ddlStatus;
        private Label label2;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dgvEquipment;
        private Button btnRefresh;
        private Button btnEditEquipment;
    }
}