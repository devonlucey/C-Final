using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class formPersonalHealthRecord : Form
    {
        public formPersonalHealthRecord()
        {
            InitializeComponent();
        }

        private void tslPersonalDetails_Click(object sender, EventArgs e)
        {

        }

        private void tslMedicalDetails_Click(object sender, EventArgs e)
        {

        }

        private void tslComprehensivePersonalRecord_Click(object sender, EventArgs e)
        {

        }

        private void tslEmergencyPersonalHealthRecord_Click(object sender, EventArgs e)
        {

        }

        private void formPersonalHealthRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pchr42563DataSet.PRIMARY_CARE_TBL' table. You can move, or remove it, as needed.
            this.pRIMARY_CARE_TBLTableAdapter.Fill(this.pchr42563DataSet.PRIMARY_CARE_TBL);
            // TODO: This line of code loads data into the 'pchr42563DataSet.PATIENT_TBL' table. You can move, or remove it, as needed.
            // this.pATIENT_TBLTableAdapter.Fill(this.pchr42563DataSet.PATIENT_TBL);

        }

        //Event Handlers for all of Form 3

        //Personal Details
        private void txtIdentityNumber_TextChanged(object sender, EventArgs e)
        {
            string IdentityNumber = null;
            this.Text = IdentityNumber;
        }

        private void txtInitials_TextChanged(object sender, EventArgs e)
        {
            string Initials = null;
            this.Text = Initials;

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            string LastName = null;
            this.Text = LastName;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            string FirstName = null;
            this.Text = FirstName;
        }

        private void dateDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            string DOB = null;
            this.Text = DOB;
        }

        //Contact Details
        private void txtContactDetailsAddress_TextChanged(object sender, EventArgs e)
        {
            string ContactDetailsAddress = null;
            this.Text = ContactDetailsAddress;
        }

        private void txtContactDetailsSuburb_TextChanged(object sender, EventArgs e)
        {
            string ContactDetailsSuburb = null;
            this.Text = ContactDetailsSuburb;
        }

        private void txtContactDetailsCity_TextChanged(object sender, EventArgs e)
        {
            string ContactDetailsCity = null;
            this.Text = ContactDetailsCity;
        }

        private void txContactDetailsHomeTelephone_TextChanged(object sender, EventArgs e)
        {
            string ContactDetailsHomePhone = null;
            this.Text = ContactDetailsHomePhone;
        }

        private void txtContactDetailsPostalCode_TextChanged(object sender, EventArgs e)
        {
            string ContactDetailsPostalCode = null;
            this.Text = ContactDetailsPostalCode;
        }

        private void txtContactDetailsMobileTelephone_TextChanged(object sender, EventArgs e)
        {
            string ContactDetailsMobilePhone = null;
            this.Text = ContactDetailsMobilePhone;

        }

        private void txtContactDetailsWorkTelephone_TextChanged(object sender, EventArgs e)
        {
            string ContactDetailsWorkTelephone = null;
            this.Text = ContactDetailsWorkTelephone;

        }

        private void txtContactDetailsFaxNumber_TextChanged(object sender, EventArgs e)
        {
            string ContactDetailsFax = null;
            this.Text = ContactDetailsFax;
        }

        private void txtContactDetailsEmail_TextChanged(object sender, EventArgs e)
        {
            string ContactDetailsEmail = null;
            this.Text = ContactDetailsEmail;
        }

        //Emergency Contact Details
        private void txtEmergenctContactDetailsAddress_TextChanged(object sender, EventArgs e)
        {
            string EmergencyContactAddress = null;
            this.Text = EmergencyContactAddress;
        }

        private void txtEmergencyContactDetailsSuburb_TextChanged(object sender, EventArgs e)
        {
            string EmergencyContactSuburb = null;
            this.Text = EmergencyContactSuburb;
        }

        private void txtEmergencyContactDetailsCity_TextChanged(object sender, EventArgs e)
        {
            string EmergencyContactCity = null;
            this.Text = EmergencyContactCity;
        }

        private void txtEmergencyContactDetailsHomeTelephone_TextChanged(object sender, EventArgs e)
        {
            string EmergencyContactHomePhone = null;
            this.Text = EmergencyContactHomePhone;
        }

        private void txtEmergencyDetailsMobileTelephone_TextChanged(object sender, EventArgs e)
        {
            string EmergencyContactMobilePhone = null;
            this.Text = EmergencyContactMobilePhone;
        }

        private void txtEmergencyContactDetailsWorkTelephone_TextChanged(object sender, EventArgs e)
        {
            string EmergencyContactWorkPhone = null;
            this.Text = EmergencyContactWorkPhone;
        }

        private void txtEmergencyContactDetailsFaxNumber_TextChanged(object sender, EventArgs e)
        {
            string EmergencyContactFax = null;
            this.Text = EmergencyContactFax;
        }

        private void txtEmergencyContactDetailsEmail_TextChanged(object sender, EventArgs e)
        {
            string EmergencyContactEmail = null;
            this.Text = EmergencyContactEmail;
        }

        private void txtEmergencyContactDetailsPostalCode_TextChanged(object sender, EventArgs e)
        {
            string EmergencyContactPostalCode = null;
            this.Text = EmergencyContactPostalCode;
        }

        //Primary Care Provider Details
        private void txtPrimaryCareProviderDetailsFullName_TextChanged(object sender, EventArgs e)
        {
            string PrimaryCareFullName = null;
            this.Text = PrimaryCareFullName;
        }

        private void txtPrimaryCareProviderDetailsSpecialty_TextChanged(object sender, EventArgs e)
        {
            string PrimaryCareSpecialty = null;
            this.Text = PrimaryCareSpecialty;
        }

        private void txtPrimaryCareProviderDetailsMobileTelephone_TextChanged(object sender, EventArgs e)
        {
            string PrimaryCareMobilePhone = null;
            this.Text = PrimaryCareMobilePhone;
        }

        private void txtPrimaryCareProviderDetailsWorkTelephone_TextChanged(object sender, EventArgs e)
        {
            string PrimaryCareWorkPhone = null;
            this.Text = PrimaryCareWorkPhone;
        }

        private void txtPrimaryCareProviderDetailsFaxNumber_TextChanged(object sender, EventArgs e)
        {
            string PrimaryCareFax = null;
            this.Text = PrimaryCareFax;
        }

        private void txtPrimaryCareProviderDetailsEmail_TextChanged(object sender, EventArgs e)
        {
            string PrimaryCareEmail = null;
            this.Text = PrimaryCareEmail;
        }

        //Health Insurace Details
        private void txtHealthInsuranceDetailsInsuranceNumber_TextChanged(object sender, EventArgs e)
        {
            string HealthInsuranceInsuranceNumber = null;
            this.Text = HealthInsuranceInsuranceNumber;
        }

        private void txtHealthInsuranceDetailsInsurancePlan_TextChanged(object sender, EventArgs e)
        {
            string HealthInsuranceInsurancePlan = null;
            this.Text = HealthInsuranceInsurancePlan;
        }

        private void txtHealthInsuranceDetailsInsurer_TextChanged(object sender, EventArgs e)
        {
            string HealthInsuranceInsurer = null;
            this.Text = HealthInsuranceInsurer;
        }

        //Unlock and lock text boxes.


        //Password Reset
        private void linkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtOldPassword.Text != null && txtNewPassword.Text != null && txtConfirmPassword.Text != null && txtNewPassword.Text == txtConfirmPassword.Text)
            {
                string newPassword = txtConfirmPassword.Text;
                MessageBox.Show("Password successfully updated.");
                txtOldPassword.Text = null;
                txtNewPassword.Text = null;
                txtConfirmPassword.Text = null;
            }
            else
            {
                MessageBox.Show("Passwords do not match");
            }
        }

        private void linkCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtOldPassword.Text = null;
            txtNewPassword.Text = null;
            txtConfirmPassword.Text = null;
            MessageBox.Show("Password Change Cleared");
        }


        //Personal Data
        private void linkPersonalEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtIdentityNumber.ReadOnly = false;
            txtInitials.ReadOnly = false;
            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;

            linkPersonalCancel.Enabled = true;
            linkPersonalSave.Enabled = true;
        }

        private void linkPersonalSave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkPersonalCancel.Enabled = false;
            linkPersonalSave.Enabled = false;
            MessageBox.Show("Changes have been saved");
        }

        private void linkPersonalCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtIdentityNumber.Text = null;
            txtInitials.Text = null;
            txtFirstName.Text = null;
            txtLastName.Text = null;

            txtIdentityNumber.ReadOnly = true;
            txtInitials.ReadOnly = true;
            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;

            linkPersonalCancel.Enabled = false;
            linkPersonalSave.Enabled = false;

            MessageBox.Show("Changes Cancelled.");
        }


        //ContactDetails Unlock and Save

        private void linkContactDetailsEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtContactDetailsAddress.ReadOnly = false;
            txtContactDetailsCity.ReadOnly = false;
            txtContactDetailsEmail.ReadOnly = false;
            txtContactDetailsFaxNumber.ReadOnly = false;
            txtContactDetailsMobileTelephone.ReadOnly = false;
            txtContactDetailsPostalCode.ReadOnly = false;
            txtContactDetailsSuburb.ReadOnly = false;
            txtContactDetailsWorkTelephone.ReadOnly = false;

            linkContactDetailsCancel.Enabled = true;
            linkContactDetailsSae.Enabled = true;
        }

        private void linkContactDetailsSae_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtContactDetailsAddress.ReadOnly = true;
            txtContactDetailsCity.ReadOnly = true;
            txtContactDetailsEmail.ReadOnly = true;
            txtContactDetailsFaxNumber.ReadOnly = true;
            txtContactDetailsMobileTelephone.ReadOnly = true;
            txtContactDetailsPostalCode.ReadOnly = true;
            txtContactDetailsSuburb.ReadOnly = true;
            txtContactDetailsWorkTelephone.ReadOnly = true;

            linkContactDetailsCancel.Enabled = false;
            linkContactDetailsSae.Enabled = false;

            MessageBox.Show("Changes have been saved");
        }

        private void linkContactDetailsCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtContactDetailsAddress.ReadOnly = true;
            txtContactDetailsCity.ReadOnly = true;
            txtContactDetailsEmail.ReadOnly = true;
            txtContactDetailsFaxNumber.ReadOnly = true;
            txtContactDetailsMobileTelephone.ReadOnly = true;
            txtContactDetailsPostalCode.ReadOnly = true;
            txtContactDetailsSuburb.ReadOnly = true;
            txtContactDetailsWorkTelephone.ReadOnly = true;

            linkContactDetailsCancel.Enabled = false;
            linkContactDetailsSae.Enabled = false;

            MessageBox.Show("Changes Cancelled.");
        }


        //Emergency Contact Details Edit/Save

        private void linkEmergencyContactDetailsEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtEmergencyContactDetailsAddress.ReadOnly = false;
            txtEmergencyContactDetailsCity.ReadOnly = false;
            txtEmergencyContactDetailsEmail.ReadOnly = false;
            txtEmergencyContactDetailsFaxNumber.ReadOnly = false;
            txtEmergencyContactDetailsMobileTelephone.ReadOnly = false;
            txtEmergencyContactDetailsPostalCode.ReadOnly = false;
            txtEmergencyContactDetailsSuburb.ReadOnly = false;
            txtEmergencyContactDetailsWorkTelephone.ReadOnly = false;
            txtEmergencyContactDetailsHomeTelephone.ReadOnly = false;
            txtNextOfKin.ReadOnly = false;
            txtRelationship.ReadOnly = false;

            linkEmergencyContactDetailsSave.Enabled = true;
            linkEmergencyContactDetailsCancel.Enabled = true;
        }

        private void linkEmergencyContactDetailsSave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtEmergencyContactDetailsAddress.Text = null;
            txtEmergencyContactDetailsCity.Text = null;
            txtEmergencyContactDetailsEmail.Text = null;
            txtEmergencyContactDetailsFaxNumber.Text = null;
            txtEmergencyContactDetailsMobileTelephone.Text = null;
            txtEmergencyContactDetailsPostalCode.Text = null;
            txtEmergencyContactDetailsSuburb.Text = null;
            txtEmergencyContactDetailsWorkTelephone.Text = null;
            txtEmergencyContactDetailsHomeTelephone.Text = null;
            txtNextOfKin.Text = null;
            txtRelationship.Text = null;

            txtEmergencyContactDetailsAddress.ReadOnly = true;
            txtEmergencyContactDetailsCity.ReadOnly = true;
            txtEmergencyContactDetailsEmail.ReadOnly = true;
            txtEmergencyContactDetailsFaxNumber.ReadOnly = true;
            txtEmergencyContactDetailsMobileTelephone.ReadOnly = true;
            txtEmergencyContactDetailsPostalCode.ReadOnly = true;
            txtEmergencyContactDetailsSuburb.ReadOnly = true;
            txtEmergencyContactDetailsWorkTelephone.ReadOnly = true;
            txtEmergencyContactDetailsHomeTelephone.ReadOnly = true;
            txtNextOfKin.ReadOnly = true;
            txtRelationship.ReadOnly = true;

            linkEmergencyContactDetailsSave.Enabled = false;
            linkEmergencyContactDetailsCancel.Enabled = false;

            MessageBox.Show("Changes Saved");
        }

        private void linkEmergencyContactDetailsCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtEmergencyContactDetailsAddress.Text = null;
            txtEmergencyContactDetailsCity.Text = null;
            txtEmergencyContactDetailsEmail.Text = null;
            txtEmergencyContactDetailsFaxNumber.Text = null;
            txtEmergencyContactDetailsMobileTelephone.Text = null;
            txtEmergencyContactDetailsPostalCode.Text = null;
            txtEmergencyContactDetailsSuburb.Text = null;
            txtEmergencyContactDetailsWorkTelephone.Text = null;
            txtEmergencyContactDetailsHomeTelephone.Text = null;
            txtNextOfKin.Text = null;
            txtRelationship.Text = null;

            txtEmergencyContactDetailsAddress.ReadOnly = true;
            txtEmergencyContactDetailsCity.ReadOnly = true;
            txtEmergencyContactDetailsEmail.ReadOnly = true;
            txtEmergencyContactDetailsFaxNumber.ReadOnly = true;
            txtEmergencyContactDetailsMobileTelephone.ReadOnly = true;
            txtEmergencyContactDetailsPostalCode.ReadOnly = true;
            txtEmergencyContactDetailsSuburb.ReadOnly = true;
            txtEmergencyContactDetailsWorkTelephone.ReadOnly = true;
            txtEmergencyContactDetailsHomeTelephone.ReadOnly = true;
            txtNextOfKin.ReadOnly = true;
            txtRelationship.ReadOnly = true;

            linkEmergencyContactDetailsSave.Enabled = false;
            linkEmergencyContactDetailsCancel.Enabled = false;

            MessageBox.Show("Changes Cancelled");
        }

        //Primary Care edit/save

        private void linkPrimaryCareProviderDetailsEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPrimaryCareProviderDetailsEmail.ReadOnly = false;
            txtPrimaryCareProviderDetailsFaxNumber.ReadOnly = false;
            txtPrimaryCareProviderDetailsFullName.ReadOnly = false;
            txtPrimaryCareProviderDetailsMobileTelephone.ReadOnly = false;
            txtPrimaryCareProviderDetailsSpecialty.ReadOnly = false;
            txtPrimaryCareProviderDetailsWorkTelephone.ReadOnly = false;

            linkPrimaryCareProviderDetailsSave.Enabled = true;
            linkPrimaryCareProviderDetailsCancel.Enabled = true;
        }

        private void linkPrimaryCareProviderDetailsSave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPrimaryCareProviderDetailsEmail.Text = null;
            txtPrimaryCareProviderDetailsFaxNumber.Text = null;
            txtPrimaryCareProviderDetailsFullName.Text = null;
            txtPrimaryCareProviderDetailsMobileTelephone.Text = null;
            txtPrimaryCareProviderDetailsSpecialty.Text = null;
            txtPrimaryCareProviderDetailsWorkTelephone.Text = null;

            txtPrimaryCareProviderDetailsEmail.ReadOnly = true;
            txtPrimaryCareProviderDetailsFaxNumber.ReadOnly = true;
            txtPrimaryCareProviderDetailsFullName.ReadOnly = true;
            txtPrimaryCareProviderDetailsMobileTelephone.ReadOnly = true;
            txtPrimaryCareProviderDetailsSpecialty.ReadOnly = true;
            txtPrimaryCareProviderDetailsWorkTelephone.ReadOnly = true;

            linkPrimaryCareProviderDetailsSave.Enabled = false;
            linkPrimaryCareProviderDetailsCancel.Enabled = false;

            MessageBox.Show("Changes have been saved");
        }

        private void linkPrimaryCareProviderDetailsCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtPrimaryCareProviderDetailsEmail.Text = null;
            txtPrimaryCareProviderDetailsFaxNumber.Text = null;
            txtPrimaryCareProviderDetailsFullName.Text = null;
            txtPrimaryCareProviderDetailsMobileTelephone.Text = null;
            txtPrimaryCareProviderDetailsSpecialty.Text = null;
            txtPrimaryCareProviderDetailsWorkTelephone.Text = null;

            txtPrimaryCareProviderDetailsEmail.ReadOnly = true;
            txtPrimaryCareProviderDetailsFaxNumber.ReadOnly = true;
            txtPrimaryCareProviderDetailsFullName.ReadOnly = true;
            txtPrimaryCareProviderDetailsMobileTelephone.ReadOnly = true;
            txtPrimaryCareProviderDetailsSpecialty.ReadOnly = true;
            txtPrimaryCareProviderDetailsWorkTelephone.ReadOnly = true;

            linkPrimaryCareProviderDetailsSave.Enabled = false;
            linkPrimaryCareProviderDetailsCancel.Enabled = false;

            MessageBox.Show("Changes Cancelled");
        }


        //Insurance Edit/Save

        private void linkInsuranceEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtHealthInsuranceDetailsInsuranceNumber.ReadOnly = false;
            txtHealthInsuranceDetailsInsurancePlan.ReadOnly = false;
            txtHealthInsuranceDetailsInsurer.ReadOnly = false;

            linkInsuranceCancel.Enabled = true;
            linkInsuranceSave.Enabled = true;
        }

        private void linkInsuranceSave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtHealthInsuranceDetailsInsuranceNumber.ReadOnly = true;
            txtHealthInsuranceDetailsInsurancePlan.ReadOnly = true;
            txtHealthInsuranceDetailsInsurer.ReadOnly = true;

            txtHealthInsuranceDetailsInsuranceNumber.Text = null;
            txtHealthInsuranceDetailsInsurancePlan.Text = null;
            txtHealthInsuranceDetailsInsurer.Text = null;

            linkInsuranceCancel.Enabled = false;
            linkInsuranceSave.Enabled = false;

            MessageBox.Show("Changes Saved");

        }

        private void linkInsuranceCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtHealthInsuranceDetailsInsuranceNumber.ReadOnly = true;
            txtHealthInsuranceDetailsInsurancePlan.ReadOnly = true;
            txtHealthInsuranceDetailsInsurer.ReadOnly = true;

            txtHealthInsuranceDetailsInsuranceNumber.Text = null;
            txtHealthInsuranceDetailsInsurancePlan.Text = null;
            txtHealthInsuranceDetailsInsurer.Text = null;

            linkInsuranceCancel.Enabled = false;
            linkInsuranceSave.Enabled = false;

            MessageBox.Show("Changes Cancelled");
        }
    }
}
