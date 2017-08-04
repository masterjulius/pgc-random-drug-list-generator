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
    public partial class FRM_GENERATED_LIST : MaterialForm
    {
        public FRM_GENERATED_LIST()
        {
            InitializeComponent();
        }

        private void FRM_GENERATED_LIST_Load(object sender, EventArgs e)
        {

        }

        private void btnMDPrint_Click(object sender, EventArgs e)
        {
            FRM_PRINT frmPrint = new FRM_PRINT();
            frmPrint.ShowDialog(this);
        }
    }
}
