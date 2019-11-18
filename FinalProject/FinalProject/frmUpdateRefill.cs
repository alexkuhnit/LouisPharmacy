using System;
using System.Data;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmUpdateRefill : Form
    {
        public frmUpdateRefill()
        {
            InitializeComponent();
        }
        string myFulfillmentID;
        string originalPrescriptionID;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUpdateRefill_Load(object sender, EventArgs e)
        {
            myFulfillmentID = frmFulfillment.myFulfillmentID;
            originalPrescriptionID = frmFulfillment.myPrescriptionID;
            PharmacyDataTier aPharm = new PharmacyDataTier();
            DataSet ds = new DataSet();

            ds = aPharm.GetFulfillment(myFulfillmentID);

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtFulfillmentID.Text = ds.Tables[0].Rows[0]["fulfillmentID"].ToString().Trim();
                txtPrescriptionID.Text = ds.Tables[0].Rows[0]["prescriptionID"].ToString().Trim();
                dtpTime.Value = DateTime.Parse(ds.Tables[0].Rows[0]["Time"].ToString().Trim());
            }
        }

        private void btnUpdateRefill_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to update this refill?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    //get the values
                    string prescriptionID = txtPrescriptionID.Text.Trim();
                    DateTime time = dtpTime.Value;

                    //Send it throug the datatier
                    PharmacyDataTier bPharm = new PharmacyDataTier();
                    DataSet ds1 = new DataSet();
                    ds1 = bPharm.UpdateFulfillment(myFulfillmentID, originalPrescriptionID, prescriptionID, time);
                    MessageBox.Show("Refill updated successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    string myException = ex.ToString();
                    if (myException.Contains("Prescription is out of refills"))
                    {
                        MessageBox.Show("Prescription is out of refills", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(myException, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this refill?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {

                    //Send it throug the datatier
                    PharmacyDataTier bPharm = new PharmacyDataTier();
                    DataSet ds1 = new DataSet();
                    ds1 = bPharm.DeleteRefill(myFulfillmentID);
                    MessageBox.Show("Refill deleted successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    string myException = ex.ToString();
                    MessageBox.Show(myException, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }

        }

        private void txtPrescriptionID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrescriptionID_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrescriptionID.Text))
            {
                btnUpdateRefill.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnUpdateRefill.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
    }
}
