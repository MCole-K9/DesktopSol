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
    public partial class FrmAddCarRentalRecord : Form
    {
        private readonly CarRentalSystemDBEntities1 _db;
        private bool inEditMode;
        private int selectedCarID; // For the combobox 
        private int selectedCarRentalID;
        private FrmManageRentalRecord _frmManageRentalRecord;

        public FrmAddCarRentalRecord(FrmManageRentalRecord frmManageRentalRecord = null)
        {
            InitializeComponent();
            _db = new CarRentalSystemDBEntities1();
            inEditMode = false;
            _frmManageRentalRecord = frmManageRentalRecord;
        }
        public FrmAddCarRentalRecord(CarRental carRental, FrmManageRentalRecord frmManageRentalRecord = null)
        {
            InitializeComponent();
            _db = new CarRentalSystemDBEntities1();

            inEditMode = true;
            _frmManageRentalRecord = frmManageRentalRecord;
            populateFields(carRental);
            selectedCarRentalID = carRental.ID;


        }

        private void populateFields(CarRental carRental)
        {
            txtCustomerName.Text = carRental.Customer_Name;
            dtpDateRented.Value = (DateTime)carRental.Date_Rented;
            dtpDateReturned.Value = (DateTime)carRental.Date_Returned;
            selectedCarID = (int)carRental.Car_Type;
            txtCost.Text = carRental.Cost.ToString();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string customerName = txtCustomerName.Text;
                DateTime dateRented = dtpDateRented.Value;
                DateTime dateReturned = dtpDateReturned.Value;
                string carType = cboTypeOfCar.Text;
                double carCost = double.Parse(txtCost.Text);


                if (customerName == "")
                {
                    MessageBox.Show("Please Enter Customer Name");
                    txtCustomerName.Focus();

                }
                else if (dateRented > dateReturned)
                {
                    MessageBox.Show("Date Rented Cannot be grater than Date Returned");
                    dtpDateRented.Focus();

                }
                else if (carType == "")
                {
                    MessageBox.Show("Please Select Car Type");
                    cboTypeOfCar.Focus();
                }
                else
                {
                    var carRental = new CarRental();

                    if (inEditMode)
                    {
                       carRental = _db.CarRentals.FirstOrDefault(q => q.ID == selectedCarRentalID);
                    }
           
                    carRental.Customer_Name = customerName;
                    carRental.Date_Rented = dateRented;
                    carRental.Date_Returned = dateReturned;
                    carRental.Car_Type = int.Parse(cboTypeOfCar.SelectedValue.ToString());
                    carRental.Cost = (float)carCost;

                    if(!inEditMode)
                        _db.CarRentals.Add(carRental);

                    _db.SaveChanges();
                    MessageBox.Show("Operation Successful");
                    _frmManageRentalRecord.PopolateGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

        }

        private void FrmCarRentalSystem_Load(object sender, EventArgs e)
        {
            try
            {
                btnSubmit.Text = inEditMode ? "Save Changes" : "Submit";
                var cars = _db.typeofcars.Select(q => new { q.ID, Name = q.Make + " " + q.Model }).ToList();
                cboTypeOfCar.DisplayMember = "Name";
                cboTypeOfCar.ValueMember = "ID";
                cboTypeOfCar.DataSource = cars;

                if (inEditMode)
                {
                    //Searches the index the car would appear in the combobox using the id of the desired car
                    int index = 0;
                    foreach (var car in cars)
                    {
                        if (car.ID == selectedCarID)
                        {
                            cboTypeOfCar.SelectedIndex = index;
                        }
                        index++;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }



        }


    }
}
