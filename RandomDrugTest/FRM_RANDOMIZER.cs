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
    public partial class FRM_RANDOMIZER : MaterialForm
    {
        //variables
        private int dataCount;

        public FRM_RANDOMIZER()
        {
            InitializeComponent();
        }

        private void FRM_RANDOMIZER_Load(object sender, EventArgs e)
        {

            toolStripTxtNumberofPersons.Select();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            pbPreloader.Visible = true;
            tmrPreloader.Start();
            ///generate_all();
            

        }

        // Generate Datagridview
        private void generate_datagrid(string[] headers, DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();

            dgv.ColumnCount = headers.Length;
            for (int i = 0; i < headers.Length; i++)
            {
                dgv.Columns[i].Name = headers[i];
            }
            dgv.Columns["ID"].Visible = false;

        }

        // Add Names
        private void add_person(DataGridView dgv, string[] args)
        {
            dgv.Rows.Add(args);
        }

        private void toolStripTxtNumberofPersons_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        public void generate_all(int personToTest = 0) {

            string[] args = new string[] { };

            int[] ref_restrict = new int[6];

            using (SqlConnection conn = new SqlConnection(Global.connStr))
            {

                string[] restrict = new string[] { "SANGGUNIANG PANLALAWIGAN (SECRETARIAT)", "SANGGUNIANG PANLALAWIGAN OFFICE (Legislation)", "VICE GOVERNOR' S OFFICE", "GOVERNOR'S OFFICE", "PROVINCIAL LEARNING AND RESOURCE CENTER", "OFFICE OF THE GOVERNOR" };

                for (int i = 0; i < restrict.Length; i++)
                {

                    string stmt = "select office_id from tblOffice where office_name=@name";
                    using (SqlCommand comm = new SqlCommand(stmt,conn))
                    {
                        comm.Parameters.Add("@name", SqlDbType.VarChar).Value = restrict[i];
                        SqlDataAdapter da = new SqlDataAdapter();
                        DataSet ds = new DataSet();
                        conn.Open();
                        da.SelectCommand = comm;
                        da.Fill(ds, "tblOffice");
                        conn.Close();
                        
                        ref_restrict[i] = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0]);

                        // Dispose All Resources
                        //conn.Dispose();
                        comm.Dispose();
                        da.Dispose();
                        ds.Dispose();

                    }

                }
            }

            int personCount = 0;
            using (SqlConnection conn = new SqlConnection(Global.connStr))
            {
                string stmt = "select count(employee_id) as emp_count from tblEmployee where employee_office_id!=@name_1 and employee_office_id!=@name_2 and employee_office_id!=@name_3 and employee_office_id!=@name_4 and employee_office_id!=@name_5 and employee_office_id!=@name_6";
                using (SqlCommand comm = new SqlCommand(stmt, conn))
                {

                    for (int x = 0; x < ref_restrict.Length; x++)
                    {
                        comm.Parameters.Add("@name_" + (x + 1).ToString(), SqlDbType.VarChar).Value = Convert.ToInt32(ref_restrict[x]);
                    }


                    SqlDataAdapter da = new SqlDataAdapter();
                    conn.Open();
                    da.SelectCommand = comm;
                    DataSet ds = new DataSet();
                    da.Fill(ds, "tblEmployee");
                    conn.Close();
                    personCount = ds.Tables[0].Rows[0].Field<int>("emp_count");
                    dataCount = personCount;

                    // Dispose All Resources
                    conn.Dispose();
                    comm.Dispose();
                    da.Dispose();
                    ds.Dispose();

                }
            }

            if (personToTest <= personCount)
            {
                string[] headerNames = new string[] { "ID", "FULL NAME", "POSITION", "OFFICE" };
                generate_datagrid(headerNames, dgv1);

                List<int> number_set = new List<int>();

                for (int i = 0; i <= personToTest - 1; i++)
                {
                    using (SqlConnection conn = new SqlConnection(Global.connStr))
                    {
                        string stmt = "select tblEmployee.employee_id, tblEmployee.employee_full_name, tblEmployee.employee_position, tblOffice.office_name from tblEmployee left join tblOffice on tblEmployee.employee_office_id=tblOffice.office_id where tblEmployee.employee_office_id!=@name_1 and tblEmployee.employee_office_id!=@name_2 and tblEmployee.employee_office_id!=@name_3 and tblEmployee.employee_office_id!=@name_4 and tblEmployee.employee_office_id!=@name_5 and tblEmployee.employee_office_id!=@name_6";
                        using (SqlCommand comm = new SqlCommand(stmt, conn))
                        {
                            for (int x = 0; x < ref_restrict.Length; x++)
                            {
                                comm.Parameters.Add("@name_" + (x + 1).ToString(), SqlDbType.VarChar).Value = Convert.ToInt32(ref_restrict[x]);
                            }

                            SqlDataAdapter da = new SqlDataAdapter();
                            conn.Open();
                            da.SelectCommand = comm;
                            DataSet ds = new DataSet();
                            da.Fill(ds, "tblEmployee");
                            conn.Close();
                            // Random here

                            Random rnd = new Random();
                            int index;

                            do
                            {
                                index = rnd.Next(0, personCount);
                            } while (number_set.Contains(index));

                            number_set.Add(index);

                            // Add To Datagrid
                            string[] person = new string[4];
                            person[0] =ds.Tables[0].Rows[index].Field<int>("employee_id").ToString();
                            person[1] = ds.Tables[0].Rows[index].Field<string>("employee_full_name");
                            person[2] = ds.Tables[0].Rows[index].Field<string>("employee_position");
                            person[3] = ds.Tables[0].Rows[index].Field<string>("office_name");
                            add_person(dgv1, person);

                            // Dispose All Resources
                            conn.Dispose();
                            comm.Dispose();
                            da.Dispose();
                            ds.Dispose();

                        }
                                                
                    }
                }
            }
            else
            {
                MessageBox.Show("Overload!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void toolStripTxtNumberofPersons_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are Your Sure You Want To Exit?", "Atention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            // Save Data
            this._save_employee_data();
            this.to_print(this.dgv1);


        }

        private void to_print(DataGridView dgv)
        {

            FRM_PRINT frmPrint = new FRM_PRINT();
            //frmPrint.dataGridView1

            //create table with three columns
            DataTable t = new DataTable();
            t.Columns.Add("ID", typeof(string));
            t.Columns.Add("FULL NAME", typeof(string));
            t.Columns.Add("POSITION", typeof(string));
            t.Columns.Add("OFFICE", typeof(string));
            //add data to table
            for (int i = 0; i < dgv.RowCount; i++)
            {
                string[] arrVals = new string[4];
                arrVals[0] = dgv.Rows[i].Cells[0].Value.ToString();
                arrVals[1] = dgv.Rows[i].Cells[1].Value.ToString();
                arrVals[2] = dgv.Rows[i].Cells[2].Value.ToString();
                arrVals[3] = dgv.Rows[i].Cells[3].Value.ToString();
                t.Rows.Add(arrVals);
            }         

            //bind table to datagridview
            frmPrint.dataGridView1.DataSource = t;
            frmPrint.ShowDialog();

        }


        private void save_to_print(DataGridView dgv)
        {
            string listEmps = "";
            for (int i = 0; i < dgv.RowCount; i++)
            {
                //string theID = dgv.Rows[i].Cells["ID"].ToString();

                if (i >= dgv.RowCount -1)
                {
                    listEmps += dgv.Rows[i].Cells["ID"].Value.ToString();
                } else
                {
                    listEmps += dgv.Rows[i].Cells["ID"].Value.ToString() + ":";
                }              

            }

            int last_id;
            using (SqlConnection conn = new SqlConnection(Global.connStr))
            {                
                string stmt = "insert into tblTest (test_event_code, test_employees) OUTPUT INSERTED.test_event_id values (@test_event_code, @test_employees)";
                using (SqlCommand comm = new SqlCommand(stmt,conn))
                {
                    comm.Parameters.Add("@test_event_code", SqlDbType.VarChar, 50).Value = "00001";
                    comm.Parameters.Add("@test_employees", SqlDbType.Text).Value = listEmps;
                    conn.Open();
                    last_id = Convert.ToInt32(comm.ExecuteScalar());
                    conn.Close();

                    conn.Dispose();
                    comm.Dispose();
                }
            }

            Global.print_test_id = last_id;
            FRM_PRINT frmPrint = new FRM_PRINT();
            frmPrint.ShowDialog();

        }

        private void tmrPreloader_Tick(object sender, EventArgs e)
        {
            tmrPreloader.Stop();
            pbPreloader.Visible = false;
            generate_all(Convert.ToInt32(this.toolStripTxtNumberofPersons.Text));
        }

        /*
         * Save To Database 
         * 
        */

        /* Save Employees To Test */
        private void _save_employee_data()
        {
            int getWeekNum = GetWeekNumberOfMonth(DateTime.Now);

            using (SqlConnection conn = new SqlConnection(Global.connStr))
            {
                string fullEmployees = "";
                for (int i = 0; i < dgv1.RowCount; i++)
                {
                    if (i >= dgv1.RowCount - 1)
                    {
                        fullEmployees += dgv1.Rows[i].Cells["ID"].Value.ToString();
                    } else
                    {
                        fullEmployees += dgv1.Rows[i].Cells["ID"].Value.ToString() + ":";
                    }
                }

                // Date Functions
                DateTime getDate = DateTime.Now;
                int month = Convert.ToInt32(getDate.ToString("MM"));
                int week = getWeekNum;
                int year = Convert.ToInt32(getDate.ToString("yyyy"));

                string stmt = "insert into tblTestRecords (testRecords_event_code, testRecords_batch, testRecords_covered_month, testRecords_covered_week, testRecords_covered_year, testRecords_employees, testRecords_witnesses, testRecords_generated_by) values (@testRecords_event_code, @testRecords_batch, @testRecords_covered_month, @testRecords_covered_week, @testRecords_covered_year, @testRecords_employees, @testRecords_witnesses, @testRecords_generated_by)";
                using (SqlCommand comm = new SqlCommand(stmt, conn))
                {
                    comm.Parameters.Add("@testRecords_event_code", SqlDbType.VarChar).Value = _convert_str(year) + "-" + _convert_str(week) + _convert_str(month) + "-" + getDate.ToString("dd");
                    comm.Parameters.Add("@testRecords_batch", SqlDbType.Int).Value = this.recordCounter("tblTestRecords") + 1;
                    comm.Parameters.Add("@testRecords_covered_month", SqlDbType.VarChar).Value = month;
                    comm.Parameters.Add("@testRecords_covered_week", SqlDbType.VarChar).Value = week;
                    comm.Parameters.Add("@testRecords_covered_year", SqlDbType.VarChar).Value = year;
                    comm.Parameters.Add("@testRecords_employees", SqlDbType.VarChar).Value = fullEmployees;
                    comm.Parameters.Add("@testRecords_witnesses", SqlDbType.VarChar).Value = Global.testWintesses;
                    comm.Parameters.Add("@testRecords_generated_by", SqlDbType.VarChar).Value = Global.testGeneratedBy;
                    conn.Open();
                    comm.ExecuteNonQuery();
                    conn.Close();

                    // Dispose Resources
                    conn.Dispose();
                    comm.Dispose();

                }
            }
        }
        /* End */

        // Get the particular week number of the month
        static int GetWeekNumberOfMonth(DateTime date)
        {
            date = date.Date;
            DateTime firstMonthDay = new DateTime(date.Year, date.Month, 1);
            DateTime firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) % 7);
            if (firstMonthMonday > date)
            {
                firstMonthDay = firstMonthDay.AddMonths(-1);
                firstMonthMonday = firstMonthDay.AddDays((DayOfWeek.Monday + 7 - firstMonthDay.DayOfWeek) % 7);
            }
            return (date - firstMonthMonday).Days / 7 + 1;
        }
        // End

        /*
         * Record Counter 
        */
        private int recordCounter(string tableName)
        {
            int records = 0;
            using (SqlConnection conn = new SqlConnection(Global.connStr))
            {
                string stmt = "select COUNT(*) as count_records from " + tableName;
                using (SqlCommand comm = new SqlCommand(stmt, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    DataSet ds = new DataSet();
                    conn.Open();
                    da.SelectCommand = comm;
                    da.Fill(ds, tableName);
                    conn.Close();

                    // Dispose All Resources
                    conn.Dispose();
                    comm.Dispose();
                    da.Dispose();
                    ds.Dispose();

                    // Get Values
                    records = ds.Tables[0].Rows[0].Field<int>("count_records");

                }
            }
            return records;
        }
        // End

        // String COnverter
        static string _convert_str(object obj)
        {
            return Convert.ToString(obj);
        }

    }
}
