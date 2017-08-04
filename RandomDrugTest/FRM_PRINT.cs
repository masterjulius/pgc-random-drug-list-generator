using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RandomDrugTest
{
    public partial class FRM_PRINT : Form
    {
        public FRM_PRINT()
        {
            InitializeComponent();
        }

        private void FRM_PRINT_Load(object sender, EventArgs e)
        {
            //print_data();
            set_xml();
        }

        private void set_xml()
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("FULL NAME", typeof(string));
            dt.Columns.Add("POSITION", typeof(string));
            dt.Columns.Add("OFFICE", typeof(string));

            foreach (DataGridViewRow dgv in dataGridView1.Rows)
            {
                dt.Rows.Add(dgv.Cells[0].Value, dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value);
            }

            ds.Tables.Add(dt);
            CrystalReport1 cr1 = new CrystalReport1();
            cr1.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr1;

            ds.WriteXmlSchema("Sample.xml");

        }

        private void load_main()
        {
            DataSet ds = new DataSet();
            CrystalReport1 cr1 = new CrystalReport1();
            cr1.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr1;
        }

        // Load Records To Print
        private void print_data()
        {

            using (SqlConnection conn = new SqlConnection(Global.connStr))
            {
                string stmt = "InsertTestEmployees";
                using (SqlCommand comm = new SqlCommand(stmt,conn))
                {
                    comm.Parameters.Add("@test_event_id", SqlDbType.BigInt).Value = Global.print_test_id;
                    comm.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataSet ds = new DataSet();
                    conn.Open();
                    da.SelectCommand = comm;
                    da.Fill(ds, "tblTest");
                    conn.Close();
                    da.Dispose();
                    ds.Dispose();
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }

        }

    }
}
