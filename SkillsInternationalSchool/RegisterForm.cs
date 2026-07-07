using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SkillsInternationalSchool
{
    /// <summary>
    /// RegisterForm - Student Registration form for Skills International School.
    /// Performs full CRUD operations (Create, Read, Update, Delete) on the
    /// Registration table using ADO.NET and SQL Server.
    /// </summary>
    public partial class RegisterForm : Form
    {
        // ====================================================================
        // Database Connection String
        // --------------------------------------------------------------------
        // UPDATE THIS if your SQL Server instance name or credentials differ.
        // Default assumes: Server=localhost (or .\SQLEXPRESS), integrated security.
        // ====================================================================
        private readonly string connectionString =
            ConfigurationManager.ConnectionStrings["StudentDB"]?.ConnectionString
            ?? "Server=localhost;Database=Student;Integrated Security=True;";

        // ====================================================================
        // Constructor
        // ====================================================================
        public RegisterForm()
        {
            InitializeComponent();

            // Attach event handlers
            this.Load += RegisterForm_Load;
            cmbRegNo.SelectedIndexChanged += cmbRegNo_SelectedIndexChanged;
            btnRegister.Click += btnRegister_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnClear.Click += btnClear_Click;
            btnDelete.Click += btnDelete_Click;
            lnkLogout.LinkClicked += lnkLogout_LinkClicked;
            lnkExit.LinkClicked += lnkExit_LinkClicked;
        }

        // ====================================================================
        // RegisterForm_Load - Populates the regNo ComboBox with all existing IDs
        // ====================================================================
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            LoadRegistrationNumbers();
            ClearAllFields();
        }

        /// <summary>
        /// Loads all existing registration numbers from the database into cmbRegNo.
        /// </summary>
        private void LoadRegistrationNumbers()
        {
            cmbRegNo.Items.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT regNo FROM Registration ORDER BY regNo";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbRegNo.Items.Add(reader["regNo"].ToString());
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Database connection failed. Please check your connection string and ensure SQL Server is running.\n\nError: " + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ====================================================================
        // cmbRegNo_SelectedIndexChanged - Searches and auto-fills form with
        // the selected student's details from the database.
        // ====================================================================
        private void cmbRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRegNo.SelectedIndex < 0)
                return;

            string selectedRegNo = cmbRegNo.SelectedItem.ToString();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Registration WHERE regNo = @regNo";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@regNo", Convert.ToInt32(selectedRegNo));
                        conn.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate all fields from the database record
                                txtFirstName.Text   = reader["firstName"].ToString();
                                txtLastName.Text    = reader["lastName"].ToString();
                                dtpDOB.Value        = Convert.ToDateTime(reader["dateOfBirth"]);
                                string gender       = reader["gender"].ToString();
                                rdoMale.Checked     = (gender == "Male");
                                rdoFemale.Checked   = (gender == "Female");
                                txtAddress.Text     = reader["address"].ToString();
                                txtEmail.Text       = reader["email"].ToString();
                                txtMobilePhone.Text = reader["mobilePhone"].ToString();
                                txtHomePhone.Text   = reader["homePhone"].ToString();
                                txtParentName.Text  = reader["parentName"].ToString();
                                txtNIC.Text         = reader["nic"].ToString();
                                txtContactNo.Text   = reader["contactNo"].ToString();
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Error fetching student record.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ====================================================================
        // btnRegister_Click - Inserts a new student record into the database
        // ====================================================================
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (!ValidateFields())
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        INSERT INTO Registration 
                        (regNo, firstName, lastName, dateOfBirth, gender, address, email,
                         mobilePhone, homePhone, parentName, nic, contactNo)
                        VALUES 
                        (@regNo, @firstName, @lastName, @dateOfBirth, @gender, @address, @email,
                         @mobilePhone, @homePhone, @parentName, @nic, @contactNo)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Bind parameters
                        cmd.Parameters.AddWithValue("@regNo",       Convert.ToInt32(cmbRegNo.Text));
                        cmd.Parameters.AddWithValue("@firstName",   txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@lastName",    txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@dateOfBirth", dtpDOB.Value);
                        cmd.Parameters.AddWithValue("@gender",      rdoMale.Checked ? "Male" : "Female");
                        cmd.Parameters.AddWithValue("@address",     txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@email",       txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@mobilePhone", Convert.ToInt32(txtMobilePhone.Text));
                        cmd.Parameters.AddWithValue("@homePhone",   Convert.ToInt32(txtHomePhone.Text));
                        cmd.Parameters.AddWithValue("@parentName",  txtParentName.Text.Trim());
                        cmd.Parameters.AddWithValue("@nic",         txtNIC.Text.Trim());
                        cmd.Parameters.AddWithValue("@contactNo",   Convert.ToInt32(txtContactNo.Text));

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                // Success feedback
                MessageBox.Show(
                    "Record Added Succesfully",
                    "Register Student",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Refresh ComboBox and clear fields
                LoadRegistrationNumbers();
                ClearAllFields();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Error inserting record. The registration number may already exist.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ====================================================================
        // btnUpdate_Click - Updates an existing student record in the database
        // ====================================================================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbRegNo.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Please select a registration number from the dropdown to update.",
                    "No Record Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateFields())
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        UPDATE Registration SET
                            firstName   = @firstName,
                            lastName    = @lastName,
                            dateOfBirth = @dateOfBirth,
                            gender      = @gender,
                            address     = @address,
                            email       = @email,
                            mobilePhone = @mobilePhone,
                            homePhone   = @homePhone,
                            parentName  = @parentName,
                            nic         = @nic,
                            contactNo   = @contactNo
                        WHERE regNo = @regNo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@regNo",       Convert.ToInt32(cmbRegNo.Text));
                        cmd.Parameters.AddWithValue("@firstName",   txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@lastName",    txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@dateOfBirth", dtpDOB.Value);
                        cmd.Parameters.AddWithValue("@gender",      rdoMale.Checked ? "Male" : "Female");
                        cmd.Parameters.AddWithValue("@address",     txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@email",       txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@mobilePhone", Convert.ToInt32(txtMobilePhone.Text));
                        cmd.Parameters.AddWithValue("@homePhone",   Convert.ToInt32(txtHomePhone.Text));
                        cmd.Parameters.AddWithValue("@parentName",  txtParentName.Text.Trim());
                        cmd.Parameters.AddWithValue("@nic",         txtNIC.Text.Trim());
                        cmd.Parameters.AddWithValue("@contactNo",   Convert.ToInt32(txtContactNo.Text));

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Record Updated Succesfully",
                    "Update Student",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadRegistrationNumbers();
                ClearAllFields();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Error updating record.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ====================================================================
        // btnDelete_Click - Confirms and deletes a student record
        // ====================================================================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbRegNo.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Please select a registration number from the dropdown to delete.",
                    "No Record Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Confirmation dialog
            DialogResult result = MessageBox.Show(
                "Are you sure, Do you really want to Delete this Record...?",
                "Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Registration WHERE regNo = @regNo";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@regNo", Convert.ToInt32(cmbRegNo.Text));
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Record Deleted Succesfully",
                    "Delete Student",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadRegistrationNumbers();
                ClearAllFields();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Error deleting record.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ====================================================================
        // btnClear_Click - Clears all input fields on the form
        // ====================================================================
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        // ====================================================================
        // lnkLogout_LinkClicked - Hides RegisterForm and returns to LoginForm
        // ====================================================================
        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();   // Returning to LoginForm because LoginForm used ShowDialog()
        }

        // ====================================================================
        // lnkExit_LinkClicked - Confirms exit and closes the application
        // ====================================================================
        private void lnkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
        // ValidateFields - Checks all required inputs before save/update
        // ====================================================================
        private bool ValidateFields()
        {
            // Registration Number
            if (string.IsNullOrWhiteSpace(cmbRegNo.Text))
            {
                ShowValidationError("Please enter a Registration Number.");
                cmbRegNo.Focus();
                return false;
            }

            if (!int.TryParse(cmbRegNo.Text, out _))
            {
                ShowValidationError("Registration Number must be a valid integer.");
                cmbRegNo.Focus();
                return false;
            }

            // First Name
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                ShowValidationError("Please enter First Name.");
                txtFirstName.Focus();
                return false;
            }

            // Last Name
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                ShowValidationError("Please enter Last Name.");
                txtLastName.Focus();
                return false;
            }

            // Gender
            if (!rdoMale.Checked && !rdoFemale.Checked)
            {
                ShowValidationError("Please select a Gender.");
                return false;
            }

            // Address
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                ShowValidationError("Please enter Address.");
                txtAddress.Focus();
                return false;
            }

            // Email
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ShowValidationError("Please enter Email.");
                txtEmail.Focus();
                return false;
            }

            // Mobile Phone
            if (string.IsNullOrWhiteSpace(txtMobilePhone.Text))
            {
                ShowValidationError("Please enter Mobile Phone.");
                txtMobilePhone.Focus();
                return false;
            }

            if (!int.TryParse(txtMobilePhone.Text, out _))
            {
                ShowValidationError("Mobile Phone must be a valid integer.");
                txtMobilePhone.Focus();
                return false;
            }

            // Home Phone
            if (string.IsNullOrWhiteSpace(txtHomePhone.Text))
            {
                ShowValidationError("Please enter Home Phone.");
                txtHomePhone.Focus();
                return false;
            }

            if (!int.TryParse(txtHomePhone.Text, out _))
            {
                ShowValidationError("Home Phone must be a valid integer.");
                txtHomePhone.Focus();
                return false;
            }

            // Parent Name
            if (string.IsNullOrWhiteSpace(txtParentName.Text))
            {
                ShowValidationError("Please enter Parent Name.");
                txtParentName.Focus();
                return false;
            }

            // NIC
            if (string.IsNullOrWhiteSpace(txtNIC.Text))
            {
                ShowValidationError("Please enter NIC.");
                txtNIC.Focus();
                return false;
            }

            // Contact No
            if (string.IsNullOrWhiteSpace(txtContactNo.Text))
            {
                ShowValidationError("Please enter Contact Number.");
                txtContactNo.Focus();
                return false;
            }

            if (!int.TryParse(txtContactNo.Text, out _))
            {
                ShowValidationError("Contact Number must be a valid integer.");
                txtContactNo.Focus();
                return false;
            }

            return true;
        }

        // ====================================================================
        // ShowValidationError - Helper to show validation warning
        // ====================================================================
        private void ShowValidationError(string message)
        {
            MessageBox.Show(
                message,
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        // ====================================================================
        // ClearAllFields - Resets all input controls to their default state
        // ====================================================================
        private void ClearAllFields()
        {
            cmbRegNo.SelectedIndex = -1;
            cmbRegNo.Text = string.Empty;
            txtFirstName.Clear();
            txtLastName.Clear();
            dtpDOB.Value = DateTime.Today;
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobilePhone.Clear();
            txtHomePhone.Clear();
            txtParentName.Clear();
            txtNIC.Clear();
            txtContactNo.Clear();
            cmbRegNo.Focus();
        }
    }
}
