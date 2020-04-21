namespace CitiZone
{
    partial class frmBillInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBillID = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.ptbPrint = new System.Windows.Forms.PictureBox();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBillID
            // 
            this.lblBillID.AutoSize = true;
            this.lblBillID.BackColor = System.Drawing.Color.Transparent;
            this.lblBillID.Location = new System.Drawing.Point(13, 13);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(0, 13);
            this.lblBillID.TabIndex = 0;
            this.lblBillID.Visible = false;
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.BackColor = System.Drawing.Color.Transparent;
            this.lblBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.Location = new System.Drawing.Point(191, 13);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(94, 42);
            this.lblBill.TabIndex = 1;
            this.lblBill.Text = "BILL";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(369, 436);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(111, 20);
            this.txtTotal.TabIndex = 3;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AllowUserToResizeColumns = false;
            this.dgvBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodName,
            this.Amount,
            this.TotalPrice});
            this.dgvBill.Enabled = false;
            this.dgvBill.GridColor = System.Drawing.Color.Black;
            this.dgvBill.Location = new System.Drawing.Point(32, 78);
            this.dgvBill.MultiSelect = false;
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(448, 342);
            this.dgvBill.TabIndex = 4;
            // 
            // ptbPrint
            // 
            this.ptbPrint.BackColor = System.Drawing.Color.Transparent;
            this.ptbPrint.Image = ((System.Drawing.Image)(resources.GetObject("ptbPrint.Image")));
            this.ptbPrint.Location = new System.Drawing.Point(333, 426);
            this.ptbPrint.Name = "ptbPrint";
            this.ptbPrint.Size = new System.Drawing.Size(30, 30);
            this.ptbPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPrint.TabIndex = 27;
            this.ptbPrint.TabStop = false;
            this.ptbPrint.Click += new System.EventHandler(this.ptbPrint_Click);
            // 
            // FoodName
            // 
            this.FoodName.DataPropertyName = "FoodName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.FoodName.DefaultCellStyle = dataGridViewCellStyle3;
            this.FoodName.HeaderText = "FoodName";
            this.FoodName.Name = "FoodName";
            this.FoodName.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Amount.DefaultCellStyle = dataGridViewCellStyle4;
            this.Amount.FillWeight = 35F;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TotalPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.TotalPrice.FillWeight = 45F;
            this.TotalPrice.HeaderText = "Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // frmBillInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(514, 476);
            this.Controls.Add(this.ptbPrint);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblBill);
            this.Controls.Add(this.lblBillID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBillInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill Info";
            this.Load += new System.EventHandler(this.frmBillInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBillID;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.PictureBox ptbPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}