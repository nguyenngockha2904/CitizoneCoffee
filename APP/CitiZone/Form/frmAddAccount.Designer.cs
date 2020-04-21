namespace CitiZone
{
    partial class frmAddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAccount));
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.lblRPW = new System.Windows.Forms.Label();
            this.ptbBConfirm = new System.Windows.Forms.PictureBox();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.ptbConfirm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPosition
            // 
            this.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.ItemHeight = 13;
            this.cbPosition.Location = new System.Drawing.Point(174, 144);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(149, 21);
            this.cbPosition.TabIndex = 13;
            this.cbPosition.SelectedIndexChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(174, 65);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 20);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(174, 29);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(150, 20);
            this.txtUsername.TabIndex = 11;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.Location = new System.Drawing.Point(19, 144);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(47, 13);
            this.lblPosition.TabIndex = 10;
            this.lblPosition.Text = "Position:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Location = new System.Drawing.Point(19, 65);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(104, 13);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Choose a Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Location = new System.Drawing.Point(19, 29);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(101, 13);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Create a Username:";
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(174, 104);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(150, 20);
            this.txtRePassword.TabIndex = 13;
            this.txtRePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRePassword.UseSystemPasswordChar = true;
            this.txtRePassword.TextChanged += new System.EventHandler(this.tbx_TextChanged);
            // 
            // lblRPW
            // 
            this.lblRPW.AutoSize = true;
            this.lblRPW.BackColor = System.Drawing.Color.Transparent;
            this.lblRPW.Location = new System.Drawing.Point(19, 104);
            this.lblRPW.Name = "lblRPW";
            this.lblRPW.Size = new System.Drawing.Size(100, 13);
            this.lblRPW.TabIndex = 16;
            this.lblRPW.Text = "Re-enter Password:";
            // 
            // ptbBConfirm
            // 
            this.ptbBConfirm.BackColor = System.Drawing.Color.Transparent;
            this.ptbBConfirm.Image = ((System.Drawing.Image)(resources.GetObject("ptbBConfirm.Image")));
            this.ptbBConfirm.Location = new System.Drawing.Point(343, 29);
            this.ptbBConfirm.Name = "ptbBConfirm";
            this.ptbBConfirm.Size = new System.Drawing.Size(35, 35);
            this.ptbBConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBConfirm.TabIndex = 17;
            this.ptbBConfirm.TabStop = false;
            // 
            // ptbClose
            // 
            this.ptbClose.BackColor = System.Drawing.Color.Transparent;
            this.ptbClose.Image = ((System.Drawing.Image)(resources.GetObject("ptbClose.Image")));
            this.ptbClose.Location = new System.Drawing.Point(343, 70);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(35, 35);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbClose.TabIndex = 18;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // ptbConfirm
            // 
            this.ptbConfirm.BackColor = System.Drawing.Color.Transparent;
            this.ptbConfirm.Image = ((System.Drawing.Image)(resources.GetObject("ptbConfirm.Image")));
            this.ptbConfirm.Location = new System.Drawing.Point(343, 29);
            this.ptbConfirm.Name = "ptbConfirm";
            this.ptbConfirm.Size = new System.Drawing.Size(35, 35);
            this.ptbConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbConfirm.TabIndex = 19;
            this.ptbConfirm.TabStop = false;
            this.ptbConfirm.Visible = false;
            this.ptbConfirm.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // frmAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(397, 194);
            this.Controls.Add(this.ptbConfirm);
            this.Controls.Add(this.ptbClose);
            this.Controls.Add(this.ptbBConfirm);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.lblRPW);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Account";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Label lblRPW;
        private System.Windows.Forms.PictureBox ptbBConfirm;
        private System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.PictureBox ptbConfirm;
    }
}