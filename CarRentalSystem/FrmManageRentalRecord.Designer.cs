namespace CarRentalSystem
{
    partial class FrmManageRentalRecord
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
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.btnEditRecord = new System.Windows.Forms.Button();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.dgvRentalRecord = new System.Windows.Forms.DataGridView();
            this.lblManageRecord = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.Location = new System.Drawing.Point(636, 379);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(132, 49);
            this.btnDeleteRecord.TabIndex = 6;
            this.btnDeleteRecord.Text = "Delete Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = true;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // btnEditRecord
            // 
            this.btnEditRecord.Location = new System.Drawing.Point(321, 379);
            this.btnEditRecord.Name = "btnEditRecord";
            this.btnEditRecord.Size = new System.Drawing.Size(132, 49);
            this.btnEditRecord.TabIndex = 7;
            this.btnEditRecord.Text = "Edit Record";
            this.btnEditRecord.UseVisualStyleBackColor = true;
            this.btnEditRecord.Click += new System.EventHandler(this.btnEditRecord_Click);
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(32, 379);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(132, 49);
            this.btnAddRecord.TabIndex = 8;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // dgvRentalRecord
            // 
            this.dgvRentalRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentalRecord.Location = new System.Drawing.Point(32, 64);
            this.dgvRentalRecord.Name = "dgvRentalRecord";
            this.dgvRentalRecord.Size = new System.Drawing.Size(736, 253);
            this.dgvRentalRecord.TabIndex = 5;
            // 
            // lblManageRecord
            // 
            this.lblManageRecord.AutoSize = true;
            this.lblManageRecord.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageRecord.Location = new System.Drawing.Point(247, 23);
            this.lblManageRecord.Name = "lblManageRecord";
            this.lblManageRecord.Size = new System.Drawing.Size(303, 54);
            this.lblManageRecord.TabIndex = 4;
            this.lblManageRecord.Text = "Manage Rental Record\r\n\r\n";
            // 
            // FrmManageRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteRecord);
            this.Controls.Add(this.btnEditRecord);
            this.Controls.Add(this.btnAddRecord);
            this.Controls.Add(this.dgvRentalRecord);
            this.Controls.Add(this.lblManageRecord);
            this.Name = "FrmManageRentalRecord";
            this.Text = "FrmManageRentalRecord";
            this.Load += new System.EventHandler(this.FrmManageRentalRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Button btnEditRecord;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.DataGridView dgvRentalRecord;
        private System.Windows.Forms.Label lblManageRecord;
    }
}