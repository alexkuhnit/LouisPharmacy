namespace FinalProject
{
    partial class frmAddPhysician
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
            this.lblFName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblMInit = new System.Windows.Forms.Label();
            this.txtMInit = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblOffice = new System.Windows.Forms.Label();
            this.txtOffice = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.lblLicenseNum = new System.Windows.Forms.Label();
            this.txtLicenseNum = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAddPhysician = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(5, 26);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(60, 13);
            this.lblFName.TabIndex = 3;
            this.lblFName.Text = "First Name:";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(71, 19);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 20);
            this.txtFName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtFName, "Enter Physicians First Name");
            // 
            // lblMInit
            // 
            this.lblMInit.AutoSize = true;
            this.lblMInit.Location = new System.Drawing.Point(260, 26);
            this.lblMInit.Name = "lblMInit";
            this.lblMInit.Size = new System.Drawing.Size(65, 13);
            this.lblMInit.TabIndex = 5;
            this.lblMInit.Text = "Middle Initial";
            // 
            // txtMInit
            // 
            this.txtMInit.Location = new System.Drawing.Point(331, 19);
            this.txtMInit.Name = "txtMInit";
            this.txtMInit.Size = new System.Drawing.Size(100, 20);
            this.txtMInit.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtMInit, "Enter Physicians  Middle Initial");
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(518, 26);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 7;
            this.lblLName.Text = "Last Name:";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(585, 19);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 20);
            this.txtLName.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtLName, "Enter Physicians  Last Name");
            // 
            // lblOffice
            // 
            this.lblOffice.AutoSize = true;
            this.lblOffice.Location = new System.Drawing.Point(27, 98);
            this.lblOffice.Name = "lblOffice";
            this.lblOffice.Size = new System.Drawing.Size(38, 13);
            this.lblOffice.TabIndex = 9;
            this.lblOffice.Text = "Office:";
            // 
            // txtOffice
            // 
            this.txtOffice.Location = new System.Drawing.Point(71, 91);
            this.txtOffice.Name = "txtOffice";
            this.txtOffice.Size = new System.Drawing.Size(100, 20);
            this.txtOffice.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtOffice, "Enter Physicians Office ");
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Location = new System.Drawing.Point(244, 98);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNum.TabIndex = 11;
            this.lblPhoneNum.Text = "Phone Number:";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(331, 91);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNum.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtPhoneNum, "Enter Physicians  Phone Number");
            // 
            // lblLicenseNum
            // 
            this.lblLicenseNum.AutoSize = true;
            this.lblLicenseNum.Location = new System.Drawing.Point(495, 98);
            this.lblLicenseNum.Name = "lblLicenseNum";
            this.lblLicenseNum.Size = new System.Drawing.Size(84, 13);
            this.lblLicenseNum.TabIndex = 13;
            this.lblLicenseNum.Text = "License Number";
            // 
            // txtLicenseNum
            // 
            this.txtLicenseNum.Location = new System.Drawing.Point(585, 91);
            this.txtLicenseNum.Name = "txtLicenseNum";
            this.txtLicenseNum.Size = new System.Drawing.Size(100, 20);
            this.txtLicenseNum.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtLicenseNum, "Enter Physicians  License Number");
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(646, 338);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 29);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.toolTip1.SetToolTip(this.btnAdd, "Submit Information");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(646, 395);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 29);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnExit, "Exit Form");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAddPhysician
            // 
            this.lblAddPhysician.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPhysician.Location = new System.Drawing.Point(323, 52);
            this.lblAddPhysician.Name = "lblAddPhysician";
            this.lblAddPhysician.Size = new System.Drawing.Size(241, 57);
            this.lblAddPhysician.TabIndex = 16;
            this.lblAddPhysician.Text = "Add Physician";
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
            this.groupBox1.Location = new System.Drawing.Point(24, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 160);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General Info";
            // 
            // frmAddPhysician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAddPhysician);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmAddPhysician";
            this.Text = "frmAddPhysician";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblMInit;
        private System.Windows.Forms.TextBox txtMInit;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblOffice;
        private System.Windows.Forms.TextBox txtOffice;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label lblLicenseNum;
        private System.Windows.Forms.TextBox txtLicenseNum;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAddPhysician;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}