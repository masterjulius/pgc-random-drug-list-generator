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
    public partial class FRM_HOWMANY : MaterialForm
    {
        public FRM_HOWMANY()
        {
            InitializeComponent();
        }

        private void FRM_HOWMANY_Load(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Global.personToGenerateCout = Convert.ToInt32(this.txtMDNum.Text);
            FRM_GENERATING frmGenerating = new FRM_GENERATING();
            FRM_MAIN frmMain = new FRM_MAIN();
            frmGenerating.ShowDialog(this);
        }
    }
}
