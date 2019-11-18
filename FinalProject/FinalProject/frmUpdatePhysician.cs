using System;
using System.Data;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmUpdatePhysician : Form
    {
        public frmUpdatePhysician()
        {
            InitializeComponent();
        }
        string myPhysicianID;
        private void EnableButton()
        {
            if (string.IsNullOrEmpty(txtFName.Text) || string.IsNullOrEmpty(txtMInit.Text) || string.IsNullOrEmpty(txtLName.Text) || string.IsNullOrEmpty(txtOffice.Text) ||
                string.IsNullOrEmpty(txtLicenseNum.Text) || string.IsNullOrEmpty(txtPhoneNum.Text)
                || txtPhoneNum.TextLength != 10 || txtLicenseNum.TextLength != 6)
            {
                btnUpdate.Enabled = false;
            }
            else
            {

                btnUpdate.Enabled = true;

            }
        }
        private void frmUpdatePhysician_Load(object sender, EventArgs e)
        {
            try
            {
                myPhysicianID = frmSearchPhysician.myPhysicianID;
                PharmacyDataTier aPharm = new PharmacyDataTier();
                DataSet ds = new DataSet();

                ds = aPharm.GetPhysician("", "", myPhysicianID);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtPhysicianID.Text = ds.Tables[0].Rows[0]["Physician ID"].ToString().Trim();

                    txtFName.Text = ds.Tables[0].Rows[0]["First Name"].ToString().Trim();
                    txtMInit.Text = ds.Tables[0].Rows[0]["Middle Initial"].ToString().Trim();
                    txtLName.Text = ds.Tables[0].Rows[0]["Last Name"].ToString().Trim();

                    txtOffice.Text = ds.Tables[0].Rows[0]["Office"].ToString().Trim();
                    txtPhoneNum.Text = ds.Tables[0].Rows[0]["Phone Number"].ToString().Trim();
                    txtLicenseNum.Text = ds.Tables[0].Rows[0]["License Number"].ToString().Trim();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtOffice_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void txtPhoneNum_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void txtLicenseNum_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void txtMInit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtMInit.TextLength > 0)
            {
                txtMInit.Text = "";
            }
        }

        private void txtPhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLicenseNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("Are you sure you want to update this physician?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    //get the values
                    string fName = txtFName.Text.Trim();
                    string mInit = txtMInit.Text.Trim();
                    string lName = txtLName.Text.Trim();
                    string office = txtOffice.Text.Trim();
                    string phoneNum = txtPhoneNum.Text.Trim();
                    int licenseNum = int.Parse(txtLicenseNum.Text.Trim());

                    //Send it throug the datatier
                    PharmacyDataTier bPharm = new PharmacyDataTier();
                    DataSet ds2 = new DataSet();
                    ds2 = bPharm.UpdatePhysicians(myPhysicianID, fName, mInit, lName, office, phoneNum, licenseNum);
                    MessageBox.Show("Physician succesfully updated.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmResult = MessageBox.Show("This will also delete all prescriptions and refills attached to this physician. Are you sure you want to delete this physician?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    //Send it throug the datatier
                    PharmacyDataTier bPharm = new PharmacyDataTier();
                    DataSet ds2 = new DataSet();
                    ds2 = bPharm.DeletePhysician(myPhysicianID);
                    MessageBox.Show("Physician succesfully deleted.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
