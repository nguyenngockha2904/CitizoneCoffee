namespace CitiZone
{
    partial class frmAddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCategory));
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.ptbConfirm = new System.Windows.Forms.PictureBox();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.ptbBConfirm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(125, 59);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(227, 20);
            this.txtCategoryName.TabIndex = 21;
            this.txtCategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCategoryName.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(125, 23);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(227, 20);
            this.txtCategoryID.TabIndex = 20;
            this.txtCategoryID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCategoryID.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoryName.Location = new System.Drawing.Point(21, 59);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(83, 13);
            this.lblCategoryName.TabIndex = 18;
            this.lblCategoryName.Text = "Category Name:";
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoryID.Location = new System.Drawing.Point(21, 23);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(66, 13);
            this.lblCategoryID.TabIndex = 17;
            this.lblCategoryID.Text = "Category ID:";
            // 
            // ptbConfirm
            // 
            this.ptbConfirm.BackColor = System.Drawing.Color.Transparent;
            this.ptbConfirm.Image = ((System.Drawing.Image)(resources.GetObject("ptbConfirm.Image")));
            this.ptbConfirm.Location = new System.Drawing.Point(365, 10);
            this.ptbConfirm.Name = "ptbConfirm";
            this.ptbConfirm.Size = new System.Drawing.Size(35, 35);
            this.ptbConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbConfirm.TabIndex = 31;
            this.ptbConfirm.TabStop = false;
            this.ptbConfirm.Visible = false;
            this.ptbConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ptbClose
            // 
            this.ptbClose.BackColor = System.Drawing.Color.Transparent;
            this.ptbClose.Image = ((System.Drawing.Image)(resources.GetObject("ptbClose.Image")));
            this.ptbClose.Location = new System.Drawing.Point(365, 51);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(35, 35);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbClose.TabIndex = 30;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ptbBConfirm
            // 
            this.ptbBConfirm.BackColor = System.Drawing.Color.Transparent;
            this.ptbBConfirm.Image = ((System.Drawing.Image)(resources.GetObject("ptbBConfirm.Image")));
            this.ptbBConfirm.Location = new System.Drawing.Point(365, 10);
            this.ptbBConfirm.Name = "ptbBConfirm";
            this.ptbBConfirm.Size = new System.Drawing.Size(35, 35);
            this.ptbBConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBConfirm.TabIndex = 29;
            this.ptbBConfirm.TabStop = false;
            // 
            // frmAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(413, 101);
            this.Controls.Add(this.ptbConfirm);
            this.Controls.Add(this.ptbClose);
            this.Controls.Add(this.ptbBConfirm);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.lblCategoryID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Category";
            this.Load += new System.EventHandler(this.frmAddCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.PictureBox ptbConfirm;
        private System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.PictureBox ptbBConfirm;
    }
}