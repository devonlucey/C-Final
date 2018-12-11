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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void tslPersonalDetails_Click(object sender, EventArgs e)
        {
            Form form3 = new formPersonalHealthRecord();
            this.Close();
            form3.Show();
            form3.Focus();
        }

        private void tslMedicalDetails_Click(object sender, EventArgs e)
        {
            Form form4 = new Form4();
            this.Close();
            form4.Show();
            form4.Focus();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }
    }
}
