namespace WBMajestySystem
{
    partial class LoginForm
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
            lblTitle = new Label();
            lblSubtitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            lblRole = new Label();
            cboRole = new ComboBox();
            btnLogin = new Button();
            btnCancel = new Button();
            panelDefaults = new Panel();
            lblDefaults3 = new Label();
            lblDefaults2 = new Label();
            lblDefaults1 = new Label();
            lblDefaults = new Label();
            panelDefaults.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Sparkling Bright", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.DarkViolet;
            lblTitle.Location = new Point(52, 17);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(344, 47);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "WB MAJESTY GROCERIES";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("SansSerif", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(109, 56);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(252, 22);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Sales and Inventory System";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Microsoft Sans Serif", 12F);
            lblUsername.Location = new Point(61, 110);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(87, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(101, 133);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(260, 23);
            txtUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Microsoft Sans Serif", 12F);
            lblPassword.Location = new Point(61, 165);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(82, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(101, 188);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(260, 23);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.Location = new Point(102, 213);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(114, 21);
            chkShowPassword.TabIndex = 6;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Microsoft Sans Serif", 12F);
            lblRole.Location = new Point(66, 255);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(46, 20);
            lblRole.TabIndex = 7;
            lblRole.Text = "Role:";
            // 
            // cboRole
            // 
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(102, 278);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(260, 23);
            cboRole.TabIndex = 8;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkViolet;
            btnLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(83, 392);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 30);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(241, 392);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 30);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // panelDefaults
            // 
            panelDefaults.BackColor = Color.Lavender;
            panelDefaults.Controls.Add(lblDefaults3);
            panelDefaults.Controls.Add(lblDefaults2);
            panelDefaults.Controls.Add(lblDefaults1);
            panelDefaults.Controls.Add(lblDefaults);
            panelDefaults.Font = new Font("LT Karaoke", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelDefaults.Location = new Point(92, 317);
            panelDefaults.Name = "panelDefaults";
            panelDefaults.Size = new Size(252, 50);
            panelDefaults.TabIndex = 11;
            // 
            // lblDefaults3
            // 
            lblDefaults3.AutoSize = true;
            lblDefaults3.Font = new Font("Lucida Fax", 8F);
            lblDefaults3.ForeColor = Color.DimGray;
            lblDefaults3.Location = new Point(131, 32);
            lblDefaults3.Name = "lblDefaults3";
            lblDefaults3.Size = new Size(92, 14);
            lblDefaults3.TabIndex = 3;
            lblDefaults3.Text = "staff / staff123";
            // 
            // lblDefaults2
            // 
            lblDefaults2.AutoSize = true;
            lblDefaults2.Font = new Font("Lucida Fax", 8F);
            lblDefaults2.ForeColor = Color.DimGray;
            lblDefaults2.Location = new Point(131, 18);
            lblDefaults2.Name = "lblDefaults2";
            lblDefaults2.Size = new Size(120, 14);
            lblDefaults2.TabIndex = 2;
            lblDefaults2.Text = "cashier / cashier123";
            // 
            // lblDefaults1
            // 
            lblDefaults1.AutoSize = true;
            lblDefaults1.Font = new Font("Lucida Fax", 8F);
            lblDefaults1.ForeColor = Color.DimGray;
            lblDefaults1.Location = new Point(131, 4);
            lblDefaults1.Name = "lblDefaults1";
            lblDefaults1.Size = new Size(110, 14);
            lblDefaults1.TabIndex = 1;
            lblDefaults1.Text = "admin / admin123";
            // 
            // lblDefaults
            // 
            lblDefaults.AutoSize = true;
            lblDefaults.Font = new Font("Calibri", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDefaults.ForeColor = Color.DimGray;
            lblDefaults.Location = new Point(3, 14);
            lblDefaults.Name = "lblDefaults";
            lblDefaults.Size = new Size(131, 18);
            lblDefaults.TabIndex = 0;
            lblDefaults.Text = "Default Credentials:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(433, 455);
            Controls.Add(panelDefaults);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(cboRole);
            Controls.Add(lblRole);
            Controls.Add(chkShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WB Majesty – Login";
            Load += LoginForm_Load;
            panelDefaults.ResumeLayout(false);
            panelDefaults.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private Label lblRole;
        private ComboBox cboRole;
        private Panel panelDefaults;
        private Label lblDefaults;
        private Label lblDefaults1;
        private Label lblDefaults3;
        private Label lblDefaults2;
        private Button btnLogin;
        private Button btnCancel;
    }
}