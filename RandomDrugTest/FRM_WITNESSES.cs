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
    public partial class FRM_WITNESSES : MaterialForm
    {
        public FRM_WITNESSES()
        {
            InitializeComponent();
        }

        private void FRM_WITNESSES_Load(object sender, EventArgs e)
        {

        }

        private void btnMDProceed_Click(object sender, EventArgs e)
        {

            Global.testWintesses = this.txtMDWitness1.Text + ":" + this.txtMDWitness2.Text;

            this.Hide();
            FRM_GENERATOR frmGenerator = new FRM_GENERATOR();
            frmGenerator.ShowDialog(this);
        }
    }
}
