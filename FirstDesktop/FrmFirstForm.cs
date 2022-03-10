using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cool_App
{
    public partial class FrmFisrtForm : Form
    {
        public FrmFisrtForm()
        {
            InitializeComponent();
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {

            string firstName, lastName, fullName;

            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;

            fullName = firstName + " " + lastName;

            txtFullName.Text = fullName;

            MessageBox.Show("Full Name Generated");
        }
    }
}
