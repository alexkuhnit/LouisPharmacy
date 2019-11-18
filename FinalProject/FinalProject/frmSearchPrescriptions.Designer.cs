namespace FinalProject
{
    partial class frmSearchPrescriptions
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
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.txtPatientFName = new System.Windows.Forms.TextBox();
            this.txtPatientLName = new System.Windows.Forms.TextBox();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblPatientFName = new System.Windows.Forms.Label();
            this.lblPatientLName = new System.Windows.Forms.Label();
            this.lblSearchPatient = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPatientsTable = new System.Windows.Forms.Label();
            this.lblInfoIcon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPatients.Location = new System.Drawing.Point(72, 294);
            this.dgvPatients.MultiSelect = false;
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(1218, 268);
            this.dgvPatients.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dgvPatients, "Double click to update or right click for a context menu");
            this.dgvPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatients_CellContentClick);
            this.dgvPatients.DoubleClick += new System.EventHandler(this.dgvPatients_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
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
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(539, 226);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.toolTip1.SetToolTip(this.btnSearch, "Search Entered Information");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(335, 167);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(121, 20);
            this.txtPatientID.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtPatientID, "Insert Patient ID");
            // 
            // txtPatientFName
            // 
            this.txtPatientFName.Location = new System.Drawing.Point(631, 167);
            this.txtPatientFName.Name = "txtPatientFName";
            this.txtPatientFName.Size = new System.Drawing.Size(121, 20);
            this.txtPatientFName.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtPatientFName, "Insert Patients First Name");
            // 
            // txtPatientLName
            // 
            this.txtPatientLName.Location = new System.Drawing.Point(931, 167);
            this.txtPatientLName.Name = "txtPatientLName";
            this.txtPatientLName.Size = new System.Drawing.Size(121, 20);
            this.txtPatientLName.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtPatientLName, "Insert Patients Last Name");
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(272, 174);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(57, 13);
            this.lblPatientID.TabIndex = 7;
            this.lblPatientID.Text = "Patient ID:";
            // 
            // lblPatientFName
            // 
            this.lblPatientFName.AutoSize = true;
            this.lblPatientFName.Location = new System.Drawing.Point(529, 174);
            this.lblPatientFName.Name = "lblPatientFName";
            this.lblPatientFName.Size = new System.Drawing.Size(96, 13);
            this.lblPatientFName.TabIndex = 8;
            this.lblPatientFName.Text = "Patient First Name:";
            // 
            // lblPatientLName
            // 
            this.lblPatientLName.AutoSize = true;
            this.lblPatientLName.Location = new System.Drawing.Point(828, 174);
            this.lblPatientLName.Name = "lblPatientLName";
            this.lblPatientLName.Size = new System.Drawing.Size(97, 13);
            this.lblPatientLName.TabIndex = 9;
            this.lblPatientLName.Text = "Patient Last Name:";
            // 
            // lblSearchPatient
            // 
            this.lblSearchPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchPatient.Location = new System.Drawing.Point(584, 31);
            this.lblSearchPatient.Name = "lblSearchPatient";
            this.lblSearchPatient.Size = new System.Drawing.Size(259, 60);
            this.lblSearchPatient.TabIndex = 10;
            this.lblSearchPatient.Text = "Search Patient";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(639, 226);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(94, 29);
            this.btnAddPatient.TabIndex = 11;
            this.btnAddPatient.Text = "Add Patient";
            this.toolTip1.SetToolTip(this.btnAddPatient, "Search Entered Information");
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(739, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Search Entered Information");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPatientsTable
            // 
            this.lblPatientsTable.AutoSize = true;
            this.lblPatientsTable.Location = new System.Drawing.Point(72, 275);
            this.lblPatientsTable.Name = "lblPatientsTable";
            this.lblPatientsTable.Size = new System.Drawing.Size(75, 13);
            this.lblPatientsTable.TabIndex = 13;
            this.lblPatientsTable.Text = "Patients Table";
            this.toolTip1.SetToolTip(this.lblPatientsTable, "Double click to update or right click for a context menu");
            // 
            // lblInfoIcon
            // 
            this.lblInfoIcon.AutoSize = true;
            this.lblInfoIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoIcon.Location = new System.Drawing.Point(153, 263);
            this.lblInfoIcon.Name = "lblInfoIcon";
            this.lblInfoIcon.Size = new System.Drawing.Size(29, 29);
            this.lblInfoIcon.TabIndex = 14;
            this.lblInfoIcon.Text = "🛈";
            this.toolTip1.SetToolTip(this.lblInfoIcon, "Double click to update or right click for a context menu");
            // 
            // frmSearchPrescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 581);
            this.Controls.Add(this.lblInfoIcon);
            this.Controls.Add(this.lblPatientsTable);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.lblSearchPatient);
            this.Controls.Add(this.lblPatientLName);
            this.Controls.Add(this.lblPatientFName);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.txtPatientLName);
            this.Controls.Add(this.txtPatientFName);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvPatients);
            this.Name = "frmSearchPrescriptions";
            this.Text = "Search Patients";
            this.Activated += new System.EventHandler(this.frmSearchPrescriptions_Activated);
            this.Load += new System.EventHandler(this.frmSearchPrescriptions_Load);
            this.DoubleClick += new System.EventHandler(this.frmSearchPrescriptions_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.TextBox txtPatientFName;
        private System.Windows.Forms.TextBox txtPatientLName;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblPatientFName;
        private System.Windows.Forms.Label lblPatientLName;
        private System.Windows.Forms.Label lblSearchPatient;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label lblPatientsTable;
        private System.Windows.Forms.Label lblInfoIcon;
    }
}