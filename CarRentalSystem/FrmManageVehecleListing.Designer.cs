namespace CarRentalSystem
{
    partial class FrmManageVehecleListing
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
            this.lblManageVehicleListing = new System.Windows.Forms.Label();
            this.dgvVehicleListing = new System.Windows.Forms.DataGridView();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnEditCar = new System.Windows.Forms.Button();
            this.btnDeleteCar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleListing)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManageVehicleListing
            // 
            this.lblManageVehicleListing.AutoSize = true;
            this.lblManageVehicleListing.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageVehicleListing.Location = new System.Drawing.Point(252, 33);
            this.lblManageVehicleListing.Name = "lblManageVehicleListing";
            this.lblManageVehicleListing.Size = new System.Drawing.Size(310, 27);
            this.lblManageVehicleListing.TabIndex = 1;
            this.lblManageVehicleListing.Text = "Manage Vehicle Listing";
            this.lblManageVehicleListing.Click += new System.EventHandler(this.lblCarRentalSystem_Click);
            // 
            // dgvVehicleListing
            // 
            this.dgvVehicleListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleListing.Location = new System.Drawing.Point(37, 74);
            this.dgvVehicleListing.Name = "dgvVehicleListing";
            this.dgvVehicleListing.Size = new System.Drawing.Size(736, 253);
            this.dgvVehicleListing.TabIndex = 2;
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(37, 389);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(132, 49);
            this.btnAddCar.TabIndex = 3;
            this.btnAddCar.Text = "Add Car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnEditCar
            // 
            this.btnEditCar.Location = new System.Drawing.Point(326, 389);
            this.btnEditCar.Name = "btnEditCar";
            this.btnEditCar.Size = new System.Drawing.Size(132, 49);
            this.btnEditCar.TabIndex = 3;
            this.btnEditCar.Text = "Edit Car";
            this.btnEditCar.UseVisualStyleBackColor = true;
            this.btnEditCar.Click += new System.EventHandler(this.btnEditCar_Click);
            // 
            // btnDeleteCar
            // 
            this.btnDeleteCar.Location = new System.Drawing.Point(641, 389);
            this.btnDeleteCar.Name = "btnDeleteCar";
            this.btnDeleteCar.Size = new System.Drawing.Size(132, 49);
            this.btnDeleteCar.TabIndex = 3;
            this.btnDeleteCar.Text = "Delete Car";
            this.btnDeleteCar.UseVisualStyleBackColor = true;
            this.btnDeleteCar.Click += new System.EventHandler(this.btnDeleteCar_Click);
            // 
            // FrmManageVehecleListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteCar);
            this.Controls.Add(this.btnEditCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.dgvVehicleListing);
            this.Controls.Add(this.lblManageVehicleListing);
            this.Name = "FrmManageVehecleListing";
            this.Text = "FrmManageVehecleListing";
            this.Load += new System.EventHandler(this.FrmManageVehecleListing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleListing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageVehicleListing;
        private System.Windows.Forms.DataGridView dgvVehicleListing;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnEditCar;
        private System.Windows.Forms.Button btnDeleteCar;
    }
}