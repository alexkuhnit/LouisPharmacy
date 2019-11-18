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
            this.components = new System.ComponentModel.Container();
            this.cboDrug = new System.Windows.Forms.ComboBox();
            this.txtRefill = new System.Windows.Forms.TextBox();
            this.cboPhysicianID = new System.Windows.Forms.ComboBox();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblPhysician = new System.Windows.Forms.Label();
            this.lblDrug = new System.Windows.Forms.Label();
            this.lblRefills = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblAddPrescription = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dtpDatePrescribed = new System.Windows.Forms.DateTimePicker();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.EPV = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EPV)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDrug
            // 
            this.cboDrug.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboDrug.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDrug.FormattingEnabled = true;
            this.cboDrug.Location = new System.Drawing.Point(68, 210);
            this.cboDrug.Name = "cboDrug";
            this.cboDrug.Size = new System.Drawing.Size(309, 21);
            this.cboDrug.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cboDrug, "Select Drug");
            // 
            // txtRefill
            // 
            this.txtRefill.Location = new System.Drawing.Point(479, 210);
            this.txtRefill.Name = "txtRefill";
            this.txtRefill.Size = new System.Drawing.Size(100, 20);
            this.txtRefill.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtRefill, "Amount of times the prescription can be fulfilled");
            this.txtRefill.TextChanged += new System.EventHandler(this.txtRefill_TextChanged);
            this.txtRefill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRefill_KeyPress);
            // 
            // cboPhysicianID
            // 
            this.cboPhysicianID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboPhysicianID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPhysicianID.FormattingEnabled = true;
            this.cboPhysicianID.Location = new System.Drawing.Point(479, 161);
            this.cboPhysicianID.Name = "cboPhysicianID";
            this.cboPhysicianID.Size = new System.Drawing.Size(309, 21);
            this.cboPhysicianID.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cboPhysicianID, "Select Physician");
            this.cboPhysicianID.SelectedIndexChanged += new System.EventHandler(this.cboPhysicianID_SelectedIndexChanged);
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(19, 169);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(43, 13);
            this.lblPatient.TabIndex = 5;
            this.lblPatient.Text = "Patient:";
            this.toolTip1.SetToolTip(this.lblPatient, "Select Patient");
            // 
            // lblPhysician
            // 
            this.lblPhysician.AutoSize = true;
            this.lblPhysician.Location = new System.Drawing.Point(411, 169);
            this.lblPhysician.Name = "lblPhysician";
            this.lblPhysician.Size = new System.Drawing.Size(55, 13);
            this.lblPhysician.TabIndex = 6;
            this.lblPhysician.Text = "Physician:";
            this.toolTip1.SetToolTip(this.lblPhysician, "Select Physician");
            // 
            // lblDrug
            // 
            this.lblDrug.AutoSize = true;
            this.lblDrug.Location = new System.Drawing.Point(29, 218);
            this.lblDrug.Name = "lblDrug";
            this.lblDrug.Size = new System.Drawing.Size(33, 13);
            this.lblDrug.TabIndex = 7;
            this.lblDrug.Text = "Drug:";
            this.toolTip1.SetToolTip(this.lblDrug, "Select Drug");
            // 
            // lblRefills
            // 
            this.lblRefills.AutoSize = true;
            this.lblRefills.Location = new System.Drawing.Point(385, 217);
            this.lblRefills.Name = "lblRefills";
            this.lblRefills.Size = new System.Drawing.Size(88, 13);
            this.lblRefills.TabIndex = 8;
            this.lblRefills.Text = "Total Fulfillments:";
            this.toolTip1.SetToolTip(this.lblRefills, "Amount of times the prescription can be fulfilled");
            this.lblRefills.Click += new System.EventHandler(this.lblRefills_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(645, 355);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 27);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add ";
            this.toolTip1.SetToolTip(this.btnAdd, "Submit Information");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(645, 405);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 27);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Exit Form");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(387, 258);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(86, 13);
            this.lblTime.TabIndex = 12;
            this.lblTime.Text = "Date Prescribed:";
            // 
            // lblAddPrescription
            // 
            this.lblAddPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPrescription.Location = new System.Drawing.Point(331, 46);
            this.lblAddPrescription.Name = "lblAddPrescription";
            this.lblAddPrescription.Size = new System.Drawing.Size(241, 69);
            this.lblAddPrescription.TabIndex = 13;
            this.lblAddPrescription.Text = "Add Prescription";
            // 
            // dtpDatePrescribed
            // 
            this.dtpDatePrescribed.Location = new System.Drawing.Point(479, 251);
            this.dtpDatePrescribed.Name = "dtpDatePrescribed";
            this.dtpDatePrescribed.Size = new System.Drawing.Size(200, 20);
            this.dtpDatePrescribed.TabIndex = 4;
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(68, 161);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.ReadOnly = true;
            this.txtPatientID.Size = new System.Drawing.Size(309, 20);
            this.txtPatientID.TabIndex = 15;
            // 
            // EPV
            // 
            this.EPV.ContainerControl = this;
            // 
            // frmAddPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.dtpDatePrescribed);
            this.Controls.Add(this.lblAddPrescription);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblRefills);
            this.Controls.Add(this.lblDrug);
            this.Controls.Add(this.lblPhysician);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.cboPhysicianID);
            this.Controls.Add(this.txtRefill);
            this.Controls.Add(this.cboDrug);
            this.Name = "frmAddPrescription";
            this.Text = "frmAddPrescription";
            this.Load += new System.EventHandler(this.frmAddPrescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EPV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDrug;
        private System.Windows.Forms.TextBox txtRefill;
        private System.Windows.Forms.ComboBox cboPhysicianID;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblPhysician;
        private System.Windows.Forms.Label lblDrug;
        private System.Windows.Forms.Label lblRefills;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblAddPrescription;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dtpDatePrescribed;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.ErrorProvider EPV;
    }
}