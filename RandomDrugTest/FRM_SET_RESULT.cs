using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RandomDrugTest
{
    public partial class FRM_SET_RESULT : MaterialForm
    {
        public int batchID { get; set; }
        public int employeeID { get; set; }

        public FRM_SET_RESULT()
        {
            InitializeComponent();
        }

        private void FRM_SET_RESULT_Load(object sender, EventArgs e)
        {
            //set picturebox size and location same to its parent panel
            pbCamera.Size = pnlScannedResult.Size;
            pbCamera.Location = new Point(0, 0);
        }

        private void pbCamera_Click(object sender, EventArgs e)
        {
            ofdScannedResult.ShowDialog();
            if (ofdScannedResult.FileName != "")
            {
                pnlScannedResult.BackgroundImage = Image.FromFile(ofdScannedResult.FileName);
            }
        }

        private void pbCamera_MouseEnter(object sender, EventArgs e)
        {
            pbCamera.ImageLocation = Application.StartupPath + "/background/img_large_result_active.png";
        }

        private void pbCamera_MouseLeave(object sender, EventArgs e)
        {
            pbCamera.ImageLocation = Application.StartupPath + "/background/img_large_result_default.png";
        }

        private void ofdScannedResult_FileOk(object sender, CancelEventArgs e)
        {

        }

        // Save Functions
        private void _save_result_trigger()
        {
            
        }

        // Save Data
        private void _save_data()
        {
            using (SqlConnection conn = new SqlConnection(Global.connStr))
            {
                string stmt = "insert into tblTestResults (result_batch_id, result_code, result_employee_id, result_methamphetamine_is_positive, result_is_tetrahydrocannibinol_is_positiive, result_image_name, result_remarks) values (@result_batch_id, @result_code, @result_employee_id, @result_methamphetamine_is_positive, @result_is_tetrahydrocannibinol_is_positiive, @result_image_name, @result_remarks)";
                using (SqlCommand comm = new SqlCommand(stmt,conn))
                {
                    comm.Parameters.Add("@result_batch_id", SqlDbType.VarChar).Value = batchID;
                    comm.Parameters.Add("@result_code", SqlDbType.VarChar).Value = "000" + batchID + "0" + employeeID;
                    comm.Parameters.Add("@result_employee_id", SqlDbType.BigInt).Value = employeeID;
                    comm.Parameters.Add("@result_methamphetamine_is_positive", SqlDbType.Bit).Value = batchID;
                    comm.Parameters.Add("@result_is_tetrahydrocannibinol_is_positiive", SqlDbType.Bit).Value = batchID;
                    comm.Parameters.Add("@result_image_name", SqlDbType.VarChar).Value = batchID;
                    comm.Parameters.Add("@result_remarks", SqlDbType.Text).Value = batchID;
                }
            }
        }

        // * Field Requirement Checker
        private Boolean _field_checker()
        {
            return false;
        }

    }
}
