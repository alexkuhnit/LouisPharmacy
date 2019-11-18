namespace FinalProject
{
    partial class frmSearchPhysician
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
            this.btnAddPhysician = new System.Windows.Forms.Button();
            this.lblSearchPhysician = new System.Windows.Forms.Label();
            this.lblPatientLName = new System.Windows.Forms.Label();
            this.lblPatientFName = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.txtPhysicianLName = new System.Windows.Forms.TextBox();
            this.txtPhysicianFName = new System.Windows.Forms.TextBox();
            this.txtPhysicianID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInfoIcon = new System.Windows.Forms.Label();
            this.lblPhysicianTable = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(689, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddPhysician
            // 
            this.btnAddPhysician.Location = new System.Drawing.Point(589, 212);
            this.btnAddPhysician.Name = "btnAddPhysician";
            this.btnAddPhysician.Size = new System.Drawing.Size(94, 29);
            this.btnAddPhysician.TabIndex = 22;
            this.btnAddPhysician.Text = "Add Physician";
            this.btnAddPhysician.UseVisualStyleBackColor = true;
            this.btnAddPhysician.Click += new System.EventHandler(this.btnAddPhysician_Click);
            // 
            // lblSearchPhysician
            // 
            this.lblSearchPhysician.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchPhysician.Location = new System.Drawing.Point(534, 17);
            this.lblSearchPhysician.Name = "lblSearchPhysician";
            this.lblSearchPhysician.Size = new System.Drawing.Size(259, 60);
            this.lblSearchPhysician.TabIndex = 21;
            this.lblSearchPhysician.Text = "Search Physician";
            // 
            // lblPatientLName
            // 
            this.lblPatientLName.AutoSize = true;
            this.lblPatientLName.Location = new System.Drawing.Point(766, 160);
            this.lblPatientLName.Name = "lblPatientLName";
            this.lblPatientLName.Size = new System.Drawing.Size(109, 13);
            this.lblPatientLName.TabIndex = 20;
            this.lblPatientLName.Text = "Physician Last Name:";
            // 
            // lblPatientFName
            // 
            this.lblPatientFName.AutoSize = true;
            this.lblPatientFName.Location = new System.Drawing.Point(467, 160);
            this.lblPatientFName.Name = "lblPatientFName";
            this.lblPatientFName.Size = new System.Drawing.Size(108, 13);
            this.lblPatientFName.TabIndex = 19;
            this.lblPatientFName.Text = "Physician First Name:";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(210, 160);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(69, 13);
            this.lblPatientID.TabIndex = 18;
            this.lblPatientID.Text = "Physician ID:";
            // 
            // txtPhysicianLName
            // 
            this.txtPhysicianLName.Location = new System.Drawing.Point(881, 153);
            this.txtPhysicianLName.Name = "txtPhysicianLName";
            this.txtPhysicianLName.Size = new System.Drawing.Size(121, 20);
            this.txtPhysicianLName.TabIndex = 16;
            // 
            // txtPhysicianFName
            // 
            this.txtPhysicianFName.Location = new System.Drawing.Point(581, 153);
            this.txtPhysicianFName.Name = "txtPhysicianFName";
            this.txtPhysicianFName.Size = new System.Drawing.Size(121, 20);
            this.txtPhysicianFName.TabIndex = 15;
            // 
            // txtPhysicianID
            // 
            this.txtPhysicianID.Location = new System.Drawing.Point(285, 153);
            this.txtPhysicianID.Name = "txtPhysicianID";
            this.txtPhysicianID.Size = new System.Drawing.Size(121, 20);
            this.txtPhysicianID.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(489, 212);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPatients.Location = new System.Drawing.Point(22, 280);
            this.dgvPatients.MultiSelect = false;
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(1218, 268);
            this.dgvPatients.TabIndex = 13;
            this.toolTip1.SetToolTip(this.dgvPatients, "Double click to update or right click for context menu");
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
            // lblInfoIcon
            // 
            this.lblInfoIcon.AutoSize = true;
            this.lblInfoIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoIcon.Location = new System.Drawing.Point(107, 248);
            this.lblInfoIcon.Name = "lblInfoIcon";
            this.lblInfoIcon.Size = new System.Drawing.Size(29, 29);
            this.lblInfoIcon.TabIndex = 24;
            this.lblInfoIcon.Text = "🛈";
            this.toolTip1.SetToolTip(this.lblInfoIcon, "Double click to update or right click for context menu");
            // 
            // lblPhysicianTable
            // 
            this.lblPhysicianTable.AutoSize = true;
            this.lblPhysicianTable.Location = new System.Drawing.Point(19, 264);
            this.lblPhysicianTable.Name = "lblPhysicianTable";
            this.lblPhysicianTable.Size = new System.Drawing.Size(82, 13);
            this.lblPhysicianTable.TabIndex = 25;
            this.lblPhysicianTable.Text = "Physician Table";
            this.toolTip1.SetToolTip(this.lblPhysicianTable, "Double click to update or right click for context menu");
            // 
            // frmSearchPhysician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 580);
            this.Controls.Add(this.lblPhysicianTable);
            this.Controls.Add(this.lblInfoIcon);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddPhysician);
            this.Controls.Add(this.lblSearchPhysician);
            this.Controls.Add(this.lblPatientLName);
            this.Controls.Add(this.lblPatientFName);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.txtPhysicianLName);
            this.Controls.Add(this.txtPhysicianFName);
            this.Controls.Add(this.txtPhysicianID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvPatients);
            this.Name = "frmSearchPhysician";
            this.Text = "Search Physicians";
            this.Activated += new System.EventHandler(this.frmSearchPhysician_Activated);
            this.Load += new System.EventHandler(this.frmSearchPhysician_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddPhysician;
        private System.Windows.Forms.Label lblSearchPhysician;
        private System.Windows.Forms.Label lblPatientLName;
        private System.Windows.Forms.Label lblPatientFName;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.TextBox txtPhysicianLName;
        private System.Windows.Forms.TextBox txtPhysicianFName;
        private System.Windows.Forms.TextBox txtPhysicianID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblInfoIcon;
        private System.Windows.Forms.Label lblPhysicianTable;
    }
}