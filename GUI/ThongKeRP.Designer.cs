namespace GUI
{
    partial class ThongKeRP
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
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrLabel_DoanhThu = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel_ThoiGianTK = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 0F;
            this.TopMargin.Name = "TopMargin";
            // 
            // xrLabel_DoanhThu
            // 
            this.xrLabel_DoanhThu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel_DoanhThu.LocationFloat = new DevExpress.Utils.PointFloat(135F, 71.66666F);
            this.xrLabel_DoanhThu.Multiline = true;
            this.xrLabel_DoanhThu.Name = "xrLabel_DoanhThu";
            this.xrLabel_DoanhThu.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel_DoanhThu.SizeF = new System.Drawing.SizeF(351.8182F, 25.49999F);
            this.xrLabel_DoanhThu.StylePriority.UseFont = false;
            this.xrLabel_DoanhThu.StylePriority.UseTextAlignment = false;
            this.xrLabel_DoanhThu.Text = "Tổng doanh thu:";
            this.xrLabel_DoanhThu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel_ThoiGianTK
            // 
            this.xrLabel_ThoiGianTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel_ThoiGianTK.LocationFloat = new DevExpress.Utils.PointFloat(135F, 49.36363F);
            this.xrLabel_ThoiGianTK.Multiline = true;
            this.xrLabel_ThoiGianTK.Name = "xrLabel_ThoiGianTK";
            this.xrLabel_ThoiGianTK.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel_ThoiGianTK.SizeF = new System.Drawing.SizeF(351.8182F, 22.30302F);
            this.xrLabel_ThoiGianTK.StylePriority.UseFont = false;
            this.xrLabel_ThoiGianTK.StylePriority.UseTextAlignment = false;
            this.xrLabel_ThoiGianTK.Text = "Thời gian:";
            this.xrLabel_ThoiGianTK.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(135F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(351.8182F, 49.36364F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "BÁO CÁO THỐNG KÊ";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 0F;
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Name = "Detail";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel_DoanhThu,
            this.xrLabel_ThoiGianTK,
            this.xrLabel1});
            this.ReportHeader.Name = "ReportHeader";
            // 
            // ReportFooter
            // 
            this.ReportFooter.HeightF = 137.5F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // ThongKeRP
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader,
            this.ReportFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.bindingSource1});
            this.DataSource = this.bindingSource1;
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 0, 0);
            this.Version = "19.2";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel_ThoiGianTK;
        private DevExpress.XtraReports.UI.XRLabel xrLabel_DoanhThu;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
