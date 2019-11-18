using System;
using System.Data;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmSearchPrescriptions : Form
    {
        public frmSearchPrescriptions()
        {
            InitializeComponent();
        }
        //declare a public string for new forms to reference
        public static string myID;

        private void frmSearchPrescriptions_Load(object sender, EventArgs e)
        {
            //Fill patient datagrid
            PharmacyDataTier bPharm = new PharmacyDataTier();
            DataSet ds1 = new DataSet();
            ds1 = bPharm.FillPatient();

            dgvPatients.DataSource = ds1.Tables[0];
            dgvPatients.AutoResizeColumns();
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
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmSearchPrescriptions_Activated(object sender, EventArgs e)
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

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            frmAddPatient bForm = new frmAddPatient();
            bForm.MdiParent = this.MdiParent;
            bForm.StartPosition = FormStartPosition.CenterScreen;
            bForm.Show();
            bForm.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("This will also delete all prescriptions and refills attached to this patient. Are you sure you want to delete this patient?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    DataGridViewRow row = dgvPatients.SelectedRows[0];
                    string patientID;
                    patientID = row.Cells[0].Value.ToString();
                    //Send it throug the datatier
                    PharmacyDataTier bPharm = new PharmacyDataTier();
                    DataSet ds1 = new DataSet();
                    ds1 = bPharm.DeletePatient(patientID);
                    MessageBox.Show("Patient deleted successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        //get the values
                        string fname = txtPatientFName.Text.Trim();
                        string lname = txtPatientLName.Text.Trim();
                        string patientID2 = txtPatientID.Text.Trim();

                        //Fill patient datagrid
                        PharmacyDataTier cPharm = new PharmacyDataTier();
                        DataSet ds2 = new DataSet();
                        ds1 = bPharm.GetPatient(fname, lname, patientID2);

                        dgvPatients.DataSource = ds1.Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
