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
using System.Data.SqlClient;

namespace RandomDrugTest
{
    public partial class FRM_TEST_RESULT : MaterialForm
    {
        public FRM_TEST_RESULT()
        {
            InitializeComponent();
        }

        private void FRM_TEST_RESULT_Load(object sender, EventArgs e)
        {
            this._initialize_all();
        }

        /* Initialize All */
        private void _initialize_all()
        {

            // Load Batch
            this._load_batch_records(this.cboBatch);
        }
        /**/

        private void _load_batch_records(ComboBox cmbBox)
        {
            using (SqlConnection conn = new SqlConnection(Global.connStr))
            {
                string stmt = "select testRecords_event_id, testRecords_batch from tblTestRecords order by testRecords_batch ASC";
                using (SqlCommand comm = new SqlCommand(stmt, conn))
                {
                    conn.Open();
                    SqlDataReader dr = comm.ExecuteReader();
                    Dictionary<int, string> item = new Dictionary<int, string>();
                    item.Add(0, "-Select Batch-");
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            string displayName = "Batch 0" + dr["testRecords_batch"].ToString();
                            if (dr["testRecords_batch"].ToString().Length > 1)
                            {
                                displayName = "Batch " + dr["testRecords_batch"].ToString();
                            }
                            item.Add(Convert.ToInt32(dr["testRecords_event_id"]), displayName);
                        }
                    }
                    dr.Close();
                    conn.Close();

                    // Dispose All Resources
                    conn.Dispose();
                    comm.Dispose();
                    dr.Dispose();

                    cmbBox.DisplayMember = "Value";
                    cmbBox.ValueMember = "Key";
                    cmbBox.DataSource = new BindingSource(item, null);

                }
            }
        }

        /* Explode Employee ID's */
        private string[] _explode_string(string subject, char delimeter)
        {
            string[] representingValue = subject.Split(delimeter);
            return representingValue;
        }
        /**/

        /* Get All EMployee ID's */
        private void _populate_selected_batch(int batchID = 0)
        {
            string employee_str = "";
            using (SqlConnection conn = new SqlConnection(Global.connStr)) {
                string stmt = "select testRecords_employees from tblTestRecords where testRecords_batch=@testRecords_batch";
                using (SqlCommand comm = new SqlCommand(stmt,conn)) {
                    comm.Parameters.Add("@testRecords_batch", SqlDbType.BigInt).Value = batchID;
                    conn.Open();
                    SqlDataReader dr = comm.ExecuteReader();
                    if (dr.HasRows) {
                        dr.Read();
                        employee_str = dr["testRecords_employees"].ToString();
                    }
                    dr.Close();
                    conn.Close();

                    // Dispose All Resources
                    conn.Dispose();
                    comm.Dispose();
                    dr.Dispose();

                }
            }

            // Explode
            string[] explodeCall = this._explode_string(employee_str, ':');
            for (int i = 0; i < explodeCall.Length; i++)
            {
                this._get_database_details(dgvBatch, Convert.ToInt32(explodeCall[i]));
            }

        }
        /**/

        /* Populate DataGrid Upon Selection of Batch */
        private void _get_database_details(DataGridView dgv, int employee_ID)
        {
            using (SqlConnection conn = new SqlConnection(Global.connStr))
            {
                string stmt = "select tblEmployee.employee_id, tblEmployee.employee_full_name, tblEmployee.employee_position, tblOffice.office_name from tblEmployee left join tblOffice on tblEmployee.employee_office_id=tblOffice.office_id where tblEmployee.employee_id=@employee_id";
                using (SqlCommand comm = new SqlCommand(stmt, conn))
                {
                    comm.Parameters.Add("@employee_id", SqlDbType.Int).Value = employee_ID;
                    conn.Open();
                    SqlDataReader dr = comm.ExecuteReader();
                    if (dr.HasRows)
                    {
                        string[] columnValues = new string[4];
                        dr.Read();
                        columnValues[0] = dr["employee_id"].ToString();
                        columnValues[1] = dr["employee_full_name"].ToString();
                        columnValues[2] = dr["employee_position"].ToString();
                        columnValues[3] = dr["office_name"].ToString();

                        // Add Row
                        this._add_row(dgvBatch, columnValues);
                    }
                    dr.Close();
                    conn.Close();

                    // Dispose All Resources
                    conn.Dispose();
                    comm.Dispose();
                    dr.Dispose();
                }
            }
        }
        /**/

        /* Add The Row */
        private void _add_row(DataGridView dgv, string[] cellValues)
        {
            dgv.Rows.Add(cellValues);
        }

        /**/

        /* Initialize DataGrid */
        private void _initialize_datagrid(DataGridView dgv, string[] columnHeaders)
        {
            // Clear At First
            dgv.DataSource = null;
            dgv.Rows.Clear();

            dgv.ColumnCount = columnHeaders.Length;
            for (int i = 0; i < columnHeaders.Length; i++)
            {
                dgv.Columns[i].Name = columnHeaders[i];
            }

            // Set DatagridView Design Here

        }
        /**/

        /* Clear DataGridView Details */
        private void _clear_datagridview(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.Columns.Clear();
        }
        /**/

        private void btnMDSetResult_Click(object sender, EventArgs e)
        {
            FRM_SET_RESULT frmSetResult = new FRM_SET_RESULT();
            frmSetResult.ShowDialog(this);
        }

        private void cboBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedValue = Convert.ToInt32(cboBatch.SelectedValue);
            if (selectedValue != 0)
            {
                // First Populate / Initialize Datagridview details
                string[] columnHeaders = new string[] { "Employee ID", "FULL NAME", "POSITION", "OFFICE" };
                this._initialize_datagrid(dgvBatch, columnHeaders);
                // Call To Add Row

                this._populate_selected_batch(selectedValue);
            }
            else
            {
                // Clear DataGridView
                this._clear_datagridview(dgvBatch);
            }
        }

        private void dgvBatch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        // Trigger Set Result Event(s)
        private void _trigger_set_result_event(DataGridView dgv)
        {
            int employeeID = Convert.ToInt32(dgv.SelectedRows[0].Cells["Employee ID"].Value);
            string employeeName = dgv.SelectedRows[0].Cells["FULL NAME"].Value.ToString();
            this._set_result_details(employeeID, employeeName);
        }

        // Set Selected Cell It's Content
        private void _set_result_details(int employeeID, string employeeName = "John Doe")
        {

            // Next Form
            FRM_SET_RESULT frmSetResult = new FRM_SET_RESULT();
            frmSetResult.batchID = Convert.ToInt32(this.cboBatch.SelectedValue);
            frmSetResult.employeeID = employeeID;
            frmSetResult.lblEmployeeName.Text = employeeName;
            frmSetResult.ShowDialog();
        }

        private void dgvBatch_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvBatch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this._trigger_set_result_event(dgvBatch);
        }

    }
}
