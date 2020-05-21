namespace CitiZone
{
    partial class frmManageAccount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageAccount));
            this.dgvQLTK = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptbAddAccount = new System.Windows.Forms.PictureBox();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.ptbInfoAccount = new System.Windows.Forms.PictureBox();
            this.ptbDeleteAccount = new System.Windows.Forms.PictureBox();
            this.pnlManageAccount = new System.Windows.Forms.Panel();
            this.ptbEditAccount = new System.Windows.Forms.PictureBox();
            this.ptbPrint = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfoAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDeleteAccount)).BeginInit();
            this.pnlManageAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEditAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQLTK
            // 
            this.dgvQLTK.AllowUserToAddRows = false;
            this.dgvQLTK.AllowUserToDeleteRows = false;
            this.dgvQLTK.AllowUserToResizeColumns = false;
            this.dgvQLTK.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvQLTK.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQLTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLTK.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLTK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQLTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Fullname,
            this.Quyen,
            this.pw});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQLTK.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQLTK.Location = new System.Drawing.Point(13, 13);
            this.dgvQLTK.MultiSelect = false;
            this.dgvQLTK.Name = "dgvQLTK";
            this.dgvQLTK.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQLTK.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQLTK.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvQLTK.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvQLTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQLTK.Size = new System.Drawing.Size(685, 369);
            this.dgvQLTK.TabIndex = 7;
            this.dgvQLTK.DoubleClick += new System.EventHandler(this.ptbViewInfo_Click);
            this.dgvQLTK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmManageAccount_KeyDown);
            // 
            // Username
            // 
            this.Username.DataPropertyName = "usn";
            this.Username.FillWeight = 75F;
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Fullname
            // 
            this.Fullname.DataPropertyName = "Fullname";
            this.Fullname.HeaderText = "Fullname";
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            // 
            // Quyen
            // 
            this.Quyen.DataPropertyName = "quyen";
            this.Quyen.FillWeight = 45F;
            this.Quyen.HeaderText = "Position";
            this.Quyen.Name = "Quyen";
            this.Quyen.ReadOnly = true;
            // 
            // pw
            // 
            this.pw.DataPropertyName = "pw";
            this.pw.HeaderText = "pw";
            this.pw.Name = "pw";
            this.pw.ReadOnly = true;
            this.pw.Visible = false;
            // 
            // ptbAddAccount
            // 
            this.ptbAddAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbAddAccount.BackgroundImage")));
            this.ptbAddAccount.Location = new System.Drawing.Point(732, 35);
            this.ptbAddAccount.Name = "ptbAddAccount";
            this.ptbAddAccount.Size = new System.Drawing.Size(50, 50);
            this.ptbAddAccount.TabIndex = 13;
            this.ptbAddAccount.TabStop = false;
            this.ptbAddAccount.Click += new System.EventHandler(this.ptbAdd_Click);
            // 
            // ptbClose
            // 
            this.ptbClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbClose.BackgroundImage")));
            this.ptbClose.Location = new System.Drawing.Point(732, 310);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(50, 50);
            this.ptbClose.TabIndex = 14;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.ptbClose_Click);
            // 
            // ptbInfoAccount
            // 
            this.ptbInfoAccount.Image = ((System.Drawing.Image)(resources.GetObject("ptbInfoAccount.Image")));
            this.ptbInfoAccount.Location = new System.Drawing.Point(732, 242);
            this.ptbInfoAccount.Name = "ptbInfoAccount";
            this.ptbInfoAccount.Size = new System.Drawing.Size(50, 50);
            this.ptbInfoAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbInfoAccount.TabIndex = 15;
            this.ptbInfoAccount.TabStop = false;
            this.ptbInfoAccount.Click += new System.EventHandler(this.ptbViewInfo_Click);
            // 
            // ptbDeleteAccount
            // 
            this.ptbDeleteAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbDeleteAccount.BackgroundImage")));
            this.ptbDeleteAccount.Location = new System.Drawing.Point(732, 174);
            this.ptbDeleteAccount.Name = "ptbDeleteAccount";
            this.ptbDeleteAccount.Size = new System.Drawing.Size(50, 50);
            this.ptbDeleteAccount.TabIndex = 16;
            this.ptbDeleteAccount.TabStop = false;
            this.ptbDeleteAccount.Click += new System.EventHandler(this.ptbDelete_Click);
            // 
            // pnlManageAccount
            // 
            this.pnlManageAccount.BackColor = System.Drawing.Color.Transparent;
            this.pnlManageAccount.Controls.Add(this.ptbPrint);
            this.pnlManageAccount.Controls.Add(this.ptbDeleteAccount);
            this.pnlManageAccount.Controls.Add(this.ptbInfoAccount);
            this.pnlManageAccount.Controls.Add(this.ptbEditAccount);
            this.pnlManageAccount.Controls.Add(this.ptbClose);
            this.pnlManageAccount.Controls.Add(this.ptbAddAccount);
            this.pnlManageAccount.Controls.Add(this.dgvQLTK);
            this.pnlManageAccount.Location = new System.Drawing.Point(32, 30);
            this.pnlManageAccount.Name = "pnlManageAccount";
            this.pnlManageAccount.Size = new System.Drawing.Size(804, 382);
            this.pnlManageAccount.TabIndex = 13;
            // 
            // ptbEditAccount
            // 
            this.ptbEditAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbEditAccount.BackgroundImage")));
            this.ptbEditAccount.Location = new System.Drawing.Point(732, 106);
            this.ptbEditAccount.Name = "ptbEditAccount";
            this.ptbEditAccount.Size = new System.Drawing.Size(50, 50);
            this.ptbEditAccount.TabIndex = 14;
            this.ptbEditAccount.TabStop = false;
            this.ptbEditAccount.Click += new System.EventHandler(this.ptbEdit_Click);
            // 
            // ptbPrint
            // 
            this.ptbPrint.BackColor = System.Drawing.Color.White;
            this.ptbPrint.Image = ((System.Drawing.Image)(resources.GetObject("ptbPrint.Image")));
            this.ptbPrint.Location = new System.Drawing.Point(647, 333);
            this.ptbPrint.Name = "ptbPrint";
            this.ptbPrint.Size = new System.Drawing.Size(40, 40);
            this.ptbPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPrint.TabIndex = 28;
            this.ptbPrint.TabStop = false;
            this.ptbPrint.Click += new System.EventHandler(this.ptbPrint_Click);
            // 
            // frmManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(866, 452);
            this.Controls.Add(this.pnlManageAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmManageAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Account";
            this.Load += new System.EventHandler(this.frmManageAccount_Load);
            this.ClientSizeChanged += new System.EventHandler(this.frmManageAccount_ClientSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAddAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfoAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDeleteAccount)).EndInit();
            this.pnlManageAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbEditAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPrint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvQLTK;
        private System.Windows.Forms.PictureBox ptbDeleteAccount;
        private System.Windows.Forms.PictureBox ptbInfoAccount;
        private System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.PictureBox ptbAddAccount;
        private System.Windows.Forms.Panel pnlManageAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn pw;
        private System.Windows.Forms.PictureBox ptbEditAccount;
        private System.Windows.Forms.PictureBox ptbPrint;
    }
}