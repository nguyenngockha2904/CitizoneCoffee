namespace CitiZone
{
    partial class frmChart
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
        /// 
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChart));
            this.crtStaticDay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.cbCTG = new System.Windows.Forms.ComboBox();
            this.ptbSA = new System.Windows.Forms.PictureBox();
            this.lblChart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.crtStaticDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSA)).BeginInit();
            this.SuspendLayout();
            // 
            // crtStaticDay
            // 
            this.crtStaticDay.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.crtStaticDay.ChartAreas.Add(chartArea1);
            this.crtStaticDay.Location = new System.Drawing.Point(2, 129);
            this.crtStaticDay.Name = "crtStaticDay";
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Percent50;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.Name = "Food";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;
            this.crtStaticDay.Series.Add(series1);
            this.crtStaticDay.Size = new System.Drawing.Size(1131, 482);
            this.crtStaticDay.TabIndex = 0;
            this.crtStaticDay.Text = "chart1";
            // 
            // cbUser
            // 
            this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Items.AddRange(new object[] {
            "showALL"});
            this.cbUser.Location = new System.Drawing.Point(936, 620);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(111, 21);
            this.cbUser.TabIndex = 1;
            this.cbUser.SelectedValueChanged += new System.EventHandler(this.btShow_Click);
            this.cbUser.Click += new System.EventHandler(this.cbUser_Click);
            // 
            // cbCTG
            // 
            this.cbCTG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCTG.FormattingEnabled = true;
            this.cbCTG.Items.AddRange(new object[] {
            "showALL"});
            this.cbCTG.Location = new System.Drawing.Point(780, 620);
            this.cbCTG.Name = "cbCTG";
            this.cbCTG.Size = new System.Drawing.Size(150, 21);
            this.cbCTG.TabIndex = 7;
            this.cbCTG.SelectedValueChanged += new System.EventHandler(this.btShow_Click);
            // 
            // ptbSA
            // 
            this.ptbSA.BackColor = System.Drawing.Color.Transparent;
            this.ptbSA.Image = ((System.Drawing.Image)(resources.GetObject("ptbSA.Image")));
            this.ptbSA.Location = new System.Drawing.Point(1058, 612);
            this.ptbSA.Name = "ptbSA";
            this.ptbSA.Size = new System.Drawing.Size(35, 35);
            this.ptbSA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSA.TabIndex = 35;
            this.ptbSA.TabStop = false;
            this.ptbSA.Click += new System.EventHandler(this.btShowAll_Click);
            // 
            // lblChart
            // 
            this.lblChart.AutoSize = true;
            this.lblChart.BackColor = System.Drawing.Color.Transparent;
            this.lblChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChart.Location = new System.Drawing.Point(71, 21);
            this.lblChart.Name = "lblChart";
            this.lblChart.Size = new System.Drawing.Size(142, 55);
            this.lblChart.TabIndex = 36;
            this.lblChart.Text = "Chart";
            // 
            // frmChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1145, 665);
            this.Controls.Add(this.lblChart);
            this.Controls.Add(this.ptbSA);
            this.Controls.Add(this.cbCTG);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.crtStaticDay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.frmChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crtStaticDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart crtStaticDay;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.ComboBox cbCTG;
        private System.Windows.Forms.PictureBox ptbSA;
        private System.Windows.Forms.Label lblChart;
    }
}