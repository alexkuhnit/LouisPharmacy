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
    public partial class frmFulfillment : Form
    {
        public frmFulfillment()
        {
            InitializeComponent();
        }
        string myPrescriptionID;
        private void frmFulfillment_Load(object sender, EventArgs e)
        {
            myPrescriptionID = frmPatientPrescription.myPrescriptionID;
            PharmacyDataTier aPharm = new PharmacyDataTier();
            DataSet ds = new DataSet();

            ds = aPharm.GetPatient("", "", myPrescriptionID);

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtPatientID.Text = ds.Tables[0].Rows[0]["patientID"].ToString().Trim();

                txtFName.Text = ds.Tables[0].Rows[0]["fName"].ToString().Trim();
                txtMInit.Text = ds.Tables[0].Rows[0]["lName"].ToString().Trim();
                txtLName.Text = ds.Tables[0].Rows[0]["mInit"].ToString().Trim();
                txtDOB.Text = ds.Tables[0].Rows[0]["DOB"].ToString().Trim().Substring(0, 10);

                cboGender.Text = ds.Tables[0].Rows[0]["gender"].ToString().Trim();
                txtStreet1.Text = ds.Tables[0].Rows[0]["street1"].ToString().Trim();
                txtStreet2.Text = ds.Tables[0].Rows[0]["street2"].ToString().Trim();
                txtCity.Text = ds.Tables[0].Rows[0]["city"].ToString().Trim();

                cboState.Text = ds.Tables[0].Rows[0]["state"].ToString().Trim();
                txtZip.Text = ds.Tables[0].Rows[0]["zip"].ToString().Trim();
                txtHomePhone.Text = ds.Tables[0].Rows[0]["homePhone"].ToString().Trim();
                txtWorkPhone.Text = ds.Tables[0].Rows[0]["workPhone"].ToString().Trim();

                txtCellPhone.Text = ds.Tables[0].Rows[0]["cellPhone"].ToString().Trim();
                txtEmail.Text = ds.Tables[0].Rows[0]["email"].ToString().Trim();
            }
        }
    }
}
