using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomDrugTest
{
    public partial class FRM_GENERATOR : MaterialForm
    {
        public FRM_GENERATOR()
        {
            InitializeComponent();
        }

        private void FRM_GENERATOR_Load(object sender, EventArgs e)
        {

        }

        private void btnMDProceed_Click(object sender, EventArgs e)
        {
            Global.testGeneratedBy = this.txtMDNameOfGenerator.Text;
            this.Hide();
            FRM_HOWMANY frmHowMany = new FRM_HOWMANY();
            frmHowMany.ShowDialog(this);
        }

        private void btnMDMaybeLater_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_HOWMANY frmHowMany = new FRM_HOWMANY();
            frmHowMany.ShowDialog(this);
        }
    }
}
