using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmAddPatient : Form
    {
        public frmAddPatient()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string fName = txtFName.Text.Trim();
            string lName = txtLName.Text.Trim();
            string mInit = txtMInit.Text.Trim();
            DateTime DOB = DateTime.Parse(txtDOB.Text.Trim());

            string gender = cboGender.Text.Trim();
            string street1 = txtStreet1.Text.Trim();
            string street2 = txtStreet2.Text.Trim();
            string city = txtCity.Text.Trim();

            string state = txtState.Text.Trim();
            string zip = txtZip.Text.Trim();
            string homePhone = txtHomePhone.Text.Trim();
            string workPhone = txtWorkPhone.Text.Trim();

            string cellPhone = txtCellPhone.Text.Trim();
            string email = txtEmail.Text.Trim();

            PharmacyDataTier bPharm = new PharmacyDataTier();
            DataSet ds1 = new DataSet();
            ds1 = bPharm.AddPatient( fName,  lName,  mInit,  DOB,gender,  street1,  street2,  city,state,  zip,  homePhone,  workPhone, cellPhone, email);
        }
    }
}
