namespace CitiZone
{
    partial class frmEditFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditFood));
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblFoodID = new System.Windows.Forms.Label();
            this.ptbConfirm = new System.Windows.Forms.PictureBox();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.ptbBConfirm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(130, 93);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(227, 20);
            this.txtPrice.TabIndex = 36;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrice.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(130, 57);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(227, 20);
            this.txtFoodName.TabIndex = 35;
            this.txtFoodName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFoodName.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Location = new System.Drawing.Point(26, 93);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 34;
            this.lblPrice.Text = "Price:";
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.BackColor = System.Drawing.Color.Transparent;
            this.lblFoodName.Location = new System.Drawing.Point(26, 57);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(65, 13);
            this.lblFoodName.TabIndex = 33;
            this.lblFoodName.Text = "Food Name:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(130, 20);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(227, 20);
            this.txtID.TabIndex = 40;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFoodID
            // 
            this.lblFoodID.AutoSize = true;
            this.lblFoodID.BackColor = System.Drawing.Color.Transparent;
            this.lblFoodID.Location = new System.Drawing.Point(26, 20);
            this.lblFoodID.Name = "lblFoodID";
            this.lblFoodID.Size = new System.Drawing.Size(21, 13);
            this.lblFoodID.TabIndex = 39;
            this.lblFoodID.Text = "ID:";
            // 
            // ptbConfirm
            // 
            this.ptbConfirm.BackColor = System.Drawing.Color.Transparent;
            this.ptbConfirm.Image = ((System.Drawing.Image)(resources.GetObject("ptbConfirm.Image")));
            this.ptbConfirm.Location = new System.Drawing.Point(366, 20);
            this.ptbConfirm.Name = "ptbConfirm";
            this.ptbConfirm.Size = new System.Drawing.Size(35, 35);
            this.ptbConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbConfirm.TabIndex = 61;
            this.ptbConfirm.TabStop = false;
            this.ptbConfirm.Visible = false;
            this.ptbConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // ptbClose
            // 
            this.ptbClose.BackColor = System.Drawing.Color.Transparent;
            this.ptbClose.Image = ((System.Drawing.Image)(resources.GetObject("ptbClose.Image")));
            this.ptbClose.Location = new System.Drawing.Point(366, 61);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(35, 35);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbClose.TabIndex = 60;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ptbBConfirm
            // 
            this.ptbBConfirm.BackColor = System.Drawing.Color.Transparent;
            this.ptbBConfirm.Image = ((System.Drawing.Image)(resources.GetObject("ptbBConfirm.Image")));
            this.ptbBConfirm.Location = new System.Drawing.Point(366, 20);
            this.ptbBConfirm.Name = "ptbBConfirm";
            this.ptbBConfirm.Size = new System.Drawing.Size(35, 35);
            this.ptbBConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBConfirm.TabIndex = 59;
            this.ptbBConfirm.TabStop = false;
            // 
            // frmEditFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(415, 133);
            this.Controls.Add(this.ptbConfirm);
            this.Controls.Add(this.ptbClose);
            this.Controls.Add(this.ptbBConfirm);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblFoodID);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblFoodName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEditFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Food";
            this.Load += new System.EventHandler(this.frmEditFoodName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblFoodID;
        private System.Windows.Forms.PictureBox ptbConfirm;
        private System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.PictureBox ptbBConfirm;
    }
}