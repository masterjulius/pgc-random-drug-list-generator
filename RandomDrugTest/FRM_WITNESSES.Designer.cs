namespace RandomDrugTest
{
    partial class FRM_WITNESSES
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
            this.txtMDWitness1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMDWitness2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMDProceed = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtMDWitness1
            // 
            this.txtMDWitness1.Depth = 0;
            this.txtMDWitness1.Hint = "Name of witness";
            this.txtMDWitness1.Location = new System.Drawing.Point(12, 134);
            this.txtMDWitness1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMDWitness1.Name = "txtMDWitness1";
            this.txtMDWitness1.PasswordChar = '\0';
            this.txtMDWitness1.SelectedText = "";
            this.txtMDWitness1.SelectionLength = 0;
            this.txtMDWitness1.SelectionStart = 0;
            this.txtMDWitness1.Size = new System.Drawing.Size(526, 23);
            this.txtMDWitness1.TabIndex = 0;
            this.txtMDWitness1.TabStop = false;
            this.txtMDWitness1.UseSystemPasswordChar = false;
            // 
            // txtMDWitness2
            // 
            this.txtMDWitness2.Depth = 0;
            this.txtMDWitness2.Hint = "Name of witness";
            this.txtMDWitness2.Location = new System.Drawing.Point(12, 194);
            this.txtMDWitness2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMDWitness2.Name = "txtMDWitness2";
            this.txtMDWitness2.PasswordChar = '\0';
            this.txtMDWitness2.SelectedText = "";
            this.txtMDWitness2.SelectionLength = 0;
            this.txtMDWitness2.SelectionStart = 0;
            this.txtMDWitness2.Size = new System.Drawing.Size(526, 23);
            this.txtMDWitness2.TabIndex = 1;
            this.txtMDWitness2.TabStop = false;
            this.txtMDWitness2.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter the name of witnesses below : ";
            // 
            // btnMDProceed
            // 
            this.btnMDProceed.Depth = 0;
            this.btnMDProceed.Location = new System.Drawing.Point(405, 258);
            this.btnMDProceed.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMDProceed.Name = "btnMDProceed";
            this.btnMDProceed.Primary = true;
            this.btnMDProceed.Size = new System.Drawing.Size(133, 32);
            this.btnMDProceed.TabIndex = 3;
            this.btnMDProceed.Text = "Proceed";
            this.btnMDProceed.UseVisualStyleBackColor = true;
            this.btnMDProceed.Click += new System.EventHandler(this.btnMDProceed_Click);
            // 
            // FRM_WITNESSES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 314);
            this.Controls.Add(this.btnMDProceed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMDWitness2);
            this.Controls.Add(this.txtMDWitness1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_WITNESSES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Name of Witnesses";
            this.Load += new System.EventHandler(this.FRM_WITNESSES_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtMDWitness1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMDWitness2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton btnMDProceed;
    }
}