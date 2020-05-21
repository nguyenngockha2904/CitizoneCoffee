namespace Bai1
{
    partial class frmBaiToan1
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
            this.lblSoViTri = new System.Windows.Forms.Label();
            this.nudSoViTri = new System.Windows.Forms.NumericUpDown();
            this.lblBanTinRo = new System.Windows.Forms.Label();
            this.txtBanTinRo = new System.Windows.Forms.TextBox();
            this.txtBanTinDuocMaHoa = new System.Windows.Forms.TextBox();
            this.lblBanTinDuocMaHoa = new System.Windows.Forms.Label();
            this.txtBanTinDuocGiaiMa = new System.Windows.Forms.TextBox();
            this.lblBanTinDuocGiaiMa = new System.Windows.Forms.Label();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.btnGiaiMa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoViTri)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSoViTri
            // 
            this.lblSoViTri.AutoSize = true;
            this.lblSoViTri.Location = new System.Drawing.Point(23, 41);
            this.lblSoViTri.Name = "lblSoViTri";
            this.lblSoViTri.Size = new System.Drawing.Size(47, 13);
            this.lblSoViTri.TabIndex = 0;
            this.lblSoViTri.Text = "Số vị trí:";
            // 
            // nudSoViTri
            // 
            this.nudSoViTri.Location = new System.Drawing.Point(147, 41);
            this.nudSoViTri.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudSoViTri.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoViTri.Name = "nudSoViTri";
            this.nudSoViTri.Size = new System.Drawing.Size(157, 20);
            this.nudSoViTri.TabIndex = 1;
            this.nudSoViTri.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblBanTinRo
            // 
            this.lblBanTinRo.AutoSize = true;
            this.lblBanTinRo.Location = new System.Drawing.Point(23, 91);
            this.lblBanTinRo.Name = "lblBanTinRo";
            this.lblBanTinRo.Size = new System.Drawing.Size(55, 13);
            this.lblBanTinRo.TabIndex = 2;
            this.lblBanTinRo.Text = "Bản tin rõ:";
            // 
            // txtBanTinRo
            // 
            this.txtBanTinRo.Location = new System.Drawing.Point(147, 91);
            this.txtBanTinRo.Name = "txtBanTinRo";
            this.txtBanTinRo.Size = new System.Drawing.Size(210, 20);
            this.txtBanTinRo.TabIndex = 3;
            this.txtBanTinRo.TextChanged += new System.EventHandler(this.txtBanTinRo_TextChanged);
            // 
            // txtBanTinDuocMaHoa
            // 
            this.txtBanTinDuocMaHoa.Location = new System.Drawing.Point(147, 139);
            this.txtBanTinDuocMaHoa.Name = "txtBanTinDuocMaHoa";
            this.txtBanTinDuocMaHoa.Size = new System.Drawing.Size(210, 20);
            this.txtBanTinDuocMaHoa.TabIndex = 5;
            this.txtBanTinDuocMaHoa.TextChanged += new System.EventHandler(this.txtBanTinDuocMaHoa_TextChanged);
            // 
            // lblBanTinDuocMaHoa
            // 
            this.lblBanTinDuocMaHoa.AutoSize = true;
            this.lblBanTinDuocMaHoa.Location = new System.Drawing.Point(23, 139);
            this.lblBanTinDuocMaHoa.Name = "lblBanTinDuocMaHoa";
            this.lblBanTinDuocMaHoa.Size = new System.Drawing.Size(95, 13);
            this.lblBanTinDuocMaHoa.TabIndex = 4;
            this.lblBanTinDuocMaHoa.Text = "Bản được mã hoá:";
            // 
            // txtBanTinDuocGiaiMa
            // 
            this.txtBanTinDuocGiaiMa.Location = new System.Drawing.Point(147, 185);
            this.txtBanTinDuocGiaiMa.Name = "txtBanTinDuocGiaiMa";
            this.txtBanTinDuocGiaiMa.Size = new System.Drawing.Size(210, 20);
            this.txtBanTinDuocGiaiMa.TabIndex = 7;
            // 
            // lblBanTinDuocGiaiMa
            // 
            this.lblBanTinDuocGiaiMa.AutoSize = true;
            this.lblBanTinDuocGiaiMa.Location = new System.Drawing.Point(23, 185);
            this.lblBanTinDuocGiaiMa.Name = "lblBanTinDuocGiaiMa";
            this.lblBanTinDuocGiaiMa.Size = new System.Drawing.Size(107, 13);
            this.lblBanTinDuocGiaiMa.TabIndex = 6;
            this.lblBanTinDuocGiaiMa.Text = "Bản tin được giải mã:";
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Location = new System.Drawing.Point(26, 269);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(92, 23);
            this.btnMaHoa.TabIndex = 8;
            this.btnMaHoa.Text = "Mã hoá";
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.Location = new System.Drawing.Point(147, 269);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(92, 23);
            this.btnGiaiMa.TabIndex = 9;
            this.btnGiaiMa.Text = "Giải mã";
            this.btnGiaiMa.UseVisualStyleBackColor = true;
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // frmBaiToan1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 367);
            this.Controls.Add(this.btnGiaiMa);
            this.Controls.Add(this.btnMaHoa);
            this.Controls.Add(this.txtBanTinDuocGiaiMa);
            this.Controls.Add(this.lblBanTinDuocGiaiMa);
            this.Controls.Add(this.txtBanTinDuocMaHoa);
            this.Controls.Add(this.lblBanTinDuocMaHoa);
            this.Controls.Add(this.txtBanTinRo);
            this.Controls.Add(this.lblBanTinRo);
            this.Controls.Add(this.nudSoViTri);
            this.Controls.Add(this.lblSoViTri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmBaiToan1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Bài toán 1";
            ((System.ComponentModel.ISupportInitialize)(this.nudSoViTri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoViTri;
        private System.Windows.Forms.NumericUpDown nudSoViTri;
        private System.Windows.Forms.Label lblBanTinRo;
        private System.Windows.Forms.TextBox txtBanTinRo;
        private System.Windows.Forms.TextBox txtBanTinDuocMaHoa;
        private System.Windows.Forms.Label lblBanTinDuocMaHoa;
        private System.Windows.Forms.TextBox txtBanTinDuocGiaiMa;
        private System.Windows.Forms.Label lblBanTinDuocGiaiMa;
        private System.Windows.Forms.Button btnMaHoa;
        private System.Windows.Forms.Button btnGiaiMa;
    }
}

