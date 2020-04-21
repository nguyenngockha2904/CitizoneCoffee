namespace CitiZone
{
    partial class frmManageCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageCategories));
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFoods = new System.Windows.Forms.DataGridView();
            this.Food = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlManageCategories = new System.Windows.Forms.Panel();
            this.ptbFoodNamesEdit = new System.Windows.Forms.PictureBox();
            this.ptbCategoriesEdit = new System.Windows.Forms.PictureBox();
            this.ptbFoodDelete = new System.Windows.Forms.PictureBox();
            this.ptbFoodNamesADD = new System.Windows.Forms.PictureBox();
            this.ptbCategoriesDelete = new System.Windows.Forms.PictureBox();
            this.ptbCategoriesAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).BeginInit();
            this.pnlManageCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoodNamesEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCategoriesEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoodDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoodNamesADD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCategoriesDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCategoriesAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.AllowUserToResizeColumns = false;
            this.dgvCategories.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategories.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryID,
            this.CategoryName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategories.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategories.Location = new System.Drawing.Point(27, 35);
            this.dgvCategories.MultiSelect = false;
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.ReadOnly = true;
            this.dgvCategories.RowHeadersVisible = false;
            this.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategories.Size = new System.Drawing.Size(305, 393);
            this.dgvCategories.TabIndex = 0;
            this.dgvCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bgcCategory_CellClick);
            this.dgvCategories.DoubleClick += new System.EventHandler(this.ptbCategoriesEdit_Click);
            this.dgvCategories.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCategories_KeyDown);
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.FillWeight = 45F;
            this.CategoryID.HeaderText = "Category ID";
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            this.CategoryName.HeaderText = "CategoryName";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            // 
            // dgvFoods
            // 
            this.dgvFoods.AllowUserToAddRows = false;
            this.dgvFoods.AllowUserToDeleteRows = false;
            this.dgvFoods.AllowUserToResizeColumns = false;
            this.dgvFoods.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvFoods.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoods.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Food,
            this.Price,
            this.ID});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFoods.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFoods.Location = new System.Drawing.Point(406, 35);
            this.dgvFoods.MultiSelect = false;
            this.dgvFoods.Name = "dgvFoods";
            this.dgvFoods.ReadOnly = true;
            this.dgvFoods.RowHeadersVisible = false;
            this.dgvFoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoods.Size = new System.Drawing.Size(411, 393);
            this.dgvFoods.TabIndex = 1;
            this.dgvFoods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoodNames_CellClick);
            this.dgvFoods.DoubleClick += new System.EventHandler(this.ptbFoodNamesEdit_Click);
            this.dgvFoods.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvFoods_KeyDown);
            // 
            // Food
            // 
            this.Food.DataPropertyName = "Food";
            this.Food.HeaderText = "Food";
            this.Food.Name = "Food";
            this.Food.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.FillWeight = 35F;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 20F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // pnlManageCategories
            // 
            this.pnlManageCategories.BackColor = System.Drawing.Color.Transparent;
            this.pnlManageCategories.Controls.Add(this.ptbFoodNamesEdit);
            this.pnlManageCategories.Controls.Add(this.ptbCategoriesEdit);
            this.pnlManageCategories.Controls.Add(this.ptbFoodDelete);
            this.pnlManageCategories.Controls.Add(this.ptbFoodNamesADD);
            this.pnlManageCategories.Controls.Add(this.ptbCategoriesDelete);
            this.pnlManageCategories.Controls.Add(this.ptbCategoriesAdd);
            this.pnlManageCategories.Controls.Add(this.dgvCategories);
            this.pnlManageCategories.Controls.Add(this.dgvFoods);
            this.pnlManageCategories.Location = new System.Drawing.Point(12, 24);
            this.pnlManageCategories.Name = "pnlManageCategories";
            this.pnlManageCategories.Size = new System.Drawing.Size(886, 466);
            this.pnlManageCategories.TabIndex = 2;
            // 
            // ptbFoodNamesEdit
            // 
            this.ptbFoodNamesEdit.Image = ((System.Drawing.Image)(resources.GetObject("ptbFoodNamesEdit.Image")));
            this.ptbFoodNamesEdit.Location = new System.Drawing.Point(836, 35);
            this.ptbFoodNamesEdit.Name = "ptbFoodNamesEdit";
            this.ptbFoodNamesEdit.Size = new System.Drawing.Size(30, 30);
            this.ptbFoodNamesEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFoodNamesEdit.TabIndex = 16;
            this.ptbFoodNamesEdit.TabStop = false;
            this.ptbFoodNamesEdit.Visible = false;
            this.ptbFoodNamesEdit.Click += new System.EventHandler(this.ptbFoodNamesEdit_Click);
            // 
            // ptbCategoriesEdit
            // 
            this.ptbCategoriesEdit.Image = ((System.Drawing.Image)(resources.GetObject("ptbCategoriesEdit.Image")));
            this.ptbCategoriesEdit.Location = new System.Drawing.Point(351, 35);
            this.ptbCategoriesEdit.Name = "ptbCategoriesEdit";
            this.ptbCategoriesEdit.Size = new System.Drawing.Size(30, 30);
            this.ptbCategoriesEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCategoriesEdit.TabIndex = 15;
            this.ptbCategoriesEdit.TabStop = false;
            this.ptbCategoriesEdit.Visible = false;
            this.ptbCategoriesEdit.Click += new System.EventHandler(this.ptbCategoriesEdit_Click);
            // 
            // ptbFoodDelete
            // 
            this.ptbFoodDelete.Image = ((System.Drawing.Image)(resources.GetObject("ptbFoodDelete.Image")));
            this.ptbFoodDelete.Location = new System.Drawing.Point(836, 107);
            this.ptbFoodDelete.Name = "ptbFoodDelete";
            this.ptbFoodDelete.Size = new System.Drawing.Size(30, 30);
            this.ptbFoodDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFoodDelete.TabIndex = 14;
            this.ptbFoodDelete.TabStop = false;
            this.ptbFoodDelete.Visible = false;
            this.ptbFoodDelete.Click += new System.EventHandler(this.ptbFoodNamesDelete_Click);
            // 
            // ptbFoodNamesADD
            // 
            this.ptbFoodNamesADD.Image = ((System.Drawing.Image)(resources.GetObject("ptbFoodNamesADD.Image")));
            this.ptbFoodNamesADD.Location = new System.Drawing.Point(836, 71);
            this.ptbFoodNamesADD.Name = "ptbFoodNamesADD";
            this.ptbFoodNamesADD.Size = new System.Drawing.Size(30, 30);
            this.ptbFoodNamesADD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFoodNamesADD.TabIndex = 13;
            this.ptbFoodNamesADD.TabStop = false;
            this.ptbFoodNamesADD.Click += new System.EventHandler(this.ptbFoodNamesADD_Click);
            // 
            // ptbCategoriesDelete
            // 
            this.ptbCategoriesDelete.Image = ((System.Drawing.Image)(resources.GetObject("ptbCategoriesDelete.Image")));
            this.ptbCategoriesDelete.Location = new System.Drawing.Point(351, 107);
            this.ptbCategoriesDelete.Name = "ptbCategoriesDelete";
            this.ptbCategoriesDelete.Size = new System.Drawing.Size(30, 30);
            this.ptbCategoriesDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCategoriesDelete.TabIndex = 12;
            this.ptbCategoriesDelete.TabStop = false;
            this.ptbCategoriesDelete.Visible = false;
            this.ptbCategoriesDelete.Click += new System.EventHandler(this.ptbCategoriesDelete_Click);
            // 
            // ptbCategoriesAdd
            // 
            this.ptbCategoriesAdd.Image = ((System.Drawing.Image)(resources.GetObject("ptbCategoriesAdd.Image")));
            this.ptbCategoriesAdd.Location = new System.Drawing.Point(351, 71);
            this.ptbCategoriesAdd.Name = "ptbCategoriesAdd";
            this.ptbCategoriesAdd.Size = new System.Drawing.Size(30, 30);
            this.ptbCategoriesAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCategoriesAdd.TabIndex = 11;
            this.ptbCategoriesAdd.TabStop = false;
            this.ptbCategoriesAdd.Click += new System.EventHandler(this.ptbCategoriesAdd_Click);
            // 
            // frmManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(901, 512);
            this.Controls.Add(this.pnlManageCategories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmManageCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Categories";
            this.Load += new System.EventHandler(this.frmManageCategories_Load);
            this.ClientSizeChanged += new System.EventHandler(this.frmManageCategories_ClientSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).EndInit();
            this.pnlManageCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoodNamesEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCategoriesEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoodDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoodNamesADD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCategoriesDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCategoriesAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.DataGridView dgvFoods;
        private System.Windows.Forms.Panel pnlManageCategories;
        private System.Windows.Forms.PictureBox ptbFoodDelete;
        private System.Windows.Forms.PictureBox ptbFoodNamesADD;
        private System.Windows.Forms.PictureBox ptbCategoriesDelete;
        private System.Windows.Forms.PictureBox ptbCategoriesAdd;
        private System.Windows.Forms.PictureBox ptbFoodNamesEdit;
        private System.Windows.Forms.PictureBox ptbCategoriesEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Food;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
    }
}