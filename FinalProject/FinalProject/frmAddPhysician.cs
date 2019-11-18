using System;
using System.Data;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmAddPhysician : Form
    {
        public frmAddPhysician()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearEPV()
        {
            epv.SetError(txtFName, "");
            epv.SetError(txtMInit, "");
            epv.SetError(txtLName, "");
            epv.SetError(txtOffice, "");
            epv.SetError(txtPhoneNum, "");
            epv.SetError(txtLicenseNum, "");
        }
        private void EnableButton()
        {
            if (string.IsNullOrEmpty(txtFName.Text))
            {
                btnAdd.Enabled = false;
                ClearEPV();
                epv.SetError(txtFName,"Enter a proper first name.");
            }
            else if (string.IsNullOrEmpty(txtMInit.Text))
            {
                btnAdd.Enabled = false;
                ClearEPV();
                epv.SetError(txtMInit,"Enter a proper middle initial.");
            }
            else if (string.IsNullOrEmpty(txtLName.Text))
            {
                btnAdd.Enabled = false;
                ClearEPV();
                epv.SetError(txtLName,"Enter a proper last name.");
            }
            else if (string.IsNullOrEmpty(txtOffice.Text))
            {
                btnAdd.Enabled = false;
                ClearEPV();
                epv.SetError(txtOffice,"Enter a proper office name.");
            }
            else if (string.IsNullOrEmpty(txtPhoneNum.Text) || txtPhoneNum.TextLength != 10)
            {
                btnAdd.Enabled = false;
                ClearEPV();
                epv.SetError(txtPhoneNum,"Enter a proper 10 digit phone number.");
            }
            else if (string.IsNullOrEmpty(txtLicenseNum.Text) || txtLicenseNum.TextLength != 6)
            {
                btnAdd.Enabled = false;
                ClearEPV();
                epv.SetError(txtLicenseNum,"Please insert a 6 digit license number");
            }
            else
            {
                ClearEPV();
                btnAdd.Enabled = true;

            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //prompts the user
                var confirmResult = MessageBox.Show("Are you sure you want to add this physician?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                    DataSet ds1 = new DataSet();
                    ds1 = bPharm.AddPhysicians(fName, mInit, lName, office, phoneNum, licenseNum);
                    MessageBox.Show("Physician succesfully added.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmAddPhysician_Load(object sender, EventArgs e)
        {

        }

        private void txtLicenseNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //makes sure only a number is entered
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //makes sure only a number is entered
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMInit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //makes sure only a single character is entered
            if (txtMInit.TextLength > 0)
            {

                txtMInit.Text = "";
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
    }
}
