namespace CitiZone
{
    partial class frmAddFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddFood));
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.ptbBGConfirm = new System.Windows.Forms.PictureBox();
            this.ptbConfirm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBGConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoryID.Location = new System.Drawing.Point(26, 21);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(66, 13);
            this.lblCategoryID.TabIndex = 47;
            this.lblCategoryID.Text = "Category ID:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(122, 94);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(227, 20);
            this.txtPrice.TabIndex = 44;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(122, 58);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(227, 20);
            this.txtFoodName.TabIndex = 43;
            this.txtFoodName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFoodName.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Location = new System.Drawing.Point(26, 94);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 42;
            this.lblPrice.Text = "Price:";
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.BackColor = System.Drawing.Color.Transparent;
            this.lblFoodName.Location = new System.Drawing.Point(26, 58);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(65, 13);
            this.lblFoodName.TabIndex = 41;
            this.lblFoodName.Text = "Food Name:";
            // 
            // cbCategories
            // 
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(122, 21);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(227, 21);
            this.cbCategories.TabIndex = 48;
            // 
            // ptbClose
            // 
            this.ptbClose.BackColor = System.Drawing.Color.Transparent;
            this.ptbClose.Image = ((System.Drawing.Image)(resources.GetObject("ptbClose.Image")));
            this.ptbClose.Location = new System.Drawing.Point(366, 62);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(35, 35);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbClose.TabIndex = 49;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ptbBGConfirm
            // 
            this.ptbBGConfirm.BackColor = System.Drawing.Color.Transparent;
            this.ptbBGConfirm.Image = ((System.Drawing.Image)(resources.GetObject("ptbBGConfirm.Image")));
            this.ptbBGConfirm.Location = new System.Drawing.Point(366, 21);
            this.ptbBGConfirm.Name = "ptbBGConfirm";
            this.ptbBGConfirm.Size = new System.Drawing.Size(35, 35);
            this.ptbBGConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBGConfirm.TabIndex = 51;
            this.ptbBGConfirm.TabStop = false;
            // 
            // ptbConfirm
            // 
            this.ptbConfirm.BackColor = System.Drawing.Color.Transparent;
            this.ptbConfirm.Image = ((System.Drawing.Image)(resources.GetObject("ptbConfirm.Image")));
            this.ptbConfirm.Location = new System.Drawing.Point(366, 21);
            this.ptbConfirm.Name = "ptbConfirm";
            this.ptbConfirm.Size = new System.Drawing.Size(35, 35);
            this.ptbConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbConfirm.TabIndex = 52;
            this.ptbConfirm.TabStop = false;
            this.ptbConfirm.Visible = false;
            this.ptbConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmAddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(417, 136);
            this.Controls.Add(this.ptbConfirm);
            this.Controls.Add(this.ptbBGConfirm);
            this.Controls.Add(this.ptbClose);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.lblCategoryID);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblFoodName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Food";
            this.Load += new System.EventHandler(this.frmAddFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBGConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.PictureBox ptbBGConfirm;
        private System.Windows.Forms.PictureBox ptbConfirm;
    }
}