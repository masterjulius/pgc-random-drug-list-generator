namespace RandomDrugTest
{
    partial class FRM_HOWMANY
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
            this.txtMDNum = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtMDNum
            // 
            this.txtMDNum.Depth = 0;
            this.txtMDNum.Hint = "Enter number here";
            this.txtMDNum.Location = new System.Drawing.Point(26, 126);
            this.txtMDNum.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMDNum.Name = "txtMDNum";
            this.txtMDNum.PasswordChar = '\0';
            this.txtMDNum.SelectedText = "";
            this.txtMDNum.SelectionLength = 0;
            this.txtMDNum.SelectionStart = 0;
            this.txtMDNum.Size = new System.Drawing.Size(525, 23);
            this.txtMDNum.TabIndex = 0;
            this.txtMDNum.TabStop = false;
            this.txtMDNum.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "How many employees you want to generate for random drug test?";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(410, 189);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(142, 31);
            this.materialRaisedButton1.TabIndex = 1;
            this.materialRaisedButton1.Text = "Generate List";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // FRM_HOWMANY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 246);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.txtMDNum);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_HOWMANY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FRM_HOWMANY_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtMDNum;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}