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
    public partial class FrmPayroll : Form
    {
        private List<Employee> Employees = new List<Employee>();

        public void AddEmployee(string name, string position, float hours, float rate, float overtimeHours, string nht, string nis, string paye, string netPay)
        {
            this.Employees.Add(new Employee{
                Name = name,
                Position = position,
                Hours = hours,
                Rate = rate,
                OverTimeHours = overtimeHours,
                NHT = nht,
                NIS = nis,
                PAYE = paye,
                NetPay = netPay
            });

        }
        public FrmPayroll()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Enter First Name");
                txtFirstName.Focus();
            }
            else if (txtLastName.Text == "")
            {
                MessageBox.Show("EnterLast Name");
                txtLastName.Focus();
            }
            else if (cboPosition.Text == "Select Position")
            {
                MessageBox.Show("Select a Position from the list");
                cboPosition.Focus();
            }
            else if (txtHours.Text == "")
            {
                MessageBox.Show("Enter Hours");
                txtHours.Focus();
            }
            else if ((optOvertimeYes.Checked) && (txtOvertimeHours.Text == ""))
            {
                MessageBox.Show("Enter Overtime Hours");
                txtOvertimeHours.Focus();
            }
            else
            {
                //Calculate
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string fullName = firstName + " " + lastName;

                float rate = float.Parse(txtRate.Text);
                float hours = float.Parse(txtHours.Text);
                float overtimeHours = 0.0f;
                float otRate = rate + (rate / 2);


                if (optOvertimeYes.Checked)
                {
                    overtimeHours = float.Parse(txtOvertimeHours.Text);
                }

                float nht = 0.03f, nis = 0.025f, paye = 0.28735f, nhtAmount, nisAmount, payeAmount, netPay, salary;


                salary = rate * hours;
                nhtAmount = nht * salary;
                nisAmount = nis * salary;
                payeAmount = paye * salary;
                netPay = (salary - nisAmount - payeAmount - nhtAmount) + overtimeHours * otRate;



                string position = cboPosition.Text;

                lblRate.Text += " " + rate.ToString();

                lblPotition.Text += " " + position;

                lblFullName.Text += " " + fullName;

                lblHours.Text += " " + hours.ToString();

                lblOvertimeHours.Text += " " + overtimeHours.ToString();

                lblNetPay.Text += "  $" + netPay.ToString();

                lblNHT.Text += "  $" + nhtAmount.ToString();

                lblNIS.Text += "  $" + nisAmount.ToString();

                lblPAYE.Text += "  $" + payeAmount.ToString();

                AddEmployee(fullName, position, hours, rate, overtimeHours, "$" + nhtAmount.ToString(), "$" + nisAmount.ToString(), "$" + payeAmount.ToString(), "$" + netPay.ToString());

                dataGridView1.Rows.Clear();
                foreach (Employee emp in Employees)
                {
                    dataGridView1.Rows.Add(emp.Name, emp.Position, emp.Rate, emp.Hours, emp.OverTimeHours, emp.NHT, emp.NIS, emp.PAYE, emp.NetPay);
                }
                //dataGridView1.DataSource = this.Employees;

                MessageBox.Show("Payroll generated");
            }
        }

        private void lblLastNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblRate.Text = "Rate:" ;

            lblPotition.Text = "Position:";

            lblFullName.Text = "Full Name:" ;

            lblHours.Text = "Hours:";

            lblOvertimeHours.Text = "OverTime-Hours:";

            lblNetPay.Text = "Net Pay:";

            lblNHT.Text = "NHT:" ;

            lblNIS.Text = "NIS:" ;

            lblPAYE.Text = "PAYE:" ;

            lblRate.Text = "Rate:";

            cboPosition.Text = "Select Position:";

            txtFirstName.Text = "";
            txtLastName.Text = "";

            txtHours.Text = "";
            txtRate.Text = "";
            
            txtOvertimeHours.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
