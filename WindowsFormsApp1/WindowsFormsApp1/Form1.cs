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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        // Disable Login on start until requirements have been met.
        private void formLogin_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        // validation allows password that allows login only if password textbox is not empty
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text==string.Empty)
            {
                btnLogin.Enabled = false;
            }
            else
            {
                btnLogin.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Open the Registration form and hide the login form.
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form form2 = new formRegisteration();
            //this.Hide();
            form2.Show();
            form2.Focus();
        }

        // Open the Personal Health Record form and hide the login form.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form form3 = new formPersonalHealthRecord();
            //this.Hide();
            form3.Show();
            form3.Focus();
        }
    }
}
