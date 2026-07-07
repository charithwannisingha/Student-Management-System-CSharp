namespace SkillsInternationalSchool
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));

            // ================================================================
            // GroupBox: grpStudentRegistration (outer container)
            // ================================================================
            this.grpStudentRegistration = new System.Windows.Forms.GroupBox();
            this.cmbRegNo = new System.Windows.Forms.ComboBox();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.lnkLogout = new System.Windows.Forms.LinkLabel();
            this.lnkExit = new System.Windows.Forms.LinkLabel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();

            // ================================================================
            // GroupBox: grpBasicDetails
            // ================================================================
            this.grpBasicDetails = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();

            // ================================================================
            // GroupBox: grpContactDetails
            // ================================================================
            this.grpContactDetails = new System.Windows.Forms.GroupBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.lblMobilePhone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();

            // ================================================================
            // GroupBox: grpParentDetails
            // ================================================================
            this.grpParentDetails = new System.Windows.Forms.GroupBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.lblNIC = new System.Windows.Forms.Label();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.lblParentName = new System.Windows.Forms.Label();

            // ================================================================
            // Populate controls in each GroupBox
            // ================================================================
            this.grpStudentRegistration.SuspendLayout();
            this.grpBasicDetails.SuspendLayout();
            this.grpContactDetails.SuspendLayout();
            this.grpParentDetails.SuspendLayout();
            this.SuspendLayout();

            // ----------------------------------------------------------------
            // grpStudentRegistration - Main container
            // ----------------------------------------------------------------
            this.grpStudentRegistration.Controls.Add(this.cmbRegNo);
            this.grpStudentRegistration.Controls.Add(this.lblRegNo);
            this.grpStudentRegistration.Controls.Add(this.lnkLogout);
            this.grpStudentRegistration.Controls.Add(this.lnkExit);
            this.grpStudentRegistration.Controls.Add(this.btnDelete);
            this.grpStudentRegistration.Controls.Add(this.btnClear);
            this.grpStudentRegistration.Controls.Add(this.btnUpdate);
            this.grpStudentRegistration.Controls.Add(this.btnRegister);
            this.grpStudentRegistration.Controls.Add(this.grpParentDetails);
            this.grpStudentRegistration.Controls.Add(this.grpContactDetails);
            this.grpStudentRegistration.Controls.Add(this.grpBasicDetails);
            this.grpStudentRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.grpStudentRegistration.Location = new System.Drawing.Point(12, 12);
            this.grpStudentRegistration.Name = "grpStudentRegistration";
            this.grpStudentRegistration.Size = new System.Drawing.Size(600, 600);
            this.grpStudentRegistration.TabIndex = 0;
            this.grpStudentRegistration.TabStop = false;
            this.grpStudentRegistration.Text = "Student Registration";

            // ----------------------------------------------------------------
            // lblRegNo + cmbRegNo
            // ----------------------------------------------------------------
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRegNo.Location = new System.Drawing.Point(20, 30);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(100, 15);
            this.lblRegNo.Text = "Registration No";
            this.cmbRegNo.FormattingEnabled = true;
            this.cmbRegNo.Location = new System.Drawing.Point(140, 27);
            this.cmbRegNo.Name = "cmbRegNo";
            this.cmbRegNo.Size = new System.Drawing.Size(150, 23);
            this.cmbRegNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;

            // ----------------------------------------------------------------
            // grpBasicDetails
            // ----------------------------------------------------------------
            this.grpBasicDetails.Controls.Add(this.txtAddress);
            this.grpBasicDetails.Controls.Add(this.lblAddress);
            this.grpBasicDetails.Controls.Add(this.rdoFemale);
            this.grpBasicDetails.Controls.Add(this.rdoMale);
            this.grpBasicDetails.Controls.Add(this.lblGender);
            this.grpBasicDetails.Controls.Add(this.dtpDOB);
            this.grpBasicDetails.Controls.Add(this.lblDOB);
            this.grpBasicDetails.Controls.Add(this.txtLastName);
            this.grpBasicDetails.Controls.Add(this.lblLastName);
            this.grpBasicDetails.Controls.Add(this.txtFirstName);
            this.grpBasicDetails.Controls.Add(this.lblFirstName);
            this.grpBasicDetails.Location = new System.Drawing.Point(20, 65);
            this.grpBasicDetails.Name = "grpBasicDetails";
            this.grpBasicDetails.Size = new System.Drawing.Size(555, 220);
            this.grpBasicDetails.TabIndex = 1;
            this.grpBasicDetails.TabStop = false;
            this.grpBasicDetails.Text = "Basic Details";

            // lblFirstName | txtFirstName
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(15, 30);
            this.lblFirstName.Name = "lblFirstName"; this.lblFirstName.Size = new System.Drawing.Size(70, 15);
            this.lblFirstName.Text = "First Name";
            this.txtFirstName.Location = new System.Drawing.Point(120, 27);
            this.txtFirstName.Name = "txtFirstName"; this.txtFirstName.Size = new System.Drawing.Size(175, 21);

            // lblLastName | txtLastName
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(15, 65);
            this.lblLastName.Name = "lblLastName"; this.lblLastName.Size = new System.Drawing.Size(70, 15);
            this.lblLastName.Text = "Last Name";
            this.txtLastName.Location = new System.Drawing.Point(120, 62);
            this.txtLastName.Name = "txtLastName"; this.txtLastName.Size = new System.Drawing.Size(175, 21);

            // lblDOB | dtpDOB
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(15, 100);
            this.lblDOB.Name = "lblDOB"; this.lblDOB.Size = new System.Drawing.Size(80, 15);
            this.lblDOB.Text = "Date of Birth";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(120, 97);
            this.dtpDOB.Name = "dtpDOB"; this.dtpDOB.Size = new System.Drawing.Size(175, 21);

            // lblGender | rdoMale | rdoFemale
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(15, 135);
            this.lblGender.Name = "lblGender"; this.lblGender.Size = new System.Drawing.Size(50, 15);
            this.lblGender.Text = "Gender";
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(120, 133);
            this.rdoMale.Name = "rdoMale"; this.rdoMale.Size = new System.Drawing.Size(53, 19);
            this.rdoMale.Text = "Male";
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(190, 133);
            this.rdoFemale.Name = "rdoFemale"; this.rdoFemale.Size = new System.Drawing.Size(65, 19);
            this.rdoFemale.Text = "Female";

            // lblAddress | txtAddress (multiline)
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(15, 165);
            this.lblAddress.Name = "lblAddress"; this.lblAddress.Size = new System.Drawing.Size(55, 15);
            this.lblAddress.Text = "Address";
            this.txtAddress.Location = new System.Drawing.Point(120, 162);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress"; this.txtAddress.Size = new System.Drawing.Size(420, 45);
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            // ----------------------------------------------------------------
            // grpContactDetails
            // ----------------------------------------------------------------
            this.grpContactDetails.Controls.Add(this.txtHomePhone);
            this.grpContactDetails.Controls.Add(this.lblHomePhone);
            this.grpContactDetails.Controls.Add(this.txtMobilePhone);
            this.grpContactDetails.Controls.Add(this.lblMobilePhone);
            this.grpContactDetails.Controls.Add(this.txtEmail);
            this.grpContactDetails.Controls.Add(this.lblEmail);
            this.grpContactDetails.Location = new System.Drawing.Point(20, 295);
            this.grpContactDetails.Name = "grpContactDetails";
            this.grpContactDetails.Size = new System.Drawing.Size(555, 120);
            this.grpContactDetails.TabIndex = 2;
            this.grpContactDetails.TabStop = false;
            this.grpContactDetails.Text = "Contact Details";

            // lblEmail | txtEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 25);
            this.lblEmail.Name = "lblEmail"; this.lblEmail.Size = new System.Drawing.Size(40, 15);
            this.lblEmail.Text = "Email";
            this.txtEmail.Location = new System.Drawing.Point(120, 22);
            this.txtEmail.Name = "txtEmail"; this.txtEmail.Size = new System.Drawing.Size(200, 21);

            // lblMobilePhone | txtMobilePhone
            this.lblMobilePhone.AutoSize = true;
            this.lblMobilePhone.Location = new System.Drawing.Point(15, 58);
            this.lblMobilePhone.Name = "lblMobilePhone"; this.lblMobilePhone.Size = new System.Drawing.Size(88, 15);
            this.lblMobilePhone.Text = "Mobile Phone";
            this.txtMobilePhone.Location = new System.Drawing.Point(120, 55);
            this.txtMobilePhone.Name = "txtMobilePhone"; this.txtMobilePhone.Size = new System.Drawing.Size(175, 21);

            // lblHomePhone | txtHomePhone
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(330, 58);
            this.lblHomePhone.Name = "lblHomePhone"; this.lblHomePhone.Size = new System.Drawing.Size(84, 15);
            this.lblHomePhone.Text = "Home Phone";
            this.txtHomePhone.Location = new System.Drawing.Point(420, 55);
            this.txtHomePhone.Name = "txtHomePhone"; this.txtHomePhone.Size = new System.Drawing.Size(120, 21);

            // ----------------------------------------------------------------
            // grpParentDetails
            // ----------------------------------------------------------------
            this.grpParentDetails.Controls.Add(this.txtContactNo);
            this.grpParentDetails.Controls.Add(this.lblContactNo);
            this.grpParentDetails.Controls.Add(this.txtNIC);
            this.grpParentDetails.Controls.Add(this.lblNIC);
            this.grpParentDetails.Controls.Add(this.txtParentName);
            this.grpParentDetails.Controls.Add(this.lblParentName);
            this.grpParentDetails.Location = new System.Drawing.Point(20, 425);
            this.grpParentDetails.Name = "grpParentDetails";
            this.grpParentDetails.Size = new System.Drawing.Size(555, 90);
            this.grpParentDetails.TabIndex = 3;
            this.grpParentDetails.TabStop = false;
            this.grpParentDetails.Text = "Parent Details";

            // lblParentName | txtParentName
            this.lblParentName.AutoSize = true;
            this.lblParentName.Location = new System.Drawing.Point(15, 30);
            this.lblParentName.Name = "lblParentName"; this.lblParentName.Size = new System.Drawing.Size(85, 15);
            this.lblParentName.Text = "Parent Name";
            this.txtParentName.Location = new System.Drawing.Point(120, 27);
            this.txtParentName.Name = "txtParentName"; this.txtParentName.Size = new System.Drawing.Size(200, 21);

            // lblNIC | txtNIC
            this.lblNIC.AutoSize = true;
            this.lblNIC.Location = new System.Drawing.Point(15, 60);
            this.lblNIC.Name = "lblNIC"; this.lblNIC.Size = new System.Drawing.Size(30, 15);
            this.lblNIC.Text = "NIC";
            this.txtNIC.Location = new System.Drawing.Point(120, 57);
            this.txtNIC.Name = "txtNIC"; this.txtNIC.Size = new System.Drawing.Size(175, 21);

            // lblContactNo | txtContactNo
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(330, 60);
            this.lblContactNo.Name = "lblContactNo"; this.lblContactNo.Size = new System.Drawing.Size(74, 15);
            this.lblContactNo.Text = "Contact No";
            this.txtContactNo.Location = new System.Drawing.Point(420, 57);
            this.txtContactNo.Name = "txtContactNo"; this.txtContactNo.Size = new System.Drawing.Size(120, 21);

            // ----------------------------------------------------------------
            // Buttons
            // ----------------------------------------------------------------
            this.btnRegister.BackColor = System.Drawing.Color.LightGreen;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnRegister.Location = new System.Drawing.Point(20, 535);
            this.btnRegister.Name = "btnRegister"; this.btnRegister.Size = new System.Drawing.Size(100, 40);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;

            this.btnUpdate.BackColor = System.Drawing.Color.LightBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(135, 535);
            this.btnUpdate.Name = "btnUpdate"; this.btnUpdate.Size = new System.Drawing.Size(100, 40);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;

            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(250, 535);
            this.btnClear.Name = "btnClear"; this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;

            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(365, 535);
            this.btnDelete.Name = "btnDelete"; this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;

            // ----------------------------------------------------------------
            // LinkLabels
            // ----------------------------------------------------------------
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lnkLogout.LinkColor = System.Drawing.Color.Blue;
            this.lnkLogout.Location = new System.Drawing.Point(490, 540);
            this.lnkLogout.Name = "lnkLogout"; this.lnkLogout.Size = new System.Drawing.Size(50, 17);
            this.lnkLogout.Text = "Logout";
            this.lnkLogout.ActiveLinkColor = System.Drawing.Color.Red;

            this.lnkExit.AutoSize = true;
            this.lnkExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lnkExit.LinkColor = System.Drawing.Color.Blue;
            this.lnkExit.Location = new System.Drawing.Point(495, 565);
            this.lnkExit.Name = "lnkExit"; this.lnkExit.Size = new System.Drawing.Size(30, 17);
            this.lnkExit.Text = "Exit";
            this.lnkExit.ActiveLinkColor = System.Drawing.Color.Red;

            // ----------------------------------------------------------------
            // RegisterForm
            // ----------------------------------------------------------------
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(625, 625);
            this.Controls.Add(this.grpStudentRegistration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skills International School - Student Registration";

            this.grpStudentRegistration.ResumeLayout(false);
            this.grpStudentRegistration.PerformLayout();
            this.grpBasicDetails.ResumeLayout(false);
            this.grpBasicDetails.PerformLayout();
            this.grpContactDetails.ResumeLayout(false);
            this.grpContactDetails.PerformLayout();
            this.grpParentDetails.ResumeLayout(false);
            this.grpParentDetails.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        // --- GroupBoxes ---
        private System.Windows.Forms.GroupBox grpStudentRegistration;
        private System.Windows.Forms.GroupBox grpBasicDetails;
        private System.Windows.Forms.GroupBox grpContactDetails;
        private System.Windows.Forms.GroupBox grpParentDetails;

        // --- Labels ---
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMobilePhone;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.Label lblParentName;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.Label lblContactNo;

        // --- Input Controls ---
        private System.Windows.Forms.ComboBox cmbRegNo;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtContactNo;

        // --- Buttons ---
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;

        // --- LinkLabels ---
        private System.Windows.Forms.LinkLabel lnkLogout;
        private System.Windows.Forms.LinkLabel lnkExit;
    }
}
