using System;
using System.Data;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmSearchPhysician : Form
    {
        public frmSearchPhysician()
        {
            InitializeComponent();
        }
        //declare a public string for new forms to reference
        public static string myPhysicianID;

        private void frmSearchPhysician_Load(object sender, EventArgs e)
        {
            //fill the data grid with all of the physicians
            PharmacyDataTier bPharm = new PharmacyDataTier();
            DataSet ds1 = new DataSet();
            ds1 = bPharm.GetPhysician("", "", "");

            dgvPatients.DataSource = ds1.Tables[0];
            dgvPatients.AutoResizeColumns();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //get the values
                string fname = txtPhysicianFName.Text.Trim();
                string lname = txtPhysicianLName.Text.Trim();
                string physicianID = txtPhysicianID.Text.Trim();

                //Fill patient datagrid
                PharmacyDataTier bPharm = new PharmacyDataTier();
                DataSet ds1 = new DataSet();
                ds1 = bPharm.GetPhysician(fname, lname, physicianID);

                dgvPatients.DataSource = ds1.Tables[0];
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

        private void dgvPatients_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //gets the physician ID from the selected row and opens a new form for updating
                string physicianID;
                frmUpdatePhysician eForm = new frmUpdatePhysician();
                eForm.MdiParent = this.MdiParent;

                DataGridViewRow row = dgvPatients.SelectedRows[0];

                //make sure there is a row
                if (dgvPatients.Rows.Count > 0)
                {
                    //find which cell was clicked
                    //find the value based on position
                    physicianID = row.Cells[0].Value.ToString();
                    myPhysicianID = physicianID;
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

        private void frmSearchPhysician_Activated(object sender, EventArgs e)
        {
            try
            {
                //get the values
                string fname = txtPhysicianFName.Text.Trim();
                string lname = txtPhysicianLName.Text.Trim();
                string physicianID = txtPhysicianID.Text.Trim();

                //Fill patient datagrid
                PharmacyDataTier bPharm = new PharmacyDataTier();
                DataSet ds1 = new DataSet();
                ds1 = bPharm.GetPhysician(fname, lname, physicianID);

                dgvPatients.DataSource = ds1.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddPhysician_Click(object sender, EventArgs e)
        {
            frmAddPhysician aForm = new frmAddPhysician();
            aForm.MdiParent = this.MdiParent;
            aForm.StartPosition = FormStartPosition.CenterScreen;
            aForm.Show();
            aForm.Focus();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //gets the physician ID from the selected row and opens a new form for updating
                string physicianID;
                frmUpdatePhysician eForm = new frmUpdatePhysician();
                eForm.MdiParent = this.MdiParent;

                DataGridViewRow row = dgvPatients.SelectedRows[0];

                //make sure there is a row
                if (dgvPatients.Rows.Count > 0)
                {
                    //find which cell was clicked
                    //find the value based on position
                    physicianID = row.Cells[0].Value.ToString();
                    myPhysicianID = physicianID;
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
            try
            {
                var confirmResult = MessageBox.Show("This will also delete all prescriptions and refills attached to this physician. Are you sure you want to delete this physician?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    DataGridViewRow row = dgvPatients.SelectedRows[0];
                    myPhysicianID = row.Cells[0].Value.ToString();
                    //Send it throug the datatier
                    PharmacyDataTier bPharm = new PharmacyDataTier();
                    DataSet ds2 = new DataSet();
                    ds2 = bPharm.DeletePhysician(myPhysicianID);
                    MessageBox.Show("Physician succesfully deleted.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        //get the values
                        string fname = txtPhysicianFName.Text.Trim();
                        string lname = txtPhysicianLName.Text.Trim();
                        string physicianID = txtPhysicianID.Text.Trim();

                        //Fill patient datagrid
                        DataSet ds1 = new DataSet();
                        ds1 = bPharm.GetPhysician(fname, lname, physicianID);

                        dgvPatients.DataSource = ds1.Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
