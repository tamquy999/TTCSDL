namespace GUI
{
     partial class ThongKeGUI
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

          #region Component Designer generated code

          /// <summary> 
          /// Required method for Designer support - do not modify 
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedAreaSeriesView stackedAreaSeriesView1 = new DevExpress.XtraCharts.StackedAreaSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel1 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView1 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.SeriesTitle seriesTitle1 = new DevExpress.XtraCharts.SeriesTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            this.dateEditCuoi = new DevExpress.XtraEditors.DateEdit();
            this.dateEditDau = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chartControlDoanhThu = new DevExpress.XtraCharts.ChartControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tedTongDoanhThu = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.chartControlLoaiVC = new DevExpress.XtraCharts.ChartControl();
            this.chartControlMostVC = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCuoi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCuoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedAreaSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedTongDoanhThu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlLoaiVC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlMostVC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            this.SuspendLayout();
            // 
            // dateEditCuoi
            // 
            this.dateEditCuoi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateEditCuoi.EditValue = null;
            this.dateEditCuoi.Location = new System.Drawing.Point(342, 14);
            this.dateEditCuoi.Name = "dateEditCuoi";
            this.dateEditCuoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditCuoi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditCuoi.Size = new System.Drawing.Size(172, 24);
            this.dateEditCuoi.TabIndex = 4;
            this.dateEditCuoi.EditValueChanged += new System.EventHandler(this.dateEdit2_EditValueChanged);
            // 
            // dateEditDau
            // 
            this.dateEditDau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateEditDau.EditValue = null;
            this.dateEditDau.Location = new System.Drawing.Point(133, 14);
            this.dateEditDau.Name = "dateEditDau";
            this.dateEditDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDau.Size = new System.Drawing.Size(172, 24);
            this.dateEditDau.TabIndex = 3;
            this.dateEditDau.EditValueChanged += new System.EventHandler(this.dateEdit1_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Location = new System.Drawing.Point(311, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "đến";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Location = new System.Drawing.Point(46, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Thống kê từ";
            // 
            // chartControlDoanhThu
            // 
            this.chartControlDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0D;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControlDoanhThu.Diagram = xyDiagram1;
            this.chartControlDoanhThu.Legend.Name = "Default Legend";
            this.chartControlDoanhThu.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControlDoanhThu.Location = new System.Drawing.Point(0, 42);
            this.chartControlDoanhThu.Name = "chartControlDoanhThu";
            series1.Name = "BDDoanhThu";
            stackedAreaSeriesView1.Transparency = ((byte)(135));
            series1.View = stackedAreaSeriesView1;
            this.chartControlDoanhThu.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControlDoanhThu.Size = new System.Drawing.Size(1054, 354);
            this.chartControlDoanhThu.TabIndex = 0;
            chartTitle1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartTitle1.Text = "Thống kê doanh thu";
            this.chartControlDoanhThu.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Location = new System.Drawing.Point(524, 17);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(127, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Có tổng doanh thu:";
            // 
            // tedTongDoanhThu
            // 
            this.tedTongDoanhThu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tedTongDoanhThu.Location = new System.Drawing.Point(657, 14);
            this.tedTongDoanhThu.Name = "tedTongDoanhThu";
            this.tedTongDoanhThu.Properties.ReadOnly = true;
            this.tedTongDoanhThu.Size = new System.Drawing.Size(170, 24);
            this.tedTongDoanhThu.TabIndex = 6;
            this.tedTongDoanhThu.ToolTip = "Click để Copy";
            this.tedTongDoanhThu.DoubleClick += new System.EventHandler(this.tedTongDoanhThu_DoubleClick);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(866, 11);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(143, 29);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Xuất báo cáo";
            // 
            // chartControlLoaiVC
            // 
            this.chartControlLoaiVC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControlLoaiVC.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop;
            this.chartControlLoaiVC.Legend.Name = "Default Legend";
            this.chartControlLoaiVC.Legend.Tag = "";
            this.chartControlLoaiVC.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControlLoaiVC.Location = new System.Drawing.Point(558, 396);
            this.chartControlLoaiVC.Name = "chartControlLoaiVC";
            doughnutSeriesLabel1.TextPattern = "{A}:{V}";
            series2.Label = doughnutSeriesLabel1;
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.Name = "BDLoaiVC";
            doughnutSeriesView1.HoleRadiusPercent = 40;
            seriesTitle1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            seriesTitle1.Text = "Tỷ trọng vaccine theo từng loại";
            seriesTitle1.Visibility = DevExpress.Utils.DefaultBoolean.True;
            doughnutSeriesView1.Titles.AddRange(new DevExpress.XtraCharts.SeriesTitle[] {
            seriesTitle1});
            series2.View = doughnutSeriesView1;
            this.chartControlLoaiVC.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControlLoaiVC.Size = new System.Drawing.Size(497, 369);
            this.chartControlLoaiVC.TabIndex = 0;
            // 
            // chartControlMostVC
            // 
            this.chartControlMostVC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram2.Rotated = true;
            this.chartControlMostVC.Diagram = xyDiagram2;
            this.chartControlMostVC.Legend.Name = "Default Legend";
            this.chartControlMostVC.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControlMostVC.Location = new System.Drawing.Point(0, 396);
            this.chartControlMostVC.Name = "chartControlMostVC";
            series3.Name = "BDCmostVC";
            this.chartControlMostVC.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            this.chartControlMostVC.Size = new System.Drawing.Size(559, 327);
            this.chartControlMostVC.TabIndex = 8;
            chartTitle2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartTitle2.Text = "TOP 5 Vaccine dùng nhiều";
            this.chartControlMostVC.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            // 
            // ThongKeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartControlMostVC);
            this.Controls.Add(this.chartControlLoaiVC);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.tedTongDoanhThu);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dateEditCuoi);
            this.Controls.Add(this.chartControlDoanhThu);
            this.Controls.Add(this.dateEditDau);
            this.Controls.Add(this.labelControl2);
            this.Name = "ThongKeGUI";
            this.Size = new System.Drawing.Size(1055, 765);
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCuoi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCuoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedAreaSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tedTongDoanhThu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlLoaiVC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlMostVC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

          }

          #endregion
        private DevExpress.XtraEditors.DateEdit dateEditCuoi;
        private DevExpress.XtraEditors.DateEdit dateEditDau;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraCharts.ChartControl chartControlDoanhThu;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit tedTongDoanhThu;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraCharts.ChartControl chartControlLoaiVC;
        private DevExpress.XtraCharts.ChartControl chartControlMostVC;
    }
}
