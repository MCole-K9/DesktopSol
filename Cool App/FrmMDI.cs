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
    public partial class FrmMDI : Form
    {
        public FrmMDI()
        {
            InitializeComponent();
        }

        private void FrmMDI_Load(object sender, EventArgs e)
        {
            FrmNotePad frmNotePad = new FrmNotePad();
            frmNotePad.MdiParent = this;
            frmNotePad.Show();
        }

        private void coverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConverter frmConverter = new FrmConverter();
            frmConverter.MdiParent = this;
            frmConverter.Show();
        }

        private void personToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPerson person = new FrmPerson();
            person.MdiParent = this;
            person.Show();
        }

        private void payrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPayroll frmPayroll = new FrmPayroll();
            frmPayroll.MdiParent = this;
            frmPayroll.Show();
        }
    }
}
