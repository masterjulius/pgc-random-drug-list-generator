namespace RandomDrugTest
{
    partial class FRM_GENERATOR
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMDNameOfGenerator = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnMDProceed = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnMDMaybeLater = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "May we know who will generate random list this time?";
            // 
            // txtMDNameOfGenerator
            // 
            this.txtMDNameOfGenerator.Depth = 0;
            this.txtMDNameOfGenerator.Hint = "Please enter your name here";
            this.txtMDNameOfGenerator.Location = new System.Drawing.Point(12, 126);
            this.txtMDNameOfGenerator.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMDNameOfGenerator.Name = "txtMDNameOfGenerator";
            this.txtMDNameOfGenerator.PasswordChar = '\0';
            this.txtMDNameOfGenerator.SelectedText = "";
            this.txtMDNameOfGenerator.SelectionLength = 0;
            this.txtMDNameOfGenerator.SelectionStart = 0;
            this.txtMDNameOfGenerator.Size = new System.Drawing.Size(525, 23);
            this.txtMDNameOfGenerator.TabIndex = 1;
            this.txtMDNameOfGenerator.UseSystemPasswordChar = false;
            // 
            // btnMDProceed
            // 
            this.btnMDProceed.AutoSize = true;
            this.btnMDProceed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMDProceed.Depth = 0;
            this.btnMDProceed.Location = new System.Drawing.Point(465, 186);
            this.btnMDProceed.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMDProceed.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMDProceed.Name = "btnMDProceed";
            this.btnMDProceed.Primary = false;
            this.btnMDProceed.Size = new System.Drawing.Size(72, 36);
            this.btnMDProceed.TabIndex = 2;
            this.btnMDProceed.Text = "Proceed";
            this.btnMDProceed.UseVisualStyleBackColor = true;
            this.btnMDProceed.Click += new System.EventHandler(this.btnMDProceed_Click);
            // 
            // btnMDMaybeLater
            // 
            this.btnMDMaybeLater.AutoSize = true;
            this.btnMDMaybeLater.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMDMaybeLater.Depth = 0;
            this.btnMDMaybeLater.Location = new System.Drawing.Point(354, 186);
            this.btnMDMaybeLater.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMDMaybeLater.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMDMaybeLater.Name = "btnMDMaybeLater";
            this.btnMDMaybeLater.Primary = false;
            this.btnMDMaybeLater.Size = new System.Drawing.Size(103, 36);
            this.btnMDMaybeLater.TabIndex = 3;
            this.btnMDMaybeLater.Text = "Maybe Later";
            this.btnMDMaybeLater.UseVisualStyleBackColor = true;
            this.btnMDMaybeLater.Click += new System.EventHandler(this.btnMDMaybeLater_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-16, 181);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(584, 1);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // FRM_GENERATOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 226);
            this.ControlBox = false;
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnMDMaybeLater);
            this.Controls.Add(this.btnMDProceed);
            this.Controls.Add(this.txtMDNameOfGenerator);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_GENERATOR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FRM_GENERATOR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMDNameOfGenerator;
        private MaterialSkin.Controls.MaterialFlatButton btnMDProceed;
        private MaterialSkin.Controls.MaterialFlatButton btnMDMaybeLater;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}