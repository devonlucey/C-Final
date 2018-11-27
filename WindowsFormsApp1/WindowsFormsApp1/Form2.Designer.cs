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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPasssword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.groupPersonalDetails = new System.Windows.Forms.GroupBox();
            this.lblIdNumber = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblInitial = new System.Windows.Forms.Label();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.dateDob = new System.Windows.Forms.DateTimePicker();
            this.listTitle = new System.Windows.Forms.ListBox();
            this.txtInitial = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.groupLoginDetails.SuspendLayout();
            this.groupPersonalDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(901, 42);
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
            this.groupLoginDetails.Location = new System.Drawing.Point(48, 130);
            this.groupLoginDetails.Name = "groupLoginDetails";
            this.groupLoginDetails.Size = new System.Drawing.Size(866, 297);
            this.groupLoginDetails.TabIndex = 1;
            this.groupLoginDetails.TabStop = false;
            this.groupLoginDetails.Text = "Login Details";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(73, 48);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(110, 25);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblPasssword
            // 
            this.lblPasssword.AutoSize = true;
            this.lblPasssword.Location = new System.Drawing.Point(73, 132);
            this.lblPasssword.Name = "lblPasssword";
            this.lblPasssword.Size = new System.Drawing.Size(106, 25);
            this.lblPasssword.TabIndex = 1;
            this.lblPasssword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(73, 211);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(186, 25);
            this.lblConfirmPassword.TabIndex = 2;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(432, 42);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(300, 31);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(432, 126);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 31);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(432, 205);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(300, 31);
            this.txtConfirmPassword.TabIndex = 4;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
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
            this.groupPersonalDetails.Location = new System.Drawing.Point(48, 566);
            this.groupPersonalDetails.Name = "groupPersonalDetails";
            this.groupPersonalDetails.Size = new System.Drawing.Size(865, 517);
            this.groupPersonalDetails.TabIndex = 2;
            this.groupPersonalDetails.TabStop = false;
            this.groupPersonalDetails.Text = "Personal Details";
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.AutoSize = true;
            this.lblIdNumber.Location = new System.Drawing.Point(55, 65);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new System.Drawing.Size(162, 25);
            this.lblIdNumber.TabIndex = 0;
            this.lblIdNumber.Text = "Identity Number";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(55, 141);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(53, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(55, 217);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(115, 25);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(55, 293);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(116, 25);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(55, 369);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(131, 25);
            this.lblDob.TabIndex = 4;
            this.lblDob.Text = "Date of Birth";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(55, 445);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(83, 25);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender";
            // 
            // lblInitial
            // 
            this.lblInitial.AutoSize = true;
            this.lblInitial.Location = new System.Drawing.Point(461, 141);
            this.lblInitial.Name = "lblInitial";
            this.lblInitial.Size = new System.Drawing.Size(62, 25);
            this.lblInitial.TabIndex = 6;
            this.lblInitial.Text = "Initial";
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(493, 65);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(300, 31);
            this.txtIdNumber.TabIndex = 7;
            this.txtIdNumber.TextChanged += new System.EventHandler(this.txtIdNumber_TextChanged);
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(254, 441);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(90, 29);
            this.radioMale.TabIndex = 8;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            this.radioMale.CheckedChanged += new System.EventHandler(this.radioMale_CheckedChanged);
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(493, 441);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(114, 29);
            this.radioFemale.TabIndex = 9;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            this.radioFemale.CheckedChanged += new System.EventHandler(this.radioFemale_CheckedChanged);
            // 
            // dateDob
            // 
            this.dateDob.Location = new System.Drawing.Point(254, 363);
            this.dateDob.Name = "dateDob";
            this.dateDob.Size = new System.Drawing.Size(200, 31);
            this.dateDob.TabIndex = 10;
            this.dateDob.ValueChanged += new System.EventHandler(this.dateDob_ValueChanged);
            // 
            // listTitle
            // 
            this.listTitle.FormattingEnabled = true;
            this.listTitle.ItemHeight = 25;
            this.listTitle.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Dr."});
            this.listTitle.Location = new System.Drawing.Point(208, 141);
            this.listTitle.Name = "listTitle";
            this.listTitle.Size = new System.Drawing.Size(120, 29);
            this.listTitle.TabIndex = 11;
            // 
            // txtInitial
            // 
            this.txtInitial.Location = new System.Drawing.Point(574, 141);
            this.txtInitial.Name = "txtInitial";
            this.txtInitial.Size = new System.Drawing.Size(219, 31);
            this.txtInitial.TabIndex = 12;
            this.txtInitial.TextChanged += new System.EventHandler(this.txtInitial_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(432, 217);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(361, 31);
            this.txtLastName.TabIndex = 13;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(432, 293);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(361, 31);
            this.txtFirstName.TabIndex = 14;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // formRegisteration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 1195);
            this.Controls.Add(this.groupPersonalDetails);
            this.Controls.Add(this.groupLoginDetails);
            this.Controls.Add(this.label1);
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
    }
}