namespace DesktopFirst
{
    partial class FrmPayroll
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.labFirstNameLabel = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastNameLabel = new System.Windows.Forms.Label();
            this.lblPositionLabel = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.grpBxOvertime = new System.Windows.Forms.GroupBox();
            this.txtOvertimeHours = new System.Windows.Forms.TextBox();
            this.lblOvertimeHoursLabel = new System.Windows.Forms.Label();
            this.optOvertimeNo = new System.Windows.Forms.RadioButton();
            this.optOvertimeYes = new System.Windows.Forms.RadioButton();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.lblHoursLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.lblPAYE = new System.Windows.Forms.Label();
            this.lblNIS = new System.Windows.Forms.Label();
            this.lblNHT = new System.Windows.Forms.Label();
            this.lblOvertimeHours = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblPotition = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.grpBxOvertime.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(148, 382);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(97, 33);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(106, 36);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(206, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // labFirstNameLabel
            // 
            this.labFirstNameLabel.AutoSize = true;
            this.labFirstNameLabel.Location = new System.Drawing.Point(47, 38);
            this.labFirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labFirstNameLabel.Name = "labFirstNameLabel";
            this.labFirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.labFirstNameLabel.TabIndex = 2;
            this.labFirstNameLabel.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(106, 69);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(206, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // lblLastNameLabel
            // 
            this.lblLastNameLabel.AutoSize = true;
            this.lblLastNameLabel.Location = new System.Drawing.Point(47, 72);
            this.lblLastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastNameLabel.Name = "lblLastNameLabel";
            this.lblLastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lblLastNameLabel.TabIndex = 2;
            this.lblLastNameLabel.Text = "Last Name";
            // 
            // lblPositionLabel
            // 
            this.lblPositionLabel.AutoSize = true;
            this.lblPositionLabel.Location = new System.Drawing.Point(52, 126);
            this.lblPositionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPositionLabel.Name = "lblPositionLabel";
            this.lblPositionLabel.Size = new System.Drawing.Size(44, 13);
            this.lblPositionLabel.TabIndex = 6;
            this.lblPositionLabel.Text = "Position";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(106, 183);
            this.txtHours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(206, 20);
            this.txtHours.TabIndex = 5;
            // 
            // grpBxOvertime
            // 
            this.grpBxOvertime.Controls.Add(this.txtOvertimeHours);
            this.grpBxOvertime.Controls.Add(this.lblOvertimeHoursLabel);
            this.grpBxOvertime.Controls.Add(this.optOvertimeNo);
            this.grpBxOvertime.Controls.Add(this.optOvertimeYes);
            this.grpBxOvertime.Location = new System.Drawing.Point(64, 236);
            this.grpBxOvertime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBxOvertime.Name = "grpBxOvertime";
            this.grpBxOvertime.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpBxOvertime.Size = new System.Drawing.Size(259, 106);
            this.grpBxOvertime.TabIndex = 7;
            this.grpBxOvertime.TabStop = false;
            this.grpBxOvertime.Text = "Overtime";
            // 
            // txtOvertimeHours
            // 
            this.txtOvertimeHours.Location = new System.Drawing.Point(153, 49);
            this.txtOvertimeHours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOvertimeHours.Name = "txtOvertimeHours";
            this.txtOvertimeHours.Size = new System.Drawing.Size(76, 20);
            this.txtOvertimeHours.TabIndex = 8;
            // 
            // lblOvertimeHoursLabel
            // 
            this.lblOvertimeHoursLabel.AutoSize = true;
            this.lblOvertimeHoursLabel.Location = new System.Drawing.Point(116, 54);
            this.lblOvertimeHoursLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOvertimeHoursLabel.Name = "lblOvertimeHoursLabel";
            this.lblOvertimeHoursLabel.Size = new System.Drawing.Size(35, 13);
            this.lblOvertimeHoursLabel.TabIndex = 7;
            this.lblOvertimeHoursLabel.Text = "Hours";
            // 
            // optOvertimeNo
            // 
            this.optOvertimeNo.AutoSize = true;
            this.optOvertimeNo.Location = new System.Drawing.Point(18, 66);
            this.optOvertimeNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optOvertimeNo.Name = "optOvertimeNo";
            this.optOvertimeNo.Size = new System.Drawing.Size(39, 17);
            this.optOvertimeNo.TabIndex = 6;
            this.optOvertimeNo.TabStop = true;
            this.optOvertimeNo.Text = "No";
            this.optOvertimeNo.UseVisualStyleBackColor = true;
            // 
            // optOvertimeYes
            // 
            this.optOvertimeYes.AutoSize = true;
            this.optOvertimeYes.Location = new System.Drawing.Point(18, 36);
            this.optOvertimeYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optOvertimeYes.Name = "optOvertimeYes";
            this.optOvertimeYes.Size = new System.Drawing.Size(43, 17);
            this.optOvertimeYes.TabIndex = 5;
            this.optOvertimeYes.TabStop = true;
            this.optOvertimeYes.Text = "Yes";
            this.optOvertimeYes.UseVisualStyleBackColor = true;
            // 
            // cboPosition
            // 
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Items.AddRange(new object[] {
            "Manager",
            "Supervisor",
            "Line Staff",
            "Contract Worker"});
            this.cboPosition.Location = new System.Drawing.Point(106, 124);
            this.cboPosition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(206, 21);
            this.cboPosition.TabIndex = 8;
            this.cboPosition.Text = "Select Position";
            // 
            // lblHoursLabel
            // 
            this.lblHoursLabel.AutoSize = true;
            this.lblHoursLabel.Location = new System.Drawing.Point(62, 185);
            this.lblHoursLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoursLabel.Name = "lblHoursLabel";
            this.lblHoursLabel.Size = new System.Drawing.Size(35, 13);
            this.lblHoursLabel.TabIndex = 9;
            this.lblHoursLabel.Text = "Hours";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lblNetPay);
            this.panel1.Controls.Add(this.lblPAYE);
            this.panel1.Controls.Add(this.lblNIS);
            this.panel1.Controls.Add(this.lblNHT);
            this.panel1.Controls.Add(this.lblOvertimeHours);
            this.panel1.Controls.Add(this.lblHours);
            this.panel1.Controls.Add(this.lblPotition);
            this.panel1.Controls.Add(this.lblFullName);
            this.panel1.Location = new System.Drawing.Point(362, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 316);
            this.panel1.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(125, 3);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 25);
            this.label14.TabIndex = 8;
            this.label14.Text = "Payslip";
//            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.Location = new System.Drawing.Point(20, 294);
            this.lblNetPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(48, 13);
            this.lblNetPay.TabIndex = 7;
            this.lblNetPay.Text = "Net Pay:";
            // 
            // lblPAYE
            // 
            this.lblPAYE.AutoSize = true;
            this.lblPAYE.Location = new System.Drawing.Point(20, 241);
            this.lblPAYE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPAYE.Name = "lblPAYE";
            this.lblPAYE.Size = new System.Drawing.Size(38, 13);
            this.lblPAYE.TabIndex = 6;
            this.lblPAYE.Text = "PAYE:";
            // 
            // lblNIS
            // 
            this.lblNIS.AutoSize = true;
            this.lblNIS.Location = new System.Drawing.Point(20, 214);
            this.lblNIS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNIS.Name = "lblNIS";
            this.lblNIS.Size = new System.Drawing.Size(28, 13);
            this.lblNIS.TabIndex = 5;
            this.lblNIS.Text = "NIS:";
            // 
            // lblNHT
            // 
            this.lblNHT.AutoSize = true;
            this.lblNHT.Location = new System.Drawing.Point(20, 188);
            this.lblNHT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNHT.Name = "lblNHT";
            this.lblNHT.Size = new System.Drawing.Size(33, 13);
            this.lblNHT.TabIndex = 4;
            this.lblNHT.Text = "NHT:";
            // 
            // lblOvertimeHours
            // 
            this.lblOvertimeHours.AutoSize = true;
            this.lblOvertimeHours.Location = new System.Drawing.Point(20, 148);
            this.lblOvertimeHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOvertimeHours.Name = "lblOvertimeHours";
            this.lblOvertimeHours.Size = new System.Drawing.Size(83, 13);
            this.lblOvertimeHours.TabIndex = 3;
            this.lblOvertimeHours.Text = "Overtime-Hours:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(20, 119);
            this.lblHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(38, 13);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "Hours:";
            // 
            // lblPotition
            // 
            this.lblPotition.AutoSize = true;
            this.lblPotition.Location = new System.Drawing.Point(20, 67);
            this.lblPotition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPotition.Name = "lblPotition";
            this.lblPotition.Size = new System.Drawing.Size(50, 13);
            this.lblPotition.TabIndex = 1;
            this.lblPotition.Text = "Position: ";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(17, 39);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(57, 13);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name:";
            // 
            // FrmPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHoursLabel);
            this.Controls.Add(this.cboPosition);
            this.Controls.Add(this.grpBxOvertime);
            this.Controls.Add(this.lblPositionLabel);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.lblLastNameLabel);
            this.Controls.Add(this.labFirstNameLabel);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnCalculate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPayroll";
            this.Text = "Payroll";
            this.grpBxOvertime.ResumeLayout(false);
            this.grpBxOvertime.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label labFirstNameLabel;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastNameLabel;
        private System.Windows.Forms.Label lblPositionLabel;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.GroupBox grpBxOvertime;
        private System.Windows.Forms.TextBox txtOvertimeHours;
        private System.Windows.Forms.Label lblOvertimeHoursLabel;
        private System.Windows.Forms.RadioButton optOvertimeNo;
        private System.Windows.Forms.RadioButton optOvertimeYes;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.Label lblHoursLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.Label lblPAYE;
        private System.Windows.Forms.Label lblNIS;
        private System.Windows.Forms.Label lblNHT;
        private System.Windows.Forms.Label lblOvertimeHours;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblPotition;
        private System.Windows.Forms.Label lblFullName;
    }
}