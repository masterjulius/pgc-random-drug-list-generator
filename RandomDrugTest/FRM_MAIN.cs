using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomDrugTest
{
    public partial class FRM_MAIN : MaterialForm
    {
        public FRM_MAIN()
        {
            InitializeComponent();

            ///Chaging the color
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FRM_NEW_EMPLOYEE frmNewEmployee = new FRM_NEW_EMPLOYEE();
            frmNewEmployee.ShowDialog();
        }

        private void rANDOMDRUGTESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_RANDOMIZER frmRandomizer = new FRM_RANDOMIZER();
            frmRandomizer.ShowDialog();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Are Your Sure You Want To Exit This Application?", "Additional Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
                Form1 frmLogin = new Form1();
                frmLogin.Show();
            }

        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;

            pnlMenu.Size = new Size(SystemInformation.VirtualScreen.Width, pnlMenu.Height);
            pbBackground.Size = new Size(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height-(pnlMenu.Height+62));
        }

        private void btnMDAddEmployee_Click(object sender, EventArgs e)
        {
            FRM_NEW_EMPLOYEE frmNewEmployee = new FRM_NEW_EMPLOYEE();
            frmNewEmployee.ShowDialog(this);
        }

        private void btnMDNamePicker_Click(object sender, EventArgs e)
        {
            //FRM_RANDOMIZER frmRandomizer = new FRM_RANDOMIZER();
            //frmRandomizer.ShowDialog(this);
            FRM_WITNESSES frmWitnesses = new FRM_WITNESSES();
            frmWitnesses.ShowDialog(this);
        }

        private void rESULTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mANAGEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnMDExit_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Are Your Sure You Want To Exit This Application?", "Additional Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
                Form1 frmLogin = new Form1();
                frmLogin.Show();
            }
        }

        private void btnMDResult_Click(object sender, EventArgs e)
        {
            FRM_TEST_RESULT frmTestResult = new FRM_TEST_RESULT();
            frmTestResult.ShowDialog(this);
        }

        ///Expose pbBackground location











    }
}
