using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmPatientPrescription : Form
    {
        public frmPatientPrescription()
        {
            InitializeComponent();
        }
        public static string myPrescriptionID;
        public static string myPatientID;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPatient_Click(object sender, EventArgs e)
        {

        }
        
        
        private void UpdatePrescriptionDGV()
        {
            //method that updates the datagrid
            PharmacyDataTier aPharm = new PharmacyDataTier();
            DataSet ds1 = new DataSet();
            ds1 = aPharm.GetPrescription(frmSearchPrescriptions.myID);
            dgvPrescriptions.DataSource = ds1.Tables[0];
        }

        private void frmPatientPrescription_Load(object sender, EventArgs e)
        {
            try
            {
                //fills the state combo box
                cboState.DataSource = StateManager.getStates();
                cboState.DisplayMember = "abbreviation";
                cboState.ValueMember = "abbreviation";
                //gets the patient ID from the previous form
                myPatientID = frmSearchPrescriptions.myID;
                //fills the boxes with current patient information
                PharmacyDataTier aPharm = new PharmacyDataTier();
                DataSet ds = new DataSet();

                ds = aPharm.GetPatient("", "", myPatientID);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtPatientID.Text = ds.Tables[0].Rows[0]["Patient ID"].ToString().Trim();

                    txtFName.Text = ds.Tables[0].Rows[0]["First Name"].ToString().Trim();
                    txtMInit.Text = ds.Tables[0].Rows[0]["Middle Initial"].ToString().Trim();
                    txtLName.Text = ds.Tables[0].Rows[0]["Last Name"].ToString().Trim();
                    dtpDOB.Value = DateTime.Parse(ds.Tables[0].Rows[0]["Date of Birth"].ToString().Trim());

                    cboGender.Text = ds.Tables[0].Rows[0]["Gender"].ToString().Trim();
                    txtStreet1.Text = ds.Tables[0].Rows[0]["Street 1"].ToString().Trim();
                    txtStreet2.Text = ds.Tables[0].Rows[0]["Street 2"].ToString().Trim();
                    txtCity.Text = ds.Tables[0].Rows[0]["City"].ToString().Trim();

                    cboState.SelectedValue = ds.Tables[0].Rows[0]["State"].ToString().Trim();
                    txtZip.Text = ds.Tables[0].Rows[0]["zip"].ToString().Trim();
                    txtHomePhone.Text = ds.Tables[0].Rows[0]["Home Phone"].ToString().Trim();
                    txtWorkPhone.Text = ds.Tables[0].Rows[0]["Work Phone"].ToString().Trim();

                    txtCellPhone.Text = ds.Tables[0].Rows[0]["Cell Phone"].ToString().Trim();
                    txtEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString().Trim();
                }
                //fills the datagrid
                UpdatePrescriptionDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void ClearEPV()//clears all errors
        {
            epv.SetError(txtFName, "");
            epv.SetError(txtMInit, "");
            epv.SetError(txtLName, "");
            epv.SetError(txtStreet1, "");
            epv.SetError(txtCity, "");
            epv.SetError(txtZip, "");
            epv.SetError(txtHomePhone, "");
            epv.SetError(txtEmail, "");
            epv.SetError(txtWorkPhone, "");
            epv.SetError(txtCellPhone, "");
            epv.SetError(cboGender, "");
        }
        private void EnableButton()
        {
            //method to make sure the information is correct before allowing updating of patient info
            if (string.IsNullOrEmpty(txtFName.Text))
            {
                ClearEPV();
                btnUpdate.Enabled = false;
                epv.SetError(txtFName, "Insert proper first name");

            }
            else if (string.IsNullOrEmpty(txtMInit.Text))
            {
                ClearEPV();
                btnUpdate.Enabled = false;
                epv.SetError(txtMInit, "Insert proper middle initial");
            }
            else if (string.IsNullOrEmpty(txtLName.Text))
            {
                ClearEPV();
                btnUpdate.Enabled = false;
                epv.SetError(txtLName, "Insert proper last name");
            }
            else if (string.IsNullOrEmpty(txtStreet1.Text))
            {
                ClearEPV();
                btnUpdate.Enabled = false;
                epv.SetError(txtStreet1, "Insert proper street name");
            }
            else if (string.IsNullOrEmpty(txtCity.Text))
            {
                ClearEPV();
                btnUpdate.Enabled = false;
                epv.SetError(txtCity, "Insert propery city name");
            }
            else if (string.IsNullOrEmpty(txtZip.Text) || txtZip.TextLength != 5)
            {
                ClearEPV();
                btnUpdate.Enabled = false;
                epv.SetError(txtZip, "Insert proper 5 digit zip");
            }
            else if (string.IsNullOrEmpty(txtHomePhone.Text )|| txtHomePhone.TextLength != 10)
            {
                ClearEPV();
                btnUpdate.Enabled = false;
                epv.SetError(txtHomePhone, "Insert proper 10 digit phone number");
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                ClearEPV();
                btnUpdate.Enabled = false;
                epv.SetError(txtEmail, "Insert proper email");
            }
            else
            {
                if (!(txtWorkPhone.TextLength == 10 || txtWorkPhone.TextLength == 0))
                {
                    ClearEPV();
                    btnUpdate.Enabled = false;
                    epv.SetError(txtWorkPhone, "Insert proper 10 digit phone number");
                }
                else if (!(txtCellPhone.TextLength == 0 || txtCellPhone.TextLength == 10))
                {
                    ClearEPV();
                    btnUpdate.Enabled = false;
                    epv.SetError(txtCellPhone, "Insert proper 10 digit phone number");
                }
                else
                {
                    if (cboGender.Text.Trim() == "Male" || cboGender.Text.Trim() == "Female")
                    {
                        ClearEPV();
                        btnUpdate.Enabled = true;
                    }
                    else
                    {
                        ClearEPV();
                        btnUpdate.Enabled = false;
                        epv.SetError(cboGender, "Insert proper gender");

                    }
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to update this patient?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    //obtains information from the components
                    string patientID = txtPatientID.Text.Trim();
                    string fName = txtFName.Text.Trim();
                    string lName = txtLName.Text.Trim();
                    string mInit = txtMInit.Text.Trim();
                    DateTime DOB = dtpDOB.Value;

                    string gender = cboGender.Text.Trim();
                    string street1 = txtStreet1.Text.Trim();
                    string street2 = txtStreet2.Text.Trim();
                    string city = txtCity.Text.Trim();

                    string state = cboState.SelectedValue.ToString();
                    string zip = txtZip.Text.Trim();
                    string homePhone = txtHomePhone.Text.Trim();
                    string workPhone = txtWorkPhone.Text.Trim();

                    string cellPhone = txtCellPhone.Text.Trim();
                    string email = txtEmail.Text.Trim();
                    //passes the information into the data tier
                    PharmacyDataTier bPharm = new PharmacyDataTier();
                    DataSet ds1 = new DataSet();
                    ds1 = bPharm.UpdatePatient(patientID, fName, lName, mInit, DOB, gender, street1, street2, city, state, zip, homePhone, workPhone, cellPhone, email);
                    MessageBox.Show("Patient succesfully updated.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }

        }

        private void dgvPrescriptions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPrescriptions_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //opens the update form for prescriptions
                string prescriptionID;
                frmFulfillment eForm = new frmFulfillment();
                eForm.MdiParent = this.MdiParent;

                if (dgvPrescriptions.Rows.Count > 0)
                {
                    DataGridViewRow row = dgvPrescriptions.SelectedRows[0];
                    //find which cell was clicked
                    //find the value based on position
                    prescriptionID = row.Cells[0].Value.ToString();
                    myPrescriptionID = prescriptionID;
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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //opens the update form for prescriptions
                string prescriptionID;
                frmFulfillment eForm = new frmFulfillment();
                eForm.MdiParent = this.MdiParent;

                if (dgvPrescriptions.Rows.Count > 0)
                {
                    DataGridViewRow row = dgvPrescriptions.SelectedRows[0];
                    //find which cell was clicked
                    //find the value based on position
                    prescriptionID = row.Cells[0].Value.ToString();
                    myPrescriptionID = prescriptionID;
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

        private void chkEnableEdit_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //enables all the components for changing patient info
                txtFName.Enabled = chkEnableEdit.Checked;
                txtMInit.Enabled = chkEnableEdit.Checked;
                txtLName.Enabled = chkEnableEdit.Checked;
                dtpDOB.Enabled = chkEnableEdit.Checked;
                cboGender.Enabled = chkEnableEdit.Checked;
                txtStreet1.Enabled = chkEnableEdit.Checked;
                txtStreet2.Enabled = chkEnableEdit.Checked;
                txtCity.Enabled = chkEnableEdit.Checked;
                cboState.Enabled = chkEnableEdit.Checked;
                txtZip.Enabled = chkEnableEdit.Checked;
                txtHomePhone.Enabled = chkEnableEdit.Checked;
                txtWorkPhone.Enabled = chkEnableEdit.Checked;
                txtCellPhone.Enabled = chkEnableEdit.Checked;
                txtEmail.Enabled = chkEnableEdit.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmPatientPrescription_Activated(object sender, EventArgs e)
        {
            UpdatePrescriptionDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("This will also delete all prescriptions and refills attached to this patient. Are you sure you want to delete this patient?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    //Send it throug the datatier
                    PharmacyDataTier bPharm = new PharmacyDataTier();
                    DataSet ds1 = new DataSet();
                    ds1 = bPharm.DeletePatient(myPatientID);
                    MessageBox.Show("Patient deleted successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            try
            {
                //opens add prescription form
                frmAddPrescription cForm = new frmAddPrescription();
                cForm.MdiParent = this.MdiParent;
                cForm.StartPosition = FormStartPosition.CenterScreen;
                cForm.Show();
                cForm.Focus();
            }
            catch (Exception ex)
            {
                string myException = ex.ToString();
                MessageBox.Show(myException, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMInit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allows one character in minit box
            if (txtMInit.TextLength > 0)
            {
                txtMInit.Text = "";
            }
        }

        private void txtHomePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtWorkPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCellPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtZip_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allow numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void txtMInit_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void txtStreet1_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void txtStreet2_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void txtZip_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void txtHomePhone_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void txtWorkPhone_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void txtCellPhone_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void btnUpdatePrescription_Click(object sender, EventArgs e)
        {
            try
            {
                string prescriptionID;
                frmFulfillment eForm = new frmFulfillment();
                eForm.MdiParent = this.MdiParent;

                

                //make sure there is a row
                if (dgvPrescriptions.Rows.Count > 0)
                {
                    DataGridViewRow row = dgvPrescriptions.SelectedRows[0];
                    //find which cell was clicked
                    //find the value based on position
                    prescriptionID = row.Cells[0].Value.ToString();
                    myPrescriptionID = prescriptionID;
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

        private void btnDeletePrescription_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("This will also delete all fulfillments attached to this prescription. Are you sure you want to delete this prescription?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    if (dgvPrescriptions.Rows.Count > 0)
                    {
                        DataGridViewRow row = dgvPrescriptions.SelectedRows[0];
                        myPrescriptionID = row.Cells[0].Value.ToString();
                        //Send it throug the datatier
                        PharmacyDataTier bPharm = new PharmacyDataTier();
                        DataSet ds1 = new DataSet();
                        ds1 = bPharm.DeletePrescription(myPrescriptionID);
                        MessageBox.Show("Prescription deleted successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdatePrescriptionDGV();
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

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("This will also delete all fulfillments attached to this prescription. Are you sure you want to delete this prescription?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    if (dgvPrescriptions.Rows.Count > 0)
                    {
                        DataGridViewRow row = dgvPrescriptions.SelectedRows[0];
                        myPrescriptionID = row.Cells[0].Value.ToString();
                        //Send it throug the datatier
                        PharmacyDataTier bPharm = new PharmacyDataTier();
                        DataSet ds1 = new DataSet();
                        ds1 = bPharm.DeletePrescription(myPrescriptionID);
                        MessageBox.Show("Prescription deleted successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdatePrescriptionDGV();
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

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void cboGender_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void cboState_TextUpdate(object sender, EventArgs e)
        {
            EnableButton();
        }
    }
}
