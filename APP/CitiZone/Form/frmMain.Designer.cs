namespace CitiZone
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabForManagers = new System.Windows.Forms.TabPage();
            this.pnlForManagers = new System.Windows.Forms.Panel();
            this.ptbManageAccount = new System.Windows.Forms.PictureBox();
            this.lblManage = new System.Windows.Forms.Label();
            this.ptbStatistics = new System.Windows.Forms.PictureBox();
            this.lblStatistics = new System.Windows.Forms.Label();
            this.ptbManageCategories = new System.Windows.Forms.PictureBox();
            this.lblManageCategories = new System.Windows.Forms.Label();
            this.tabCitiZone = new System.Windows.Forms.TabPage();
            this.pnlCitiZone = new System.Windows.Forms.Panel();
            this.ptbSale = new System.Windows.Forms.PictureBox();
            this.lblSale = new System.Windows.Forms.Label();
            this.ptbLogOut = new System.Windows.Forms.PictureBox();
            this.ptbViewInfo = new System.Windows.Forms.PictureBox();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.lblViewInfo = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabForManagers.SuspendLayout();
            this.pnlForManagers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbManageAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbManageCategories)).BeginInit();
            this.tabCitiZone.SuspendLayout();
            this.pnlCitiZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbViewInfo)).BeginInit();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabForManagers
            // 
            this.tabForManagers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabForManagers.BackgroundImage")));
            this.tabForManagers.Controls.Add(this.pnlForManagers);
            this.tabForManagers.Location = new System.Drawing.Point(4, 22);
            this.tabForManagers.Name = "tabForManagers";
            this.tabForManagers.Size = new System.Drawing.Size(830, 473);
            this.tabForManagers.TabIndex = 0;
            this.tabForManagers.Text = "For Managers";
            this.tabForManagers.UseVisualStyleBackColor = true;
            // 
            // pnlForManagers
            // 
            this.pnlForManagers.Controls.Add(this.ptbManageAccount);
            this.pnlForManagers.Controls.Add(this.lblManage);
            this.pnlForManagers.Controls.Add(this.ptbStatistics);
            this.pnlForManagers.Controls.Add(this.lblStatistics);
            this.pnlForManagers.Controls.Add(this.ptbManageCategories);
            this.pnlForManagers.Controls.Add(this.lblManageCategories);
            this.pnlForManagers.Location = new System.Drawing.Point(81, 98);
            this.pnlForManagers.Name = "pnlForManagers";
            this.pnlForManagers.Size = new System.Drawing.Size(675, 258);
            this.pnlForManagers.TabIndex = 0;
            // 
            // ptbManageAccount
            // 
            this.ptbManageAccount.Image = ((System.Drawing.Image)(resources.GetObject("ptbManageAccount.Image")));
            this.ptbManageAccount.Location = new System.Drawing.Point(28, 31);
            this.ptbManageAccount.Name = "ptbManageAccount";
            this.ptbManageAccount.Size = new System.Drawing.Size(150, 150);
            this.ptbManageAccount.TabIndex = 12;
            this.ptbManageAccount.TabStop = false;
            this.ptbManageAccount.Click += new System.EventHandler(this.ptbManageAccount_Click);
            this.ptbManageAccount.MouseLeave += new System.EventHandler(this.ptbManageAccount_MouseLeave);
            this.ptbManageAccount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbManageAccount_MouseMove);
            // 
            // lblManage
            // 
            this.lblManage.AutoSize = true;
            this.lblManage.Font = new System.Drawing.Font("Gadugi", 17.25F);
            this.lblManage.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblManage.Location = new System.Drawing.Point(8, 204);
            this.lblManage.Name = "lblManage";
            this.lblManage.Size = new System.Drawing.Size(196, 27);
            this.lblManage.TabIndex = 11;
            this.lblManage.Text = "Manage Accounts";
            this.lblManage.Visible = false;
            // 
            // ptbStatistics
            // 
            this.ptbStatistics.Image = ((System.Drawing.Image)(resources.GetObject("ptbStatistics.Image")));
            this.ptbStatistics.Location = new System.Drawing.Point(484, 31);
            this.ptbStatistics.Name = "ptbStatistics";
            this.ptbStatistics.Size = new System.Drawing.Size(150, 150);
            this.ptbStatistics.TabIndex = 10;
            this.ptbStatistics.TabStop = false;
            this.ptbStatistics.Click += new System.EventHandler(this.ptbStatistical_Click);
            this.ptbStatistics.MouseLeave += new System.EventHandler(this.ptbStatistical_MouseLeave);
            this.ptbStatistics.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbStatistical_MouseMove);
            // 
            // lblStatistics
            // 
            this.lblStatistics.AutoSize = true;
            this.lblStatistics.Font = new System.Drawing.Font("Gadugi", 17.25F);
            this.lblStatistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.lblStatistics.Location = new System.Drawing.Point(507, 204);
            this.lblStatistics.Name = "lblStatistics";
            this.lblStatistics.Size = new System.Drawing.Size(103, 27);
            this.lblStatistics.TabIndex = 9;
            this.lblStatistics.Text = "Statistics";
            this.lblStatistics.Visible = false;
            // 
            // ptbManageCategories
            // 
            this.ptbManageCategories.Image = ((System.Drawing.Image)(resources.GetObject("ptbManageCategories.Image")));
            this.ptbManageCategories.Location = new System.Drawing.Point(257, 31);
            this.ptbManageCategories.Name = "ptbManageCategories";
            this.ptbManageCategories.Size = new System.Drawing.Size(150, 150);
            this.ptbManageCategories.TabIndex = 8;
            this.ptbManageCategories.TabStop = false;
            this.ptbManageCategories.Click += new System.EventHandler(this.ptbManageCategories_Click);
            this.ptbManageCategories.MouseLeave += new System.EventHandler(this.ptbManageCategories_MouseLeave);
            this.ptbManageCategories.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbManageCategories_MouseMove);
            // 
            // lblManageCategories
            // 
            this.lblManageCategories.AutoSize = true;
            this.lblManageCategories.Font = new System.Drawing.Font("Gadugi", 17.25F);
            this.lblManageCategories.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblManageCategories.Location = new System.Drawing.Point(226, 204);
            this.lblManageCategories.Name = "lblManageCategories";
            this.lblManageCategories.Size = new System.Drawing.Size(211, 27);
            this.lblManageCategories.TabIndex = 7;
            this.lblManageCategories.Text = "Manage Categories";
            this.lblManageCategories.Visible = false;
            // 
            // tabCitiZone
            // 
            this.tabCitiZone.BackColor = System.Drawing.Color.White;
            this.tabCitiZone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabCitiZone.BackgroundImage")));
            this.tabCitiZone.Controls.Add(this.pnlCitiZone);
            this.tabCitiZone.Location = new System.Drawing.Point(4, 22);
            this.tabCitiZone.Name = "tabCitiZone";
            this.tabCitiZone.Padding = new System.Windows.Forms.Padding(3);
            this.tabCitiZone.Size = new System.Drawing.Size(830, 473);
            this.tabCitiZone.TabIndex = 0;
            this.tabCitiZone.Text = "CitiZone";
            // 
            // pnlCitiZone
            // 
            this.pnlCitiZone.BackColor = System.Drawing.Color.Transparent;
            this.pnlCitiZone.Controls.Add(this.ptbSale);
            this.pnlCitiZone.Controls.Add(this.lblSale);
            this.pnlCitiZone.Controls.Add(this.ptbLogOut);
            this.pnlCitiZone.Controls.Add(this.ptbViewInfo);
            this.pnlCitiZone.Controls.Add(this.lblLogOut);
            this.pnlCitiZone.Controls.Add(this.lblViewInfo);
            this.pnlCitiZone.Location = new System.Drawing.Point(111, 117);
            this.pnlCitiZone.Name = "pnlCitiZone";
            this.pnlCitiZone.Size = new System.Drawing.Size(624, 228);
            this.pnlCitiZone.TabIndex = 1;
            // 
            // ptbSale
            // 
            this.ptbSale.Image = ((System.Drawing.Image)(resources.GetObject("ptbSale.Image")));
            this.ptbSale.Location = new System.Drawing.Point(21, 3);
            this.ptbSale.Name = "ptbSale";
            this.ptbSale.Size = new System.Drawing.Size(170, 170);
            this.ptbSale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSale.TabIndex = 10;
            this.ptbSale.TabStop = false;
            this.ptbSale.Click += new System.EventHandler(this.ptbSale_Click);
            this.ptbSale.MouseLeave += new System.EventHandler(this.ptbSale_MouseLeave);
            this.ptbSale.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbSale_MouseMove);
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Font = new System.Drawing.Font("Gadugi", 17.25F);
            this.lblSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(153)))), ((int)(((byte)(70)))));
            this.lblSale.Location = new System.Drawing.Point(78, 186);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(54, 27);
            this.lblSale.TabIndex = 9;
            this.lblSale.Text = "Sale";
            this.lblSale.Visible = false;
            // 
            // ptbLogOut
            // 
            this.ptbLogOut.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogOut.Image")));
            this.ptbLogOut.Location = new System.Drawing.Point(460, 13);
            this.ptbLogOut.Name = "ptbLogOut";
            this.ptbLogOut.Size = new System.Drawing.Size(150, 150);
            this.ptbLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ptbLogOut.TabIndex = 8;
            this.ptbLogOut.TabStop = false;
            this.ptbLogOut.Click += new System.EventHandler(this.ptbLogOut_Click);
            this.ptbLogOut.MouseLeave += new System.EventHandler(this.ptbLogOut_MouseLeave);
            this.ptbLogOut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbLogOut_MouseMove);
            // 
            // ptbViewInfo
            // 
            this.ptbViewInfo.Image = ((System.Drawing.Image)(resources.GetObject("ptbViewInfo.Image")));
            this.ptbViewInfo.Location = new System.Drawing.Point(240, 13);
            this.ptbViewInfo.Name = "ptbViewInfo";
            this.ptbViewInfo.Size = new System.Drawing.Size(150, 150);
            this.ptbViewInfo.TabIndex = 7;
            this.ptbViewInfo.TabStop = false;
            this.ptbViewInfo.Click += new System.EventHandler(this.ptbViewInfo_Click);
            this.ptbViewInfo.MouseLeave += new System.EventHandler(this.ptbViewInfo_MouseLeave);
            this.ptbViewInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbViewInfo_MouseMove);
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Font = new System.Drawing.Font("Gadugi", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(75)))), ((int)(((byte)(70)))));
            this.lblLogOut.Location = new System.Drawing.Point(490, 186);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(94, 27);
            this.lblLogOut.TabIndex = 5;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.Visible = false;
            // 
            // lblViewInfo
            // 
            this.lblViewInfo.AutoSize = true;
            this.lblViewInfo.Font = new System.Drawing.Font("Gadugi", 17.25F);
            this.lblViewInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
            this.lblViewInfo.Location = new System.Drawing.Point(264, 186);
            this.lblViewInfo.Name = "lblViewInfo";
            this.lblViewInfo.Size = new System.Drawing.Size(106, 27);
            this.lblViewInfo.TabIndex = 4;
            this.lblViewInfo.Text = "View Info";
            this.lblViewInfo.Visible = false;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabCitiZone);
            this.tabMain.Controls.Add(this.tabForManagers);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(838, 499);
            this.tabMain.TabIndex = 0;
            this.tabMain.Click += new System.EventHandler(this.mainTab_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 499);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee House";
            this.Load += new System.EventHandler(this.frmCitiZone_Load);
            this.ClientSizeChanged += new System.EventHandler(this.frmCitiZone_ClientSizeChanged);
            this.tabForManagers.ResumeLayout(false);
            this.pnlForManagers.ResumeLayout(false);
            this.pnlForManagers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbManageAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbManageCategories)).EndInit();
            this.tabCitiZone.ResumeLayout(false);
            this.pnlCitiZone.ResumeLayout(false);
            this.pnlCitiZone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbViewInfo)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabForManagers;
        private System.Windows.Forms.Panel pnlForManagers;
        private System.Windows.Forms.PictureBox ptbManageAccount;
        private System.Windows.Forms.Label lblManage;
        private System.Windows.Forms.PictureBox ptbStatistics;
        private System.Windows.Forms.Label lblStatistics;
        private System.Windows.Forms.PictureBox ptbManageCategories;
        private System.Windows.Forms.Label lblManageCategories;
        private System.Windows.Forms.TabPage tabCitiZone;
        private System.Windows.Forms.Panel pnlCitiZone;
        private System.Windows.Forms.PictureBox ptbSale;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.PictureBox ptbLogOut;
        private System.Windows.Forms.PictureBox ptbViewInfo;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.Label lblViewInfo;
        private System.Windows.Forms.TabControl tabMain;
    }
}