namespace RandomDrugTest {
    partial class FRM_HISTORY {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_HISTORY));
            this.toolStripEmployee = new System.Windows.Forms.ToolStrip();
            this.toolStripTxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnExit = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_datas = new System.Windows.Forms.DataGridView();
            this.toolStripEmployee.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripEmployee
            // 
            this.toolStripEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripEmployee.AutoSize = false;
            this.toolStripEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.toolStripEmployee.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripEmployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTxtSearch,
            this.toolStripBtnSearch,
            this.toolStripSeparator5,
            this.toolStripBtnExit});
            this.toolStripEmployee.Location = new System.Drawing.Point(0, 64);
            this.toolStripEmployee.Name = "toolStripEmployee";
            this.toolStripEmployee.Padding = new System.Windows.Forms.Padding(0, 5, 1, 5);
            this.toolStripEmployee.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripEmployee.Size = new System.Drawing.Size(1038, 39);
            this.toolStripEmployee.TabIndex = 15;
            this.toolStripEmployee.Text = "toolStrip1";
            // 
            // toolStripTxtSearch
            // 
            this.toolStripTxtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toolStripTxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTxtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTxtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripTxtSearch.Name = "toolStripTxtSearch";
            this.toolStripTxtSearch.Size = new System.Drawing.Size(180, 29);
            // 
            // toolStripBtnSearch
            // 
            this.toolStripBtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSearch.Image")));
            this.toolStripBtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSearch.Name = "toolStripBtnSearch";
            this.toolStripBtnSearch.Size = new System.Drawing.Size(23, 26);
            this.toolStripBtnSearch.Text = "SEARCH";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripBtnExit
            // 
            this.toolStripBtnExit.ForeColor = System.Drawing.Color.White;
            this.toolStripBtnExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnExit.Image")));
            this.toolStripBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnExit.Name = "toolStripBtnExit";
            this.toolStripBtnExit.Size = new System.Drawing.Size(59, 26);
            this.toolStripBtnExit.Text = "EXIT";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgv_datas);
            this.panel1.Location = new System.Drawing.Point(12, 106);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 40);
            this.panel1.Size = new System.Drawing.Size(947, 392);
            this.panel1.TabIndex = 16;
            // 
            // dgv_datas
            // 
            this.dgv_datas.AllowUserToAddRows = false;
            this.dgv_datas.AllowUserToDeleteRows = false;
            this.dgv_datas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_datas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_datas.Location = new System.Drawing.Point(10, 10);
            this.dgv_datas.Name = "dgv_datas";
            this.dgv_datas.ReadOnly = true;
            this.dgv_datas.Size = new System.Drawing.Size(927, 342);
            this.dgv_datas.TabIndex = 0;
            // 
            // FRM_HISTORY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripEmployee);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_HISTORY";
            this.Sizable = false;
            this.Text = "HISTORY";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_HISTORY_Load);
            this.toolStripEmployee.ResumeLayout(false);
            this.toolStripEmployee.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_datas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEmployee;
        private System.Windows.Forms.ToolStripTextBox toolStripTxtSearch;
        private System.Windows.Forms.ToolStripButton toolStripBtnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripBtnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_datas;
    }
}