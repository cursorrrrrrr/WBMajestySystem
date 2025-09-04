using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WBMajestySystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();                   // first
            cboRole.Items.AddRange(new object[] { "Admin", "Staff", "Cashier" });
            cboRole.SelectedIndex = 0;
            btnLogin.Click += btnLogin_Click;
            btnCancel.Click += (s, e) => this.Close();
            chkShowPassword.CheckedChanged += (s, e) =>
            {
                txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
            };
            this.AcceptButton = btnLogin;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // optional init

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;                         // demo: plain; hash later
            string selectedRole = cboRole.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username and password.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using var conn = Db.GetConnection();
                conn.Open();

                using var cmd = new MySqlCommand(@"
			SELECT full_name, role, status
			FROM users
			WHERE username=@u AND password=@p
			LIMIT 1;", conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password); // TODO: replace with hash compare

                using var r = cmd.ExecuteReader();
                if (!r.Read())
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var dbRole = r.GetString("role");
                var status = r.GetString("status");
                var fullName = r.GetString("full_name");

                if (!string.Equals(dbRole, selectedRole, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Selected role does not match user role.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!string.Equals(status, "Active", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(this, "Account is inactive.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Login OK – open dashboard
                this.Hide();
                using (var dashboard = new DashboardForm())
                {
                    dashboard.Text = $"Dashboard - {dbRole} | {fullName}";
                    dashboard.StartPosition = FormStartPosition.CenterScreen;
                    dashboard.ShowDialog(this);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error:\n{ex.Message}", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUsername.Text = "admin";
            txtPassword.Text = "admin123";
            cboRole.SelectedItem = "Admin";
        }

        private void lnkCashier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUsername.Text = "cashier";
            txtPassword.Text = "cashier123";
            cboRole.SelectedItem = "Cashier";
        }

        private void lnkStaff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtUsername.Text = "staff";
            txtPassword.Text = "staff123";
            cboRole.SelectedItem = "Staff";
        }

        

        }
}
