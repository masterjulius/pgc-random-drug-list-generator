namespace RandomDrugTest
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.txtMDUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtMDPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnMDLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnMDClose = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(29, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "US&ERNAME :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(29, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "PASS&WORD :";
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(521, 77);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(263, 29);
            this.txtUser.TabIndex = 1;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPass
            // 
            this.txtPass.Enabled = false;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(521, 126);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(263, 29);
            this.txtPass.TabIndex = 3;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogin
            // 
            this.btnLogin.Enabled = false;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(521, 205);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(125, 44);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "&SIGN IN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(659, 205);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 44);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.lblWarning.Location = new System.Drawing.Point(133, 182);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(328, 21);
            this.lblWarning.TabIndex = 6;
            this.lblWarning.Text = "label3";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMDUser
            // 
            this.txtMDUser.Depth = 0;
            this.txtMDUser.Hint = "Enter username";
            this.txtMDUser.Location = new System.Drawing.Point(133, 90);
            this.txtMDUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMDUser.Name = "txtMDUser";
            this.txtMDUser.PasswordChar = '\0';
            this.txtMDUser.SelectedText = "";
            this.txtMDUser.SelectionLength = 0;
            this.txtMDUser.SelectionStart = 0;
            this.txtMDUser.Size = new System.Drawing.Size(328, 23);
            this.txtMDUser.TabIndex = 0;
            this.txtMDUser.TabStop = false;
            this.txtMDUser.UseSystemPasswordChar = false;
            // 
            // txtMDPass
            // 
            this.txtMDPass.Depth = 0;
            this.txtMDPass.Hint = "Enter password";
            this.txtMDPass.Location = new System.Drawing.Point(133, 143);
            this.txtMDPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMDPass.Name = "txtMDPass";
            this.txtMDPass.PasswordChar = '●';
            this.txtMDPass.SelectedText = "";
            this.txtMDPass.SelectionLength = 0;
            this.txtMDPass.SelectionStart = 0;
            this.txtMDPass.Size = new System.Drawing.Size(328, 23);
            this.txtMDPass.TabIndex = 1;
            this.txtMDPass.TabStop = false;
            this.txtMDPass.UseSystemPasswordChar = false;
            this.txtMDPass.Click += new System.EventHandler(this.txtMDPass_Click);
            this.txtMDPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMDPass_KeyDown);
            this.txtMDPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMDPass_KeyUp);
            // 
            // btnMDLogin
            // 
            this.btnMDLogin.Depth = 0;
            this.btnMDLogin.Location = new System.Drawing.Point(201, 221);
            this.btnMDLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMDLogin.Name = "btnMDLogin";
            this.btnMDLogin.Primary = true;
            this.btnMDLogin.Size = new System.Drawing.Size(130, 35);
            this.btnMDLogin.TabIndex = 2;
            this.btnMDLogin.TabStop = false;
            this.btnMDLogin.Text = "Sign In";
            this.btnMDLogin.UseVisualStyleBackColor = true;
            this.btnMDLogin.Click += new System.EventHandler(this.btnMDLogin_Click);
            // 
            // btnMDClose
            // 
            this.btnMDClose.Depth = 0;
            this.btnMDClose.Location = new System.Drawing.Point(337, 221);
            this.btnMDClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMDClose.Name = "btnMDClose";
            this.btnMDClose.Primary = true;
            this.btnMDClose.Size = new System.Drawing.Size(130, 35);
            this.btnMDClose.TabIndex = 3;
            this.btnMDClose.TabStop = false;
            this.btnMDClose.Text = "Close";
            this.btnMDClose.UseVisualStyleBackColor = true;
            this.btnMDClose.Click += new System.EventHandler(this.btnMDClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 282);
            this.Controls.Add(this.btnMDClose);
            this.Controls.Add(this.btnMDLogin);
            this.Controls.Add(this.txtMDPass);
            this.Controls.Add(this.txtMDUser);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGN IN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblWarning;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMDUser;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMDPass;
        private MaterialSkin.Controls.MaterialRaisedButton btnMDLogin;
        private MaterialSkin.Controls.MaterialRaisedButton btnMDClose;
    }
}

