using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace RandomDrugTest
{
    public partial class FRM_GENERATE_OFFICE : Form
    {
        public FRM_GENERATE_OFFICE()
        {
            InitializeComponent();
        }

        private void FRM_GENERATE_OFFICE_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conX = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\IT Development\Projects\RandomDrugTest_20161012_0912\final.xls;Extended Properties=Excel 12.0;";
            using (OleDbConnection conn = new OleDbConnection(conX))
            {
                string stmt = "select distinct office from [Sheet1$]";
                using (OleDbCommand comm = new OleDbCommand(stmt, conn))
                {
                    OleDbDataAdapter da = new OleDbDataAdapter();
                    DataSet ds = new DataSet();
                    conn.Open();
                    da.SelectCommand = comm;
                    da.Fill(ds, "[Sheet1$]");
                    conn.Close();
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        DataRow row = ds.Tables[0].Rows[i];
                        string office;
                        if (string.IsNullOrWhiteSpace(row.Field<string>("office")))
                        {
                            office = "";
                        }
                        else
                        {
                            office = row.Field<string>("office").ToString();
                        }
                        
   
                        using (SqlConnection connX = new SqlConnection(Global.connStr))
                        {
                            stmt = "insert into tblOffice (office_code, office_name) values (@office_code, @office_name)";
                            try
                            {
                                using (SqlCommand cmd = new SqlCommand(stmt, connX))
                                {
                                    cmd.Parameters.Add("@office_code", SqlDbType.VarChar, 10).Value = "000" + (i+1).ToString();
                                    cmd.Parameters.Add("@office_name", SqlDbType.VarChar, 100).Value = office;
                                    connX.Open();
                                    cmd.ExecuteNonQuery();
                                    connX.Close();
                                }
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.ToString());
                            }
                        }
                    }
                    MessageBox.Show("Inserted Data!");
                }
            }

        }
    }
}
