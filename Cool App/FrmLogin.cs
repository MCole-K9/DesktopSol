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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if(tbUserName.Text == "")
            {
                MessageBox.Show("Please Enter Username");
                tbUserName.Focus();

            }else if(tbPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password");
                tbPassword.Focus();

            }else if((tbUserName.Text == "admin" ) && (tbPassword.Text == "admin"))
            {
                MessageBox.Show("Login Succesful");
                FrmMDI frmMDI = new FrmMDI();
                frmMDI.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Incorrect Login Info", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Warning );

                tbUserName.Text = String.Empty;
                tbPassword.Text = String.Empty;
                tbUserName.Focus();

            }


        }
    }
}
