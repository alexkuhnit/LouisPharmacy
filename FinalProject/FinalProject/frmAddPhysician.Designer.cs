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
            this.SuspendLayout();
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(247, 67);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(60, 13);
            this.lblFName.TabIndex = 3;
            this.lblFName.Text = "First Name:";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(313, 60);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 20);
            this.txtFName.TabIndex = 2;
            // 
            // lblMInit
            // 
            this.lblMInit.AutoSize = true;
            this.lblMInit.Location = new System.Drawing.Point(242, 93);
            this.lblMInit.Name = "lblMInit";
            this.lblMInit.Size = new System.Drawing.Size(65, 13);
            this.lblMInit.TabIndex = 5;
            this.lblMInit.Text = "Middle Initial";
            // 
            // txtMInit
            // 
            this.txtMInit.Location = new System.Drawing.Point(313, 86);
            this.txtMInit.Name = "txtMInit";
            this.txtMInit.Size = new System.Drawing.Size(100, 20);
            this.txtMInit.TabIndex = 4;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(246, 119);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 7;
            this.lblLName.Text = "Last Name:";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(313, 112);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 20);
            this.txtLName.TabIndex = 6;
            // 
            // lblOffice
            // 
            this.lblOffice.AutoSize = true;
            this.lblOffice.Location = new System.Drawing.Point(269, 145);
            this.lblOffice.Name = "lblOffice";
            this.lblOffice.Size = new System.Drawing.Size(38, 13);
            this.lblOffice.TabIndex = 9;
            this.lblOffice.Text = "Office:";
            // 
            // txtOffice
            // 
            this.txtOffice.Location = new System.Drawing.Point(313, 138);
            this.txtOffice.Name = "txtOffice";
            this.txtOffice.Size = new System.Drawing.Size(100, 20);
            this.txtOffice.TabIndex = 8;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Location = new System.Drawing.Point(226, 171);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNum.TabIndex = 11;
            this.lblPhoneNum.Text = "Phone Number:";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(313, 164);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNum.TabIndex = 10;
            // 
            // lblLicenseNum
            // 
            this.lblLicenseNum.AutoSize = true;
            this.lblLicenseNum.Location = new System.Drawing.Point(223, 197);
            this.lblLicenseNum.Name = "lblLicenseNum";
            this.lblLicenseNum.Size = new System.Drawing.Size(84, 13);
            this.lblLicenseNum.TabIndex = 13;
            this.lblLicenseNum.Text = "License Number";
            // 
            // txtLicenseNum
            // 
            this.txtLicenseNum.Location = new System.Drawing.Point(313, 190);
            this.txtLicenseNum.Name = "txtLicenseNum";
            this.txtLicenseNum.Size = new System.Drawing.Size(100, 20);
            this.txtLicenseNum.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(476, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(476, 86);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAddPhysician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblLicenseNum);
            this.Controls.Add(this.txtLicenseNum);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.lblOffice);
            this.Controls.Add(this.txtOffice);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.lblMInit);
            this.Controls.Add(this.txtMInit);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.txtFName);
            this.Name = "frmAddPhysician";
            this.Text = "frmAddPhysician";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}