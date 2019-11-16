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

        private void frmPatientPrescription_Load(object sender, EventArgs e)
        {
            
            cboState.DataSource = StateManager.getStates();
            cboState.DisplayMember = "abbreviation";
            cboState.ValueMember = "abbreviation";
            myPatientID = frmSearchPrescriptions.myID;
            PharmacyDataTier aPharm = new PharmacyDataTier();
            DataSet ds = new DataSet();

            ds = aPharm.GetPatient("", "", myPatientID);

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

            DataSet ds1 = new DataSet();
            ds1 = aPharm.GetPrescription(frmSearchPrescriptions.myID);

            dgvPrescriptions.DataSource = ds1.Tables[0];


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string patientID = txtPatientID.Text.Trim();
                string fName = txtFName.Text.Trim();
                string lName = txtLName.Text.Trim();
                string mInit = txtMInit.Text.Trim();
                DateTime DOB = DateTime.Parse(txtDOB.Text.Trim());

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

                PharmacyDataTier bPharm = new PharmacyDataTier();
                DataSet ds1 = new DataSet();
                ds1 = bPharm.UpdatePatient(patientID, fName, lName, mInit, DOB, gender, street1, street2, city, state, zip, homePhone, workPhone, cellPhone, email);
                //MessageBox.Show()
            }
            catch(Exception ex)
            {

            }
        }

        private void dgvPrescriptions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPrescriptions_DoubleClick(object sender, EventArgs e)
        {
            string prescriptionID;
            frmFulfillment eForm = new frmFulfillment();
            eForm.MdiParent = this.MdiParent;

            DataGridViewRow row = dgvPrescriptions.SelectedRows[0];

            //make sure there is a row
            if (dgvPrescriptions.Rows.Count > 0)
            {
                //find which cell was clicked
                //find the value based on position
                prescriptionID = row.Cells[0].Value.ToString();
                myPrescriptionID = prescriptionID;
                eForm.StartPosition = FormStartPosition.CenterScreen;
                eForm.Show();
                eForm.Focus();
            }
        }
    }
}
