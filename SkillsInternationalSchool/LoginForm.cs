using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SkillsInternationalSchool
{
    /// <summary>
    /// LoginForm - Provides authentication for the Skills International School
    /// Student Management System. Validates hardcoded admin credentials before
    /// granting access to the Student Registration Form.
    /// </summary>
    public partial class LoginForm : Form
    {
        // ====================================================================
        // Hardcoded Admin Credentials
        // ====================================================================
        private const string ADMIN_USERNAME = "Admin";
        private const string ADMIN_PASSWORD = "Skills@123";

        // ====================================================================
        // Constructor
        // ====================================================================
        public LoginForm()
        {
            InitializeComponent();

            // Load school logo from the Resources folder
            try
            {
                string logoPath = System.IO.Path.Combine(
                    System.AppDomain.CurrentDomain.BaseDirectory, "Resources", "SchoolLogo.png");
                if (System.IO.File.Exists(logoPath))
                {
                    pictureBoxLogo.Image = System.Drawing.Image.FromFile(logoPath);
                }
            }
            catch
            {
                // Silently ignore if logo file is not found; just show empty PictureBox
            }

            // Set the password character to mask password input
            txtPassword.PasswordChar = '*';

            // Set focus to the username field on load
            this.Load += (s, e) => txtUsername.Focus();
        }

        // ====================================================================
        // btnClear_Click - Clears both textboxes and sets focus to txtUsername
        // ====================================================================
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        // ====================================================================
        // btnLogin_Click - Validates credentials and navigates to RegisterForm
        // ====================================================================
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validate that both fields are filled
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter your username.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter your password.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // Check credentials against hardcoded values
            if (txtUsername.Text.Trim() == ADMIN_USERNAME &&
                txtPassword.Text == ADMIN_PASSWORD)
            {
                // Credentials match — hide LoginForm and show Registration Form
                this.Hide();

                RegisterForm registerForm = new RegisterForm();
                registerForm.ShowDialog();

                // When RegisterForm closes, show LoginForm again (handles logout)
                this.Show();
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
            else
            {
                // Invalid credentials — show error message
                MessageBox.Show(
                    "Invalid Login credentials, please check Username and Password and try again",
                    "Invalid login Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        // ====================================================================
        // btnExit_Click - Confirms before exiting the application
        // ====================================================================
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure, Do you really want to Exit...?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // ====================================================================
        // Enter key triggers login when pressed in password field
        // ====================================================================
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
