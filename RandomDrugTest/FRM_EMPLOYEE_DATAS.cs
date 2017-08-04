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

namespace RandomDrugTest
{
    public partial class FRM_EMPLOYEE_DATAS : MaterialForm
    {
        public FRM_EMPLOYEE_DATAS()
        {
            InitializeComponent();
        }

        private void FRM_EMPLOYEE_DATAS_Load(object sender, EventArgs e)
        {

        }

        // Initalize All
        private void initializeAll()
        {

            load_autocomplete(toolStripTxtSearch);

        }

        /*
         * Data Mining
         * 
        */

        private void load_autocomplete(ToolStripTextBox txtBox)
        {

            txtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();


            using (SqlConnection conn = new SqlConnection(Global.connStr))
            {
                string stmt = "select employee_last_name from tblEmployee";
                using (SqlCommand comm = new SqlCommand(stmt, conn))
                {
                    conn.Open();
                    SqlDataReader dr = comm.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            collection.Add(dr["employee_last_name"].ToString());
                        }
                    }
                    dr.Close();
                    conn.Close();
                }
            }
            txtBox.AutoCompleteCustomSource = collection;

        }

    }
}
