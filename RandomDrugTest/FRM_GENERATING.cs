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
    public partial class FRM_GENERATING : Form
    {

        // 
        public FRM_RANDOMIZER frmNext;

        public FRM_GENERATING()
        {
            InitializeComponent();
        }

        private void FRM_GENERATING_Load(object sender, EventArgs e)
        {
            ///FRM_MAIN frmMain = new FRM_MAIN();
            this.Location = new Point(this.Location.X, this.Location.X + 8);
            this.FormBorderStyle = FormBorderStyle.None;
            tmrPreload.Start();


            frmNext = new FRM_RANDOMIZER();
            frmNext.generate_all(Global.personToGenerateCout);

        }

        private void tmrPreload_Tick(object sender, EventArgs e)
        {
            tmrPreload.Stop();
            this.Hide();

            frmNext.ShowDialog();


        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
