namespace FinalProject
{
    partial class frmPatientPrescription
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
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.lblWorkPhone = new System.Windows.Forms.Label();
            this.txtWorkPhone = new System.Windows.Forms.TextBox();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblStreet2 = new System.Windows.Forms.Label();
            this.txtStreet2 = new System.Windows.Forms.TextBox();
            this.lblStreet1 = new System.Windows.Forms.Label();
            this.txtStreet1 = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblMInit = new System.Windows.Forms.Label();
            this.txtMInit = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.dgvPrescriptions = new System.Windows.Forms.DataGridView();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.chkEnableEdit = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(121, 209);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(136, 21);
            this.cboGender.TabIndex = 76;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(70, 217);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 75;
            this.lblGender.Text = "Gender:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(80, 451);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 74;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(121, 444);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 20);
            this.txtEmail.TabIndex = 73;
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Location = new System.Drawing.Point(54, 425);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(61, 13);
            this.lblCellPhone.TabIndex = 72;
            this.lblCellPhone.Text = "Cell Phone:";
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Location = new System.Drawing.Point(121, 418);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(136, 20);
            this.txtCellPhone.TabIndex = 71;
            // 
            // lblWorkPhone
            // 
            this.lblWorkPhone.AutoSize = true;
            this.lblWorkPhone.Location = new System.Drawing.Point(45, 399);
            this.lblWorkPhone.Name = "lblWorkPhone";
            this.lblWorkPhone.Size = new System.Drawing.Size(70, 13);
            this.lblWorkPhone.TabIndex = 70;
            this.lblWorkPhone.Text = "Work Phone:";
            // 
            // txtWorkPhone
            // 
            this.txtWorkPhone.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.txtWorkPhone.Location = new System.Drawing.Point(121, 392);
            this.txtWorkPhone.Name = "txtWorkPhone";
            this.txtWorkPhone.Size = new System.Drawing.Size(136, 20);
            this.txtWorkPhone.TabIndex = 69;
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(43, 373);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(72, 13);
            this.lblHomePhone.TabIndex = 68;
            this.lblHomePhone.Text = "Home Phone:";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(121, 366);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(136, 20);
            this.txtHomePhone.TabIndex = 67;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(90, 347);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(25, 13);
            this.lblZip.TabIndex = 66;
            this.lblZip.Text = "Zip:";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(121, 340);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(136, 20);
            this.txtZip.TabIndex = 65;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(80, 321);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 64;
            this.lblState.Text = "State:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(88, 295);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 62;
            this.lblCity.Text = "City:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(306, 132);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 60;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(306, 103);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 59;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblStreet2
            // 
            this.lblStreet2.AutoSize = true;
            this.lblStreet2.Location = new System.Drawing.Point(71, 269);
            this.lblStreet2.Name = "lblStreet2";
            this.lblStreet2.Size = new System.Drawing.Size(44, 13);
            this.lblStreet2.TabIndex = 58;
            this.lblStreet2.Text = "Street2:";
            // 
            // txtStreet2
            // 
            this.txtStreet2.Location = new System.Drawing.Point(121, 262);
            this.txtStreet2.Name = "txtStreet2";
            this.txtStreet2.Size = new System.Drawing.Size(136, 20);
            this.txtStreet2.TabIndex = 57;
            // 
            // lblStreet1
            // 
            this.lblStreet1.AutoSize = true;
            this.lblStreet1.Location = new System.Drawing.Point(71, 243);
            this.lblStreet1.Name = "lblStreet1";
            this.lblStreet1.Size = new System.Drawing.Size(44, 13);
            this.lblStreet1.TabIndex = 56;
            this.lblStreet1.Text = "Street1:";
            // 
            // txtStreet1
            // 
            this.txtStreet1.Location = new System.Drawing.Point(121, 236);
            this.txtStreet1.Name = "txtStreet1";
            this.txtStreet1.Size = new System.Drawing.Size(136, 20);
            this.txtStreet1.TabIndex = 55;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(46, 191);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(69, 13);
            this.lblDOB.TabIndex = 54;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(121, 184);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(136, 20);
            this.txtDOB.TabIndex = 53;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(54, 165);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 52;
            this.lblLName.Text = "Last Name:";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(121, 158);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(136, 20);
            this.txtLName.TabIndex = 51;
            // 
            // lblMInit
            // 
            this.lblMInit.AutoSize = true;
            this.lblMInit.Location = new System.Drawing.Point(50, 139);
            this.lblMInit.Name = "lblMInit";
            this.lblMInit.Size = new System.Drawing.Size(65, 13);
            this.lblMInit.TabIndex = 50;
            this.lblMInit.Text = "Middle Initial";
            // 
            // txtMInit
            // 
            this.txtMInit.Location = new System.Drawing.Point(121, 132);
            this.txtMInit.Name = "txtMInit";
            this.txtMInit.Size = new System.Drawing.Size(136, 20);
            this.txtMInit.TabIndex = 49;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(55, 113);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(60, 13);
            this.lblFName.TabIndex = 48;
            this.lblFName.Text = "First Name:";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(121, 106);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(136, 20);
            this.txtFName.TabIndex = 47;
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(171, 53);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(57, 13);
            this.lblPatientID.TabIndex = 78;
            this.lblPatientID.Text = "Patient ID:";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(234, 46);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.ReadOnly = true;
            this.txtPatientID.Size = new System.Drawing.Size(136, 20);
            this.txtPatientID.TabIndex = 77;
            // 
            // dgvPrescriptions
            // 
            this.dgvPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescriptions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPrescriptions.Location = new System.Drawing.Point(121, 484);
            this.dgvPrescriptions.Name = "dgvPrescriptions";
            this.dgvPrescriptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrescriptions.Size = new System.Drawing.Size(1110, 220);
            this.dgvPrescriptions.TabIndex = 0;
            this.dgvPrescriptions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrescriptions_CellContentClick);
            this.dgvPrescriptions.DoubleClick += new System.EventHandler(this.dgvPrescriptions_DoubleClick);
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(121, 313);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(136, 21);
            this.cboState.TabIndex = 79;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(121, 288);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(136, 20);
            this.txtCity.TabIndex = 61;
            // 
            // chkEnableEdit
            // 
            this.chkEnableEdit.AutoSize = true;
            this.chkEnableEdit.Location = new System.Drawing.Point(562, 343);
            this.chkEnableEdit.Name = "chkEnableEdit";
            this.chkEnableEdit.Size = new System.Drawing.Size(94, 17);
            this.chkEnableEdit.TabIndex = 80;
            this.chkEnableEdit.Text = "Enable Editing";
            this.chkEnableEdit.UseVisualStyleBackColor = true;
            // 
            // frmPatientPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 806);
            this.Controls.Add(this.chkEnableEdit);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.dgvPrescriptions);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtMInit);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblMInit);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.lblCellPhone);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.txtCellPhone);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.lblWorkPhone);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.txtWorkPhone);
            this.Controls.Add(this.txtStreet1);
            this.Controls.Add(this.lblHomePhone);
            this.Controls.Add(this.lblStreet1);
            this.Controls.Add(this.txtHomePhone);
            this.Controls.Add(this.txtStreet2);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblStreet2);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCity);
            this.Name = "frmPatientPrescription";
            this.Text = "frmPatientPrescription";
            this.Load += new System.EventHandler(this.frmPatientPrescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.Label lblWorkPhone;
        private System.Windows.Forms.TextBox txtWorkPhone;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblStreet2;
        private System.Windows.Forms.TextBox txtStreet2;
        private System.Windows.Forms.Label lblStreet1;
        private System.Windows.Forms.TextBox txtStreet1;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblMInit;
        private System.Windows.Forms.TextBox txtMInit;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.DataGridView dgvPrescriptions;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.CheckBox chkEnableEdit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}