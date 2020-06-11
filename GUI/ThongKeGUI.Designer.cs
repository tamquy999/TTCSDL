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
            this.groupDoanhThu = new DevExpress.XtraEditors.GroupControl();
            this.dateEditCuoi = new DevExpress.XtraEditors.DateEdit();
            this.dateEditDau = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chartControlDoanhThu = new DevExpress.XtraCharts.ChartControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupDoanhThu)).BeginInit();
            this.groupDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCuoi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCuoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedAreaSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDoanhThu
            // 
            this.groupDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDoanhThu.Controls.Add(this.dateEditCuoi);
            this.groupDoanhThu.Controls.Add(this.dateEditDau);
            this.groupDoanhThu.Controls.Add(this.labelControl2);
            this.groupDoanhThu.Controls.Add(this.labelControl1);
            this.groupDoanhThu.Controls.Add(this.chartControlDoanhThu);
            this.groupDoanhThu.Location = new System.Drawing.Point(3, 0);
            this.groupDoanhThu.Name = "groupDoanhThu";
            this.groupDoanhThu.Size = new System.Drawing.Size(1048, 417);
            this.groupDoanhThu.TabIndex = 1;
            this.groupDoanhThu.Text = "Thống Kê Doanh Thu";
            // 
            // dateEditCuoi
            // 
            this.dateEditCuoi.EditValue = null;
            this.dateEditCuoi.Location = new System.Drawing.Point(301, 40);
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
            this.dateEditDau.EditValue = null;
            this.dateEditDau.Location = new System.Drawing.Point(92, 40);
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
            this.labelControl2.Location = new System.Drawing.Point(270, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(25, 18);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "đến";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Thống kê từ";
            // 
            // chartControlDoanhThu
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.SideMarginsValue = 0D;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControlDoanhThu.Diagram = xyDiagram1;
            this.chartControlDoanhThu.Legend.Name = "Default Legend";
            this.chartControlDoanhThu.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControlDoanhThu.Location = new System.Drawing.Point(3, 72);
            this.chartControlDoanhThu.Name = "chartControlDoanhThu";
            series1.Name = "BDDoanhThu";
            stackedAreaSeriesView1.Transparency = ((byte)(135));
            series1.View = stackedAreaSeriesView1;
            this.chartControlDoanhThu.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControlDoanhThu.Size = new System.Drawing.Size(867, 344);
            this.chartControlDoanhThu.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Location = new System.Drawing.Point(3, 423);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1049, 338);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thống Kê Vaccine";
            // 
            // ThongKeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupDoanhThu);
            this.Name = "ThongKeGUI";
            this.Size = new System.Drawing.Size(1055, 765);
            ((System.ComponentModel.ISupportInitialize)(this.groupDoanhThu)).EndInit();
            this.groupDoanhThu.ResumeLayout(false);
            this.groupDoanhThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCuoi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditCuoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedAreaSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.ResumeLayout(false);

          }

          #endregion
          private DevExpress.XtraEditors.GroupControl groupDoanhThu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit dateEditCuoi;
        private DevExpress.XtraEditors.DateEdit dateEditDau;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraCharts.ChartControl chartControlDoanhThu;
    }
}
