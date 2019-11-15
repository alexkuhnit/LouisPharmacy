using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FinalProject
{
    public partial class frmAddPrescription : Form
    {
        public frmAddPrescription()
        {
            InitializeComponent();
        }

        private void FillDrugCombo()
        {
            string connString;
            SqlConnection conn;
            connString = "Data Source=DESKTOP-G73GIKA; initial catalog=pharmacy; integrated security=SSPI;";
            conn = new SqlConnection(connString);
            SqlCommand cmdString = new SqlCommand("Select productName + ', ' + strength + ', ' + convert(varchar(11), amount) + ' Pills, NDC Code ' + NDCPackageCode as combo , NDCPackageCode from [dbo].[drug]", conn);

            //SqlCommand cmdString = new SqlCommand("Select productName + ' NDC Code ' + NDCPackageCode as combo, NDCPackageCode from [dbo].[drug]", conn);
            conn.Open();
            SqlDataReader reader;
            reader = cmdString.ExecuteReader();
            DataTable dt = new DataTable();
            cboDrug.DataSource = dt;
            dt.Load(reader);
            cboDrug.DisplayMember = "combo";
            cboDrug.ValueMember = "NDCPackageCode";
        }
        private void FillPhysicianCombo()
        {
            string connString;
            SqlConnection conn;
            connString = "Data Source=DESKTOP-G73GIKA; initial catalog=pharmacy; integrated security=SSPI;";
            conn = new SqlConnection(connString);
            SqlCommand cmdString = new SqlCommand("Select lName + ', ' + mInit + ', ' + fName + ' , ID Code ' + convert(varchar(11), PhysicianID) as combo , PhysicianID from [dbo].[physician]", conn);

            //SqlCommand cmdString = new SqlCommand("Select productName + ' NDC Code ' + NDCPackageCode as combo, NDCPackageCode from [dbo].[drug]", conn);
            conn.Open();
            SqlDataReader reader;
            reader = cmdString.ExecuteReader();
            DataTable dt = new DataTable();
            cboPhysicianID.DataSource = dt;
            dt.Load(reader);
            cboPhysicianID.DisplayMember = "combo";
            cboPhysicianID.ValueMember = "physicianID";
        }
        private void FillPatientCombo()
        {
            string connString;
            SqlConnection conn;
            connString = "Data Source=DESKTOP-G73GIKA; initial catalog=pharmacy; integrated security=SSPI;";
            conn = new SqlConnection(connString);
            SqlCommand cmdString = new SqlCommand("Select lName + ', ' + mInit + ', ' + fName + ' , ID Code ' + convert(varchar(11), patientid) as combo , patientid from [dbo].[patient]", conn);

            //SqlCommand cmdString = new SqlCommand("Select productName + ' NDC Code ' + NDCPackageCode as combo, NDCPackageCode from [dbo].[drug]", conn);
            conn.Open();
            SqlDataReader reader;
            reader = cmdString.ExecuteReader();
            DataTable dt = new DataTable();
            cboPatientID.DataSource = dt;
            dt.Load(reader);
            cboPatientID.DisplayMember = "combo";
            cboPatientID.ValueMember = "patientID";
        }

        private void frmAddPrescription_Load(object sender, EventArgs e)
        {
            FillDrugCombo();
            FillPhysicianCombo();
            FillPatientCombo();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cboPhysicianID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblRefills_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get the values
            string patientID = cboPatientID.SelectedValue.ToString();
            string physicianID = cboPhysicianID.SelectedValue.ToString();
            string NDCPackageCode = cboDrug.SelectedValue.ToString();
            string totalRefills = txtRefill.Text.Trim();
            DateTime time = DateTime.Parse(txtDate.Text.Trim());

            //Send it throug the datatier
            PharmacyDataTier bPharm = new PharmacyDataTier();
            DataSet ds1 = new DataSet();
            ds1 = bPharm.AddPrescription( NDCPackageCode,  patientID,  physicianID,  totalRefills,  time);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
