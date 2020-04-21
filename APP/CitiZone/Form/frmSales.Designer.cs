namespace CitiZone
{
    partial class frmSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSale));
            this.pnlSell = new System.Windows.Forms.Panel();
            this.ptbTable = new System.Windows.Forms.PictureBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.ptbPlus = new System.Windows.Forms.PictureBox();
            this.ptbMinus = new System.Windows.Forms.PictureBox();
            this.txtBillName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvSell = new System.Windows.Forms.DataGridView();
            this.SellName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblFood = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblCategory = new System.Windows.Forms.Label();
            this.ptbDelete = new System.Windows.Forms.PictureBox();
            this.cbFoodCategony = new System.Windows.Forms.ComboBox();
            this.ptbAdd = new System.Windows.Forms.PictureBox();
            this.cbFoodName = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.ptbCitiZone = new System.Windows.Forms.PictureBox();
            this.pnlSell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCitiZone)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSell
            // 
            this.pnlSell.BackColor = System.Drawing.Color.Transparent;
            this.pnlSell.Controls.Add(this.ptbCitiZone);
            this.pnlSell.Controls.Add(this.ptbTable);
            this.pnlSell.Controls.Add(this.lblTable);
            this.pnlSell.Controls.Add(this.cbTable);
            this.pnlSell.Controls.Add(this.ptbPlus);
            this.pnlSell.Controls.Add(this.ptbMinus);
            this.pnlSell.Controls.Add(this.txtBillName);
            this.pnlSell.Controls.Add(this.btnClear);
            this.pnlSell.Controls.Add(this.dgvSell);
            this.pnlSell.Controls.Add(this.txtAmount);
            this.pnlSell.Controls.Add(this.lblFood);
            this.pnlSell.Controls.Add(this.btnConfirm);
            this.pnlSell.Controls.Add(this.lblCategory);
            this.pnlSell.Controls.Add(this.ptbDelete);
            this.pnlSell.Controls.Add(this.cbFoodCategony);
            this.pnlSell.Controls.Add(this.ptbAdd);
            this.pnlSell.Controls.Add(this.cbFoodName);
            this.pnlSell.Controls.Add(this.lblTotal);
            this.pnlSell.Controls.Add(this.lblAmount);
            this.pnlSell.Controls.Add(this.txtTotal);
            this.pnlSell.Location = new System.Drawing.Point(12, 28);
            this.pnlSell.Name = "pnlSell";
            this.pnlSell.Size = new System.Drawing.Size(701, 421);
            this.pnlSell.TabIndex = 13;
            // 
            // ptbTable
            // 
            this.ptbTable.Image = ((System.Drawing.Image)(resources.GetObject("ptbTable.Image")));
            this.ptbTable.Location = new System.Drawing.Point(311, 252);
            this.ptbTable.Name = "ptbTable";
            this.ptbTable.Size = new System.Drawing.Size(30, 30);
            this.ptbTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTable.TabIndex = 26;
            this.ptbTable.TabStop = false;
            this.ptbTable.Click += new System.EventHandler(this.ptbTable_Click);
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.Location = new System.Drawing.Point(42, 301);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(52, 20);
            this.lblTable.TabIndex = 23;
            this.lblTable.Text = "Table:";
            // 
            // cbTable
            // 
            this.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(130, 300);
            this.cbTable.MaxDropDownItems = 10;
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(33, 21);
            this.cbTable.TabIndex = 24;
            // 
            // ptbPlus
            // 
            this.ptbPlus.Image = ((System.Drawing.Image)(resources.GetObject("ptbPlus.Image")));
            this.ptbPlus.Location = new System.Drawing.Point(202, 258);
            this.ptbPlus.Name = "ptbPlus";
            this.ptbPlus.Size = new System.Drawing.Size(24, 24);
            this.ptbPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPlus.TabIndex = 22;
            this.ptbPlus.TabStop = false;
            this.ptbPlus.Visible = false;
            this.ptbPlus.Click += new System.EventHandler(this.ptbPlus_Click);
            // 
            // ptbMinus
            // 
            this.ptbMinus.Image = ((System.Drawing.Image)(resources.GetObject("ptbMinus.Image")));
            this.ptbMinus.Location = new System.Drawing.Point(128, 258);
            this.ptbMinus.Name = "ptbMinus";
            this.ptbMinus.Size = new System.Drawing.Size(24, 24);
            this.ptbMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMinus.TabIndex = 21;
            this.ptbMinus.TabStop = false;
            this.ptbMinus.Visible = false;
            this.ptbMinus.Click += new System.EventHandler(this.ptbMinus_Click);
            // 
            // txtBillName
            // 
            this.txtBillName.Location = new System.Drawing.Point(169, 301);
            this.txtBillName.Name = "txtBillName";
            this.txtBillName.Size = new System.Drawing.Size(172, 20);
            this.txtBillName.TabIndex = 18;
            this.txtBillName.Text = "HAVE FUN";
            this.txtBillName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(128, 339);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 28);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvSell
            // 
            this.dgvSell.AllowUserToAddRows = false;
            this.dgvSell.AllowUserToDeleteRows = false;
            this.dgvSell.AllowUserToResizeColumns = false;
            this.dgvSell.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvSell.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSell.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSell.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SellName,
            this.SellAmount,
            this.SellPrice});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSell.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvSell.Location = new System.Drawing.Point(366, 30);
            this.dgvSell.MultiSelect = false;
            this.dgvSell.Name = "dgvSell";
            this.dgvSell.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSell.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvSell.RowHeadersVisible = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvSell.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvSell.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSell.Size = new System.Drawing.Size(312, 337);
            this.dgvSell.TabIndex = 14;
            this.dgvSell.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSell_CellMouseClick);
            this.dgvSell.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSell_KeyDown);
            // 
            // SellName
            // 
            this.SellName.DataPropertyName = "SellName";
            this.SellName.HeaderText = "Food";
            this.SellName.Name = "SellName";
            this.SellName.ReadOnly = true;
            // 
            // SellAmount
            // 
            this.SellAmount.DataPropertyName = "SellAmount";
            this.SellAmount.FillWeight = 30F;
            this.SellAmount.HeaderText = "Amount";
            this.SellAmount.Name = "SellAmount";
            this.SellAmount.ReadOnly = true;
            // 
            // SellPrice
            // 
            this.SellPrice.DataPropertyName = "SellPrice";
            this.SellPrice.FillWeight = 35F;
            this.SellPrice.HeaderText = "Price";
            this.SellPrice.Name = "SellPrice";
            this.SellPrice.ReadOnly = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(158, 262);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(38, 20);
            this.txtAmount.TabIndex = 13;
            this.txtAmount.Text = "1";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmount.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Italic);
            this.lblFood.Location = new System.Drawing.Point(43, 214);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(51, 20);
            this.lblFood.TabIndex = 12;
            this.lblFood.Text = "Food:";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Location = new System.Drawing.Point(239, 339);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(102, 28);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(43, 172);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(82, 20);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category:";
            // 
            // ptbDelete
            // 
            this.ptbDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbDelete.BackgroundImage")));
            this.ptbDelete.Location = new System.Drawing.Point(239, 252);
            this.ptbDelete.Name = "ptbDelete";
            this.ptbDelete.Size = new System.Drawing.Size(30, 30);
            this.ptbDelete.TabIndex = 10;
            this.ptbDelete.TabStop = false;
            this.ptbDelete.Visible = false;
            this.ptbDelete.Click += new System.EventHandler(this.ptbDelete_Click);
            // 
            // cbFoodCategony
            // 
            this.cbFoodCategony.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFoodCategony.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbFoodCategony.FormattingEnabled = true;
            this.cbFoodCategony.Location = new System.Drawing.Point(131, 174);
            this.cbFoodCategony.MaxDropDownItems = 10;
            this.cbFoodCategony.Name = "cbFoodCategony";
            this.cbFoodCategony.Size = new System.Drawing.Size(210, 21);
            this.cbFoodCategony.TabIndex = 2;
            this.cbFoodCategony.SelectedIndexChanged += new System.EventHandler(this.txt_TextChanged);
            this.cbFoodCategony.SelectedValueChanged += new System.EventHandler(this.cbFoodCategony_SelectedValueChanged);
            // 
            // ptbAdd
            // 
            this.ptbAdd.Image = ((System.Drawing.Image)(resources.GetObject("ptbAdd.Image")));
            this.ptbAdd.Location = new System.Drawing.Point(275, 252);
            this.ptbAdd.Name = "ptbAdd";
            this.ptbAdd.Size = new System.Drawing.Size(30, 30);
            this.ptbAdd.TabIndex = 9;
            this.ptbAdd.TabStop = false;
            this.ptbAdd.Visible = false;
            this.ptbAdd.Click += new System.EventHandler(this.ptbAdd_Click);
            // 
            // cbFoodName
            // 
            this.cbFoodName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFoodName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbFoodName.FormattingEnabled = true;
            this.cbFoodName.Location = new System.Drawing.Point(130, 214);
            this.cbFoodName.MaxDropDownItems = 10;
            this.cbFoodName.Name = "cbFoodName";
            this.cbFoodName.Size = new System.Drawing.Size(211, 21);
            this.cbFoodName.TabIndex = 4;
            this.cbFoodName.SelectedIndexChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Italic);
            this.lblTotal.Location = new System.Drawing.Point(482, 383);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(89, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total Price:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Italic);
            this.lblAmount.Location = new System.Drawing.Point(43, 262);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(71, 20);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(577, 383);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(102, 20);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ptbCitiZone
            // 
            this.ptbCitiZone.BackColor = System.Drawing.Color.Transparent;
            this.ptbCitiZone.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ptbCitiZone.ErrorImage")));
            this.ptbCitiZone.Image = ((System.Drawing.Image)(resources.GetObject("ptbCitiZone.Image")));
            this.ptbCitiZone.InitialImage = ((System.Drawing.Image)(resources.GetObject("ptbCitiZone.InitialImage")));
            this.ptbCitiZone.Location = new System.Drawing.Point(47, 30);
            this.ptbCitiZone.Name = "ptbCitiZone";
            this.ptbCitiZone.Size = new System.Drawing.Size(294, 90);
            this.ptbCitiZone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCitiZone.TabIndex = 27;
            this.ptbCitiZone.TabStop = false;
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(725, 460);
            this.Controls.Add(this.pnlSell);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.pnlSell.ResumeLayout(false);
            this.pnlSell.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCitiZone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSell;
        private System.Windows.Forms.TextBox txtBillName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellPrice;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.PictureBox ptbDelete;
        private System.Windows.Forms.ComboBox cbFoodCategony;
        private System.Windows.Forms.PictureBox ptbAdd;
        private System.Windows.Forms.ComboBox cbFoodName;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.PictureBox ptbPlus;
        private System.Windows.Forms.PictureBox ptbMinus;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.PictureBox ptbTable;
        private System.Windows.Forms.PictureBox ptbCitiZone;
    }
}