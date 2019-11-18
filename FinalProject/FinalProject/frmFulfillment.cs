using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmFulfillment : Form
    {
        public frmFulfillment()
        {
            InitializeComponent();
        }
        public static string myPrescriptionID;
        public static string myFulfillmentID;
        string myPatientID;
        private void FillDrugCombo() //Method to fill the Drug Combo box
        {
            try
            {
                PharmacyDataTier bPharm = new PharmacyDataTier();
                DataSet ds1 = new DataSet();
                ds1 = bPharm.FillCBODrug();

                //filling combobox
                cboDrug.DataSource = ds1.Tables[0];
                cboDrug.DisplayMember = "combo";
                cboDrug.ValueMember = "NDCPackageCode";
            }
            catch (Exception ex)
            {

            }

        }
        private void FillPhysicianCombo()//Method to fill the Physician Combo box
        {
            try
            {
                PharmacyDataTier bPharm = new PharmacyDataTier();
                DataSet ds1 = new DataSet();
                ds1 = bPharm.FillCBOPhysician();

                //filling combobox
                cboPhysicianID.DataSource = ds1.Tables[0];
                cboPhysicianID.DisplayMember = "combo";
                cboPhysicianID.ValueMember = "physicianID";
            }
            catch (Exception ex)
            {

            }

        }
        private void FillPatientCombo() //Method to fill the Patient Combo box
        {
            try
            {
                PharmacyDataTier bPharm = new PharmacyDataTier();
                DataSet ds1 = new DataSet();
                ds1 = bPharm.FillCBOPatient(myPatientID);

                //filling combobox
                txtPatientID.Text = ds1.Tables[0].Rows[0]["combo"].ToString().Trim();
            }
            catch (Exception ex)
            {

            }

        }
        private void UpdateRefillDatagrid()
        {
            try
            {
                //Fill the data grid with refills
                PharmacyDataTier aPharm = new PharmacyDataTier();
                DataSet ds1 = new DataSet();
                ds1 = aPharm.GetRefills(myPrescriptionID);

                dgvRefills.DataSource = ds1.Tables[0];
            }
            catch (Exception ex)
            {
                string myException = ex.ToString();
                MessageBox.Show(myException, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void frmFulfillment_Load(object sender, EventArgs e)
        {
            try
            {
                myPatientID = frmPatientPrescription.myPatientID;
                //call combo box filling methods
                FillDrugCombo();
                FillPhysicianCombo();
                FillPatientCombo();

                //Fill the refill and prescription Information
                myPrescriptionID = frmPatientPrescription.myPrescriptionID;
                PharmacyDataTier aPharm = new PharmacyDataTier();
                DataSet ds = new DataSet();

                ds = aPharm.GetPrescriptionPID(myPrescriptionID);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtPrescriptionID.Text = ds.Tables[0].Rows[0]["prescriptionID"].ToString().Trim();
                    cboPhysicianID.SelectedValue = ds.Tables[0].Rows[0]["physicianID"].ToString().Trim();
                    cboDrug.SelectedValue = ds.Tables[0].Rows[0]["NDCPackageCode"].ToString().Trim();
                    dtpPrescribed.Value = DateTime.Parse(ds.Tables[0].Rows[0]["Time"].ToString().Trim());
                    txtRefill.Text = ds.Tables[0].Rows[0]["totalRefills"].ToString().Trim();
                }

                //Fill the data grid with refills
                UpdateRefillDatagrid();
            }
            catch (Exception ex)
            {
                string myException = ex.ToString();
                MessageBox.Show(myException, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void btnAddRefill_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to add this refill?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                    ds1 = bPharm.AddRefill(prescriptionID, time);

                    //Update DataGrid
                    UpdateRefillDatagrid();
                }
                catch (Exception ex)
                {
                    string myException = ex.ToString();
                    if (myException.Contains("No refills remaining"))
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

        private void chkEnableEditing_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Enables the components to edit the prescription
                cboPhysicianID.Enabled = chkEnableEditing.Checked;
                cboDrug.Enabled = chkEnableEditing.Checked;
                dtpPrescribed.Enabled = chkEnableEditing.Checked;
                txtRefill.Enabled = chkEnableEditing.Checked;
                btnUpdate.Enabled = chkEnableEditing.Checked;
            }
            catch (Exception ex)
            {
                string myException = ex.ToString();
                MessageBox.Show(myException, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //prompt
            var confirmResult = MessageBox.Show("Are you sure you want to update this prescription?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    string physicianID = cboPhysicianID.SelectedValue.ToString();
                    try
                    {
                        epv.SetError(cboPhysicianID, "");
                        epv.SetError(cboDrug, "");
                        epv.SetError(txtRefill, "");
                        string NDCPackageCode = cboDrug.SelectedValue.ToString();
                        string totalRefills = txtRefill.Text.Trim();
                        if (int.Parse(totalRefills) > 0)
                        {
                            DateTime time = dtpPrescribed.Value;

                            //Send it throug the datatier
                            PharmacyDataTier bPharm = new PharmacyDataTier();
                            DataSet ds1 = new DataSet();
                            ds1 = bPharm.UpdatePrescription(myPrescriptionID, NDCPackageCode, myPatientID, physicianID, totalRefills, time);
                            MessageBox.Show("prescription sucesfully updated", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            epv.SetError(txtRefill, "Cannot insert a lower than 0 fulfillments");
                            MessageBox.Show("Cannot insert a lower than 1 fulfillments", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        string myException = ex.ToString();
                        if (myException.Contains("Cannot insert a lower Total Refills than refills have been completed"))
                        {
                            epv.SetError(txtRefill, "Cannot insert a lower Total fulfillments than fulfillments have been completed");
                            MessageBox.Show("Cannot insert a lower Total fulfillments than fulfillments have been completed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            epv.SetError(cboDrug, "Must select a drug in the list.");
                            MessageBox.Show("Must select a drug in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception )
                {
                    epv.SetError(cboPhysicianID, "Must select a physician in the list.");
                    MessageBox.Show("Must select a physician in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {

            }


        }

        private void frmFulfillment_Activated(object sender, EventArgs e)
        {
            try
            {
                //checks the datagrid for changes when the form is clicked back onto
                UpdateRefillDatagrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvRefills_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                frmUpdateRefill eForm = new frmUpdateRefill();
                eForm.MdiParent = this.MdiParent;

                if (dgvRefills.Rows.Count > 0)
                {
                    DataGridViewRow row = dgvRefills.SelectedRows[0];
                    //find which cell was clicked
                    //find the value based on position
                    myFulfillmentID = row.Cells[0].Value.ToString();
                    eForm.StartPosition = FormStartPosition.CenterScreen;
                    eForm.Show();
                    eForm.Focus();
                }
                else
                {
                    MessageBox.Show("Please select a row to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("This will also delete all fulfillments attached to this prescription. Are you sure you want to delete this prescription?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {

                    //Send it throug the datatier
                    PharmacyDataTier bPharm = new PharmacyDataTier();
                    DataSet ds1 = new DataSet();
                    ds1 = bPharm.DeletePrescription(myPrescriptionID);
                    MessageBox.Show("prescription sucesfully deleted", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtRefill_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allows numbers in the refills
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRefill_TextChanged(object sender, EventArgs e)
        {
            //checks to make sure the refill is enabled before allowing changes
            if (string.IsNullOrEmpty(txtRefill.Text))
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmUpdateRefill eForm = new frmUpdateRefill();
                eForm.MdiParent = this.MdiParent;

                //make sure there is a row
                if (dgvRefills.Rows.Count > 0)
                {
                    DataGridViewRow row = dgvRefills.SelectedRows[0];
                    //find which cell was clicked
                    //find the value based on position
                    myFulfillmentID = row.Cells[0].Value.ToString();
                    eForm.StartPosition = FormStartPosition.CenterScreen;
                    eForm.Show();
                    eForm.Focus();
                }
                else
                {
                    MessageBox.Show("Please select a row to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this refill?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    if (dgvRefills.Rows.Count > 0)
                    {
                        DataGridViewRow row = dgvRefills.SelectedRows[0];
                        myFulfillmentID = row.Cells[0].Value.ToString();
                        //Send it throug the datatier
                        PharmacyDataTier bPharm = new PharmacyDataTier();
                        DataSet ds1 = new DataSet();
                        ds1 = bPharm.DeleteRefill(myFulfillmentID);
                        MessageBox.Show("Refill deleted successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateRefillDatagrid();
                    }
                    else
                    {
                        MessageBox.Show("Please select a row to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void btnUpdateRefill_Click(object sender, EventArgs e)
        {
            try
            {
                frmUpdateRefill eForm = new frmUpdateRefill();
                eForm.MdiParent = this.MdiParent;

                

                //make sure there is a row
                if (dgvRefills.Rows.Count > 0)
                {
                    DataGridViewRow row = dgvRefills.SelectedRows[0];
                    //find which cell was clicked
                    //find the value based on position
                    myFulfillmentID = row.Cells[0].Value.ToString();
                    eForm.StartPosition = FormStartPosition.CenterScreen;
                    eForm.Show();
                    eForm.Focus();
                }
                else
                {
                    MessageBox.Show("Please select a row to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteRefill_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this refill?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    if (dgvRefills.Rows.Count > 0)
                    {
                        DataGridViewRow row = dgvRefills.SelectedRows[0];
                        myFulfillmentID = row.Cells[0].Value.ToString();
                        //Send it throug the datatier
                        PharmacyDataTier bPharm = new PharmacyDataTier();
                        DataSet ds1 = new DataSet();
                        ds1 = bPharm.DeleteRefill(myFulfillmentID);
                        MessageBox.Show("Refill deleted successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateRefillDatagrid();
                    }
                    else
                    {
                        MessageBox.Show("Please select a row to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                        
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
