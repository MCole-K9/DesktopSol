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
    public partial class DesktopFirst : Form
    {
        public DesktopFirst()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if(txtValue.Text == "")
            {
                MessageBox.Show("Please Enter a value");
                txtValue.Focus();

            }
            else
            {
                float value = float.Parse(txtValue.Text);

                float result = value / 2.2f;

                txtResult.Text = result.ToString();
            }
        }
    }
}
