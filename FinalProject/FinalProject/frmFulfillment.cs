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

            ds = aPharm.GetPrescriptionPID(myPrescriptionID);

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtPrescriptionID.Text = ds.Tables[0].Rows[0]["prescriptionID"].ToString().Trim();
            }

            DataSet ds1 = new DataSet();
            ds1 = aPharm.GetRefills(myPrescriptionID);

            dgvRefills.DataSource = ds1.Tables[0];
        }
    }
}
