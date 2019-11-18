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
            this.lblLName = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblMInit = new System.Windows.Forms.Label();
            this.txtMInit = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.dgvPrescriptions = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.chkEnableEdit = new System.Windows.Forms.CheckBox();
            this.lblPrescription = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddPrescription = new System.Windows.Forms.Button();
            this.lblPatientsPrescriptions = new System.Windows.Forms.Label();
            this.lblInfoIcon = new System.Windows.Forms.Label();
            this.grpPatientActions = new System.Windows.Forms.GroupBox();
            this.grpPrescriptionTable = new System.Windows.Forms.GroupBox();
            this.btnDeletePrescription = new System.Windows.Forms.Button();
            this.btnUpdatePrescription = new System.Windows.Forms.Button();
            this.epv = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpPatientActions.SuspendLayout();
            this.grpPrescriptionTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epv)).BeginInit();
            this.SuspendLayout();
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Enabled = false;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(75, 83);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(136, 21);
            this.cboGender.TabIndex = 6;
            this.toolTip1.SetToolTip(this.cboGender, "Insert Patients Gender");
            this.cboGender.SelectedIndexChanged += new System.EventHandler(this.cboGender_SelectedIndexChanged);
            this.cboGender.TextChanged += new System.EventHandler(this.cboGender_TextChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(24, 83);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 75;
            this.lblGender.Text = "Gender:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(781, 86);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 74;
            this.lblEmail.Text = "Email:";
            this.toolTip1.SetToolTip(this.lblEmail, "Insert Patients Email");
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(822, 79);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(136, 20);
            this.txtEmail.TabIndex = 15;
            this.toolTip1.SetToolTip(this.txtEmail, "Insert Patients Email");
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Location = new System.Drawing.Point(499, 86);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(61, 13);
            this.lblCellPhone.TabIndex = 72;
            this.lblCellPhone.Text = "Cell Phone:";
            this.toolTip1.SetToolTip(this.lblCellPhone, "Insert Patients Cell Phone Number");
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Enabled = false;
            this.txtCellPhone.Location = new System.Drawing.Point(566, 79);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(136, 20);
            this.txtCellPhone.TabIndex = 14;
            this.toolTip1.SetToolTip(this.txtCellPhone, "Insert Patients Cell Phone Number");
            this.txtCellPhone.TextChanged += new System.EventHandler(this.txtCellPhone_TextChanged);
            this.txtCellPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCellPhone_KeyPress);
            // 
            // lblWorkPhone
            // 
            this.lblWorkPhone.AutoSize = true;
            this.lblWorkPhone.Location = new System.Drawing.Point(242, 86);
            this.lblWorkPhone.Name = "lblWorkPhone";
            this.lblWorkPhone.Size = new System.Drawing.Size(70, 13);
            this.lblWorkPhone.TabIndex = 70;
            this.lblWorkPhone.Text = "Work Phone:";
            this.toolTip1.SetToolTip(this.lblWorkPhone, "Insert Patients Work Phone Number");
            // 
            // txtWorkPhone
            // 
            this.txtWorkPhone.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.txtWorkPhone.Enabled = false;
            this.txtWorkPhone.Location = new System.Drawing.Point(318, 79);
            this.txtWorkPhone.Name = "txtWorkPhone";
            this.txtWorkPhone.Size = new System.Drawing.Size(136, 20);
            this.txtWorkPhone.TabIndex = 13;
            this.toolTip1.SetToolTip(this.txtWorkPhone, "Insert Patients Work Phone Number");
            this.txtWorkPhone.TextChanged += new System.EventHandler(this.txtWorkPhone_TextChanged);
            this.txtWorkPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWorkPhone_KeyPress);
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(-3, 86);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(72, 13);
            this.lblHomePhone.TabIndex = 68;
            this.lblHomePhone.Text = "Home Phone:";
            this.toolTip1.SetToolTip(this.lblHomePhone, "Insert Patients Home Phone Number");
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Enabled = false;
            this.txtHomePhone.Location = new System.Drawing.Point(75, 79);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(136, 20);
            this.txtHomePhone.TabIndex = 12;
            this.toolTip1.SetToolTip(this.txtHomePhone, "Insert Patients Home Phone Number");
            this.txtHomePhone.TextChanged += new System.EventHandler(this.txtHomePhone_TextChanged);
            this.txtHomePhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHomePhone_KeyPress);
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(1006, 26);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(25, 13);
            this.lblZip.TabIndex = 66;
            this.lblZip.Text = "Zip:";
            this.toolTip1.SetToolTip(this.lblZip, "Insert Patients Zip Code");
            // 
            // txtZip
            // 
            this.txtZip.Enabled = false;
            this.txtZip.Location = new System.Drawing.Point(1037, 19);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(136, 20);
            this.txtZip.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txtZip, "Insert Patients Zip Code");
            this.txtZip.TextChanged += new System.EventHandler(this.txtZip_TextChanged);
            this.txtZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZip_KeyPress);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(781, 27);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 64;
            this.lblState.Text = "State:";
            this.toolTip1.SetToolTip(this.lblState, "Insert Patients State");
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(533, 26);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 62;
            this.lblCity.Text = "City:";
            this.toolTip1.SetToolTip(this.lblCity, "Insert Patients City");
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1141, 408);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 32);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Exit Form");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(106, 13);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 32);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.toolTip1.SetToolTip(this.btnUpdate, "Commit Updates");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblStreet2
            // 
            this.lblStreet2.AutoSize = true;
            this.lblStreet2.Location = new System.Drawing.Point(268, 27);
            this.lblStreet2.Name = "lblStreet2";
            this.lblStreet2.Size = new System.Drawing.Size(44, 13);
            this.lblStreet2.TabIndex = 58;
            this.lblStreet2.Text = "Street2:";
            this.toolTip1.SetToolTip(this.lblStreet2, "Insert Patients Address");
            // 
            // txtStreet2
            // 
            this.txtStreet2.Enabled = false;
            this.txtStreet2.Location = new System.Drawing.Point(318, 20);
            this.txtStreet2.Name = "txtStreet2";
            this.txtStreet2.Size = new System.Drawing.Size(136, 20);
            this.txtStreet2.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtStreet2, "Insert Patients Address");
            this.txtStreet2.TextChanged += new System.EventHandler(this.txtStreet2_TextChanged);
            // 
            // lblStreet1
            // 
            this.lblStreet1.AutoSize = true;
            this.lblStreet1.Location = new System.Drawing.Point(25, 26);
            this.lblStreet1.Name = "lblStreet1";
            this.lblStreet1.Size = new System.Drawing.Size(44, 13);
            this.lblStreet1.TabIndex = 56;
            this.lblStreet1.Text = "Street1:";
            this.toolTip1.SetToolTip(this.lblStreet1, "Insert Patients Address");
            // 
            // txtStreet1
            // 
            this.txtStreet1.Enabled = false;
            this.txtStreet1.Location = new System.Drawing.Point(75, 19);
            this.txtStreet1.Name = "txtStreet1";
            this.txtStreet1.Size = new System.Drawing.Size(136, 20);
            this.txtStreet1.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtStreet1, "Insert Patients Address");
            this.txtStreet1.TextChanged += new System.EventHandler(this.txtStreet1_TextChanged);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(724, 44);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(69, 13);
            this.lblDOB.TabIndex = 54;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(499, 44);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 52;
            this.lblLName.Text = "Last Name:";
            this.toolTip1.SetToolTip(this.lblLName, "Insert Patients Last Name");
            // 
            // txtLName
            // 
            this.txtLName.Enabled = false;
            this.txtLName.Location = new System.Drawing.Point(566, 44);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(136, 20);
            this.txtLName.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtLName, "Insert Patients Last Name");
            this.txtLName.TextChanged += new System.EventHandler(this.txtLName_TextChanged);
            // 
            // lblMInit
            // 
            this.lblMInit.AutoSize = true;
            this.lblMInit.Location = new System.Drawing.Point(247, 44);
            this.lblMInit.Name = "lblMInit";
            this.lblMInit.Size = new System.Drawing.Size(65, 13);
            this.lblMInit.TabIndex = 50;
            this.lblMInit.Text = "Middle Initial";
            // 
            // txtMInit
            // 
            this.txtMInit.Enabled = false;
            this.txtMInit.Location = new System.Drawing.Point(318, 44);
            this.txtMInit.Name = "txtMInit";
            this.txtMInit.Size = new System.Drawing.Size(136, 20);
            this.txtMInit.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtMInit, "Insert Patients Middle Initital");
            this.txtMInit.TextChanged += new System.EventHandler(this.txtMInit_TextChanged);
            this.txtMInit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMInit_KeyPress);
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(9, 44);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(60, 13);
            this.lblFName.TabIndex = 48;
            this.lblFName.Text = "First Name:";
            this.toolTip1.SetToolTip(this.lblFName, "Insert Patients First Name");
            // 
            // txtFName
            // 
            this.txtFName.Enabled = false;
            this.txtFName.Location = new System.Drawing.Point(75, 44);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(136, 20);
            this.txtFName.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtFName, "Insert Patients First Name");
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(63, 95);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(57, 13);
            this.lblPatientID.TabIndex = 78;
            this.lblPatientID.Text = "Patient ID:";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(126, 88);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.ReadOnly = true;
            this.txtPatientID.Size = new System.Drawing.Size(136, 20);
            this.txtPatientID.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtPatientID, "Insert Patient ID");
            // 
            // dgvPrescriptions
            // 
            this.dgvPrescriptions.AllowUserToAddRows = false;
            this.dgvPrescriptions.AllowUserToDeleteRows = false;
            this.dgvPrescriptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescriptions.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPrescriptions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPrescriptions.Location = new System.Drawing.Point(51, 487);
            this.dgvPrescriptions.Name = "dgvPrescriptions";
            this.dgvPrescriptions.ReadOnly = true;
            this.dgvPrescriptions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrescriptions.Size = new System.Drawing.Size(1201, 220);
            this.dgvPrescriptions.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dgvPrescriptions, "List of patients prescriptions double click to update prescription info right cli" +
        "ck to update or delete");
            this.dgvPrescriptions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrescriptions_CellContentClick);
            this.dgvPrescriptions.DoubleClick += new System.EventHandler(this.dgvPrescriptions_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.editToolStripMenuItem.Text = "Update/Fill";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // cboState
            // 
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.Enabled = false;
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(822, 19);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(136, 21);
            this.cboState.TabIndex = 10;
            this.toolTip1.SetToolTip(this.cboState, "Insert Patients State");
            this.cboState.SelectedIndexChanged += new System.EventHandler(this.cboState_SelectedIndexChanged);
            this.cboState.TextUpdate += new System.EventHandler(this.cboState_TextUpdate);
            // 
            // txtCity
            // 
            this.txtCity.Enabled = false;
            this.txtCity.Location = new System.Drawing.Point(566, 19);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(136, 20);
            this.txtCity.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtCity, "Insert Patients City");
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // chkEnableEdit
            // 
            this.chkEnableEdit.AutoSize = true;
            this.chkEnableEdit.Location = new System.Drawing.Point(6, 22);
            this.chkEnableEdit.Name = "chkEnableEdit";
            this.chkEnableEdit.Size = new System.Drawing.Size(94, 17);
            this.chkEnableEdit.TabIndex = 18;
            this.chkEnableEdit.Text = "Enable Editing";
            this.toolTip1.SetToolTip(this.chkEnableEdit, "Enable Editing ");
            this.chkEnableEdit.UseVisualStyleBackColor = true;
            this.chkEnableEdit.CheckedChanged += new System.EventHandler(this.chkEnableEdit_CheckedChanged);
            // 
            // lblPrescription
            // 
            this.lblPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescription.Location = new System.Drawing.Point(547, 43);
            this.lblPrescription.Name = "lblPrescription";
            this.lblPrescription.Size = new System.Drawing.Size(272, 77);
            this.lblPrescription.TabIndex = 81;
            this.lblPrescription.Text = "Patient Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDOB);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.lblDOB);
            this.groupBox1.Controls.Add(this.lblLName);
            this.groupBox1.Controls.Add(this.txtLName);
            this.groupBox1.Controls.Add(this.lblMInit);
            this.groupBox1.Controls.Add(this.txtMInit);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.lblFName);
            this.groupBox1.Controls.Add(this.cboGender);
            this.groupBox1.Location = new System.Drawing.Point(51, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1201, 122);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Info";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Enabled = false;
            this.dtpDOB.Location = new System.Drawing.Point(799, 44);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpDOB.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtStreet1);
            this.groupBox2.Controls.Add(this.lblCity);
            this.groupBox2.Controls.Add(this.txtCity);
            this.groupBox2.Controls.Add(this.lblState);
            this.groupBox2.Controls.Add(this.cboState);
            this.groupBox2.Controls.Add(this.txtZip);
            this.groupBox2.Controls.Add(this.lblStreet2);
            this.groupBox2.Controls.Add(this.lblZip);
            this.groupBox2.Controls.Add(this.txtStreet2);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.txtHomePhone);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.lblStreet1);
            this.groupBox2.Controls.Add(this.lblCellPhone);
            this.groupBox2.Controls.Add(this.lblHomePhone);
            this.groupBox2.Controls.Add(this.txtCellPhone);
            this.groupBox2.Controls.Add(this.txtWorkPhone);
            this.groupBox2.Controls.Add(this.lblWorkPhone);
            this.groupBox2.Location = new System.Drawing.Point(51, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1201, 129);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Address and Contact Info";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(223, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 32);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.toolTip1.SetToolTip(this.btnDelete, "Commit Updates");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddPrescription
            // 
            this.btnAddPrescription.Location = new System.Drawing.Point(6, 19);
            this.btnAddPrescription.Name = "btnAddPrescription";
            this.btnAddPrescription.Size = new System.Drawing.Size(135, 35);
            this.btnAddPrescription.TabIndex = 19;
            this.btnAddPrescription.Text = "Add";
            this.toolTip1.SetToolTip(this.btnAddPrescription, "Add a prescription for the patient");
            this.btnAddPrescription.UseVisualStyleBackColor = true;
            this.btnAddPrescription.Click += new System.EventHandler(this.btnAddPrescription_Click);
            // 
            // lblPatientsPrescriptions
            // 
            this.lblPatientsPrescriptions.AutoSize = true;
            this.lblPatientsPrescriptions.Location = new System.Drawing.Point(51, 468);
            this.lblPatientsPrescriptions.Name = "lblPatientsPrescriptions";
            this.lblPatientsPrescriptions.Size = new System.Drawing.Size(108, 13);
            this.lblPatientsPrescriptions.TabIndex = 87;
            this.lblPatientsPrescriptions.Text = "Patients Prescriptions";
            this.toolTip1.SetToolTip(this.lblPatientsPrescriptions, "List of patients prescriptions double click to update prescription info right cli" +
        "ck to update or delete");
            // 
            // lblInfoIcon
            // 
            this.lblInfoIcon.AutoSize = true;
            this.lblInfoIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoIcon.Location = new System.Drawing.Point(165, 455);
            this.lblInfoIcon.Name = "lblInfoIcon";
            this.lblInfoIcon.Size = new System.Drawing.Size(29, 29);
            this.lblInfoIcon.TabIndex = 88;
            this.lblInfoIcon.Text = "🛈";
            this.toolTip1.SetToolTip(this.lblInfoIcon, "List of patients prescriptions double click to update prescription info right cli" +
        "ck to update or delete");
            // 
            // grpPatientActions
            // 
            this.grpPatientActions.Controls.Add(this.btnDelete);
            this.grpPatientActions.Controls.Add(this.chkEnableEdit);
            this.grpPatientActions.Controls.Add(this.btnUpdate);
            this.grpPatientActions.Location = new System.Drawing.Point(51, 386);
            this.grpPatientActions.Name = "grpPatientActions";
            this.grpPatientActions.Size = new System.Drawing.Size(341, 54);
            this.grpPatientActions.TabIndex = 85;
            this.grpPatientActions.TabStop = false;
            this.grpPatientActions.Text = "Patient Actions";
            // 
            // grpPrescriptionTable
            // 
            this.grpPrescriptionTable.Controls.Add(this.btnAddPrescription);
            this.grpPrescriptionTable.Controls.Add(this.btnDeletePrescription);
            this.grpPrescriptionTable.Controls.Add(this.btnUpdatePrescription);
            this.grpPrescriptionTable.Location = new System.Drawing.Point(51, 713);
            this.grpPrescriptionTable.Name = "grpPrescriptionTable";
            this.grpPrescriptionTable.Size = new System.Drawing.Size(430, 67);
            this.grpPrescriptionTable.TabIndex = 86;
            this.grpPrescriptionTable.TabStop = false;
            this.grpPrescriptionTable.Text = "Prescription Table Actions";
            // 
            // btnDeletePrescription
            // 
            this.btnDeletePrescription.Location = new System.Drawing.Point(288, 19);
            this.btnDeletePrescription.Name = "btnDeletePrescription";
            this.btnDeletePrescription.Size = new System.Drawing.Size(135, 35);
            this.btnDeletePrescription.TabIndex = 21;
            this.btnDeletePrescription.Text = "Delete";
            this.btnDeletePrescription.UseVisualStyleBackColor = true;
            this.btnDeletePrescription.Click += new System.EventHandler(this.btnDeletePrescription_Click);
            // 
            // btnUpdatePrescription
            // 
            this.btnUpdatePrescription.Location = new System.Drawing.Point(147, 19);
            this.btnUpdatePrescription.Name = "btnUpdatePrescription";
            this.btnUpdatePrescription.Size = new System.Drawing.Size(135, 35);
            this.btnUpdatePrescription.TabIndex = 20;
            this.btnUpdatePrescription.Text = "Update";
            this.btnUpdatePrescription.UseVisualStyleBackColor = true;
            this.btnUpdatePrescription.Click += new System.EventHandler(this.btnUpdatePrescription_Click);
            // 
            // epv
            // 
            this.epv.ContainerControl = this;
            // 
            // frmPatientPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 806);
            this.Controls.Add(this.lblInfoIcon);
            this.Controls.Add(this.lblPatientsPrescriptions);
            this.Controls.Add(this.grpPrescriptionTable);
            this.Controls.Add(this.grpPatientActions);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPrescription);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.dgvPrescriptions);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.btnExit);
            this.Name = "frmPatientPrescription";
            this.Text = "Patient Information";
            this.Activated += new System.EventHandler(this.frmPatientPrescription_Activated);
            this.Load += new System.EventHandler(this.frmPatientPrescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpPatientActions.ResumeLayout(false);
            this.grpPatientActions.PerformLayout();
            this.grpPrescriptionTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epv)).EndInit();
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
        private System.Windows.Forms.Label lblPrescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.GroupBox grpPatientActions;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grpPrescriptionTable;
        private System.Windows.Forms.Button btnDeletePrescription;
        private System.Windows.Forms.Button btnUpdatePrescription;
        private System.Windows.Forms.Button btnAddPrescription;
        private System.Windows.Forms.Label lblPatientsPrescriptions;
        private System.Windows.Forms.ErrorProvider epv;
        private System.Windows.Forms.Label lblInfoIcon;
    }
}