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
            this.txtPrescriptionID = new System.Windows.Forms.TextBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dgvRefills = new System.Windows.Forms.DataGridView();
            this.lblPrescriptionID = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefills)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrescriptionID
            // 
            this.txtPrescriptionID.Location = new System.Drawing.Point(198, 104);
            this.txtPrescriptionID.Name = "txtPrescriptionID";
            this.txtPrescriptionID.Size = new System.Drawing.Size(100, 20);
            this.txtPrescriptionID.TabIndex = 2;
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(198, 130);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(200, 20);
            this.dtpTime.TabIndex = 3;
            // 
            // dgvRefills
            // 
            this.dgvRefills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefills.Location = new System.Drawing.Point(131, 239);
            this.dgvRefills.Name = "dgvRefills";
            this.dgvRefills.Size = new System.Drawing.Size(514, 150);
            this.dgvRefills.TabIndex = 4;
            // 
            // lblPrescriptionID
            // 
            this.lblPrescriptionID.AutoSize = true;
            this.lblPrescriptionID.Location = new System.Drawing.Point(116, 111);
            this.lblPrescriptionID.Name = "lblPrescriptionID";
            this.lblPrescriptionID.Size = new System.Drawing.Size(79, 13);
            this.lblPrescriptionID.TabIndex = 7;
            this.lblPrescriptionID.Text = "Prescription ID:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(132, 137);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(60, 13);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time Filled:";
            // 
            // frmFulfillment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblPrescriptionID);
            this.Controls.Add(this.dgvRefills);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.txtPrescriptionID);
            this.Name = "frmFulfillment";
            this.Text = "frmFulfillment";
            this.Load += new System.EventHandler(this.frmFulfillment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPrescriptionID;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DataGridView dgvRefills;
        private System.Windows.Forms.Label lblPrescriptionID;
        private System.Windows.Forms.Label lblTime;
    }
}