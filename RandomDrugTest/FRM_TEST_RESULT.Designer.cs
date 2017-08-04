namespace RandomDrugTest
{
    partial class FRM_TEST_RESULT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBatch = new System.Windows.Forms.DataGridView();
            this.cboBatch = new System.Windows.Forms.ComboBox();
            this.btnMDSetResult = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBatch
            // 
            this.dgvBatch.AllowUserToAddRows = false;
            this.dgvBatch.AllowUserToDeleteRows = false;
            this.dgvBatch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBatch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBatch.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBatch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBatch.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBatch.Location = new System.Drawing.Point(12, 122);
            this.dgvBatch.Name = "dgvBatch";
            this.dgvBatch.ReadOnly = true;
            this.dgvBatch.RowHeadersVisible = false;
            this.dgvBatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBatch.Size = new System.Drawing.Size(986, 466);
            this.dgvBatch.TabIndex = 0;
            this.dgvBatch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBatch_CellContentClick);
            this.dgvBatch.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBatch_CellContentDoubleClick);
            this.dgvBatch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBatch_CellDoubleClick);
            // 
            // cboBatch
            // 
            this.cboBatch.BackColor = System.Drawing.Color.White;
            this.cboBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBatch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBatch.FormattingEnabled = true;
            this.cboBatch.Location = new System.Drawing.Point(12, 79);
            this.cboBatch.Name = "cboBatch";
            this.cboBatch.Size = new System.Drawing.Size(299, 29);
            this.cboBatch.TabIndex = 1;
            this.cboBatch.SelectedIndexChanged += new System.EventHandler(this.cboBatch_SelectedIndexChanged);
            // 
            // btnMDSetResult
            // 
            this.btnMDSetResult.Depth = 0;
            this.btnMDSetResult.Location = new System.Drawing.Point(852, 77);
            this.btnMDSetResult.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMDSetResult.Name = "btnMDSetResult";
            this.btnMDSetResult.Primary = true;
            this.btnMDSetResult.Size = new System.Drawing.Size(146, 35);
            this.btnMDSetResult.TabIndex = 2;
            this.btnMDSetResult.Text = "Set Result";
            this.btnMDSetResult.UseVisualStyleBackColor = true;
            this.btnMDSetResult.Click += new System.EventHandler(this.btnMDSetResult_Click);
            // 
            // FRM_TEST_RESULT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 600);
            this.Controls.Add(this.btnMDSetResult);
            this.Controls.Add(this.cboBatch);
            this.Controls.Add(this.dgvBatch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_TEST_RESULT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRM_TEST_RESULT";
            this.Load += new System.EventHandler(this.FRM_TEST_RESULT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBatch;
        private System.Windows.Forms.ComboBox cboBatch;
        private MaterialSkin.Controls.MaterialRaisedButton btnMDSetResult;
    }
}