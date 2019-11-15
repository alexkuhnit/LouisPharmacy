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

        private void btnAdd_Click(object sender, EventArgs e)
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

        }
    }
}
