namespace CitiZone
{
    partial class frmStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatistics));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlStatistics = new System.Windows.Forms.Panel();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ptbPieChart = new System.Windows.Forms.PictureBox();
            this.ptbChart = new System.Windows.Forms.PictureBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.rbBetWeen = new System.Windows.Forms.RadioButton();
            this.ptbClear = new System.Windows.Forms.PictureBox();
            this.rbYear = new System.Windows.Forms.RadioButton();
            this.rbMonth = new System.Windows.Forms.RadioButton();
            this.rbDay = new System.Windows.Forms.RadioButton();
            this.chbViewAll = new System.Windows.Forms.CheckBox();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dtpStaticDate = new System.Windows.Forms.DateTimePicker();
            this.ptbDeleteAll = new System.Windows.Forms.PictureBox();
            this.ptbDelete = new System.Windows.Forms.PictureBox();
            this.ptbInfo = new System.Windows.Forms.PictureBox();
            this.dgvUsername = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPieChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDeleteAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlStatistics
            // 
            this.pnlStatistics.BackColor = System.Drawing.Color.Transparent;
            this.pnlStatistics.Controls.Add(this.lblTo);
            this.pnlStatistics.Controls.Add(this.lblFrom);
            this.pnlStatistics.Controls.Add(this.txtSearch);
            this.pnlStatistics.Controls.Add(this.ptbPieChart);
            this.pnlStatistics.Controls.Add(this.ptbChart);
            this.pnlStatistics.Controls.Add(this.dtpEndDate);
            this.pnlStatistics.Controls.Add(this.rbBetWeen);
            this.pnlStatistics.Controls.Add(this.ptbClear);
            this.pnlStatistics.Controls.Add(this.rbYear);
            this.pnlStatistics.Controls.Add(this.rbMonth);
            this.pnlStatistics.Controls.Add(this.rbDay);
            this.pnlStatistics.Controls.Add(this.chbViewAll);
            this.pnlStatistics.Controls.Add(this.dgvBill);
            this.pnlStatistics.Controls.Add(this.txtTotal);
            this.pnlStatistics.Controls.Add(this.dtpStaticDate);
            this.pnlStatistics.Controls.Add(this.ptbDeleteAll);
            this.pnlStatistics.Controls.Add(this.ptbDelete);
            this.pnlStatistics.Controls.Add(this.ptbInfo);
            this.pnlStatistics.Controls.Add(this.dgvUsername);
            this.pnlStatistics.ForeColor = System.Drawing.Color.Black;
            this.pnlStatistics.Location = new System.Drawing.Point(4, -1);
            this.pnlStatistics.Name = "pnlStatistics";
            this.pnlStatistics.Size = new System.Drawing.Size(1075, 528);
            this.pnlStatistics.TabIndex = 0;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(218, 497);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 36;
            this.lblTo.Text = "To:";
            this.lblTo.Visible = false;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(218, 467);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 35;
            this.lblFrom.Text = "From:";
            this.lblFrom.Visible = false;
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(680, 475);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(205, 20);
            this.txtSearch.TabIndex = 34;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.DoubleClick += new System.EventHandler(this.txtSearch_DoubleClick);
            // 
            // ptbPieChart
            // 
            this.ptbPieChart.Image = ((System.Drawing.Image)(resources.GetObject("ptbPieChart.Image")));
            this.ptbPieChart.Location = new System.Drawing.Point(589, 468);
            this.ptbPieChart.Name = "ptbPieChart";
            this.ptbPieChart.Size = new System.Drawing.Size(35, 35);
            this.ptbPieChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPieChart.TabIndex = 33;
            this.ptbPieChart.TabStop = false;
            this.ptbPieChart.Click += new System.EventHandler(this.ptbPieChart_Click);
            // 
            // ptbChart
            // 
            this.ptbChart.Image = ((System.Drawing.Image)(resources.GetObject("ptbChart.Image")));
            this.ptbChart.Location = new System.Drawing.Point(630, 468);
            this.ptbChart.Name = "ptbChart";
            this.ptbChart.Size = new System.Drawing.Size(35, 35);
            this.ptbChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbChart.TabIndex = 32;
            this.ptbChart.TabStop = false;
            this.ptbChart.Click += new System.EventHandler(this.ptbChart_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpEndDate.Location = new System.Drawing.Point(263, 495);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(136, 20);
            this.dtpEndDate.TabIndex = 31;
            this.dtpEndDate.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpStaticDate_ValueChanged);
            // 
            // rbBetWeen
            // 
            this.rbBetWeen.AutoSize = true;
            this.rbBetWeen.Location = new System.Drawing.Point(425, 495);
            this.rbBetWeen.Name = "rbBetWeen";
            this.rbBetWeen.Size = new System.Drawing.Size(67, 17);
            this.rbBetWeen.TabIndex = 30;
            this.rbBetWeen.TabStop = true;
            this.rbBetWeen.Text = "Between";
            this.rbBetWeen.UseVisualStyleBackColor = true;
            this.rbBetWeen.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // ptbClear
            // 
            this.ptbClear.Image = ((System.Drawing.Image)(resources.GetObject("ptbClear.Image")));
            this.ptbClear.Location = new System.Drawing.Point(502, 497);
            this.ptbClear.Name = "ptbClear";
            this.ptbClear.Size = new System.Drawing.Size(15, 15);
            this.ptbClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbClear.TabIndex = 28;
            this.ptbClear.TabStop = false;
            this.ptbClear.Visible = false;
            this.ptbClear.Click += new System.EventHandler(this.ptbClear_Click);
            // 
            // rbYear
            // 
            this.rbYear.AutoSize = true;
            this.rbYear.Location = new System.Drawing.Point(536, 465);
            this.rbYear.Name = "rbYear";
            this.rbYear.Size = new System.Drawing.Size(47, 17);
            this.rbYear.TabIndex = 27;
            this.rbYear.TabStop = true;
            this.rbYear.Text = "Year";
            this.rbYear.UseVisualStyleBackColor = true;
            this.rbYear.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // rbMonth
            // 
            this.rbMonth.AutoSize = true;
            this.rbMonth.Location = new System.Drawing.Point(475, 465);
            this.rbMonth.Name = "rbMonth";
            this.rbMonth.Size = new System.Drawing.Size(55, 17);
            this.rbMonth.TabIndex = 26;
            this.rbMonth.TabStop = true;
            this.rbMonth.Text = "Month";
            this.rbMonth.UseVisualStyleBackColor = true;
            this.rbMonth.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // rbDay
            // 
            this.rbDay.AutoSize = true;
            this.rbDay.Location = new System.Drawing.Point(425, 465);
            this.rbDay.Name = "rbDay";
            this.rbDay.Size = new System.Drawing.Size(44, 17);
            this.rbDay.TabIndex = 25;
            this.rbDay.TabStop = true;
            this.rbDay.Text = "Day";
            this.rbDay.UseVisualStyleBackColor = true;
            this.rbDay.CheckedChanged += new System.EventHandler(this.rbCheckedChanged);
            // 
            // chbViewAll
            // 
            this.chbViewAll.AutoSize = true;
            this.chbViewAll.ForeColor = System.Drawing.Color.Transparent;
            this.chbViewAll.Location = new System.Drawing.Point(18, 465);
            this.chbViewAll.Name = "chbViewAll";
            this.chbViewAll.Size = new System.Drawing.Size(62, 17);
            this.chbViewAll.TabIndex = 22;
            this.chbViewAll.Text = "All User";
            this.chbViewAll.UseVisualStyleBackColor = true;
            this.chbViewAll.CheckedChanged += new System.EventHandler(this.chbViewAll_CheckedChanged);
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AllowUserToResizeColumns = false;
            this.dgvBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillID,
            this.BillName,
            this.BillDate,
            this.Creator,
            this.BillTotal});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBill.Location = new System.Drawing.Point(263, 20);
            this.dgvBill.MultiSelect = false;
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBill.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvBill.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(764, 428);
            this.dgvBill.TabIndex = 21;
            this.dgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellClick);
            this.dgvBill.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ptbInfo_Click);
            this.dgvBill.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBill_KeyDown);
            // 
            // BillID
            // 
            this.BillID.DataPropertyName = "BillID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BillID.DefaultCellStyle = dataGridViewCellStyle3;
            this.BillID.FillWeight = 45F;
            this.BillID.HeaderText = "Bill ID";
            this.BillID.Name = "BillID";
            this.BillID.ReadOnly = true;
            // 
            // BillName
            // 
            this.BillName.DataPropertyName = "BillName";
            this.BillName.HeaderText = "Bill Name";
            this.BillName.Name = "BillName";
            this.BillName.ReadOnly = true;
            // 
            // BillDate
            // 
            this.BillDate.DataPropertyName = "BillDate";
            this.BillDate.FillWeight = 60F;
            this.BillDate.HeaderText = "Date Created";
            this.BillDate.Name = "BillDate";
            this.BillDate.ReadOnly = true;
            // 
            // Creator
            // 
            this.Creator.DataPropertyName = "Creator";
            this.Creator.FillWeight = 50F;
            this.Creator.HeaderText = "Creator";
            this.Creator.Name = "Creator";
            this.Creator.ReadOnly = true;
            // 
            // BillTotal
            // 
            this.BillTotal.DataPropertyName = "BillTotal";
            this.BillTotal.FillWeight = 50F;
            this.BillTotal.HeaderText = "Total Price";
            this.BillTotal.Name = "BillTotal";
            this.BillTotal.ReadOnly = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(898, 475);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(126, 20);
            this.txtTotal.TabIndex = 20;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpStaticDate
            // 
            this.dtpStaticDate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtpStaticDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpStaticDate.Location = new System.Drawing.Point(263, 465);
            this.dtpStaticDate.Name = "dtpStaticDate";
            this.dtpStaticDate.Size = new System.Drawing.Size(136, 20);
            this.dtpStaticDate.TabIndex = 18;
            this.dtpStaticDate.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtpStaticDate.ValueChanged += new System.EventHandler(this.dtpStaticDate_ValueChanged);
            // 
            // ptbDeleteAll
            // 
            this.ptbDeleteAll.Image = ((System.Drawing.Image)(resources.GetObject("ptbDeleteAll.Image")));
            this.ptbDeleteAll.Location = new System.Drawing.Point(1037, 122);
            this.ptbDeleteAll.Name = "ptbDeleteAll";
            this.ptbDeleteAll.Size = new System.Drawing.Size(35, 35);
            this.ptbDeleteAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDeleteAll.TabIndex = 5;
            this.ptbDeleteAll.TabStop = false;
            this.ptbDeleteAll.Visible = false;
            this.ptbDeleteAll.Click += new System.EventHandler(this.ptbDeleteAll_Click);
            // 
            // ptbDelete
            // 
            this.ptbDelete.Image = ((System.Drawing.Image)(resources.GetObject("ptbDelete.Image")));
            this.ptbDelete.Location = new System.Drawing.Point(1037, 81);
            this.ptbDelete.Name = "ptbDelete";
            this.ptbDelete.Size = new System.Drawing.Size(35, 35);
            this.ptbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbDelete.TabIndex = 3;
            this.ptbDelete.TabStop = false;
            this.ptbDelete.Visible = false;
            this.ptbDelete.Click += new System.EventHandler(this.ptbDelete_Click);
            // 
            // ptbInfo
            // 
            this.ptbInfo.Image = ((System.Drawing.Image)(resources.GetObject("ptbInfo.Image")));
            this.ptbInfo.Location = new System.Drawing.Point(1037, 40);
            this.ptbInfo.Name = "ptbInfo";
            this.ptbInfo.Size = new System.Drawing.Size(35, 35);
            this.ptbInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbInfo.TabIndex = 2;
            this.ptbInfo.TabStop = false;
            this.ptbInfo.Visible = false;
            this.ptbInfo.Click += new System.EventHandler(this.ptbInfo_Click);
            // 
            // dgvUsername
            // 
            this.dgvUsername.AllowUserToAddRows = false;
            this.dgvUsername.AllowUserToDeleteRows = false;
            this.dgvUsername.AllowUserToResizeColumns = false;
            this.dgvUsername.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvUsername.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUsername.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsername.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsername.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUsername.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsername.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.Position});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsername.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvUsername.Location = new System.Drawing.Point(18, 20);
            this.dgvUsername.MultiSelect = false;
            this.dgvUsername.Name = "dgvUsername";
            this.dgvUsername.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsername.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvUsername.RowHeadersVisible = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvUsername.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvUsername.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsername.Size = new System.Drawing.Size(226, 428);
            this.dgvUsername.TabIndex = 0;
            this.dgvUsername.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsername_CellClick);
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Username.DefaultCellStyle = dataGridViewCellStyle9;
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Position.DefaultCellStyle = dataGridViewCellStyle10;
            this.Position.FillWeight = 70F;
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1091, 529);
            this.Controls.Add(this.pnlStatistics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.frmStatistics_Load);
            this.pnlStatistics.ResumeLayout(false);
            this.pnlStatistics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPieChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDeleteAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsername)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStatistics;
        private System.Windows.Forms.DataGridView dgvUsername;
        private System.Windows.Forms.PictureBox ptbDelete;
        private System.Windows.Forms.PictureBox ptbInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.PictureBox ptbDeleteAll;
        public System.Windows.Forms.DateTimePicker dtpStaticDate;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.CheckBox chbViewAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creator;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTotal;
        private System.Windows.Forms.RadioButton rbYear;
        private System.Windows.Forms.RadioButton rbMonth;
        private System.Windows.Forms.RadioButton rbDay;
        private System.Windows.Forms.PictureBox ptbClear;
        private System.Windows.Forms.RadioButton rbBetWeen;
        public System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.PictureBox ptbChart;
        private System.Windows.Forms.PictureBox ptbPieChart;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
    }
}