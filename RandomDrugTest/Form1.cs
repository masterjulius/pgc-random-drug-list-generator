using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MaterialSkin.Controls;
using MaterialSkin;

namespace RandomDrugTest
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            ///Chaging the color
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            user_sign_in(txtUser.Text, txtPass.Text);

        }

        private void user_sign_in(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(Global.connStr)) {
                string stmt = "select * from tblUsers where username=@username and password=@password";
                using (SqlCommand comm = new SqlCommand(stmt, conn))
                {
                    comm.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;
                    comm.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = password;
                    conn.Open();
                    SqlDataReader dr = comm.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        string chk_username = dr["username"].ToString();
                        string chk_password = dr["password"].ToString();
                        if (username != chk_username || password != chk_password) {
                            MessageBox.Show("Invalid Username or Password", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPass.Clear();
                        }
                        else
                        {
                            txtUser.Clear();
                            txtPass.Clear();
                            ///for material textboxes
                            txtMDUser.Clear();
                            txtMDPass.Clear();
                            this.Hide();
                            FRM_MAIN frmMain = new FRM_MAIN();
                            frmMain.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPass.Clear();
                        ///for material Textbox
                        txtMDPass.Clear();
                    }
                    dr.Close();
                    conn.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            lblWarning.Text = "";
            txtMDUser.Select();

        }


        private void check_caps(Label label)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                label.Text = "Capslock is on";
            }
            else
            {
                label.Text = "";
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            check_caps(this.lblWarning);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            check_caps(this.lblWarning);
        }

        private void btnMDClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMDLogin_Click(object sender, EventArgs e)
        {
            ///for material Textboxes
            user_sign_in(txtMDUser.Text, txtMDPass.Text);
        }

        private void txtMDPass_Click(object sender, EventArgs e)
        {

            

        }

        private void txtMDPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                this.user_sign_in(this.txtMDUser.Text, this.txtMDPass.Text);
            }
        }

        private void txtMDPass_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
}
