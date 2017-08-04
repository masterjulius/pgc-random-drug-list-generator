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
using System.Threading;
using MaterialSkin.Controls;

namespace RandomDrugTest
{
    public partial class FRM_NEW_EMPLOYEE : MaterialForm
    {

        //Variables
        private string xlsConnStr;
        private int progressStat = 0, fileImportCount = 0;

        public FRM_NEW_EMPLOYEE()
        {
            InitializeComponent();
        }

        private void FRM_NEW_EMPLOYEE_Load(object sender, EventArgs e)
        {
            
            set_actions();
        }

        private void set_actions()
        {
            Global.actionMode = 0;
            // Disable Mode
            ToolStripButton[] allButtons = new ToolStripButton[] { this.toolStripBtnNew, this.toolStripBtnEdit, this.toolStripBtnDelete, this.toolStripBtnCancel, this.toolStripBtnCancel, this.toolStripBtnSave };
            ToolStripButton[] tools = new ToolStripButton[] { this.toolStripBtnEdit, this.toolStripBtnDelete, this.toolStripBtnCancel, this.toolStripBtnSave };
            this.disable_tools(tools, allButtons);

            // Autocomplete Textbox
            set_autocomplete(toolStripTxtSearch);

        }

        private void load_offices()
        {
            using (SqlConnection conn = new SqlConnection(Global.connStr))
            {
                string stmt = "select office_id, office_name from tblOffice order by office_name ASC";
                using (SqlCommand comm = new SqlCommand(stmt, conn))
                {
                    conn.Open();
                    SqlDataReader dr = comm.ExecuteReader();
                    Dictionary<int, string>item = new Dictionary<int, string>();
                    item.Add(0, "-Select Department/Division-");
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            item.Add(Convert.ToInt32(dr["office_id"]), dr["office_name"].ToString());
                        }
                    }
                    dr.Close();
                    conn.Close();

                    cbOffice.DisplayMember = "Value";
                    cbOffice.ValueMember = "Key";
                    cbOffice.DataSource = new BindingSource(item, null);
                    
                }
            }
        }



        private Boolean save_employee()
        {
            Boolean result = false;

            if (Global.actionMode != 3)
            {

                using (SqlConnection conn = new SqlConnection(Global.connStr))
                {
                    string stmt;
                    if (Global.actionMode == 1)
                    {
                        stmt = "if not exists (select * from tblEmployee where employee_full_name=@emp_full_name_1) insert into tblEmployee (employee_code, employee_full_name, employee_position, employee_office_id, employee_contact, employee_email) values (@employee_code, @employee_full_name, @employee_position, @employee_office_id, @employee_contact, @employee_email)";
                    }
                    else
                    {
                        stmt = "if not exists (select * from tblEmployee where employee_full_name=@emp_full_name_1) update tblEmployee set employee_code=@employee_code, employee_full_name=@employee_full_name, employee_position=@employee_position, employee_office_id=@employee_office_id, employee_contact=@employee_contact, employee_email=@employee_email where employee_id=@employee_id";
                    }

                    using (SqlCommand comm = new SqlCommand(stmt, conn))
                    {
                        string fullName = this.txtLastName.Text + ", " + txtFirstName.Text + " " + txtMiddleInitial.Text + ".";
                        comm.Parameters.Add("@emp_full_name_1", SqlDbType.VarChar, 120).Value = fullName;

                        comm.Parameters.Add("@employee_code", SqlDbType.VarChar, 10).Value = "11111";
                        comm.Parameters.Add("@employee_full_name", SqlDbType.VarChar, 120).Value = fullName;
                        comm.Parameters.Add("@employee_position", SqlDbType.VarChar, 50).Value = txtPosition.Text;
                        comm.Parameters.Add("@employee_office_id", SqlDbType.Int, 11).Value = Convert.ToInt32(cbOffice.SelectedValue);
                        comm.Parameters.Add("@employee_contact", SqlDbType.VarChar, 25).Value = txtContact.Text;
                        comm.Parameters.Add("@employee_email", SqlDbType.VarChar, 120).Value = txtEmail.Text;

                        if (Global.actionMode == 2)
                        {
                            comm.Parameters.Add("@employee_id", SqlDbType.Int).Value = Global.empID;
                        }

                        conn.Open();
                        int affectedRows = Convert.ToInt32(comm.ExecuteNonQuery());
                        conn.Close();

                        if (affectedRows > 0)
                        {
                            result = true;
                        }
                    }
                }

            }
            else // if Importing
            {
                
                // Import Query
                //result = this.import_data();
                if (!backgroundWorkerProgress.IsBusy)
                {
                    backgroundWorkerProgress.RunWorkerAsync();
                }
                
                // * End Importing

            }

            return result;

        }

        /*
         * Import Function
         * This is a Long Code
         * So We Should Write It Well
        */

        

        /*
         *  End Importing
         *  End
        */  

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void toolStripBtnExit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure You Want To Exit?", "Additional Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void toolStripBtnNew_Click(object sender, EventArgs e)
        {
            Global.actionMode = 1;
            ToolStripButton[] allButtons = new ToolStripButton[] { this.toolStripBtnNew ,this.toolStripBtnEdit, this.toolStripBtnDelete, this.toolStripBtnCancel, this.toolStripBtnCancel, this.toolStripBtnSave };
            ToolStripButton[] tools = new ToolStripButton[] { this.toolStripBtnNew ,this.toolStripBtnEdit, this.toolStripBtnDelete };
            this.disable_tools(tools, allButtons);
            this.enable_fields(panel_main.Controls);
        }

        private void toolStripBtnSave_Click(object sender, EventArgs e)
        {
            if (save_employee() == false)
            {
                if (Global.actionMode == 1)
                {
                    MessageBox.Show("This Person Already Exists. Please Try Another Person", "Additional Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Failed To Update Personal Information. Please Try Again", "Additional Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                if (Global.actionMode == 1)
                {
                    MessageBox.Show("You had successfully added new employee", "Additional Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (Global.actionMode == 2)
                {
                    MessageBox.Show("You had successfully Updated the personal Information of this Employee", "Additional Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Finished Importing Employee Datas", "Additional Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                txtFirstName.Clear();
                txtLastName.Clear();
                txtMiddleInitial.Clear();
                txtPosition.Clear();
                txtContact.Clear();
                txtEmail.Clear();

                ToolStripButton[] allButtons = new ToolStripButton[] { this.toolStripBtnNew, this.toolStripBtnEdit, this.toolStripBtnDelete, this.toolStripBtnCancel, this.toolStripBtnCancel, this.toolStripBtnSave };
                ToolStripButton[] tools = new ToolStripButton[] { this.toolStripBtnEdit, this.toolStripBtnDelete, this.toolStripBtnCancel, this.toolStripBtnSave };
                this.disable_tools(tools, allButtons);

            }


            //if (InterActivities.check_empty_fields(panel_main.Controls) <= 0)
            //{
                
            //}
            //else
            //{
            //    MessageBox.Show("Please Fill Up All The Required Field(s)\n in the Form", "Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}

        }

        /* Disable/ Enable Actions
         * 1 = Disable Tools
         * 2 = Disable Fields
        */
        private void disable_tools(ToolStripButton[] tools, ToolStripButton[] toolsMain)
        {
            foreach (var item in toolsMain)
            {
                item.Enabled = true;
            }

            foreach (var item in tools)
            {
                item.Enabled = false;
            }
            this.disable_fields(this.panel_main.Controls);
        }

        /* */
        private void disable_fields(Control.ControlCollection control) {
            foreach (Control item in control)
            {
                item.Enabled = false;
            }
            cbOffice.DataSource = null;

        }

        /* */
        private void enable_fields(Control.ControlCollection control)
        {
            foreach (Control item in control)
            {
                item.Enabled = true;
            }
            txtLastName.Select();
            this.load_offices();
        }

        /*
         *  Set Auto Complete Datas
         * 
        */
        private void set_autocomplete(ToolStripTextBox txtBox)
        {

            txtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            
            using (SqlConnection conn = new SqlConnection(Global.connStr))
            {
                string stmt = "select employee_full_name from tblEmployee";
                using (SqlCommand comm = new SqlCommand(stmt, conn))
                {
                    conn.Open();
                    SqlDataReader dr = comm.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            collection.Add(dr["employee_full_name"].ToString());
                        }
                    }
                    dr.Close();
                    conn.Close();
                }
            }
            txtBox.AutoCompleteCustomSource = collection;

        }

        private void toolStripBtnImport_Click(object sender, EventArgs e)
        {

            openFileDialogImport.ShowDialog();

        }

        private void openFileDialogImport_FileOk(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(this.openFileDialogImport.FileName))
            {
                string path = this.openFileDialogImport.FileName;
                xlsConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;";
                Global.actionMode = 3;
                ToolStripButton[] allButtons = new ToolStripButton[] { this.toolStripBtnNew, this.toolStripBtnEdit, this.toolStripBtnDelete, this.toolStripBtnCancel, this.toolStripBtnCancel, this.toolStripBtnSave };
                ToolStripButton[] tools = new ToolStripButton[] { this.toolStripBtnNew, this.toolStripBtnEdit, this.toolStripBtnDelete };
                this.disable_tools(tools, allButtons);            
            }
        }

        private void toolStripBtnCancel_Click(object sender, EventArgs e)
        {

            xlsConnStr = null;
            Global.actionMode = 3;
            ToolStripButton[] allButtons = new ToolStripButton[] { this.toolStripBtnNew, this.toolStripBtnEdit, this.toolStripBtnDelete, this.toolStripBtnCancel, this.toolStripBtnCancel, this.toolStripBtnSave };
            ToolStripButton[] tools = new ToolStripButton[] { this.toolStripBtnEdit, this.toolStripBtnDelete, this.toolStripBtnCancel, this.toolStripBtnSave };
            this.disable_tools(tools, allButtons);

        }

        private void backgroundWorkerProgress_DoWork(object sender, DoWorkEventArgs e)
        {

            using (OleDbConnection xlsConn = new OleDbConnection(xlsConnStr))
            {
                string stmt = "select * from [Sheet1$]";
                using (OleDbCommand cmd = new OleDbCommand(stmt, xlsConn))
                {

                    OleDbDataAdapter datAdapter = new OleDbDataAdapter();
                    DataSet datSet = new DataSet();
                    xlsConn.Open();
                    datAdapter.SelectCommand = cmd;
                    datAdapter.Fill(datSet, "[Sheet1$]");
                    int rowCount = datSet.Tables[0].Rows.Count;
                    if (rowCount > 0)
                    {
                        progressStat = 0;
                        fileImportCount = rowCount;
                        pb1.Value = 0;

                        // Affected Rows
                        int affectedRows = 0;

                        for (int i = 0; i < rowCount; i++)
                        {

                            DataRow row = datSet.Tables[0].Rows[i];

                            using (SqlConnection conn = new SqlConnection(Global.connStr))
                            {
                                stmt = "if not exists (select * from tblEmployee where employee_full_name=@emp_full_name_1) insert into tblEmployee (employee_full_name, employee_position, employee_office_id) values (@employee_full_name, @employee_position, @employee_office_id)";
                                using (SqlCommand comm = new SqlCommand(stmt, conn))
                                {

                                    comm.Parameters.Add("@emp_full_name_1", SqlDbType.VarChar, 120).Value = row.Field<string>("FULL NAME").ToString();

                                    //comm.Parameters.Add("@employee_code", SqlDbType.VarChar, 10).Value = row.Field<string>("EMPLOYEE CODE").ToString();
                                    comm.Parameters.Add("@employee_full_name", SqlDbType.VarChar, 120).Value = row.Field<string>("FULL NAME").ToString();
                                    comm.Parameters.Add("@employee_position", SqlDbType.VarChar, 50).Value = row.Field<string>("POSITION").ToString();

                                    string office_name;
                                    if (string.IsNullOrWhiteSpace(row.Field<string>("OFFICE")))
                                    {
                                        office_name = "";
                                    }
                                    else
                                    {
                                        office_name = row.Field<string>("OFFICE").ToString();
                                    }

                                    SqlCommand command = new SqlCommand("select office_id from tblOffice where office_name=@office_name", conn);
                                    command.Parameters.Add("@office_name", SqlDbType.VarChar, 150).Value = office_name;
                                    SqlDataAdapter da = new SqlDataAdapter();
                                    da.SelectCommand = command;
                                    DataSet ds = new DataSet();
                                    da.Fill(ds, "tblOffice");

                                    // Initialize office_id
                                    int office_id;
                                    if (ds.Tables[0].Rows.Count > 0)
                                    {
                                        office_id = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0]);
                                    }
                                    else
                                    {
                                        office_id = 0;
                                    }

                                    comm.Parameters.Add("@employee_office_id", SqlDbType.Int, 20).Value = Convert.ToInt32(office_id);

                                    conn.Open();
                                    affectedRows = Convert.ToInt32(comm.ExecuteNonQuery());
                                    conn.Close();

                                }
                            }


                            Thread.Sleep(100);
                            backgroundWorkerProgress.ReportProgress(i);

                            if (backgroundWorkerProgress.CancellationPending)
                            {
                                e.Cancel = true;
                                backgroundWorkerProgress.ReportProgress(0);
                                return;
                            }

                            progressStat += 1;

                        }
                        // End for Loop
                        if (affectedRows <= 0)
                        {
                            MessageBox.Show("Some of the Datas Are Duplicated", "Additional Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    xlsConn.Close();

                }
            }

            e.Result = progressStat;

        }

        private void backgroundWorkerProgress_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pb1.Maximum = fileImportCount;
            pb1.Value = e.ProgressPercentage;
            Double totalLoaded = e.ProgressPercentage / 100;
            lblProgressIndicator.Text = pb1.Value.ToString() + "%";
            
        }

        private void backgroundWorkerProgress_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (e.Cancelled)
            {
                lblProgressProcessed.Text = "Process Cancelled!";
            }
            else if (e.Error != null)
            {
                lblProgressProcessed.Text = e.Error.Message;
            }
            else
            {
                lblProgressProcessed.Text = "Done Processing " + e.Result.ToString() + " Datas.";
            }

        }


    }
}
