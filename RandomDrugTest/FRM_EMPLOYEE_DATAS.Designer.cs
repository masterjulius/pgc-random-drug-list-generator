namespace RandomDrugTest
{
    partial class FRM_EMPLOYEE_DATAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_EMPLOYEE_DATAS));
            this.toolStripEmployee = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTxtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripEmployee
            // 
            this.toolStripEmployee.AutoSize = false;
            this.toolStripEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
            this.toolStripEmployee.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripEmployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnEdit,
            this.toolStripSeparator2,
            this.toolStripSeparator4,
            this.toolStripTxtSearch,
            this.toolStripBtnSearch,
            this.toolStripSeparator5,
            this.toolStripBtnExit});
            this.toolStripEmployee.Location = new System.Drawing.Point(-5, 64);
            this.toolStripEmployee.Name = "toolStripEmployee";
            this.toolStripEmployee.Padding = new System.Windows.Forms.Padding(0, 5, 1, 5);
            this.toolStripEmployee.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripEmployee.Size = new System.Drawing.Size(1008, 39);
            this.toolStripEmployee.TabIndex = 15;
            this.toolStripEmployee.Text = "toolStrip1";
            // 
            // toolStripBtnEdit
            // 
            this.toolStripBtnEdit.ForeColor = System.Drawing.Color.White;
            this.toolStripBtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnEdit.Image")));
            this.toolStripBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnEdit.Name = "toolStripBtnEdit";
            this.toolStripBtnEdit.Size = new System.Drawing.Size(63, 26);
            this.toolStripBtnEdit.Text = "EDIT";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.White;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(112, 26);
            this.toolStripSeparator4.Text = "SEARCH FOR: ";
            // 
            // toolStripTxtSearch
            // 
            this.toolStripTxtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toolStripTxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTxtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.toolStripTxtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolStripTxtSearch.Name = "toolStripTxtSearch";
            this.toolStripTxtSearch.Size = new System.Drawing.Size(220, 29);
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
            this.toolStripBtnExit.Size = new System.Drawing.Size(62, 26);
            this.toolStripBtnExit.Text = "EXIT";
            // 
            // FRM_EMPLOYEE_DATAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(981, 495);
            this.Controls.Add(this.toolStripEmployee);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_EMPLOYEE_DATAS";
            this.Text = "VIEW ALL EMPLOYEE DATAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_EMPLOYEE_DATAS_Load);
            this.toolStripEmployee.ResumeLayout(false);
            this.toolStripEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripEmployee;
        private System.Windows.Forms.ToolStripButton toolStripBtnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTxtSearch;
        private System.Windows.Forms.ToolStripButton toolStripBtnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripBtnExit;
    }
}