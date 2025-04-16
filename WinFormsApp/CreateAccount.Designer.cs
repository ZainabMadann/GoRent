namespace WinFormsApp
{
    partial class CreateAccount
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbUserRoles = new ComboBox();
            txtName = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            btnLogin = new Button();
            btnCreateAccount = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(203, 44);
            label1.Name = "label1";
            label1.Size = new Size(227, 67);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(112, 133);
            label2.Name = "label2";
            label2.Size = new Size(89, 33);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(112, 184);
            label3.Name = "label3";
            label3.Size = new Size(89, 33);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(112, 240);
            label4.Name = "label4";
            label4.Size = new Size(99, 33);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(112, 294);
            label5.Name = "label5";
            label5.Size = new Size(89, 33);
            label5.TabIndex = 4;
            label5.Text = "Role:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbUserRoles
            // 
            cmbUserRoles.BackColor = Color.FromArgb(31, 42, 85);
            cmbUserRoles.Font = new Font("Segoe UI", 10.2F);
            cmbUserRoles.ForeColor = Color.White;
            cmbUserRoles.FormattingEnabled = true;
            cmbUserRoles.Items.AddRange(new object[] { "Administrator", "Manager" });
            cmbUserRoles.Location = new Point(218, 298);
            cmbUserRoles.Name = "cmbUserRoles";
            cmbUserRoles.Size = new Size(288, 31);
            cmbUserRoles.TabIndex = 14;
            cmbUserRoles.Text = "Chose a role";
            // 
            // txtName
            // 
            txtName.Location = new Point(218, 133);
            txtName.Name = "txtName";
            txtName.Size = new Size(288, 27);
            txtName.TabIndex = 17;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(218, 246);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(288, 27);
            txtPassword.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(218, 192);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(288, 27);
            txtEmail.TabIndex = 15;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(31, 42, 85);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(525, 476);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(108, 29);
            btnLogin.TabIndex = 18;
            btnLogin.Text = "go to Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.FromArgb(31, 42, 85);
            btnCreateAccount.ForeColor = Color.White;
            btnCreateAccount.Location = new Point(259, 375);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(139, 29);
            btnCreateAccount.TabIndex = 19;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(645, 517);
            Controls.Add(btnCreateAccount);
            Controls.Add(btnLogin);
            Controls.Add(txtName);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(cmbUserRoles);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateAccount";
            Text = "CreateAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbUserRoles;
        private TextBox txtName;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Button btnLogin;
        private Button btnCreateAccount;
    }
}