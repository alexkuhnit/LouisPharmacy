namespace FinalProject
{
    partial class frmUpdateRefill
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
            this.btnUpdateRefill = new System.Windows.Forms.Button();
            this.txtPrescriptionID = new System.Windows.Forms.TextBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPrescriptionID = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtFulfillmentID = new System.Windows.Forms.TextBox();
            this.lblFulfillmentID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnUpdateRefill
            // 
            this.btnUpdateRefill.Location = new System.Drawing.Point(177, 166);
            this.btnUpdateRefill.Name = "btnUpdateRefill";
            this.btnUpdateRefill.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateRefill.TabIndex = 4;
            this.btnUpdateRefill.Text = "Update Refill";
            this.btnUpdateRefill.UseVisualStyleBackColor = true;
            this.btnUpdateRefill.Click += new System.EventHandler(this.btnUpdateRefill_Click);
            // 
            // txtPrescriptionID
            // 
            this.txtPrescriptionID.Location = new System.Drawing.Point(177, 90);
            this.txtPrescriptionID.Name = "txtPrescriptionID";
            this.txtPrescriptionID.Size = new System.Drawing.Size(100, 20);
            this.txtPrescriptionID.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtPrescriptionID, "Prescription ID for the refill being made");
            this.txtPrescriptionID.TextChanged += new System.EventHandler(this.txtPrescriptionID_TextChanged);
            this.txtPrescriptionID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrescriptionID_KeyPress);
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(177, 116);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(200, 20);
            this.dtpTime.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(111, 123);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(60, 13);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "Time Filled:";
            // 
            // lblPrescriptionID
            // 
            this.lblPrescriptionID.AutoSize = true;
            this.lblPrescriptionID.Location = new System.Drawing.Point(95, 97);
            this.lblPrescriptionID.Name = "lblPrescriptionID";
            this.lblPrescriptionID.Size = new System.Drawing.Size(79, 13);
            this.lblPrescriptionID.TabIndex = 12;
            this.lblPrescriptionID.Text = "Prescription ID:";
            this.toolTip1.SetToolTip(this.lblPrescriptionID, "Prescription ID for the refill being made");
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(258, 166);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtFulfillmentID
            // 
            this.txtFulfillmentID.Location = new System.Drawing.Point(177, 58);
            this.txtFulfillmentID.Name = "txtFulfillmentID";
            this.txtFulfillmentID.ReadOnly = true;
            this.txtFulfillmentID.Size = new System.Drawing.Size(100, 20);
            this.txtFulfillmentID.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtFulfillmentID, "Fulfillment ID retrieved from previous form");
            // 
            // lblFulfillmentID
            // 
            this.lblFulfillmentID.AutoSize = true;
            this.lblFulfillmentID.Location = new System.Drawing.Point(104, 65);
            this.lblFulfillmentID.Name = "lblFulfillmentID";
            this.lblFulfillmentID.Size = new System.Drawing.Size(70, 13);
            this.lblFulfillmentID.TabIndex = 17;
            this.lblFulfillmentID.Text = "Fulfillment ID:";
            this.toolTip1.SetToolTip(this.lblFulfillmentID, "Fulfillment ID retrieved from previous form");
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(177, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmUpdateRefill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblFulfillmentID);
            this.Controls.Add(this.txtFulfillmentID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdateRefill);
            this.Controls.Add(this.txtPrescriptionID);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblPrescriptionID);
            this.Name = "frmUpdateRefill";
            this.Text = "frmRefill";
            this.Load += new System.EventHandler(this.frmUpdateRefill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateRefill;
        private System.Windows.Forms.TextBox txtPrescriptionID;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPrescriptionID;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtFulfillmentID;
        private System.Windows.Forms.Label lblFulfillmentID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}