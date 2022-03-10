using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibMain;

namespace Cool_App
{
    public partial class FrmPerson : Form
    {
        public FrmPerson()
        {
            InitializeComponent();
        }

        private void FrmPerson_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Person person = new Person();

            person.setFirstName(txtFirstName.Text);
            person.setLastName(txtLastName.Text);
           // person.setAge(int.Parse(txtAge.Text));
            person.setAddress(txtAddress.Text);
            person.setDob(dtpDob.Value);

            MessageBox.Show(person.ToString());
        }
    }
}
