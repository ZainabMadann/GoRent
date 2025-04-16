namespace WinFormsApp
{
    partial class Dashboard
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
            groupBox1 = new GroupBox();
            groupBox9 = new GroupBox();
            groupBox7 = new GroupBox();
            groupBox5 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox6 = new GroupBox();
            btnHome = new Button();
            btnRefresh = new Button();
            lblTotalEquipment = new Label();
            lblRentedEquipment = new Label();
            lblOverdueRentals = new Label();
            lblTotalSales = new Label();
            lblCompletedRentals = new Label();
            lblMostRentedItem = new Label();
            groupBox1.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.Controls.Add(groupBox9);
            groupBox1.Controls.Add(groupBox7);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox6);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(631, 440);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dashboard";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(lblMostRentedItem);
            groupBox9.Cursor = Cursors.IBeam;
            groupBox9.ForeColor = Color.White;
            groupBox9.Location = new Point(428, 228);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(182, 203);
            groupBox9.TabIndex = 4;
            groupBox9.TabStop = false;
            groupBox9.Text = "Most Rented Item";
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(lblCompletedRentals);
            groupBox7.ForeColor = Color.White;
            groupBox7.Location = new Point(229, 228);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(182, 203);
            groupBox7.TabIndex = 4;
            groupBox7.TabStop = false;
            groupBox7.Text = "Completed Rentals";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblTotalSales);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(17, 228);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(182, 203);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Total Sale";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblTotalEquipment);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(17, 27);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(182, 195);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Total Equipment";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblRentedEquipment);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(229, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(182, 195);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Rented Equipment";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lblOverdueRentals);
            groupBox6.ForeColor = Color.White;
            groupBox6.Location = new Point(428, 27);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(182, 195);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Over Due Rentals";
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(31, 42, 85);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(536, 472);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(107, 31);
            btnHome.TabIndex = 20;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(31, 42, 85);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(12, 472);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(107, 31);
            btnRefresh.TabIndex = 21;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // lblTotalEquipment
            // 
            lblTotalEquipment.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalEquipment.Location = new Point(6, 156);
            lblTotalEquipment.Name = "lblTotalEquipment";
            lblTotalEquipment.Size = new Size(170, 36);
            lblTotalEquipment.TabIndex = 0;
            lblTotalEquipment.Text = "lblTotalEquipment";
            lblTotalEquipment.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRentedEquipment
            // 
            lblRentedEquipment.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentedEquipment.Location = new Point(6, 156);
            lblRentedEquipment.Name = "lblRentedEquipment";
            lblRentedEquipment.Size = new Size(170, 36);
            lblRentedEquipment.TabIndex = 1;
            lblRentedEquipment.Text = "lblRentedEquipment";
            lblRentedEquipment.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOverdueRentals
            // 
            lblOverdueRentals.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOverdueRentals.Location = new Point(6, 156);
            lblOverdueRentals.Name = "lblOverdueRentals";
            lblOverdueRentals.Size = new Size(170, 36);
            lblOverdueRentals.TabIndex = 2;
            lblOverdueRentals.Text = "lblOverdueRentalsAC";
            lblOverdueRentals.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalSales
            // 
            lblTotalSales.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSales.Location = new Point(6, 159);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(170, 36);
            lblTotalSales.TabIndex = 3;
            lblTotalSales.Text = "lblTotalSales";
            lblTotalSales.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCompletedRentals
            // 
            lblCompletedRentals.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCompletedRentals.Location = new Point(6, 151);
            lblCompletedRentals.Name = "lblCompletedRentals";
            lblCompletedRentals.Size = new Size(170, 36);
            lblCompletedRentals.TabIndex = 4;
            lblCompletedRentals.Text = "lblCompletedRentals";
            lblCompletedRentals.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMostRentedItem
            // 
            lblMostRentedItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMostRentedItem.Location = new Point(6, 149);
            lblMostRentedItem.Name = "lblMostRentedItem";
            lblMostRentedItem.Size = new Size(170, 36);
            lblMostRentedItem.TabIndex = 4;
            lblMostRentedItem.Text = "lblMostRentedItem";
            lblMostRentedItem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(665, 515);
            Controls.Add(btnRefresh);
            Controls.Add(btnHome);
            Controls.Add(groupBox1);
            Name = "Dashboard";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox9;
        private GroupBox groupBox7;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox6;
        private Button btnHome;
        private Button btnRefresh;
        private Label lblTotalEquipment;
        private Label lblMostRentedItem;
        private Label lblCompletedRentals;
        private Label lblTotalSales;
        private Label lblRentedEquipment;
        private Label lblOverdueRentals;
    }
}