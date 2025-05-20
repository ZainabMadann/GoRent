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
            groupBox8 = new GroupBox();
            lblPendingRequests = new Label();
            groupBox2 = new GroupBox();
            lblTotalMonth = new Label();
            groupBox9 = new GroupBox();
            lblMostRentedItem = new Label();
            groupBox7 = new GroupBox();
            lblApprovedRentals = new Label();
            groupBox5 = new GroupBox();
            lblTotalSales = new Label();
            groupBox4 = new GroupBox();
            lblTotalEquipment = new Label();
            groupBox3 = new GroupBox();
            lblRentedEquipment = new Label();
            groupBox6 = new GroupBox();
            lblCancelledRentals = new Label();
            btnHome = new Button();
            groupBox1.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox2.SuspendLayout();
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
            groupBox1.Controls.Add(groupBox8);
            groupBox1.Controls.Add(groupBox2);
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
            groupBox1.Size = new Size(906, 311);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dashboard";
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(lblPendingRequests);
            groupBox8.ForeColor = Color.White;
            groupBox8.Location = new Point(690, 175);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(192, 105);
            groupBox8.TabIndex = 7;
            groupBox8.TabStop = false;
            groupBox8.Text = "lblPendingRequest";
            // 
            // lblPendingRequests
            // 
            lblPendingRequests.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingRequests.Location = new Point(6, 34);
            lblPendingRequests.Name = "lblPendingRequests";
            lblPendingRequests.Size = new Size(180, 36);
            lblPendingRequests.TabIndex = 2;
            lblPendingRequests.Text = "lblPendingRequests";
            lblPendingRequests.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblTotalMonth);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(690, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(192, 118);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Total sales this month";
            // 
            // lblTotalMonth
            // 
            lblTotalMonth.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalMonth.Location = new Point(6, 49);
            lblTotalMonth.Name = "lblTotalMonth";
            lblTotalMonth.Size = new Size(180, 36);
            lblTotalMonth.TabIndex = 2;
            lblTotalMonth.Text = "lblTotalMonth";
            lblTotalMonth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(lblMostRentedItem);
            groupBox9.Cursor = Cursors.IBeam;
            groupBox9.ForeColor = Color.White;
            groupBox9.Location = new Point(465, 175);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(199, 105);
            groupBox9.TabIndex = 4;
            groupBox9.TabStop = false;
            groupBox9.Text = "Most Rented Item";
            // 
            // lblMostRentedItem
            // 
            lblMostRentedItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMostRentedItem.Location = new Point(6, 42);
            lblMostRentedItem.Name = "lblMostRentedItem";
            lblMostRentedItem.Size = new Size(180, 36);
            lblMostRentedItem.TabIndex = 4;
            lblMostRentedItem.Text = "lblMostRentedItem";
            lblMostRentedItem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(lblApprovedRentals);
            groupBox7.ForeColor = Color.White;
            groupBox7.Location = new Point(243, 175);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(201, 105);
            groupBox7.TabIndex = 4;
            groupBox7.TabStop = false;
            groupBox7.Text = "Approved Rentals";
            // 
            // lblApprovedRentals
            // 
            lblApprovedRentals.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApprovedRentals.Location = new Point(6, 42);
            lblApprovedRentals.Name = "lblApprovedRentals";
            lblApprovedRentals.Size = new Size(189, 36);
            lblApprovedRentals.TabIndex = 4;
            lblApprovedRentals.Text = "lblApprovedRentals";
            lblApprovedRentals.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblTotalSales);
            groupBox5.ForeColor = Color.White;
            groupBox5.Location = new Point(17, 175);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(199, 105);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Total Sale";
            // 
            // lblTotalSales
            // 
            lblTotalSales.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSales.Location = new Point(6, 40);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(187, 36);
            lblTotalSales.TabIndex = 3;
            lblTotalSales.Text = "lblTotalSales";
            lblTotalSales.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblTotalEquipment);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(17, 27);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(199, 118);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Total Equipment";
            // 
            // lblTotalEquipment
            // 
            lblTotalEquipment.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalEquipment.Location = new Point(6, 49);
            lblTotalEquipment.Name = "lblTotalEquipment";
            lblTotalEquipment.Size = new Size(187, 36);
            lblTotalEquipment.TabIndex = 0;
            lblTotalEquipment.Text = "lblTotalEquipment";
            lblTotalEquipment.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblRentedEquipment);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(243, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(201, 118);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Rented Equipment";
            // 
            // lblRentedEquipment
            // 
            lblRentedEquipment.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentedEquipment.Location = new Point(6, 49);
            lblRentedEquipment.Name = "lblRentedEquipment";
            lblRentedEquipment.Size = new Size(189, 36);
            lblRentedEquipment.TabIndex = 1;
            lblRentedEquipment.Text = "lblRentedEquipment";
            lblRentedEquipment.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lblCancelledRentals);
            groupBox6.ForeColor = Color.White;
            groupBox6.Location = new Point(465, 27);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(199, 118);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Over Due Rentals";
            // 
            // lblCancelledRentals
            // 
            lblCancelledRentals.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCancelledRentals.Location = new Point(6, 49);
            lblCancelledRentals.Name = "lblCancelledRentals";
            lblCancelledRentals.Size = new Size(180, 36);
            lblCancelledRentals.TabIndex = 2;
            lblCancelledRentals.Text = "lblCancelledRentalsAC";
            lblCancelledRentals.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(31, 42, 85);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(811, 331);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(107, 31);
            btnHome.TabIndex = 20;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(930, 377);
            Controls.Add(btnHome);
            Controls.Add(groupBox1);
            Name = "Dashboard";
            Text = "Form1";
            Load += Dashboard_Load;
            groupBox1.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
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
        private Label lblTotalEquipment;
        private Label lblMostRentedItem;
        private Label lblApprovedRentals;
        private Label lblTotalSales;
        private Label lblRentedEquipment;
        private Label lblCancelledRentals;
        private GroupBox groupBox8;
        private Label lblPendingRequests;
        private GroupBox groupBox2;
        private Label lblTotalMonth;
    }
}