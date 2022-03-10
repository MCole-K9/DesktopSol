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
    public partial class FrmManageVehecleListing : Form
    {
        private readonly CarRentalSystemDBEntities1 _db;
        public FrmManageVehecleListing()
        {
            InitializeComponent();
            _db = new CarRentalSystemDBEntities1();
        }

        private void lblCarRentalSystem_Click(object sender, EventArgs e)
        {

        }
        public void PopulateGrid()
        {
            var cars = _db.typeofcars.Select(q => new { q.ID, q.Make, q.Model, q.Vin, q.LicensePlateNumber, q.Year }).ToList();
            dgvVehicleListing.DataSource = cars;
        }

        private void FrmManageVehecleListing_Load(object sender, EventArgs e)
        {
            PopulateGrid();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            FrmAddEditVehicle frmAddEditVehicle = new FrmAddEditVehicle(this);
            frmAddEditVehicle.MdiParent = this.MdiParent;
            frmAddEditVehicle.Show();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            try
            {
                //Get id of selected Car
                int Id = (int)dgvVehicleListing.SelectedRows[0].Cells["ID"].Value;

                //Query db for id 
                var car = _db.typeofcars.FirstOrDefault(q => q.ID == Id);

                //pass car to edit form through contructor

                FrmAddEditVehicle frmAddEditVehicle = new FrmAddEditVehicle(car, this);
                frmAddEditVehicle.MdiParent = this.MdiParent;
                frmAddEditVehicle.Show();
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Please select car before editing");
            }

        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                //Get id of selected car
                int Id = (int)dgvVehicleListing.SelectedRows[0].Cells["ID"].Value;
                //Query db for id 
                var car = _db.typeofcars.FirstOrDefault(q => q.ID == Id);

                if (MessageBox.Show("Are you sure you want the delete the selected vehicle", "Delete Car",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _db.typeofcars.Remove(car);
                    _db.SaveChanges();

                   // dgvVehicleListing.Refresh();
                    PopulateGrid();//Refreshes Grid
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
