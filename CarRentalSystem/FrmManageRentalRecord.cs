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
    public partial class FrmManageRentalRecord : Form
    {
        private readonly CarRentalSystemDBEntities1 _db;
        public FrmManageRentalRecord()
        {
            InitializeComponent();
            _db = new CarRentalSystemDBEntities1(); ;
        }
        public void PopolateGrid()
        {
            try
            {
                var carRentals = _db.CarRentals.Select(q => new { q.ID, q.Customer_Name, Car = q.typeofcar.Make + " " + q.typeofcar.Model, q.Cost, q.Date_Rented, q.Date_Returned }).ToList();

                dgvRentalRecord.DataSource = carRentals;

                dgvRentalRecord.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            FrmAddCarRentalRecord frmAddCarRentalRecord = new FrmAddCarRentalRecord(this);
            frmAddCarRentalRecord.MdiParent = this.MdiParent;
            frmAddCarRentalRecord.Show();
        }

        private void FrmManageRentalRecord_Load(object sender, EventArgs e)
        {
            PopolateGrid();
        }

        private void btnEditRecord_Click(object sender, EventArgs e)
        {
            try
            {

                int carRentalID = (int)dgvRentalRecord.SelectedRows[0].Cells["ID"].Value;

                var carRental = _db.CarRentals.FirstOrDefault(q => q.ID == carRentalID);

                FrmAddCarRentalRecord frmAddCarRentalRecord = new FrmAddCarRentalRecord(carRental, this);
                frmAddCarRentalRecord.MdiParent = this.MdiParent;
                frmAddCarRentalRecord.Show();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                int carRentalID = (int)dgvRentalRecord.SelectedRows[0].Cells["ID"].Value;

                var carRental = _db.CarRentals.FirstOrDefault(q => q.ID == carRentalID);

                if (MessageBox.Show("Are you sure you want the delete the selected Record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _db.CarRentals.Remove(carRental);
                    _db.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
    
               
        }
    }
}
