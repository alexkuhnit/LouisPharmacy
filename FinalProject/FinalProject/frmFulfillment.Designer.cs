namespace FinalProject
{
    partial class frmFulfillment
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
            this.txtPrescriptionID = new System.Windows.Forms.TextBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dgvRefills = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPrescriptionID = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRefills = new System.Windows.Forms.Label();
            this.lblDrug = new System.Windows.Forms.Label();
            this.lblPhysician = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.cboPhysicianID = new System.Windows.Forms.ComboBox();
            this.txtRefill = new System.Windows.Forms.TextBox();
            this.cboDrug = new System.Windows.Forms.ComboBox();
            this.chkEnableEditing = new System.Windows.Forms.CheckBox();
            this.grpPrescriptionInfo = new System.Windows.Forms.GroupBox();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtpPrescribed = new System.Windows.Forms.DateTimePicker();
            this.grpRefillInformation = new System.Windows.Forms.GroupBox();
            this.btnAddRefill = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblRefillsDGV = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.grpRefillActions = new System.Windows.Forms.GroupBox();
            this.btnDeleteRefill = new System.Windows.Forms.Button();
            this.btnUpdateRefill = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.epv = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblInfoIcon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefills)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.grpPrescriptionInfo.SuspendLayout();
            this.grpRefillInformation.SuspendLayout();
            this.grpRefillActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrescriptionID
            // 
            this.txtPrescriptionID.Location = new System.Drawing.Point(94, 19);
            this.txtPrescriptionID.Name = "txtPrescriptionID";
            this.txtPrescriptionID.ReadOnly = true;
            this.txtPrescriptionID.Size = new System.Drawing.Size(100, 20);
            this.txtPrescriptionID.TabIndex = 2;
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(94, 45);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(200, 20);
            this.dtpTime.TabIndex = 0;
            // 
            // dgvRefills
            // 
            this.dgvRefills.AllowUserToAddRows = false;
            this.dgvRefills.AllowUserToDeleteRows = false;
            this.dgvRefills.AllowUserToResizeColumns = false;
            this.dgvRefills.AllowUserToResizeRows = false;
            this.dgvRefills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRefills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefills.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvRefills.Location = new System.Drawing.Point(79, 273);
            this.dgvRefills.Name = "dgvRefills";
            this.dgvRefills.ReadOnly = true;
            this.dgvRefills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRefills.Size = new System.Drawing.Size(514, 150);
            this.dgvRefills.TabIndex = 4;
            this.toolTip1.SetToolTip(this.dgvRefills, "Double click to update refill information or right click to update or delete.");
            this.dgvRefills.DoubleClick += new System.EventHandler(this.dgvRefills_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.dleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 48);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // dleteToolStripMenuItem
            // 
            this.dleteToolStripMenuItem.Name = "dleteToolStripMenuItem";
            this.dleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.dleteToolStripMenuItem.Text = "Delete";
            this.dleteToolStripMenuItem.Click += new System.EventHandler(this.dleteToolStripMenuItem_Click);
            // 
            // lblPrescriptionID
            // 
            this.lblPrescriptionID.AutoSize = true;
            this.lblPrescriptionID.Location = new System.Drawing.Point(12, 26);
            this.lblPrescriptionID.Name = "lblPrescriptionID";
            this.lblPrescriptionID.Size = new System.Drawing.Size(79, 13);
            this.lblPrescriptionID.TabIndex = 7;
            this.lblPrescriptionID.Text = "Prescription ID:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(28, 52);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(60, 13);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time Filled:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Date Prescribed:";
            // 
            // lblRefills
            // 
            this.lblRefills.AutoSize = true;
            this.lblRefills.Location = new System.Drawing.Point(25, 141);
            this.lblRefills.Name = "lblRefills";
            this.lblRefills.Size = new System.Drawing.Size(85, 13);
            this.lblRefills.TabIndex = 21;
            this.lblRefills.Text = "Total fulfillments:";
            // 
            // lblDrug
            // 
            this.lblDrug.AutoSize = true;
            this.lblDrug.Location = new System.Drawing.Point(28, 89);
            this.lblDrug.Name = "lblDrug";
            this.lblDrug.Size = new System.Drawing.Size(33, 13);
            this.lblDrug.TabIndex = 20;
            this.lblDrug.Text = "Drug:";
            // 
            // lblPhysician
            // 
            this.lblPhysician.AutoSize = true;
            this.lblPhysician.Location = new System.Drawing.Point(6, 62);
            this.lblPhysician.Name = "lblPhysician";
            this.lblPhysician.Size = new System.Drawing.Size(55, 13);
            this.lblPhysician.TabIndex = 19;
            this.lblPhysician.Text = "Physician:";
            this.toolTip1.SetToolTip(this.lblPhysician, "Physician who signed prescription");
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Location = new System.Drawing.Point(18, 34);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(43, 13);
            this.lblPatient.TabIndex = 17;
            this.lblPatient.Text = "Patient:";
            this.toolTip1.SetToolTip(this.lblPatient, "Parient prescribed to");
            // 
            // cboPhysicianID
            // 
            this.cboPhysicianID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboPhysicianID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPhysicianID.Enabled = false;
            this.cboPhysicianID.FormattingEnabled = true;
            this.cboPhysicianID.ItemHeight = 13;
            this.cboPhysicianID.Location = new System.Drawing.Point(67, 54);
            this.cboPhysicianID.Name = "cboPhysicianID";
            this.cboPhysicianID.Size = new System.Drawing.Size(309, 21);
            this.cboPhysicianID.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cboPhysicianID, "Physician who signed prescription");
            // 
            // txtRefill
            // 
            this.txtRefill.Enabled = false;
            this.txtRefill.Location = new System.Drawing.Point(116, 134);
            this.txtRefill.Name = "txtRefill";
            this.txtRefill.Size = new System.Drawing.Size(100, 20);
            this.txtRefill.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtRefill, "Please insert the amount of refills for this prescription. Must be more or the sa" +
        "me as the amount of times fulfilled");
            this.txtRefill.TextChanged += new System.EventHandler(this.txtRefill_TextChanged);
            this.txtRefill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRefill_KeyPress);
            // 
            // cboDrug
            // 
            this.cboDrug.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboDrug.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDrug.Enabled = false;
            this.cboDrug.FormattingEnabled = true;
            this.cboDrug.ItemHeight = 13;
            this.cboDrug.Location = new System.Drawing.Point(67, 81);
            this.cboDrug.Name = "cboDrug";
            this.cboDrug.Size = new System.Drawing.Size(309, 21);
            this.cboDrug.TabIndex = 6;
            // 
            // chkEnableEditing
            // 
            this.chkEnableEditing.AutoSize = true;
            this.chkEnableEditing.Location = new System.Drawing.Point(276, 170);
            this.chkEnableEditing.Name = "chkEnableEditing";
            this.chkEnableEditing.Size = new System.Drawing.Size(94, 17);
            this.chkEnableEditing.TabIndex = 4;
            this.chkEnableEditing.Text = "Enable Editing";
            this.chkEnableEditing.UseVisualStyleBackColor = true;
            this.chkEnableEditing.CheckedChanged += new System.EventHandler(this.chkEnableEditing_CheckedChanged);
            // 
            // grpPrescriptionInfo
            // 
            this.grpPrescriptionInfo.Controls.Add(this.txtPatientID);
            this.grpPrescriptionInfo.Controls.Add(this.btnDelete);
            this.grpPrescriptionInfo.Controls.Add(this.btnUpdate);
            this.grpPrescriptionInfo.Controls.Add(this.dtpPrescribed);
            this.grpPrescriptionInfo.Controls.Add(this.chkEnableEditing);
            this.grpPrescriptionInfo.Controls.Add(this.cboDrug);
            this.grpPrescriptionInfo.Controls.Add(this.label1);
            this.grpPrescriptionInfo.Controls.Add(this.txtRefill);
            this.grpPrescriptionInfo.Controls.Add(this.cboPhysicianID);
            this.grpPrescriptionInfo.Controls.Add(this.lblRefills);
            this.grpPrescriptionInfo.Controls.Add(this.lblPatient);
            this.grpPrescriptionInfo.Controls.Add(this.lblDrug);
            this.grpPrescriptionInfo.Controls.Add(this.lblPhysician);
            this.grpPrescriptionInfo.Location = new System.Drawing.Point(12, 12);
            this.grpPrescriptionInfo.Name = "grpPrescriptionInfo";
            this.grpPrescriptionInfo.Size = new System.Drawing.Size(420, 221);
            this.grpPrescriptionInfo.TabIndex = 24;
            this.grpPrescriptionInfo.TabStop = false;
            this.grpPrescriptionInfo.Text = "Prescription Information";
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(67, 28);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.ReadOnly = true;
            this.txtPatientID.Size = new System.Drawing.Size(309, 20);
            this.txtPatientID.TabIndex = 23;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(116, 191);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(116, 161);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtpPrescribed
            // 
            this.dtpPrescribed.Enabled = false;
            this.dtpPrescribed.Location = new System.Drawing.Point(116, 109);
            this.dtpPrescribed.Name = "dtpPrescribed";
            this.dtpPrescribed.Size = new System.Drawing.Size(200, 20);
            this.dtpPrescribed.TabIndex = 7;
            // 
            // grpRefillInformation
            // 
            this.grpRefillInformation.Controls.Add(this.btnAddRefill);
            this.grpRefillInformation.Controls.Add(this.txtPrescriptionID);
            this.grpRefillInformation.Controls.Add(this.dtpTime);
            this.grpRefillInformation.Controls.Add(this.lblTime);
            this.grpRefillInformation.Controls.Add(this.lblPrescriptionID);
            this.grpRefillInformation.Location = new System.Drawing.Point(438, 12);
            this.grpRefillInformation.Name = "grpRefillInformation";
            this.grpRefillInformation.Size = new System.Drawing.Size(339, 102);
            this.grpRefillInformation.TabIndex = 25;
            this.grpRefillInformation.TabStop = false;
            this.grpRefillInformation.Text = "Refill Information";
            // 
            // btnAddRefill
            // 
            this.btnAddRefill.Location = new System.Drawing.Point(152, 71);
            this.btnAddRefill.Name = "btnAddRefill";
            this.btnAddRefill.Size = new System.Drawing.Size(75, 23);
            this.btnAddRefill.TabIndex = 1;
            this.btnAddRefill.Text = "Add Refill";
            this.btnAddRefill.UseVisualStyleBackColor = true;
            this.btnAddRefill.Click += new System.EventHandler(this.btnAddRefill_Click);
            // 
            // lblRefillsDGV
            // 
            this.lblRefillsDGV.AutoSize = true;
            this.lblRefillsDGV.Location = new System.Drawing.Point(76, 257);
            this.lblRefillsDGV.Name = "lblRefillsDGV";
            this.lblRefillsDGV.Size = new System.Drawing.Size(126, 13);
            this.lblRefillsDGV.TabIndex = 27;
            this.lblRefillsDGV.Text = "Refills for this prescription";
            this.toolTip1.SetToolTip(this.lblRefillsDGV, "Double click to update refill information or right click to update or delete.");
            // 
            // grpRefillActions
            // 
            this.grpRefillActions.Controls.Add(this.btnDeleteRefill);
            this.grpRefillActions.Controls.Add(this.btnUpdateRefill);
            this.grpRefillActions.Location = new System.Drawing.Point(599, 273);
            this.grpRefillActions.Name = "grpRefillActions";
            this.grpRefillActions.Size = new System.Drawing.Size(127, 150);
            this.grpRefillActions.TabIndex = 28;
            this.grpRefillActions.TabStop = false;
            this.grpRefillActions.Text = "Refill Table Actions";
            // 
            // btnDeleteRefill
            // 
            this.btnDeleteRefill.Location = new System.Drawing.Point(6, 62);
            this.btnDeleteRefill.Name = "btnDeleteRefill";
            this.btnDeleteRefill.Size = new System.Drawing.Size(107, 37);
            this.btnDeleteRefill.TabIndex = 3;
            this.btnDeleteRefill.Text = "Delete";
            this.btnDeleteRefill.UseVisualStyleBackColor = true;
            this.btnDeleteRefill.Click += new System.EventHandler(this.btnDeleteRefill_Click);
            // 
            // btnUpdateRefill
            // 
            this.btnUpdateRefill.Location = new System.Drawing.Point(6, 19);
            this.btnUpdateRefill.Name = "btnUpdateRefill";
            this.btnUpdateRefill.Size = new System.Drawing.Size(107, 37);
            this.btnUpdateRefill.TabIndex = 2;
            this.btnUpdateRefill.Text = "Update";
            this.btnUpdateRefill.UseVisualStyleBackColor = true;
            this.btnUpdateRefill.Click += new System.EventHandler(this.btnUpdateRefill_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(740, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 37);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // epv
            // 
            this.epv.ContainerControl = this;
            // 
            // lblInfoIcon
            // 
            this.lblInfoIcon.AutoSize = true;
            this.lblInfoIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoIcon.Location = new System.Drawing.Point(208, 241);
            this.lblInfoIcon.Name = "lblInfoIcon";
            this.lblInfoIcon.Size = new System.Drawing.Size(29, 29);
            this.lblInfoIcon.TabIndex = 29;
            this.lblInfoIcon.Text = "🛈";
            this.toolTip1.SetToolTip(this.lblInfoIcon, "Double click to update refill information or right click to update or delete.");
            // 
            // frmFulfillment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.lblInfoIcon);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpRefillActions);
            this.Controls.Add(this.lblRefillsDGV);
            this.Controls.Add(this.grpRefillInformation);
            this.Controls.Add(this.grpPrescriptionInfo);
            this.Controls.Add(this.dgvRefills);
            this.Name = "frmFulfillment";
            this.Text = "frmFulfillment";
            this.Activated += new System.EventHandler(this.frmFulfillment_Activated);
            this.Load += new System.EventHandler(this.frmFulfillment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefills)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.grpPrescriptionInfo.ResumeLayout(false);
            this.grpPrescriptionInfo.PerformLayout();
            this.grpRefillInformation.ResumeLayout(false);
            this.grpRefillInformation.PerformLayout();
            this.grpRefillActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPrescriptionID;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DataGridView dgvRefills;
        private System.Windows.Forms.Label lblPrescriptionID;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRefills;
        private System.Windows.Forms.Label lblDrug;
        private System.Windows.Forms.Label lblPhysician;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.ComboBox cboPhysicianID;
        private System.Windows.Forms.TextBox txtRefill;
        private System.Windows.Forms.ComboBox cboDrug;
        private System.Windows.Forms.CheckBox chkEnableEditing;
        private System.Windows.Forms.GroupBox grpPrescriptionInfo;
        private System.Windows.Forms.GroupBox grpRefillInformation;
        private System.Windows.Forms.Button btnAddRefill;
        private System.Windows.Forms.DateTimePicker dtpPrescribed;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dleteToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label lblRefillsDGV;
        private System.Windows.Forms.GroupBox grpRefillActions;
        private System.Windows.Forms.Button btnDeleteRefill;
        private System.Windows.Forms.Button btnUpdateRefill;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.ErrorProvider epv;
        private System.Windows.Forms.Label lblInfoIcon;
    }
}