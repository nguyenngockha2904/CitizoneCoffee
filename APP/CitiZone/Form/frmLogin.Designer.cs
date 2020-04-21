namespace CitiZone
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblquyen = new System.Windows.Forms.Label();
            this.ptbCitiZone = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.ptbConfirm = new System.Windows.Forms.PictureBox();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.ptbBConfirm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCitiZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblquyen
            // 
            this.lblquyen.AutoSize = true;
            this.lblquyen.Location = new System.Drawing.Point(16, 184);
            this.lblquyen.Name = "lblquyen";
            this.lblquyen.Size = new System.Drawing.Size(0, 13);
            this.lblquyen.TabIndex = 19;
            this.lblquyen.Visible = false;
            // 
            // ptbCitiZone
            // 
            this.ptbCitiZone.BackColor = System.Drawing.Color.Transparent;
            this.ptbCitiZone.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ptbCitiZone.ErrorImage")));
            this.ptbCitiZone.Image = ((System.Drawing.Image)(resources.GetObject("ptbCitiZone.Image")));
            this.ptbCitiZone.InitialImage = ((System.Drawing.Image)(resources.GetObject("ptbCitiZone.InitialImage")));
            this.ptbCitiZone.Location = new System.Drawing.Point(44, 12);
            this.ptbCitiZone.Name = "ptbCitiZone";
            this.ptbCitiZone.Size = new System.Drawing.Size(284, 84);
            this.ptbCitiZone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCitiZone.TabIndex = 17;
            this.ptbCitiZone.TabStop = false;
            this.ptbCitiZone.Click += new System.EventHandler(this.ptbCitiZone_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(90, 169);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(213, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(90, 129);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(213, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.BackColor = System.Drawing.Color.Transparent;
            this.lblpass.Location = new System.Drawing.Point(16, 171);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(56, 13);
            this.lblpass.TabIndex = 12;
            this.lblpass.Text = "Password:";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.BackColor = System.Drawing.Color.Transparent;
            this.lbluser.Location = new System.Drawing.Point(16, 132);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(58, 13);
            this.lbluser.TabIndex = 10;
            this.lbluser.Text = "Username:";
            // 
            // ptbConfirm
            // 
            this.ptbConfirm.BackColor = System.Drawing.Color.Transparent;
            this.ptbConfirm.Image = ((System.Drawing.Image)(resources.GetObject("ptbConfirm.Image")));
            this.ptbConfirm.Location = new System.Drawing.Point(320, 120);
            this.ptbConfirm.Name = "ptbConfirm";
            this.ptbConfirm.Size = new System.Drawing.Size(35, 35);
            this.ptbConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbConfirm.TabIndex = 22;
            this.ptbConfirm.TabStop = false;
            this.ptbConfirm.Visible = false;
            this.ptbConfirm.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // ptbClose
            // 
            this.ptbClose.BackColor = System.Drawing.Color.Transparent;
            this.ptbClose.Image = ((System.Drawing.Image)(resources.GetObject("ptbClose.Image")));
            this.ptbClose.Location = new System.Drawing.Point(320, 161);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(35, 35);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbClose.TabIndex = 21;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ptbBConfirm
            // 
            this.ptbBConfirm.BackColor = System.Drawing.Color.Transparent;
            this.ptbBConfirm.Image = ((System.Drawing.Image)(resources.GetObject("ptbBConfirm.Image")));
            this.ptbBConfirm.Location = new System.Drawing.Point(320, 120);
            this.ptbBConfirm.Name = "ptbBConfirm";
            this.ptbBConfirm.Size = new System.Drawing.Size(35, 35);
            this.ptbBConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBConfirm.TabIndex = 20;
            this.ptbBConfirm.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(365, 222);
            this.Controls.Add(this.ptbConfirm);
            this.Controls.Add(this.ptbClose);
            this.Controls.Add(this.ptbBConfirm);
            this.Controls.Add(this.lblquyen);
            this.Controls.Add(this.ptbCitiZone);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCitiZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblquyen;
        private System.Windows.Forms.PictureBox ptbCitiZone;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.PictureBox ptbConfirm;
        private System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.PictureBox ptbBConfirm;
    }
}

