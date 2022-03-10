using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopFirst
{
    public partial class FrmPayroll : Form
    {
        public FrmPayroll()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text == "")
            {
                MessageBox.Show("Enter First Name");
                txtFirstName.Focus();
            }else if(txtLastName.Text == "")
            {
                MessageBox.Show("EnterLast Name");
                txtLastName.Focus();
            }else if(cboPosition.Text == "Select Position")
            {
                MessageBox.Show("Select a Position from the list");
                cboPosition.Focus();
            }else if(txtHours.Text == "")
            {
                MessageBox.Show("Enter Hours");
                txtHours.Focus();
            }
            else if((optOvertimeYes.Checked)&&(txtOvertimeHours.Text == "")){
                MessageBox.Show("Enter Overtime Hours");
                txtOvertimeHours.Focus();
            }else
            {
                //Calculate
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string fullName = firstName + " " + lastName;

                float hours = float.Parse(txtHours.Text);
                float overtimeHours = 0.0f;

                if (optOvertimeYes.Checked)
                {
                    overtimeHours = float.Parse(txtOvertimeHours.Text);
                }

                float nht = 0.03f, nis = 0.025f, paye = 0.28735f, nhtAmount, nisAmount, payeAmount;

                string position  = cboPosition.Text;

                lblPotition.Text += " " + position;



                MessageBox.Show("Payroll generated");
            }
            

            
        }

        
    }
}
