namespace CitiZone
{
    partial class frmPieChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPieChart));
            this.chartCG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.ptbChart = new System.Windows.Forms.PictureBox();
            this.ptbSA = new System.Windows.Forms.PictureBox();
            this.lblChart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartCG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSA)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCG
            // 
            this.chartCG.BackColor = System.Drawing.Color.Transparent;
            this.chartCG.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chartCG.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chartCG.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartCG.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            this.chartCG.Legends.Add(legend1);
            this.chartCG.Location = new System.Drawing.Point(33, 142);
            this.chartCG.Name = "chartCG";
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Percent50;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            series1.XValueMember = "ctg";
            series1.YValueMembers = "amt";
            this.chartCG.Series.Add(series1);
            this.chartCG.Size = new System.Drawing.Size(985, 500);
            this.chartCG.TabIndex = 0;
            // 
            // cbUser
            // 
            this.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Items.AddRange(new object[] {
            "showALL"});
            this.cbUser.Location = new System.Drawing.Point(827, 589);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(119, 21);
            this.cbUser.TabIndex = 7;
            this.cbUser.SelectedValueChanged += new System.EventHandler(this.btnShow_Click);
            this.cbUser.Click += new System.EventHandler(this.cbUser_Click_1);
            // 
            // ptbChart
            // 
            this.ptbChart.BackColor = System.Drawing.Color.Transparent;
            this.ptbChart.Image = ((System.Drawing.Image)(resources.GetObject("ptbChart.Image")));
            this.ptbChart.Location = new System.Drawing.Point(993, 580);
            this.ptbChart.Name = "ptbChart";
            this.ptbChart.Size = new System.Drawing.Size(35, 35);
            this.ptbChart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbChart.TabIndex = 33;
            this.ptbChart.TabStop = false;
            this.ptbChart.Click += new System.EventHandler(this.ptbChart_Click);
            // 
            // ptbSA
            // 
            this.ptbSA.BackColor = System.Drawing.Color.Transparent;
            this.ptbSA.Image = ((System.Drawing.Image)(resources.GetObject("ptbSA.Image")));
            this.ptbSA.Location = new System.Drawing.Point(952, 580);
            this.ptbSA.Name = "ptbSA";
            this.ptbSA.Size = new System.Drawing.Size(35, 35);
            this.ptbSA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSA.TabIndex = 34;
            this.ptbSA.TabStop = false;
            this.ptbSA.Click += new System.EventHandler(this.btnSA_Click);
            // 
            // lblChart
            // 
            this.lblChart.AutoSize = true;
            this.lblChart.BackColor = System.Drawing.Color.Transparent;
            this.lblChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChart.Location = new System.Drawing.Point(23, 26);
            this.lblChart.Name = "lblChart";
            this.lblChart.Size = new System.Drawing.Size(224, 55);
            this.lblChart.TabIndex = 35;
            this.lblChart.Text = "Pie Chart";
            // 
            // frmPieChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1063, 661);
            this.Controls.Add(this.lblChart);
            this.Controls.Add(this.ptbSA);
            this.Controls.Add(this.ptbChart);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.chartCG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPieChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pie Chart";
            this.Load += new System.EventHandler(this.frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCG;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.PictureBox ptbChart;
        private System.Windows.Forms.PictureBox ptbSA;
        private System.Windows.Forms.Label lblChart;
    }
}