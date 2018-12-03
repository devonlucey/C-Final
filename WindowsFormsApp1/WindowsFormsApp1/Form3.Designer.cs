namespace WindowsFormsApp1
{
    partial class formPersonalHealthRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPersonalHealthRecord));
            this.picProfileImage = new System.Windows.Forms.PictureBox();
            this.groupLoginDetails = new System.Windows.Forms.GroupBox();
            this.groupPassword = new System.Windows.Forms.GroupBox();
            this.linkCancel = new System.Windows.Forms.LinkLabel();
            this.linkChangePassword = new System.Windows.Forms.LinkLabel();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.linkChangeProfilePicture = new System.Windows.Forms.LinkLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslPersonalDetails = new System.Windows.Forms.ToolStripButton();
            this.tslMedicalDetails = new System.Windows.Forms.ToolStripButton();
            this.tslComprehensivePersonalRecord = new System.Windows.Forms.ToolStripButton();
            this.tslEmergencyPersonalHealthRecord = new System.Windows.Forms.ToolStripButton();
            this.groupPersonalDetails = new System.Windows.Forms.GroupBox();
            this.linkPersonalCancel = new System.Windows.Forms.LinkLabel();
            this.linkPersonalSave = new System.Windows.Forms.LinkLabel();
            this.linkPersonalEdit = new System.Windows.Forms.LinkLabel();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.dateDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtInitials = new System.Windows.Forms.TextBox();
            this.lblInitials = new System.Windows.Forms.Label();
            this.listTitle = new System.Windows.Forms.ListBox();
            this.txtIdentityNumber = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIdentityNumber = new System.Windows.Forms.Label();
            this.groupContactDetails = new System.Windows.Forms.GroupBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblHomeTelephone = new System.Windows.Forms.Label();
            this.lblMobileTelephone = new System.Windows.Forms.Label();
            this.lblWorkTelephone = new System.Windows.Forms.Label();
            this.lblFaxNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txHomeTelephone = new System.Windows.Forms.TextBox();
            this.txtMobileTelephone = new System.Windows.Forms.TextBox();
            this.txtWorkTelephone = new System.Windows.Forms.TextBox();
            this.txtFaxNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.linkContactDetailsCancel = new System.Windows.Forms.LinkLabel();
            this.linkContactDetailsSae = new System.Windows.Forms.LinkLabel();
            this.linkContactDetailsEdit = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileImage)).BeginInit();
            this.groupLoginDetails.SuspendLayout();
            this.groupPassword.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupPersonalDetails.SuspendLayout();
            this.groupContactDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // picProfileImage
            // 
            this.picProfileImage.Location = new System.Drawing.Point(12, 38);
            this.picProfileImage.Name = "picProfileImage";
            this.picProfileImage.Size = new System.Drawing.Size(122, 122);
            this.picProfileImage.TabIndex = 0;
            this.picProfileImage.TabStop = false;
            // 
            // groupLoginDetails
            // 
            this.groupLoginDetails.Controls.Add(this.groupPassword);
            this.groupLoginDetails.Controls.Add(this.txtUsername);
            this.groupLoginDetails.Controls.Add(this.lblUsername);
            this.groupLoginDetails.Location = new System.Drawing.Point(146, 38);
            this.groupLoginDetails.Name = "groupLoginDetails";
            this.groupLoginDetails.Size = new System.Drawing.Size(324, 184);
            this.groupLoginDetails.TabIndex = 1;
            this.groupLoginDetails.TabStop = false;
            this.groupLoginDetails.Text = "Login Details";
            // 
            // groupPassword
            // 
            this.groupPassword.Controls.Add(this.linkCancel);
            this.groupPassword.Controls.Add(this.linkChangePassword);
            this.groupPassword.Controls.Add(this.txtOldPassword);
            this.groupPassword.Controls.Add(this.txtConfirmPassword);
            this.groupPassword.Controls.Add(this.txtNewPassword);
            this.groupPassword.Controls.Add(this.lblConfirmNewPassword);
            this.groupPassword.Controls.Add(this.lblNewPassword);
            this.groupPassword.Controls.Add(this.lblOldPassword);
            this.groupPassword.Location = new System.Drawing.Point(10, 46);
            this.groupPassword.Name = "groupPassword";
            this.groupPassword.Size = new System.Drawing.Size(308, 131);
            this.groupPassword.TabIndex = 2;
            this.groupPassword.TabStop = false;
            this.groupPassword.Text = "Change Password";
            // 
            // linkCancel
            // 
            this.linkCancel.AutoSize = true;
            this.linkCancel.Location = new System.Drawing.Point(252, 107);
            this.linkCancel.Name = "linkCancel";
            this.linkCancel.Size = new System.Drawing.Size(40, 13);
            this.linkCancel.TabIndex = 7;
            this.linkCancel.TabStop = true;
            this.linkCancel.Text = "Cancel";
            // 
            // linkChangePassword
            // 
            this.linkChangePassword.AutoSize = true;
            this.linkChangePassword.Location = new System.Drawing.Point(152, 108);
            this.linkChangePassword.Name = "linkChangePassword";
            this.linkChangePassword.Size = new System.Drawing.Size(93, 13);
            this.linkChangePassword.TabIndex = 6;
            this.linkChangePassword.TabStop = true;
            this.linkChangePassword.Text = "Change Password";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(152, 19);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(150, 20);
            this.txtOldPassword.TabIndex = 5;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(152, 81);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(150, 20);
            this.txtConfirmPassword.TabIndex = 4;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(152, 46);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(150, 20);
            this.txtNewPassword.TabIndex = 3;
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(17, 85);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(116, 13);
            this.lblConfirmNewPassword.TabIndex = 2;
            this.lblConfirmNewPassword.Text = "Confirm New Password";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(17, 50);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(78, 13);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "New Password";
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Location = new System.Drawing.Point(17, 23);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(72, 13);
            this.lblOldPassword.TabIndex = 0;
            this.lblOldPassword.Text = "Old Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(88, 17);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(214, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(7, 21);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // linkChangeProfilePicture
            // 
            this.linkChangeProfilePicture.AutoSize = true;
            this.linkChangeProfilePicture.Location = new System.Drawing.Point(17, 169);
            this.linkChangeProfilePicture.Name = "linkChangeProfilePicture";
            this.linkChangeProfilePicture.Size = new System.Drawing.Size(112, 13);
            this.linkChangeProfilePicture.TabIndex = 2;
            this.linkChangeProfilePicture.TabStop = true;
            this.linkChangeProfilePicture.Text = "Change Profile Picture";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslPersonalDetails,
            this.tslMedicalDetails,
            this.tslComprehensivePersonalRecord,
            this.tslEmergencyPersonalHealthRecord});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1143, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslPersonalDetails
            // 
            this.tslPersonalDetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslPersonalDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslPersonalDetails.Name = "tslPersonalDetails";
            this.tslPersonalDetails.Size = new System.Drawing.Size(94, 22);
            this.tslPersonalDetails.Text = "Personal Details";
            this.tslPersonalDetails.Click += new System.EventHandler(this.tslPersonalDetails_Click);
            // 
            // tslMedicalDetails
            // 
            this.tslMedicalDetails.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslMedicalDetails.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslMedicalDetails.Name = "tslMedicalDetails";
            this.tslMedicalDetails.Size = new System.Drawing.Size(91, 22);
            this.tslMedicalDetails.Text = "Medical Details";
            this.tslMedicalDetails.Click += new System.EventHandler(this.tslMedicalDetails_Click);
            // 
            // tslComprehensivePersonalRecord
            // 
            this.tslComprehensivePersonalRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslComprehensivePersonalRecord.Image = ((System.Drawing.Image)(resources.GetObject("tslComprehensivePersonalRecord.Image")));
            this.tslComprehensivePersonalRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslComprehensivePersonalRecord.Name = "tslComprehensivePersonalRecord";
            this.tslComprehensivePersonalRecord.Size = new System.Drawing.Size(182, 22);
            this.tslComprehensivePersonalRecord.Text = "Comprehensive Personal Record";
            this.tslComprehensivePersonalRecord.Click += new System.EventHandler(this.tslComprehensivePersonalRecord_Click);
            // 
            // tslEmergencyPersonalHealthRecord
            // 
            this.tslEmergencyPersonalHealthRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslEmergencyPersonalHealthRecord.Image = ((System.Drawing.Image)(resources.GetObject("tslEmergencyPersonalHealthRecord.Image")));
            this.tslEmergencyPersonalHealthRecord.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tslEmergencyPersonalHealthRecord.Name = "tslEmergencyPersonalHealthRecord";
            this.tslEmergencyPersonalHealthRecord.Size = new System.Drawing.Size(196, 22);
            this.tslEmergencyPersonalHealthRecord.Text = "Emergency Personal Health Record";
            this.tslEmergencyPersonalHealthRecord.Click += new System.EventHandler(this.tslEmergencyPersonalHealthRecord_Click);
            // 
            // groupPersonalDetails
            // 
            this.groupPersonalDetails.Controls.Add(this.linkPersonalCancel);
            this.groupPersonalDetails.Controls.Add(this.linkPersonalSave);
            this.groupPersonalDetails.Controls.Add(this.linkPersonalEdit);
            this.groupPersonalDetails.Controls.Add(this.radioFemale);
            this.groupPersonalDetails.Controls.Add(this.radioMale);
            this.groupPersonalDetails.Controls.Add(this.lblGender);
            this.groupPersonalDetails.Controls.Add(this.dateDateOfBirth);
            this.groupPersonalDetails.Controls.Add(this.txtFirstName);
            this.groupPersonalDetails.Controls.Add(this.txtLastName);
            this.groupPersonalDetails.Controls.Add(this.txtInitials);
            this.groupPersonalDetails.Controls.Add(this.lblInitials);
            this.groupPersonalDetails.Controls.Add(this.listTitle);
            this.groupPersonalDetails.Controls.Add(this.txtIdentityNumber);
            this.groupPersonalDetails.Controls.Add(this.lblDateOfBirth);
            this.groupPersonalDetails.Controls.Add(this.lblFirstName);
            this.groupPersonalDetails.Controls.Add(this.lblLastName);
            this.groupPersonalDetails.Controls.Add(this.lblTitle);
            this.groupPersonalDetails.Controls.Add(this.lblIdentityNumber);
            this.groupPersonalDetails.Location = new System.Drawing.Point(12, 244);
            this.groupPersonalDetails.Name = "groupPersonalDetails";
            this.groupPersonalDetails.Size = new System.Drawing.Size(458, 255);
            this.groupPersonalDetails.TabIndex = 4;
            this.groupPersonalDetails.TabStop = false;
            this.groupPersonalDetails.Text = "Personal Details";
            // 
            // linkPersonalCancel
            // 
            this.linkPersonalCancel.AutoSize = true;
            this.linkPersonalCancel.Location = new System.Drawing.Point(376, 192);
            this.linkPersonalCancel.Name = "linkPersonalCancel";
            this.linkPersonalCancel.Size = new System.Drawing.Size(40, 13);
            this.linkPersonalCancel.TabIndex = 17;
            this.linkPersonalCancel.TabStop = true;
            this.linkPersonalCancel.Text = "Cancel";
            // 
            // linkPersonalSave
            // 
            this.linkPersonalSave.AutoSize = true;
            this.linkPersonalSave.Location = new System.Drawing.Point(338, 192);
            this.linkPersonalSave.Name = "linkPersonalSave";
            this.linkPersonalSave.Size = new System.Drawing.Size(32, 13);
            this.linkPersonalSave.TabIndex = 16;
            this.linkPersonalSave.TabStop = true;
            this.linkPersonalSave.Text = "Save";
            // 
            // linkPersonalEdit
            // 
            this.linkPersonalEdit.AutoSize = true;
            this.linkPersonalEdit.Location = new System.Drawing.Point(307, 192);
            this.linkPersonalEdit.Name = "linkPersonalEdit";
            this.linkPersonalEdit.Size = new System.Drawing.Size(25, 13);
            this.linkPersonalEdit.TabIndex = 15;
            this.linkPersonalEdit.TabStop = true;
            this.linkPersonalEdit.Text = "Edit";
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(341, 91);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(59, 17);
            this.radioFemale.TabIndex = 14;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(341, 57);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(48, 17);
            this.radioMale.TabIndex = 13;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(347, 27);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender";
            // 
            // dateDateOfBirth
            // 
            this.dateDateOfBirth.Location = new System.Drawing.Point(95, 158);
            this.dateDateOfBirth.Name = "dateDateOfBirth";
            this.dateDateOfBirth.Size = new System.Drawing.Size(207, 20);
            this.dateDateOfBirth.TabIndex = 11;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(96, 127);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(207, 20);
            this.txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(95, 96);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(207, 20);
            this.txtLastName.TabIndex = 9;
            // 
            // txtInitials
            // 
            this.txtInitials.Location = new System.Drawing.Point(203, 57);
            this.txtInitials.Name = "txtInitials";
            this.txtInitials.ReadOnly = true;
            this.txtInitials.Size = new System.Drawing.Size(100, 20);
            this.txtInitials.TabIndex = 8;
            // 
            // lblInitials
            // 
            this.lblInitials.AutoSize = true;
            this.lblInitials.Location = new System.Drawing.Point(160, 64);
            this.lblInitials.Name = "lblInitials";
            this.lblInitials.Size = new System.Drawing.Size(36, 13);
            this.lblInitials.TabIndex = 7;
            this.lblInitials.Text = "Initials";
            // 
            // listTitle
            // 
            this.listTitle.AllowDrop = true;
            this.listTitle.FormattingEnabled = true;
            this.listTitle.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Dr."});
            this.listTitle.Location = new System.Drawing.Point(95, 61);
            this.listTitle.Name = "listTitle";
            this.listTitle.Size = new System.Drawing.Size(47, 17);
            this.listTitle.TabIndex = 6;
            // 
            // txtIdentityNumber
            // 
            this.txtIdentityNumber.Location = new System.Drawing.Point(95, 27);
            this.txtIdentityNumber.Name = "txtIdentityNumber";
            this.txtIdentityNumber.ReadOnly = true;
            this.txtIdentityNumber.Size = new System.Drawing.Size(207, 20);
            this.txtIdentityNumber.TabIndex = 5;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(8, 158);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(66, 13);
            this.lblDateOfBirth.TabIndex = 4;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(11, 127);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(11, 96);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(11, 65);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // lblIdentityNumber
            // 
            this.lblIdentityNumber.AutoSize = true;
            this.lblIdentityNumber.Location = new System.Drawing.Point(8, 34);
            this.lblIdentityNumber.Name = "lblIdentityNumber";
            this.lblIdentityNumber.Size = new System.Drawing.Size(81, 13);
            this.lblIdentityNumber.TabIndex = 0;
            this.lblIdentityNumber.Text = "Identity Number";
            // 
            // groupContactDetails
            // 
            this.groupContactDetails.Controls.Add(this.linkContactDetailsCancel);
            this.groupContactDetails.Controls.Add(this.linkContactDetailsSae);
            this.groupContactDetails.Controls.Add(this.linkContactDetailsEdit);
            this.groupContactDetails.Controls.Add(this.txtPostalCode);
            this.groupContactDetails.Controls.Add(this.lblPostalCode);
            this.groupContactDetails.Controls.Add(this.txtEmail);
            this.groupContactDetails.Controls.Add(this.txtFaxNumber);
            this.groupContactDetails.Controls.Add(this.txtWorkTelephone);
            this.groupContactDetails.Controls.Add(this.txtMobileTelephone);
            this.groupContactDetails.Controls.Add(this.txHomeTelephone);
            this.groupContactDetails.Controls.Add(this.txtCity);
            this.groupContactDetails.Controls.Add(this.txtSuburb);
            this.groupContactDetails.Controls.Add(this.txtAddress);
            this.groupContactDetails.Controls.Add(this.lblEmail);
            this.groupContactDetails.Controls.Add(this.lblFaxNumber);
            this.groupContactDetails.Controls.Add(this.lblWorkTelephone);
            this.groupContactDetails.Controls.Add(this.lblMobileTelephone);
            this.groupContactDetails.Controls.Add(this.lblHomeTelephone);
            this.groupContactDetails.Controls.Add(this.lblCity);
            this.groupContactDetails.Controls.Add(this.lblSuburb);
            this.groupContactDetails.Controls.Add(this.lblAddress);
            this.groupContactDetails.Location = new System.Drawing.Point(12, 506);
            this.groupContactDetails.Name = "groupContactDetails";
            this.groupContactDetails.Size = new System.Drawing.Size(458, 296);
            this.groupContactDetails.TabIndex = 5;
            this.groupContactDetails.TabStop = false;
            this.groupContactDetails.Text = "Contact Details";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(7, 30);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(7, 82);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(41, 13);
            this.lblSuburb.TabIndex = 1;
            this.lblSuburb.Text = "Suburb";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(7, 106);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City";
            // 
            // lblHomeTelephone
            // 
            this.lblHomeTelephone.AutoSize = true;
            this.lblHomeTelephone.Location = new System.Drawing.Point(5, 135);
            this.lblHomeTelephone.Name = "lblHomeTelephone";
            this.lblHomeTelephone.Size = new System.Drawing.Size(89, 13);
            this.lblHomeTelephone.TabIndex = 3;
            this.lblHomeTelephone.Text = "Home Telephone";
            // 
            // lblMobileTelephone
            // 
            this.lblMobileTelephone.AutoSize = true;
            this.lblMobileTelephone.Location = new System.Drawing.Point(7, 166);
            this.lblMobileTelephone.Name = "lblMobileTelephone";
            this.lblMobileTelephone.Size = new System.Drawing.Size(89, 13);
            this.lblMobileTelephone.TabIndex = 4;
            this.lblMobileTelephone.Text = "MobileTelephone";
            // 
            // lblWorkTelephone
            // 
            this.lblWorkTelephone.AutoSize = true;
            this.lblWorkTelephone.Location = new System.Drawing.Point(8, 200);
            this.lblWorkTelephone.Name = "lblWorkTelephone";
            this.lblWorkTelephone.Size = new System.Drawing.Size(87, 13);
            this.lblWorkTelephone.TabIndex = 5;
            this.lblWorkTelephone.Text = "Work Telephone";
            // 
            // lblFaxNumber
            // 
            this.lblFaxNumber.AutoSize = true;
            this.lblFaxNumber.Location = new System.Drawing.Point(7, 229);
            this.lblFaxNumber.Name = "lblFaxNumber";
            this.lblFaxNumber.Size = new System.Drawing.Size(64, 13);
            this.lblFaxNumber.TabIndex = 6;
            this.lblFaxNumber.Text = "Fax Number";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(11, 260);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(116, 30);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(186, 40);
            this.txtAddress.TabIndex = 8;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(116, 82);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(186, 20);
            this.txtSuburb.TabIndex = 9;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(117, 106);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(186, 20);
            this.txtCity.TabIndex = 10;
            // 
            // txHomeTelephone
            // 
            this.txHomeTelephone.Location = new System.Drawing.Point(116, 135);
            this.txHomeTelephone.Name = "txHomeTelephone";
            this.txHomeTelephone.Size = new System.Drawing.Size(186, 20);
            this.txHomeTelephone.TabIndex = 11;
            // 
            // txtMobileTelephone
            // 
            this.txtMobileTelephone.Location = new System.Drawing.Point(117, 166);
            this.txtMobileTelephone.Name = "txtMobileTelephone";
            this.txtMobileTelephone.Size = new System.Drawing.Size(186, 20);
            this.txtMobileTelephone.TabIndex = 12;
            // 
            // txtWorkTelephone
            // 
            this.txtWorkTelephone.Location = new System.Drawing.Point(117, 200);
            this.txtWorkTelephone.Name = "txtWorkTelephone";
            this.txtWorkTelephone.Size = new System.Drawing.Size(186, 20);
            this.txtWorkTelephone.TabIndex = 13;
            // 
            // txtFaxNumber
            // 
            this.txtFaxNumber.Location = new System.Drawing.Point(116, 229);
            this.txtFaxNumber.Name = "txtFaxNumber";
            this.txtFaxNumber.Size = new System.Drawing.Size(186, 20);
            this.txtFaxNumber.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(117, 260);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(324, 106);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(64, 13);
            this.lblPostalCode.TabIndex = 16;
            this.lblPostalCode.Text = "Postal Code";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(327, 135);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 17;
            // 
            // linkContactDetailsCancel
            // 
            this.linkContactDetailsCancel.AutoSize = true;
            this.linkContactDetailsCancel.Location = new System.Drawing.Point(387, 236);
            this.linkContactDetailsCancel.Name = "linkContactDetailsCancel";
            this.linkContactDetailsCancel.Size = new System.Drawing.Size(40, 13);
            this.linkContactDetailsCancel.TabIndex = 20;
            this.linkContactDetailsCancel.TabStop = true;
            this.linkContactDetailsCancel.Text = "Cancel";
            // 
            // linkContactDetailsSae
            // 
            this.linkContactDetailsSae.AutoSize = true;
            this.linkContactDetailsSae.Location = new System.Drawing.Point(349, 236);
            this.linkContactDetailsSae.Name = "linkContactDetailsSae";
            this.linkContactDetailsSae.Size = new System.Drawing.Size(32, 13);
            this.linkContactDetailsSae.TabIndex = 19;
            this.linkContactDetailsSae.TabStop = true;
            this.linkContactDetailsSae.Text = "Save";
            // 
            // linkContactDetailsEdit
            // 
            this.linkContactDetailsEdit.AutoSize = true;
            this.linkContactDetailsEdit.Location = new System.Drawing.Point(318, 236);
            this.linkContactDetailsEdit.Name = "linkContactDetailsEdit";
            this.linkContactDetailsEdit.Size = new System.Drawing.Size(25, 13);
            this.linkContactDetailsEdit.TabIndex = 18;
            this.linkContactDetailsEdit.TabStop = true;
            this.linkContactDetailsEdit.Text = "Edit";
            // 
            // formPersonalHealthRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 814);
            this.Controls.Add(this.groupContactDetails);
            this.Controls.Add(this.groupPersonalDetails);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.linkChangeProfilePicture);
            this.Controls.Add(this.groupLoginDetails);
            this.Controls.Add(this.picProfileImage);
            this.Name = "formPersonalHealthRecord";
            ((System.ComponentModel.ISupportInitialize)(this.picProfileImage)).EndInit();
            this.groupLoginDetails.ResumeLayout(false);
            this.groupLoginDetails.PerformLayout();
            this.groupPassword.ResumeLayout(false);
            this.groupPassword.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupPersonalDetails.ResumeLayout(false);
            this.groupPersonalDetails.PerformLayout();
            this.groupContactDetails.ResumeLayout(false);
            this.groupContactDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picProfileImage;
        private System.Windows.Forms.GroupBox groupLoginDetails;
        private System.Windows.Forms.GroupBox groupPassword;
        private System.Windows.Forms.LinkLabel linkCancel;
        private System.Windows.Forms.LinkLabel linkChangePassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.LinkLabel linkChangeProfilePicture;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tslPersonalDetails;
        private System.Windows.Forms.ToolStripButton tslMedicalDetails;
        private System.Windows.Forms.ToolStripButton tslComprehensivePersonalRecord;
        private System.Windows.Forms.ToolStripButton tslEmergencyPersonalHealthRecord;
        private System.Windows.Forms.GroupBox groupPersonalDetails;
        private System.Windows.Forms.TextBox txtInitials;
        private System.Windows.Forms.Label lblInitials;
        private System.Windows.Forms.ListBox listTitle;
        private System.Windows.Forms.TextBox txtIdentityNumber;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIdentityNumber;
        private System.Windows.Forms.DateTimePicker dateDateOfBirth;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.LinkLabel linkPersonalCancel;
        private System.Windows.Forms.LinkLabel linkPersonalSave;
        private System.Windows.Forms.LinkLabel linkPersonalEdit;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.GroupBox groupContactDetails;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFaxNumber;
        private System.Windows.Forms.TextBox txtWorkTelephone;
        private System.Windows.Forms.TextBox txtMobileTelephone;
        private System.Windows.Forms.TextBox txHomeTelephone;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFaxNumber;
        private System.Windows.Forms.Label lblWorkTelephone;
        private System.Windows.Forms.Label lblMobileTelephone;
        private System.Windows.Forms.Label lblHomeTelephone;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.LinkLabel linkContactDetailsCancel;
        private System.Windows.Forms.LinkLabel linkContactDetailsSae;
        private System.Windows.Forms.LinkLabel linkContactDetailsEdit;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblPostalCode;
    }
}