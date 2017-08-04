namespace RandomDrugTest
{
    partial class FRM_GENERATED_LIST
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
            this.dgvGeneratedList = new System.Windows.Forms.DataGridView();
            this.btnMDPrint = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneratedList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGeneratedList
            // 
            this.dgvGeneratedList.AllowUserToAddRows = false;
            this.dgvGeneratedList.AllowUserToDeleteRows = false;
            this.dgvGeneratedList.BackgroundColor = System.Drawing.Color.White;
            this.dgvGeneratedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneratedList.Location = new System.Drawing.Point(12, 78);
            this.dgvGeneratedList.Name = "dgvGeneratedList";
            this.dgvGeneratedList.ReadOnly = true;
            this.dgvGeneratedList.Size = new System.Drawing.Size(691, 440);
            this.dgvGeneratedList.TabIndex = 0;
            // 
            // btnMDPrint
            // 
            this.btnMDPrint.Depth = 0;
            this.btnMDPrint.Location = new System.Drawing.Point(592, 32);
            this.btnMDPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMDPrint.Name = "btnMDPrint";
            this.btnMDPrint.Primary = true;
            this.btnMDPrint.Size = new System.Drawing.Size(111, 23);
            this.btnMDPrint.TabIndex = 1;
            this.btnMDPrint.Text = "Print";
            this.btnMDPrint.UseVisualStyleBackColor = true;
            this.btnMDPrint.Click += new System.EventHandler(this.btnMDPrint_Click);
            // 
            // FRM_GENERATED_LIST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 530);
            this.Controls.Add(this.btnMDPrint);
            this.Controls.Add(this.dgvGeneratedList);
            this.MinimizeBox = false;
            this.Name = "FRM_GENERATED_LIST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "List of employees who will undergo random drug test";
            this.Load += new System.EventHandler(this.FRM_GENERATED_LIST_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneratedList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGeneratedList;
        private MaterialSkin.Controls.MaterialRaisedButton btnMDPrint;
    }
}