namespace WindowsFormsApp1
{
    partial class formRegisteration
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupLoginDetails = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPasssword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.groupPersonalDetails = new System.Windows.Forms.GroupBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtInitial = new System.Windows.Forms.TextBox();
            this.listTitle = new System.Windows.Forms.ListBox();
            this.dateDob = new System.Windows.Forms.DateTimePicker();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.lblInitial = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIdNumber = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupLoginDetails.SuspendLayout();
            this.groupPersonalDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter all of the following details to register: ";
            // 
            // groupLoginDetails
            // 
            this.groupLoginDetails.Controls.Add(this.txtUsername);
            this.groupLoginDetails.Controls.Add(this.txtPassword);
            this.groupLoginDetails.Controls.Add(this.txtConfirmPassword);
            this.groupLoginDetails.Controls.Add(this.lblConfirmPassword);
            this.groupLoginDetails.Controls.Add(this.lblPasssword);
            this.groupLoginDetails.Controls.Add(this.lblUsername);
            this.groupLoginDetails.Location = new System.Drawing.Point(24, 68);
            this.groupLoginDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupLoginDetails.Name = "groupLoginDetails";
            this.groupLoginDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupLoginDetails.Size = new System.Drawing.Size(433, 154);
            this.groupLoginDetails.TabIndex = 1;
            this.groupLoginDetails.TabStop = false;
            this.groupLoginDetails.Text = "Login Details";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(216, 22);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(152, 20);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(216, 66);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(152, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(216, 107);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(152, 20);
            this.txtConfirmPassword.TabIndex = 4;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(36, 110);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.lblConfirmPassword.TabIndex = 2;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblPasssword
            // 
            this.lblPasssword.AutoSize = true;
            this.lblPasssword.Location = new System.Drawing.Point(36, 69);
            this.lblPasssword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasssword.Name = "lblPasssword";
            this.lblPasssword.Size = new System.Drawing.Size(53, 13);
            this.lblPasssword.TabIndex = 1;
            this.lblPasssword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(36, 25);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // groupPersonalDetails
            // 
            this.groupPersonalDetails.Controls.Add(this.txtFirstName);
            this.groupPersonalDetails.Controls.Add(this.txtLastName);
            this.groupPersonalDetails.Controls.Add(this.txtInitial);
            this.groupPersonalDetails.Controls.Add(this.listTitle);
            this.groupPersonalDetails.Controls.Add(this.dateDob);
            this.groupPersonalDetails.Controls.Add(this.radioFemale);
            this.groupPersonalDetails.Controls.Add(this.radioMale);
            this.groupPersonalDetails.Controls.Add(this.txtIdNumber);
            this.groupPersonalDetails.Controls.Add(this.lblInitial);
            this.groupPersonalDetails.Controls.Add(this.lblGender);
            this.groupPersonalDetails.Controls.Add(this.lblDob);
            this.groupPersonalDetails.Controls.Add(this.lblFirstName);
            this.groupPersonalDetails.Controls.Add(this.lblLastName);
            this.groupPersonalDetails.Controls.Add(this.lblTitle);
            this.groupPersonalDetails.Controls.Add(this.lblIdNumber);
            this.groupPersonalDetails.Location = new System.Drawing.Point(24, 294);
            this.groupPersonalDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupPersonalDetails.Name = "groupPersonalDetails";
            this.groupPersonalDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupPersonalDetails.Size = new System.Drawing.Size(432, 269);
            this.groupPersonalDetails.TabIndex = 2;
            this.groupPersonalDetails.TabStop = false;
            this.groupPersonalDetails.Text = "Personal Details";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(216, 152);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(182, 20);
            this.txtFirstName.TabIndex = 14;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(216, 113);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(182, 20);
            this.txtLastName.TabIndex = 13;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtInitial
            // 
            this.txtInitial.Location = new System.Drawing.Point(287, 73);
            this.txtInitial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInitial.Name = "txtInitial";
            this.txtInitial.Size = new System.Drawing.Size(112, 20);
            this.txtInitial.TabIndex = 12;
            this.txtInitial.TextChanged += new System.EventHandler(this.txtInitial_TextChanged);
            // 
            // listTitle
            // 
            this.listTitle.FormattingEnabled = true;
            this.listTitle.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Dr."});
            this.listTitle.Location = new System.Drawing.Point(104, 73);
            this.listTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listTitle.Name = "listTitle";
            this.listTitle.Size = new System.Drawing.Size(62, 17);
            this.listTitle.TabIndex = 11;
            // 
            // dateDob
            // 
            this.dateDob.Location = new System.Drawing.Point(127, 189);
            this.dateDob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateDob.Name = "dateDob";
            this.dateDob.Size = new System.Drawing.Size(102, 20);
            this.dateDob.TabIndex = 10;
            this.dateDob.ValueChanged += new System.EventHandler(this.dateDob_ValueChanged);
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(246, 229);
            this.radioFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(59, 17);
            this.radioFemale.TabIndex = 9;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            this.radioFemale.CheckedChanged += new System.EventHandler(this.radioFemale_CheckedChanged);
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(127, 229);
            this.radioMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(48, 17);
            this.radioMale.TabIndex = 8;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            this.radioMale.CheckedChanged += new System.EventHandler(this.radioMale_CheckedChanged);
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(246, 34);
            this.txtIdNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(152, 20);
            this.txtIdNumber.TabIndex = 7;
            this.txtIdNumber.TextChanged += new System.EventHandler(this.txtIdNumber_TextChanged);
            // 
            // lblInitial
            // 
            this.lblInitial.AutoSize = true;
            this.lblInitial.Location = new System.Drawing.Point(230, 73);
            this.lblInitial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInitial.Name = "lblInitial";
            this.lblInitial.Size = new System.Drawing.Size(31, 13);
            this.lblInitial.TabIndex = 6;
            this.lblInitial.Text = "Initial";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(28, 231);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(28, 192);
            this.lblDob.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(66, 13);
            this.lblDob.TabIndex = 4;
            this.lblDob.Text = "Date of Birth";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(28, 152);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(28, 113);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(28, 73);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.AutoSize = true;
            this.lblIdNumber.Location = new System.Drawing.Point(28, 34);
            this.lblIdNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new System.Drawing.Size(81, 13);
            this.lblIdNumber.TabIndex = 0;
            this.lblIdNumber.Text = "Identity Number";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(210, 598);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(347, 598);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // formRegisteration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 633);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupPersonalDetails);
            this.Controls.Add(this.groupLoginDetails);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formRegisteration";
            this.Text = "Registration";
            this.groupLoginDetails.ResumeLayout(false);
            this.groupLoginDetails.PerformLayout();
            this.groupPersonalDetails.ResumeLayout(false);
            this.groupPersonalDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupLoginDetails;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblPasssword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox groupPersonalDetails;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtInitial;
        private System.Windows.Forms.ListBox listTitle;
        private System.Windows.Forms.DateTimePicker dateDob;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.Label lblInitial;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
    }
}