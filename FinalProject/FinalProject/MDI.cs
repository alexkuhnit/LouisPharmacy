using System;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void physicianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddPhysician aForm = new frmAddPhysician();
            aForm.MdiParent = this;
            aForm.StartPosition = FormStartPosition.CenterScreen;
            aForm.Show();
            aForm.Focus();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddPatient bForm = new frmAddPatient();
            bForm.MdiParent = this;
            bForm.StartPosition = FormStartPosition.CenterScreen;
            bForm.Show();
            bForm.Focus();
        }

        private void prescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddPrescription cForm = new frmAddPrescription();
            cForm.MdiParent = this;
            cForm.StartPosition = FormStartPosition.CenterScreen;
            cForm.Show();
            cForm.Focus();
        }

        private void mnuSearchPatient_Click(object sender, EventArgs e)
        {
            frmSearchPrescriptions dForm = new frmSearchPrescriptions();
            dForm.MdiParent = this;
            dForm.StartPosition = FormStartPosition.CenterScreen;
            dForm.Show();
            dForm.Focus();
        }

        private void physicianToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmSearchPhysician eForm = new frmSearchPhysician();
            eForm.MdiParent = this;
            eForm.StartPosition = FormStartPosition.CenterScreen;
            eForm.Show();
            eForm.Focus();
        }
    }
}
