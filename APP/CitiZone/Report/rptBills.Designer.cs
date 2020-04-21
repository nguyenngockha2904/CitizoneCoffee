namespace CitiZone
{
    partial class rptBill
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rptBill));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.lblBillID = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabelBillID = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblPrice = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblFood = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblAmount = new DevExpress.XtraReports.UI.XRLabel();
            this.xrptbCitiZone = new DevExpress.XtraReports.UI.XRPictureBox();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.lblTotal = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblTotalPrice = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.xrTableCellPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellAmount = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCellFood = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblBillID,
            this.xrLabelBillID,
            this.xrlblPrice,
            this.xrlblFood,
            this.xrlblAmount,
            this.xrptbCitiZone});
            this.TopMargin.HeightF = 204.75F;
            this.TopMargin.Name = "TopMargin";
            // 
            // lblBillID
            // 
            this.lblBillID.BorderColor = System.Drawing.Color.Transparent;
            this.lblBillID.Font = new System.Drawing.Font("Caviar Dreams", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblBillID.LocationFloat = new DevExpress.Utils.PointFloat(65.625F, 136.6666F);
            this.lblBillID.Multiline = true;
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblBillID.SizeF = new System.Drawing.SizeF(63.54167F, 23F);
            this.lblBillID.StylePriority.UseBorderColor = false;
            this.lblBillID.StylePriority.UseFont = false;
            this.lblBillID.StylePriority.UseTextAlignment = false;
            this.lblBillID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabelBillID
            // 
            this.xrLabelBillID.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabelBillID.Font = new System.Drawing.Font("Caviar Dreams", 11.25F, System.Drawing.FontStyle.Bold);
            this.xrLabelBillID.LocationFloat = new DevExpress.Utils.PointFloat(2.083333F, 136.6666F);
            this.xrLabelBillID.Multiline = true;
            this.xrLabelBillID.Name = "xrLabelBillID";
            this.xrLabelBillID.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabelBillID.SizeF = new System.Drawing.SizeF(63.54167F, 23F);
            this.xrLabelBillID.StylePriority.UseBorderColor = false;
            this.xrLabelBillID.StylePriority.UseFont = false;
            this.xrLabelBillID.StylePriority.UseTextAlignment = false;
            this.xrLabelBillID.Text = "Bill ID:";
            this.xrLabelBillID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrlblPrice
            // 
            this.xrlblPrice.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrlblPrice.Font = new System.Drawing.Font("Caviar Dreams", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrlblPrice.LocationFloat = new DevExpress.Utils.PointFloat(363.125F, 181.75F);
            this.xrlblPrice.Multiline = true;
            this.xrlblPrice.Name = "xrlblPrice";
            this.xrlblPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlblPrice.SizeF = new System.Drawing.SizeF(98.87497F, 23F);
            this.xrlblPrice.StylePriority.UseBorders = false;
            this.xrlblPrice.StylePriority.UseFont = false;
            this.xrlblPrice.StylePriority.UseTextAlignment = false;
            this.xrlblPrice.Text = "Price";
            this.xrlblPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrlblFood
            // 
            this.xrlblFood.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrlblFood.Font = new System.Drawing.Font("Caviar Dreams", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrlblFood.LocationFloat = new DevExpress.Utils.PointFloat(0F, 181.75F);
            this.xrlblFood.Multiline = true;
            this.xrlblFood.Name = "xrlblFood";
            this.xrlblFood.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlblFood.SizeF = new System.Drawing.SizeF(281.875F, 23F);
            this.xrlblFood.StylePriority.UseBorders = false;
            this.xrlblFood.StylePriority.UseFont = false;
            this.xrlblFood.StylePriority.UseTextAlignment = false;
            this.xrlblFood.Text = "Food";
            this.xrlblFood.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrlblAmount
            // 
            this.xrlblAmount.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrlblAmount.Font = new System.Drawing.Font("Caviar Dreams", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrlblAmount.LocationFloat = new DevExpress.Utils.PointFloat(281.875F, 181.75F);
            this.xrlblAmount.Multiline = true;
            this.xrlblAmount.Name = "xrlblAmount";
            this.xrlblAmount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlblAmount.SizeF = new System.Drawing.SizeF(81.25F, 23F);
            this.xrlblAmount.StylePriority.UseBorders = false;
            this.xrlblAmount.StylePriority.UseFont = false;
            this.xrlblAmount.StylePriority.UseTextAlignment = false;
            this.xrlblAmount.Text = "Amount";
            this.xrlblAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrptbCitiZone
            // 
            this.xrptbCitiZone.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrptbCitiZone.ImageSource"));
            this.xrptbCitiZone.LocationFloat = new DevExpress.Utils.PointFloat(65.625F, 27.08333F);
            this.xrptbCitiZone.Name = "xrptbCitiZone";
            this.xrptbCitiZone.SizeF = new System.Drawing.SizeF(338.5415F, 97.70832F);
            this.xrptbCitiZone.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblTotal,
            this.xrlblTotalPrice,
            this.xrLabel1});
            this.BottomMargin.HeightF = 225F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderColor = System.Drawing.Color.Transparent;
            this.lblTotal.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.lblTotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.LocationFloat = new DevExpress.Utils.PointFloat(363.125F, 0F);
            this.lblTotal.Multiline = true;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTotal.SizeF = new System.Drawing.SizeF(97.91669F, 22.99998F);
            this.lblTotal.StylePriority.UseBorderColor = false;
            this.lblTotal.StylePriority.UseBorders = false;
            this.lblTotal.StylePriority.UseFont = false;
            this.lblTotal.StylePriority.UseTextAlignment = false;
            this.lblTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrlblTotalPrice
            // 
            this.xrlblTotalPrice.BorderColor = System.Drawing.Color.Transparent;
            this.xrlblTotalPrice.Font = new System.Drawing.Font("Caviar Dreams", 11.25F, System.Drawing.FontStyle.Bold);
            this.xrlblTotalPrice.LocationFloat = new DevExpress.Utils.PointFloat(251.6667F, 0F);
            this.xrlblTotalPrice.Multiline = true;
            this.xrlblTotalPrice.Name = "xrlblTotalPrice";
            this.xrlblTotalPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlblTotalPrice.SizeF = new System.Drawing.SizeF(111.4583F, 23.00001F);
            this.xrlblTotalPrice.StylePriority.UseBorderColor = false;
            this.xrlblTotalPrice.StylePriority.UseFont = false;
            this.xrlblTotalPrice.StylePriority.UseTextAlignment = false;
            this.xrlblTotalPrice.Text = "Total Price:";
            this.xrlblTotalPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.BorderColor = System.Drawing.Color.Transparent;
            this.xrLabel1.Font = new System.Drawing.Font("Caviar Dreams", 11.25F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(82.91661F, 39.16667F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(294.5834F, 40.70835F);
            this.xrLabel1.StylePriority.UseBorderColor = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "HAVE FUN WITH YOUR FRIENDS";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.DataSource = typeof(CitiZone.billInfo);
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // xrTableCellPrice
            // 
            this.xrTableCellPrice.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCellPrice.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Total]")});
            this.xrTableCellPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCellPrice.Multiline = true;
            this.xrTableCellPrice.Name = "xrTableCellPrice";
            this.xrTableCellPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCellPrice.StylePriority.UseBorders = false;
            this.xrTableCellPrice.StylePriority.UseFont = false;
            this.xrTableCellPrice.StylePriority.UseTextAlignment = false;
            this.xrTableCellPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCellPrice.Weight = 0.63790305268298386D;
            // 
            // xrTableCellAmount
            // 
            this.xrTableCellAmount.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCellAmount.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Amount]")});
            this.xrTableCellAmount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCellAmount.Multiline = true;
            this.xrTableCellAmount.Name = "xrTableCellAmount";
            this.xrTableCellAmount.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCellAmount.StylePriority.UseBorders = false;
            this.xrTableCellAmount.StylePriority.UseFont = false;
            this.xrTableCellAmount.StylePriority.UseTextAlignment = false;
            this.xrTableCellAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCellAmount.Weight = 0.52419353039199457D;
            // 
            // xrTableCellFood
            // 
            this.xrTableCellFood.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCellFood.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[FoodID]")});
            this.xrTableCellFood.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCellFood.Multiline = true;
            this.xrTableCellFood.Name = "xrTableCellFood";
            this.xrTableCellFood.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrTableCellFood.StylePriority.UseBorders = false;
            this.xrTableCellFood.StylePriority.UseFont = false;
            this.xrTableCellFood.StylePriority.UseTextAlignment = false;
            this.xrTableCellFood.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCellFood.Weight = 1.8185479888228231D;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCellFood,
            this.xrTableCellAmount,
            this.xrTableCellPrice});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(461.9999F, 28.125F);
            // 
            // Detail
            // 
            this.Detail.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid;
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.HeightF = 28.54153F;
            this.Detail.KeepTogetherWithDetailReports = true;
            this.Detail.Name = "Detail";
            this.Detail.StylePriority.UseBorderDashStyle = false;
            this.Detail.StylePriority.UseTextAlignment = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // rptBill
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
            this.DataSource = this.objectDataSource1;
            this.DisplayName = "CitiZone";
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(44, 37, 205, 225);
            this.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Version = "18.2";
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPictureBox xrptbCitiZone;
        private DevExpress.XtraReports.UI.XRLabel xrlblTotalPrice;
        private DevExpress.XtraReports.UI.XRLabel xrlblPrice;
        private DevExpress.XtraReports.UI.XRLabel xrlblAmount;
        private DevExpress.XtraReports.UI.XRLabel xrlblFood;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraReports.UI.XRLabel xrLabelBillID;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        private DevExpress.XtraReports.UI.XRLabel lblBillID;
        private DevExpress.XtraReports.UI.XRLabel lblTotal;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellPrice;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellAmount;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCellFood;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.DetailBand Detail;
    }
}
