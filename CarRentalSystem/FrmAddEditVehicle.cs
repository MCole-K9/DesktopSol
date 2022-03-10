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
    public partial class FrmAddEditVehicle : Form
    {
        private readonly CarRentalSystemDBEntities1 _db;
        private bool inEditMode; //Flag to indicate that that we are editing a vehicle
        private int CarId; // ID of car to be edited
        private FrmManageVehecleListing _frmManageVehecleListing;
        public FrmAddEditVehicle(FrmManageVehecleListing frmManageVehecleListing = null)
        {
            InitializeComponent();
            _db = new CarRentalSystemDBEntities1();
            inEditMode = false;

            _frmManageVehecleListing = frmManageVehecleListing;
        }
        public FrmAddEditVehicle(typeofcar car, FrmManageVehecleListing frmManageVehecleListing = null)
        {
            InitializeComponent();
            _db = new CarRentalSystemDBEntities1();
            inEditMode = true;
            CarId = car.ID;
            PopulateFields(car);
            _frmManageVehecleListing = frmManageVehecleListing;
        }

        private void PopulateFields(typeofcar car)
        {
            txtMake.Text = car.Make;
            txtModel.Text = car.Model;
            txtVin.Text = car.Vin;
            txtYear.Text = car.Year.ToString();
            txtLicensePlateNum.Text = car.LicensePlateNumber;
        }
        private void ClearFields()
        {
            txtMake.Text = String.Empty;
            txtModel.Text = String.Empty;
            txtVin.Text = String.Empty;
            txtYear.Text = String.Empty;
            txtLicensePlateNum.Text = String.Empty;
        }

        private void FrmAddEditVehicle_Load(object sender, EventArgs e)
        {
            lblTitle.Text = inEditMode ? "Edit Vehicle" : "Add Vehicle";
            btnAddSave.Text = inEditMode ? "Save Chances" : "Add Vehicle";
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            //Add Validations
            try
            {
                // All fields are made manditory, reconsider for the case of editing
                if(txtMake.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Car Make");
                    txtMake.Focus();
                }
                else if (txtModel.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Car Make");
                    txtModel.Focus();
                }
                else if (txtVin.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Car Vin Number");
                    txtVin.Focus();
                }
                else if (txtYear.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Car Year");
                    txtYear.Focus();
                }
                else if (txtLicensePlateNum.Text == String.Empty)
                {
                    MessageBox.Show("Please Enter Car License Plate Number");
                    txtLicensePlateNum.Focus();
                }

                typeofcar car = new typeofcar();


                if (inEditMode)
                {
                    car = _db.typeofcars.FirstOrDefault(q => q.ID == CarId);
                }

                car.Make = txtMake.Text;
                car.Model = txtModel.Text;
                car.Vin = txtVin.Text;
                car.Year = int.Parse(txtYear.Text);
                car.LicensePlateNumber = txtLicensePlateNum.Text;

                if(!inEditMode)
                    _db.typeofcars.Add(car);
                
                _db.SaveChanges();
                MessageBox.Show("Operation Complete");
                _frmManageVehecleListing.PopulateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            
        }
    }
}
