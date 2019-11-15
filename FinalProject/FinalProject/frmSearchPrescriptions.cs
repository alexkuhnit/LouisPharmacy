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
    public partial class frmSearchPrescriptions : Form
    {
        public frmSearchPrescriptions()
        {
            InitializeComponent();
        }
        public static string myID;

        private void frmSearchPrescriptions_Load(object sender, EventArgs e)
        {
            //Fill patient datagrid
            PharmacyDataTier bPharm = new PharmacyDataTier();
            DataSet ds1 = new DataSet();
            ds1 = bPharm.FillPatient();

            dgvPatients.DataSource = ds1.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //get the values
            string fname = txtPatientFName.Text.Trim();
            string lname = txtPatientLName.Text.Trim();
            string patientID = txtPatientID.Text.Trim();

            //Fill patient datagrid
            PharmacyDataTier bPharm = new PharmacyDataTier();
            DataSet ds1 = new DataSet();
            ds1 = bPharm.GetPatient(fname, lname, patientID);

            dgvPatients.DataSource = ds1.Tables[0];
        }

        private void frmSearchPrescriptions_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dgvPatients_DoubleClick(object sender, EventArgs e)
        {
            string patientID;
            frmPatientPrescription eForm = new frmPatientPrescription();
            eForm.MdiParent = this.MdiParent;

            DataGridViewRow row = dgvPatients.SelectedRows[0];

            //make sure there is a row
            if (dgvPatients.Rows.Count > 0)
            {
                //find which cell was clicked
                //find the value based on position
                patientID = row.Cells[0].Value.ToString();
                myID = patientID;
                eForm.StartPosition = FormStartPosition.CenterScreen;
                eForm.Show();
                eForm.Focus();
            }
        }
    }
}
