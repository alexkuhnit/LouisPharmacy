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
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.txtPatientFName = new System.Windows.Forms.TextBox();
            this.txtPatientLName = new System.Windows.Forms.TextBox();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblPatientFName = new System.Windows.Forms.Label();
            this.lblPatientLName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPatients
            // 
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Location = new System.Drawing.Point(46, 219);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(717, 268);
            this.dgvPatients.TabIndex = 0;
            this.dgvPatients.DoubleClick += new System.EventHandler(this.dgvPatients_DoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(268, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPatientID
            // 
            this.txtPatientID.Location = new System.Drawing.Point(141, 73);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(121, 20);
            this.txtPatientID.TabIndex = 3;
            // 
            // txtPatientFName
            // 
            this.txtPatientFName.Location = new System.Drawing.Point(141, 99);
            this.txtPatientFName.Name = "txtPatientFName";
            this.txtPatientFName.Size = new System.Drawing.Size(121, 20);
            this.txtPatientFName.TabIndex = 4;
            // 
            // txtPatientLName
            // 
            this.txtPatientLName.Location = new System.Drawing.Point(141, 125);
            this.txtPatientLName.Name = "txtPatientLName";
            this.txtPatientLName.Size = new System.Drawing.Size(121, 20);
            this.txtPatientLName.TabIndex = 5;
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(78, 80);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(57, 13);
            this.lblPatientID.TabIndex = 7;
            this.lblPatientID.Text = "Patient ID:";
            // 
            // lblPatientFName
            // 
            this.lblPatientFName.AutoSize = true;
            this.lblPatientFName.Location = new System.Drawing.Point(39, 106);
            this.lblPatientFName.Name = "lblPatientFName";
            this.lblPatientFName.Size = new System.Drawing.Size(96, 13);
            this.lblPatientFName.TabIndex = 8;
            this.lblPatientFName.Text = "Patient First Name:";
            // 
            // lblPatientLName
            // 
            this.lblPatientLName.AutoSize = true;
            this.lblPatientLName.Location = new System.Drawing.Point(38, 132);
            this.lblPatientLName.Name = "lblPatientLName";
            this.lblPatientLName.Size = new System.Drawing.Size(97, 13);
            this.lblPatientLName.TabIndex = 9;
            this.lblPatientLName.Text = "Patient Last Name:";
            // 
            // frmSearchPrescriptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 581);
            this.Controls.Add(this.lblPatientLName);
            this.Controls.Add(this.lblPatientFName);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.txtPatientLName);
            this.Controls.Add(this.txtPatientFName);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvPatients);
            this.Name = "frmSearchPrescriptions";
            this.Text = "v";
            this.Load += new System.EventHandler(this.frmSearchPrescriptions_Load);
            this.DoubleClick += new System.EventHandler(this.frmSearchPrescriptions_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
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
    }
}