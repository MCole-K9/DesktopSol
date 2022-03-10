using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class FrmMainWindow : Form
    {
        public FrmMainWindow()
        {
            InitializeComponent();
        }

        private void FrmMainWindow_Load(object sender, EventArgs e)
        {

        }

        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddCarRentalRecord frmAddCarRentalRecord = new FrmAddCarRentalRecord();
            frmAddCarRentalRecord.MdiParent = this;
            frmAddCarRentalRecord.Show();
        }

        private void manageVehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            bool isOpen = OpenForms.Any(q => q.Name == "FrmManageRentalRecord");
            if (!isOpen)
            {
                FrmManageVehecleListing frmManageVehecleListing = new FrmManageVehecleListing();
                frmManageVehecleListing.MdiParent = this;
                frmManageVehecleListing.Show();
            }
    
        }

        private void manageRentalRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OpenForms = Application.OpenForms.Cast<Form>();
            bool isOpen = OpenForms.Any(q => q.Name == "FrmManageRentalRecord");
            if (!isOpen)
            {
                FrmManageRentalRecord frmManageRentalRecord = new FrmManageRentalRecord();
                frmManageRentalRecord.MdiParent = this;
                frmManageRentalRecord.Show();
            }

            
        }
    }
}
