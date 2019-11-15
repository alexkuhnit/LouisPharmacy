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
    }
}
