using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace FinalProject
{
    public partial class frmAddPrescription : Form
    {
        public frmAddPrescription()
        {
            InitializeComponent();
        }

        string myPatientID;
        private void FillDrugCombo()
        {
            try
            {
                PharmacyDataTier bPharm = new PharmacyDataTier();
                DataSet ds1 = new DataSet();
                ds1 = bPharm.FillCBODrug();

                //filling combobox
                cboDrug.DataSource = ds1.Tables[0];
                cboDrug.DisplayMember = "combo";
                cboDrug.ValueMember = "NDCPackageCode";
            }
            catch (Exception ex)
            {

            }
            
        }
        private void FillPhysicianCombo()
        {
            try
            {
                PharmacyDataTier bPharm = new PharmacyDataTier();
                DataSet ds1 = new DataSet();
                ds1 = bPharm.FillCBOPhysician();

                //filling combobox
                cboPhysicianID.DataSource = ds1.Tables[0];
                cboPhysicianID.DisplayMember = "combo";
                cboPhysicianID.ValueMember = "physicianID";
            }
            catch (Exception ex)
            {

            }
            
        }
        private void FillPatientCombo()
        {
            try
            {
                PharmacyDataTier bPharm = new PharmacyDataTier();
                DataSet ds1 = new DataSet();
                ds1 = bPharm.FillCBOPatient(myPatientID);

                //filling combobox
                txtPatientID.Text = ds1.Tables[0].Rows[0]["combo"].ToString().Trim();
            }
            catch(Exception ex)
            {

            }
            
        }

        private void frmAddPrescription_Load(object sender, EventArgs e)
        {
            myPatientID = frmPatientPrescription.myPatientID;
            if (myPatientID == null)
            {
                this.Close();
            }
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
            try
            {
                EPV.SetError(cboDrug, "");
                EPV.SetError(cboPhysicianID, "");
                string physicianID = cboPhysicianID.SelectedValue.ToString();
                try
                {
                    //get the values

                    string NDCPackageCode = cboDrug.SelectedValue.ToString();
                    string totalRefills = txtRefill.Text.Trim();
                    DateTime time = dtpDatePrescribed.Value;

                    //Send it throug the datatier
                    PharmacyDataTier bPharm = new PharmacyDataTier();
                    DataSet ds1 = new DataSet();
                    ds1 = bPharm.AddPrescription(NDCPackageCode, myPatientID, physicianID, totalRefills, time);
                    MessageBox.Show("Prescription succesfully added.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception )
                {
                    EPV.SetError(cboDrug, "must select a drug from the list");
                        MessageBox.Show("Must select a drug in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

            }
            catch (Exception)
            {
                EPV.SetError(cboPhysicianID, "Must select a physician from the list");
                MessageBox.Show("Must select a physician in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRefill_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allows numbers in txtRefill
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRefill_TextChanged(object sender, EventArgs e)
        {
            //disables the button if the refills is less than 0
            try
            {
                if (int.Parse(txtRefill.Text.Trim()) > 0)
                {
                    EPV.SetError(txtRefill, "");
                    btnAdd.Enabled = true;
                }
                else
                {
                    EPV.SetError(txtRefill, "Must have one or more fulfillments");
                    btnAdd.Enabled = false;
                }
            }
            catch (Exception)
            {
                EPV.SetError(txtRefill, "Must have one or more fulfillments");
                btnAdd.Enabled = false;
            }

        }
    }
}
