namespace CitiZone
{
    partial class frmInfoAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfoAccount));
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPW = new System.Windows.Forms.Label();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblBD = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblAR = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.lblAvatar = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Location = new System.Drawing.Point(268, 22);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username: ";
            // 
            // lblPW
            // 
            this.lblPW.AutoSize = true;
            this.lblPW.BackColor = System.Drawing.Color.Transparent;
            this.lblPW.Location = new System.Drawing.Point(268, 56);
            this.lblPW.Name = "lblPW";
            this.lblPW.Size = new System.Drawing.Size(56, 13);
            this.lblPW.TabIndex = 1;
            this.lblPW.Text = "Password:";
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.BackColor = System.Drawing.Color.Transparent;
            this.lblFN.Location = new System.Drawing.Point(268, 91);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(52, 13);
            this.lblFN.TabIndex = 2;
            this.lblFN.Text = "Fullname:";
            // 
            // lblBD
            // 
            this.lblBD.AutoSize = true;
            this.lblBD.BackColor = System.Drawing.Color.Transparent;
            this.lblBD.Location = new System.Drawing.Point(268, 127);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(48, 13);
            this.lblBD.TabIndex = 3;
            this.lblBD.Text = "Birthday:";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.BackColor = System.Drawing.Color.Transparent;
            this.lblP.Location = new System.Drawing.Point(268, 205);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(41, 13);
            this.lblP.TabIndex = 5;
            this.lblP.Text = "Phone:";
            // 
            // lblAR
            // 
            this.lblAR.AutoSize = true;
            this.lblAR.BackColor = System.Drawing.Color.Transparent;
            this.lblAR.Location = new System.Drawing.Point(268, 165);
            this.lblAR.Name = "lblAR";
            this.lblAR.Size = new System.Drawing.Size(48, 13);
            this.lblAR.TabIndex = 4;
            this.lblAR.Text = "Address:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(352, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(184, 20);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(352, 53);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(184, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(352, 202);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(184, 20);
            this.txtPhone.TabIndex = 6;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhone.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(352, 162);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(184, 20);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAddress.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Enabled = false;
            this.dtpBirthday.Location = new System.Drawing.Point(352, 127);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpBirthday.Size = new System.Drawing.Size(184, 20);
            this.dtpBirthday.TabIndex = 4;
            this.dtpBirthday.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            this.dtpBirthday.ValueChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(352, 88);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.ReadOnly = true;
            this.txtFullname.Size = new System.Drawing.Size(184, 20);
            this.txtFullname.TabIndex = 3;
            this.txtFullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFullname.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(461, 241);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(352, 241);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.BackColor = System.Drawing.Color.White;
            this.ptbAvatar.Enabled = false;
            this.ptbAvatar.Location = new System.Drawing.Point(23, 22);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(200, 200);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvatar.TabIndex = 9;
            this.ptbAvatar.TabStop = false;
            this.ptbAvatar.Click += new System.EventHandler(this.ptbAvatar_Click);
            // 
            // lblAvatar
            // 
            this.lblAvatar.AutoSize = true;
            this.lblAvatar.BackColor = System.Drawing.Color.Transparent;
            this.lblAvatar.Location = new System.Drawing.Point(103, 241);
            this.lblAvatar.Name = "lblAvatar";
            this.lblAvatar.Size = new System.Drawing.Size(38, 13);
            this.lblAvatar.TabIndex = 10;
            this.lblAvatar.Text = "Avatar";
            this.lblAvatar.Visible = false;
            this.lblAvatar.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(352, 241);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 11;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // frmInfoAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(561, 290);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblAvatar);
            this.Controls.Add(this.ptbAvatar);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFullname);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblAR);
            this.Controls.Add(this.lblBD);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.lblPW);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInfoAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info Account";
            this.Load += new System.EventHandler(this.frmInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPW;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblAR;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.PictureBox ptbAvatar;
        private System.Windows.Forms.Label lblAvatar;
        private System.Windows.Forms.Button btnChange;
    }
}