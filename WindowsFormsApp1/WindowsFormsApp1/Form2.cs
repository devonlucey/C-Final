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
    public partial class formRegisteration : Form
    {
        public formRegisteration()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdNumber_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateDob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtInitial_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            PATIENT_TBL pateint = new PATIENT_TBL() {
                PATIENT_ID = txtIdNumber.Text,
                LAST_NAME = txtLastName.Text,
                FIRST_NAME = txtFirstName.Text,
                ADDRESS_STREET = string.Empty,
                ADDRESS_CITY = string.Empty,
                ADDRESS_STATE = string.Empty,
                ADDRESS_ZIP = string.Empty,
                PHONE_HOME = string.Empty,
                PHONE_MOBILE = string.Empty,
                PRIMARY_ID = string.Empty
            };

            pchr42563Entities entities = new pchr42563Entities();
            entities.PATIENT_TBL.Add(pateint);
            entities.SaveChanges();

            MessageBox.Show("Registration Complete");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formRegisteration_Load(object sender, EventArgs e)
        {

        }

        private void fillIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pATIENT_TBLTableAdapter.FillID(this.pchr42563DataSet.PATIENT_TBL);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
