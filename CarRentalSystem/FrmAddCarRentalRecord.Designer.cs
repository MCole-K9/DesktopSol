namespace CarRentalSystem
{
    partial class FrmAddCarRentalRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCarRentalSystem = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblDateRented = new System.Windows.Forms.Label();
            this.lblTypeOfCar = new System.Windows.Forms.Label();
            this.lblDateReturned = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.dtpDateRented = new System.Windows.Forms.DateTimePicker();
            this.dtpDateReturned = new System.Windows.Forms.DateTimePicker();
            this.cboTypeOfCar = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCarRentalSystem
            // 
            this.lblCarRentalSystem.AutoSize = true;
            this.lblCarRentalSystem.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarRentalSystem.Location = new System.Drawing.Point(274, 9);
            this.lblCarRentalSystem.Name = "lblCarRentalSystem";
            this.lblCarRentalSystem.Size = new System.Drawing.Size(249, 27);
            this.lblCarRentalSystem.TabIndex = 0;
            this.lblCarRentalSystem.Text = "Car Rental System";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(70, 130);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblDateRented
            // 
            this.lblDateRented.AutoSize = true;
            this.lblDateRented.Location = new System.Drawing.Point(70, 203);
            this.lblDateRented.Name = "lblDateRented";
            this.lblDateRented.Size = new System.Drawing.Size(68, 13);
            this.lblDateRented.TabIndex = 1;
            this.lblDateRented.Text = "Date Rented";
            // 
            // lblTypeOfCar
            // 
            this.lblTypeOfCar.AutoSize = true;
            this.lblTypeOfCar.Location = new System.Drawing.Point(70, 276);
            this.lblTypeOfCar.Name = "lblTypeOfCar";
            this.lblTypeOfCar.Size = new System.Drawing.Size(62, 13);
            this.lblTypeOfCar.TabIndex = 1;
            this.lblTypeOfCar.Text = "Type of Car";
            // 
            // lblDateReturned
            // 
            this.lblDateReturned.AutoSize = true;
            this.lblDateReturned.Location = new System.Drawing.Point(489, 203);
            this.lblDateReturned.Name = "lblDateReturned";
            this.lblDateReturned.Size = new System.Drawing.Size(77, 13);
            this.lblDateReturned.TabIndex = 1;
            this.lblDateReturned.Text = "Date Returned";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(73, 163);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(300, 20);
            this.txtCustomerName.TabIndex = 2;
            // 
            // dtpDateRented
            // 
            this.dtpDateRented.Location = new System.Drawing.Point(73, 230);
            this.dtpDateRented.Name = "dtpDateRented";
            this.dtpDateRented.Size = new System.Drawing.Size(200, 20);
            this.dtpDateRented.TabIndex = 3;
            // 
            // dtpDateReturned
            // 
            this.dtpDateReturned.Location = new System.Drawing.Point(492, 230);
            this.dtpDateReturned.Name = "dtpDateReturned";
            this.dtpDateReturned.Size = new System.Drawing.Size(200, 20);
            this.dtpDateReturned.TabIndex = 3;
            this.dtpDateReturned.Value = new System.DateTime(2022, 2, 21, 0, 12, 22, 0);
            // 
            // cboTypeOfCar
            // 
            this.cboTypeOfCar.FormattingEnabled = true;
            this.cboTypeOfCar.Location = new System.Drawing.Point(73, 304);
            this.cboTypeOfCar.Name = "cboTypeOfCar";
            this.cboTypeOfCar.Size = new System.Drawing.Size(300, 21);
            this.cboTypeOfCar.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(492, 304);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(139, 44);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(73, 346);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 6;
            this.lblCost.Text = "Cost";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(76, 374);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(197, 20);
            this.txtCost.TabIndex = 7;
            this.txtCost.Text = "0";
            // 
            // FrmAddCarRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cboTypeOfCar);
            this.Controls.Add(this.dtpDateReturned);
            this.Controls.Add(this.dtpDateRented);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblDateReturned);
            this.Controls.Add(this.lblTypeOfCar);
            this.Controls.Add(this.lblDateRented);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCarRentalSystem);
            this.Name = "FrmAddCarRentalRecord";
            this.Text = "Car Rental System";
            this.Load += new System.EventHandler(this.FrmCarRentalSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarRentalSystem;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblDateRented;
        private System.Windows.Forms.Label lblTypeOfCar;
        private System.Windows.Forms.Label lblDateReturned;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DateTimePicker dtpDateRented;
        private System.Windows.Forms.DateTimePicker dtpDateReturned;
        private System.Windows.Forms.ComboBox cboTypeOfCar;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
    }
}

