namespace FinalProject
{
    partial class frmAddPrescription
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
            this.cboDrug = new System.Windows.Forms.ComboBox();
            this.txtRefill = new System.Windows.Forms.TextBox();
            this.cboPhysicianID = new System.Windows.Forms.ComboBox();
            this.cboPatientID = new System.Windows.Forms.ComboBox();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblPhysician = new System.Windows.Forms.Label();
            this.lblDrug = new System.Windows.Forms.Label();
            this.lblRefills = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboDrug
            // 
            this.cboDrug.FormattingEnabled = true;
            this.cboDrug.Location = new System.Drawing.Point(170, 157);
            this.cboDrug.Name = "cboDrug";
            this.cboDrug.Size = new System.Drawing.Size(309, 21);
            this.cboDrug.TabIndex = 0;
            // 
            // txtRefill
            // 
            this.txtRefill.Location = new System.Drawing.Point(170, 184);
            this.txtRefill.Name = "txtRefill";
            this.txtRefill.Size = new System.Drawing.Size(100, 20);
            this.txtRefill.TabIndex = 2;
            // 
            // cboPhysicianID
            // 
            this.cboPhysicianID.FormattingEnabled = true;
            this.cboPhysicianID.Location = new System.Drawing.Point(170, 124);
            this.cboPhysicianID.Name = "cboPhysicianID";
            this.cboPhysicianID.Size = new System.Drawing.Size(309, 21);
            this.cboPhysicianID.TabIndex = 3;
            this.cboPhysicianID.SelectedIndexChanged += new System.EventHandler(this.cboPhysicianID_SelectedIndexChanged);
            // 
            // cboPatientID
            // 
            this.cboPatientID.FormattingEnabled = true;
            this.cboPatientID.Location = new System.Drawing.Point(170, 92);
            this.cboPatientID.Name = "cboPatientID";
            this.cboPatientID.Size = new System.Drawing.Size(309, 21);
            this.cboPatientID.TabIndex = 4;
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(121, 100);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(43, 13);
            this.lblPatient.TabIndex = 5;
            this.lblPatient.Text = "Patient:";
            // 
            // lblPhysician
            // 
            this.lblPhysician.AutoSize = true;
            this.lblPhysician.Location = new System.Drawing.Point(109, 132);
            this.lblPhysician.Name = "lblPhysician";
            this.lblPhysician.Size = new System.Drawing.Size(55, 13);
            this.lblPhysician.TabIndex = 6;
            this.lblPhysician.Text = "Physician:";
            // 
            // lblDrug
            // 
            this.lblDrug.AutoSize = true;
            this.lblDrug.Location = new System.Drawing.Point(131, 165);
            this.lblDrug.Name = "lblDrug";
            this.lblDrug.Size = new System.Drawing.Size(33, 13);
            this.lblDrug.TabIndex = 7;
            this.lblDrug.Text = "Drug:";
            // 
            // lblRefills
            // 
            this.lblRefills.AutoSize = true;
            this.lblRefills.Location = new System.Drawing.Point(92, 191);
            this.lblRefills.Name = "lblRefills";
            this.lblRefills.Size = new System.Drawing.Size(72, 13);
            this.lblRefills.TabIndex = 8;
            this.lblRefills.Text = "Refill Amount:";
            this.lblRefills.Click += new System.EventHandler(this.lblRefills_Click);
            // 
            // frmAddPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRefills);
            this.Controls.Add(this.lblDrug);
            this.Controls.Add(this.lblPhysician);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.cboPatientID);
            this.Controls.Add(this.cboPhysicianID);
            this.Controls.Add(this.txtRefill);
            this.Controls.Add(this.cboDrug);
            this.Name = "frmAddPrescription";
            this.Text = "frmAddPrescription";
            this.Load += new System.EventHandler(this.frmAddPrescription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDrug;
        private System.Windows.Forms.TextBox txtRefill;
        private System.Windows.Forms.ComboBox cboPhysicianID;
        private System.Windows.Forms.ComboBox cboPatientID;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblPhysician;
        private System.Windows.Forms.Label lblDrug;
        private System.Windows.Forms.Label lblRefills;
    }
}