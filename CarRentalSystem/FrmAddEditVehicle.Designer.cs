namespace CarRentalSystem
{
    partial class FrmAddEditVehicle
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
            this.lblMake = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblVin = new System.Windows.Forms.Label();
            this.txtVin = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblLicensePlateNum = new System.Windows.Forms.Label();
            this.txtLicensePlateNum = new System.Windows.Forms.TextBox();
            this.btnAddSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(94, 120);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(34, 13);
            this.lblMake.TabIndex = 0;
            this.lblMake.Text = "Make";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(251, 117);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(221, 20);
            this.txtMake.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(222, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(310, 27);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Manage Vehicle Listing";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(94, 170);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 0;
            this.lblModel.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(251, 167);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(221, 20);
            this.txtModel.TabIndex = 1;
            // 
            // lblVin
            // 
            this.lblVin.AutoSize = true;
            this.lblVin.Location = new System.Drawing.Point(94, 227);
            this.lblVin.Name = "lblVin";
            this.lblVin.Size = new System.Drawing.Size(22, 13);
            this.lblVin.TabIndex = 0;
            this.lblVin.Text = "Vin";
            // 
            // txtVin
            // 
            this.txtVin.Location = new System.Drawing.Point(251, 224);
            this.txtVin.Name = "txtVin";
            this.txtVin.Size = new System.Drawing.Size(221, 20);
            this.txtVin.TabIndex = 1;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(94, 288);
            this.lblYear.Name = "lblYear";
            this.lblYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(251, 285);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(221, 20);
            this.txtYear.TabIndex = 1;
            // 
            // lblLicensePlateNum
            // 
            this.lblLicensePlateNum.AutoSize = true;
            this.lblLicensePlateNum.Location = new System.Drawing.Point(94, 340);
            this.lblLicensePlateNum.Name = "lblLicensePlateNum";
            this.lblLicensePlateNum.Size = new System.Drawing.Size(111, 13);
            this.lblLicensePlateNum.TabIndex = 0;
            this.lblLicensePlateNum.Text = "License Plate Number";
            // 
            // txtLicensePlateNum
            // 
            this.txtLicensePlateNum.Location = new System.Drawing.Point(251, 337);
            this.txtLicensePlateNum.Name = "txtLicensePlateNum";
            this.txtLicensePlateNum.Size = new System.Drawing.Size(221, 20);
            this.txtLicensePlateNum.TabIndex = 1;
            // 
            // btnAddSave
            // 
            this.btnAddSave.Location = new System.Drawing.Point(94, 403);
            this.btnAddSave.Name = "btnAddSave";
            this.btnAddSave.Size = new System.Drawing.Size(123, 35);
            this.btnAddSave.TabIndex = 3;
            this.btnAddSave.Text = "Add";
            this.btnAddSave.UseVisualStyleBackColor = true;
            this.btnAddSave.Click += new System.EventHandler(this.btnAddSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(349, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmAddEditVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtLicensePlateNum);
            this.Controls.Add(this.lblLicensePlateNum);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtVin);
            this.Controls.Add(this.lblVin);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.lblMake);
            this.Name = "FrmAddEditVehicle";
            this.Text = "addEditVehicle";
            this.Load += new System.EventHandler(this.FrmAddEditVehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblVin;
        private System.Windows.Forms.TextBox txtVin;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblLicensePlateNum;
        private System.Windows.Forms.TextBox txtLicensePlateNum;
        private System.Windows.Forms.Button btnAddSave;
        private System.Windows.Forms.Button btnCancel;
    }
}