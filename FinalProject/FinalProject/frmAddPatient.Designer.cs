namespace FinalProject
{
    partial class frmAddPatient
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStreet2 = new System.Windows.Forms.Label();
            this.txtStreet2 = new System.Windows.Forms.TextBox();
            this.lblStreet1 = new System.Windows.Forms.Label();
            this.txtStreet1 = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblMInit = new System.Windows.Forms.Label();
            this.txtMInit = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
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
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.lblAddPatient = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.epv = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(614, 513);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 30);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Exit Form");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(614, 449);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.toolTip1.SetToolTip(this.btnAdd, "Submit Information");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblStreet2
            // 
            this.lblStreet2.AutoSize = true;
            this.lblStreet2.Location = new System.Drawing.Point(284, 37);
            this.lblStreet2.Name = "lblStreet2";
            this.lblStreet2.Size = new System.Drawing.Size(44, 13);
            this.lblStreet2.TabIndex = 27;
            this.lblStreet2.Text = "Street2:";
            this.toolTip1.SetToolTip(this.lblStreet2, "Enter Patients Address");
            // 
            // txtStreet2
            // 
            this.txtStreet2.Location = new System.Drawing.Point(334, 30);
            this.txtStreet2.Name = "txtStreet2";
            this.txtStreet2.Size = new System.Drawing.Size(136, 20);
            this.txtStreet2.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtStreet2, "Enter Patients Address");
            // 
            // lblStreet1
            // 
            this.lblStreet1.AutoSize = true;
            this.lblStreet1.Location = new System.Drawing.Point(33, 33);
            this.lblStreet1.Name = "lblStreet1";
            this.lblStreet1.Size = new System.Drawing.Size(44, 13);
            this.lblStreet1.TabIndex = 25;
            this.lblStreet1.Text = "Street1:";
            this.toolTip1.SetToolTip(this.lblStreet1, "Enter Patients Address");
            // 
            // txtStreet1
            // 
            this.txtStreet1.Location = new System.Drawing.Point(83, 26);
            this.txtStreet1.Name = "txtStreet1";
            this.txtStreet1.Size = new System.Drawing.Size(136, 20);
            this.txtStreet1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtStreet1, "Enter Patients Address");
            this.txtStreet1.TextChanged += new System.EventHandler(this.txtStreet1_TextChanged);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(-1, 69);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(69, 13);
            this.lblDOB.TabIndex = 23;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(483, 26);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 21;
            this.lblLName.Text = "Last Name:";
            this.toolTip1.SetToolTip(this.lblLName, "Enter Patients Last Name");
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(550, 19);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(136, 20);
            this.txtLName.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtLName, "Enter Patients Last Name");
            this.txtLName.TextChanged += new System.EventHandler(this.txtLName_TextChanged);
            // 
            // lblMInit
            // 
            this.lblMInit.AutoSize = true;
            this.lblMInit.Location = new System.Drawing.Point(254, 26);
            this.lblMInit.Name = "lblMInit";
            this.lblMInit.Size = new System.Drawing.Size(65, 13);
            this.lblMInit.TabIndex = 19;
            this.lblMInit.Text = "Middle Initial";
            this.toolTip1.SetToolTip(this.lblMInit, "Enter Patients Middle Initial");
            // 
            // txtMInit
            // 
            this.txtMInit.Location = new System.Drawing.Point(325, 19);
            this.txtMInit.Name = "txtMInit";
            this.txtMInit.Size = new System.Drawing.Size(136, 20);
            this.txtMInit.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtMInit, "Enter Patients Middle Initial");
            this.txtMInit.TextChanged += new System.EventHandler(this.txtMInit_TextChanged);
            this.txtMInit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMInit_KeyPress);
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(8, 26);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(60, 13);
            this.lblFName.TabIndex = 17;
            this.lblFName.Text = "First Name:";
            this.toolTip1.SetToolTip(this.lblFName, "Enter Patients First Name");
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(74, 19);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(136, 20);
            this.txtFName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtFName, "Enter Patients First Name");
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Location = new System.Drawing.Point(267, 135);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(61, 13);
            this.lblCellPhone.TabIndex = 41;
            this.lblCellPhone.Text = "Cell Phone:";
            this.toolTip1.SetToolTip(this.lblCellPhone, "Enter Patients Cell Phone Number");
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Location = new System.Drawing.Point(334, 128);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(136, 20);
            this.txtCellPhone.TabIndex = 13;
            this.toolTip1.SetToolTip(this.txtCellPhone, "Enter Patients Cell Phone Number");
            this.txtCellPhone.TextChanged += new System.EventHandler(this.txtCellPhone_TextChanged);
            this.txtCellPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCellPhone_KeyPress);
            // 
            // lblWorkPhone
            // 
            this.lblWorkPhone.AutoSize = true;
            this.lblWorkPhone.Location = new System.Drawing.Point(7, 135);
            this.lblWorkPhone.Name = "lblWorkPhone";
            this.lblWorkPhone.Size = new System.Drawing.Size(70, 13);
            this.lblWorkPhone.TabIndex = 39;
            this.lblWorkPhone.Text = "Work Phone:";
            this.toolTip1.SetToolTip(this.lblWorkPhone, "Enter Patients Work Phone Number");
            // 
            // txtWorkPhone
            // 
            this.txtWorkPhone.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.txtWorkPhone.Location = new System.Drawing.Point(83, 128);
            this.txtWorkPhone.Name = "txtWorkPhone";
            this.txtWorkPhone.Size = new System.Drawing.Size(136, 20);
            this.txtWorkPhone.TabIndex = 12;
            this.toolTip1.SetToolTip(this.txtWorkPhone, "Enter Patients Work Phone Number");
            this.txtWorkPhone.TextChanged += new System.EventHandler(this.txtWorkPhone_TextChanged);
            this.txtWorkPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWorkPhone_KeyPress);
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(481, 86);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(72, 13);
            this.lblHomePhone.TabIndex = 37;
            this.lblHomePhone.Text = "Home Phone:";
            this.toolTip1.SetToolTip(this.lblHomePhone, "Enter Patients Home Phone Number");
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(559, 79);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(136, 20);
            this.txtHomePhone.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txtHomePhone, "Enter Patients Home Phone Number");
            this.txtHomePhone.TextChanged += new System.EventHandler(this.txtHomePhone_TextChanged);
            this.txtHomePhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHomePhone_KeyPress);
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(303, 86);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(25, 13);
            this.lblZip.TabIndex = 35;
            this.lblZip.Text = "Zip:";
            this.toolTip1.SetToolTip(this.lblZip, "Enter Patients Zip Code");
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(334, 79);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(136, 20);
            this.txtZip.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtZip, "Enter Patients Zip Code");
            this.txtZip.TextChanged += new System.EventHandler(this.txtZip_TextChanged);
            this.txtZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZip_KeyPress);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(42, 82);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 33;
            this.lblState.Text = "State:";
            this.toolTip1.SetToolTip(this.lblState, "Enter Patients State");
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(526, 37);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 31;
            this.lblCity.Text = "City:";
            this.toolTip1.SetToolTip(this.lblCity, "Enter Patients City");
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(559, 30);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(136, 20);
            this.txtCity.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtCity, "Enter Patients City");
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(322, 69);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 45;
            this.lblGender.Text = "Gender:";
            this.toolTip1.SetToolTip(this.lblGender, "Enter Patients Gender");
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(518, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 43;
            this.lblEmail.Text = "Email:";
            this.toolTip1.SetToolTip(this.lblEmail, "Enter Patients Email");
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(559, 128);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 20);
            this.txtEmail.TabIndex = 14;
            this.toolTip1.SetToolTip(this.txtEmail, "Enter Patients Email");
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.ItemHeight = 13;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(373, 61);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(136, 21);
            this.cboGender.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cboGender, "Enter Patients Gender");
            this.cboGender.SelectedIndexChanged += new System.EventHandler(this.cboGender_SelectedIndexChanged);
            this.cboGender.TextChanged += new System.EventHandler(this.cboGender_TextChanged);
            // 
            // cboState
            // 
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(83, 75);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(136, 21);
            this.cboState.TabIndex = 9;
            this.toolTip1.SetToolTip(this.cboState, "Enter Patients State");
            this.cboState.TextUpdate += new System.EventHandler(this.cboState_TextUpdate);
            // 
            // lblAddPatient
            // 
            this.lblAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPatient.Location = new System.Drawing.Point(337, 34);
            this.lblAddPatient.Name = "lblAddPatient";
            this.lblAddPatient.Size = new System.Drawing.Size(270, 82);
            this.lblAddPatient.TabIndex = 48;
            this.lblAddPatient.Text = "Add Patient";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDOB);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.lblFName);
            this.groupBox1.Controls.Add(this.txtMInit);
            this.groupBox1.Controls.Add(this.cboGender);
            this.groupBox1.Controls.Add(this.lblMInit);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.txtLName);
            this.groupBox1.Controls.Add(this.lblLName);
            this.groupBox1.Controls.Add(this.lblDOB);
            this.groupBox1.Location = new System.Drawing.Point(7, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 109);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Info";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(74, 62);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStreet1);
            this.groupBox2.Controls.Add(this.txtStreet1);
            this.groupBox2.Controls.Add(this.txtStreet2);
            this.groupBox2.Controls.Add(this.cboState);
            this.groupBox2.Controls.Add(this.lblStreet2);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.txtCity);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.lblCity);
            this.groupBox2.Controls.Add(this.lblCellPhone);
            this.groupBox2.Controls.Add(this.lblState);
            this.groupBox2.Controls.Add(this.txtCellPhone);
            this.groupBox2.Controls.Add(this.txtZip);
            this.groupBox2.Controls.Add(this.lblWorkPhone);
            this.groupBox2.Controls.Add(this.lblZip);
            this.groupBox2.Controls.Add(this.txtWorkPhone);
            this.groupBox2.Controls.Add(this.txtHomePhone);
            this.groupBox2.Controls.Add(this.lblHomePhone);
            this.groupBox2.Location = new System.Drawing.Point(7, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 190);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address and Contact Information";
            // 
            // epv
            // 
            this.epv.ContainerControl = this;
            // 
            // frmAddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 571);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAddPatient);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmAddPatient";
            this.Text = "Add Patient";
            this.Load += new System.EventHandler(this.frmAddPatient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStreet2;
        private System.Windows.Forms.TextBox txtStreet2;
        private System.Windows.Forms.Label lblStreet1;
        private System.Windows.Forms.TextBox txtStreet1;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblMInit;
        private System.Windows.Forms.TextBox txtMInit;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtFName;
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
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.Label lblAddPatient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ErrorProvider epv;
    }
}