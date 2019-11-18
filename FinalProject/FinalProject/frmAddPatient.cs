using System;
using System.Data;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmAddPatient : Form
    {
        public frmAddPatient()
        {
            InitializeComponent();
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
        private void EnableButton()//method to enable or disable the add patient button
        {
            //method to make sure the information is correct before allowing updating of patient info
            if (string.IsNullOrEmpty(txtFName.Text))
            {
                ClearEPV();
                btnAdd.Enabled = false;
                epv.SetError(txtFName, "Insert proper first name");

            }
            else if (string.IsNullOrEmpty(txtMInit.Text))
            {
                ClearEPV();
                btnAdd.Enabled = false;
                epv.SetError(txtMInit, "Insert proper middle initial");
            }
            else if (string.IsNullOrEmpty(txtLName.Text))
            {
                ClearEPV();
                btnAdd.Enabled = false;
                epv.SetError(txtLName, "Insert proper last name");
            }
            else if (!(cboGender.Text.Trim() == "Male" || cboGender.Text.Trim() == "Female"))
            {
                ClearEPV();
                btnAdd.Enabled = false;
                epv.SetError(cboGender, "Insert proper gender");
            }
            else if (string.IsNullOrEmpty(txtStreet1.Text))
            {
                ClearEPV();
                btnAdd.Enabled = false;
                epv.SetError(txtStreet1, "Insert proper street name");
            }
            else if (string.IsNullOrEmpty(txtCity.Text))
            {
                ClearEPV();
                btnAdd.Enabled = false;
                epv.SetError(txtCity, "Insert propery city name");
            }
            else if (string.IsNullOrEmpty(txtZip.Text) || txtZip.TextLength != 5)
            {
                ClearEPV();
                btnAdd.Enabled = false;
                epv.SetError(txtZip, "Insert proper 5 digit zip");
            }
            else if (string.IsNullOrEmpty(txtHomePhone.Text) || txtHomePhone.TextLength != 10)
            {
                ClearEPV();
                btnAdd.Enabled = false;
                epv.SetError(txtHomePhone, "Insert proper 10 digit phone number");
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                ClearEPV();
                btnAdd.Enabled = false;
                epv.SetError(txtEmail, "Insert proper email");
            }
            else
            {
                if (!(txtWorkPhone.TextLength == 10 || txtWorkPhone.TextLength == 0))
                {
                    ClearEPV();
                    btnAdd.Enabled = false;
                    epv.SetError(txtWorkPhone, "Insert proper 10 digit phone number");
                }
                else if (!(txtCellPhone.TextLength == 0 || txtCellPhone.TextLength == 10))
                {
                    ClearEPV();
                    btnAdd.Enabled = false;
                    epv.SetError(txtCellPhone, "Insert proper 10 digit phone number");
                }
                else
                {

                    ClearEPV();
                    btnAdd.Enabled = true;
                        

                    
                }
            }
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //obtains all the necessary information from the user inputs
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

                //sends the information to the datatier
                PharmacyDataTier bPharm = new PharmacyDataTier();
                DataSet ds1 = new DataSet();
                ds1 = bPharm.AddPatient(fName, lName, mInit, DOB, gender, street1, street2, city, state, zip, homePhone, workPhone, cellPhone, email);
                MessageBox.Show("Patient succesfully added.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmAddPatient_Load(object sender, EventArgs e)
        {
            //fills the state combo box
            cboState.DataSource = StateManager.getStates();
            cboState.DisplayMember = "abbreviation";
            cboState.ValueMember = "abbreviation";
            
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

        private void txtDOB_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void txtStreet1_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void txtMInit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allows one character in the middle initial
            if (txtMInit.TextLength > 0)
            {
                txtMInit.Text = "";
            }
        }

        private void txtZip_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allows numbers in the text box
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHomePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allows numbers in the text box
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtWorkPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allows numbers in the text box
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCellPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allows numbers in the text box
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtWorkPhone_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void txtCellPhone_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
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
