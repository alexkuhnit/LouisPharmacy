namespace FinalProject
{
    partial class frmUpdatePhysician
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOffice = new System.Windows.Forms.TextBox();
            this.lblOffice = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.txtMInit = new System.Windows.Forms.TextBox();
            this.txtLicenseNum = new System.Windows.Forms.TextBox();
            this.lblMInit = new System.Windows.Forms.Label();
            this.lblLicenseNum = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblUpdatePhysician = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPhysicianID = new System.Windows.Forms.TextBox();
            this.lblPhysicianID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOffice);
            this.groupBox1.Controls.Add(this.lblOffice);
            this.groupBox1.Controls.Add(this.txtFName);
            this.groupBox1.Controls.Add(this.txtPhoneNum);
            this.groupBox1.Controls.Add(this.lblFName);
            this.groupBox1.Controls.Add(this.lblPhoneNum);
            this.groupBox1.Controls.Add(this.txtMInit);
            this.groupBox1.Controls.Add(this.txtLicenseNum);
            this.groupBox1.Controls.Add(this.lblMInit);
            this.groupBox1.Controls.Add(this.lblLicenseNum);
            this.groupBox1.Controls.Add(this.txtLName);
            this.groupBox1.Controls.Add(this.lblLName);
            this.groupBox1.Location = new System.Drawing.Point(38, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 160);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Info";
            // 
            // txtOffice
            // 
            this.txtOffice.Location = new System.Drawing.Point(71, 91);
            this.txtOffice.Name = "txtOffice";
            this.txtOffice.Size = new System.Drawing.Size(153, 20);
            this.txtOffice.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtOffice, "Insert the physicians office");
            this.txtOffice.TextChanged += new System.EventHandler(this.txtOffice_TextChanged);
            // 
            // lblOffice
            // 
            this.lblOffice.AutoSize = true;
            this.lblOffice.Location = new System.Drawing.Point(27, 98);
            this.lblOffice.Name = "lblOffice";
            this.lblOffice.Size = new System.Drawing.Size(38, 13);
            this.lblOffice.TabIndex = 9;
            this.lblOffice.Text = "Office:";
            this.toolTip1.SetToolTip(this.lblOffice, "Insert the physicians office");
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(71, 19);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 20);
            this.txtFName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtFName, "Insert the physicians first name");
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(331, 91);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNum.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtPhoneNum, "Insert the physicians phone number");
            this.txtPhoneNum.TextChanged += new System.EventHandler(this.txtPhoneNum_TextChanged);
            this.txtPhoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNum_KeyPress);
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(5, 26);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(60, 13);
            this.lblFName.TabIndex = 3;
            this.lblFName.Text = "First Name:";
            this.toolTip1.SetToolTip(this.lblFName, "Insert the physicians first name");
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Location = new System.Drawing.Point(244, 98);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNum.TabIndex = 11;
            this.lblPhoneNum.Text = "Phone Number:";
            this.toolTip1.SetToolTip(this.lblPhoneNum, "Insert the physicians phone number");
            // 
            // txtMInit
            // 
            this.txtMInit.Location = new System.Drawing.Point(331, 19);
            this.txtMInit.Name = "txtMInit";
            this.txtMInit.Size = new System.Drawing.Size(100, 20);
            this.txtMInit.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtMInit, "Insert the physicians middle initial");
            this.txtMInit.TextChanged += new System.EventHandler(this.txtMInit_TextChanged);
            this.txtMInit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMInit_KeyPress);
            // 
            // txtLicenseNum
            // 
            this.txtLicenseNum.Location = new System.Drawing.Point(585, 91);
            this.txtLicenseNum.Name = "txtLicenseNum";
            this.txtLicenseNum.Size = new System.Drawing.Size(100, 20);
            this.txtLicenseNum.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtLicenseNum, "Insert the physicians 6 digit License Number.");
            this.txtLicenseNum.TextChanged += new System.EventHandler(this.txtLicenseNum_TextChanged);
            this.txtLicenseNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLicenseNum_KeyPress);
            // 
            // lblMInit
            // 
            this.lblMInit.AutoSize = true;
            this.lblMInit.Location = new System.Drawing.Point(260, 26);
            this.lblMInit.Name = "lblMInit";
            this.lblMInit.Size = new System.Drawing.Size(65, 13);
            this.lblMInit.TabIndex = 5;
            this.lblMInit.Text = "Middle Initial";
            this.toolTip1.SetToolTip(this.lblMInit, "Insert the physicians middle initial");
            // 
            // lblLicenseNum
            // 
            this.lblLicenseNum.AutoSize = true;
            this.lblLicenseNum.Location = new System.Drawing.Point(495, 98);
            this.lblLicenseNum.Name = "lblLicenseNum";
            this.lblLicenseNum.Size = new System.Drawing.Size(84, 13);
            this.lblLicenseNum.TabIndex = 13;
            this.lblLicenseNum.Text = "License Number";
            this.toolTip1.SetToolTip(this.lblLicenseNum, "Insert the physicians 6 digit License Number.");
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(585, 19);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 20);
            this.txtLName.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtLName, "Insert the physicians last name");
            this.txtLName.TextChanged += new System.EventHandler(this.txtLName_TextChanged);
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(518, 26);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 7;
            this.lblLName.Text = "Last Name:";
            this.toolTip1.SetToolTip(this.lblLName, "Insert the physicians last name");
            // 
            // lblUpdatePhysician
            // 
            this.lblUpdatePhysician.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdatePhysician.Location = new System.Drawing.Point(337, 39);
            this.lblUpdatePhysician.Name = "lblUpdatePhysician";
            this.lblUpdatePhysician.Size = new System.Drawing.Size(241, 57);
            this.lblUpdatePhysician.TabIndex = 24;
            this.lblUpdatePhysician.Text = "Update Physician";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(660, 382);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 29);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(660, 277);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 29);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPhysicianID
            // 
            this.txtPhysicianID.Location = new System.Drawing.Point(138, 39);
            this.txtPhysicianID.Name = "txtPhysicianID";
            this.txtPhysicianID.ReadOnly = true;
            this.txtPhysicianID.Size = new System.Drawing.Size(100, 20);
            this.txtPhysicianID.TabIndex = 26;
            // 
            // lblPhysicianID
            // 
            this.lblPhysicianID.AutoSize = true;
            this.lblPhysicianID.Location = new System.Drawing.Point(66, 46);
            this.lblPhysicianID.Name = "lblPhysicianID";
            this.lblPhysicianID.Size = new System.Drawing.Size(66, 13);
            this.lblPhysicianID.TabIndex = 27;
            this.lblPhysicianID.Text = "Physician ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(660, 324);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 29);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmUpdatePhysician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblPhysicianID);
            this.Controls.Add(this.txtPhysicianID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblUpdatePhysician);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Name = "frmUpdatePhysician";
            this.Text = "Update Physician";
            this.Load += new System.EventHandler(this.frmUpdatePhysician_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOffice;
        private System.Windows.Forms.Label lblOffice;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.TextBox txtMInit;
        private System.Windows.Forms.TextBox txtLicenseNum;
        private System.Windows.Forms.Label lblMInit;
        private System.Windows.Forms.Label lblLicenseNum;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblUpdatePhysician;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPhysicianID;
        private System.Windows.Forms.Label lblPhysicianID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}