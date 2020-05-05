namespace GUI
{
    partial class LichSuGUI
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
            this.gridLichSu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnTraCuu = new DevExpress.XtraEditors.SimpleButton();
            this.tbMaKH = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dtpNgayTiem = new DevExpress.XtraEditors.DateEdit();
            this.tbChiDinh = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.tbDonGia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tbLieuLuong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tbTenVC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridLichSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayTiem.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayTiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbChiDinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLieuLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenVC.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridLichSu
            // 
            this.gridLichSu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLichSu.Location = new System.Drawing.Point(3, 208);
            this.gridLichSu.MainView = this.gridView1;
            this.gridLichSu.Name = "gridLichSu";
            this.gridLichSu.Size = new System.Drawing.Size(1043, 554);
            this.gridLichSu.TabIndex = 0;
            this.gridLichSu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridLichSu;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnTraCuu);
            this.groupControl1.Controls.Add(this.tbMaKH);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(297, 202);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Tra cứu lịch sử tiêm";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Location = new System.Drawing.Point(104, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 18);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã khách hàng";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTraCuu.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnTraCuu.Appearance.Options.UseBackColor = true;
            this.btnTraCuu.Location = new System.Drawing.Point(104, 134);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(100, 29);
            this.btnTraCuu.TabIndex = 1;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // tbMaKH
            // 
            this.tbMaKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMaKH.Location = new System.Drawing.Point(38, 91);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Properties.Appearance.Options.UseTextOptions = true;
            this.tbMaKH.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tbMaKH.Size = new System.Drawing.Size(226, 24);
            this.tbMaKH.TabIndex = 0;
            this.tbMaKH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMaKH_KeyDown);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dtpNgayTiem);
            this.groupControl2.Controls.Add(this.tbChiDinh);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.tbDonGia);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.tbLieuLuong);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.tbTenVC);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(306, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(740, 202);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Chi tiết lần tiêm";
            // 
            // dtpNgayTiem
            // 
            this.dtpNgayTiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayTiem.EditValue = null;
            this.dtpNgayTiem.Location = new System.Drawing.Point(120, 49);
            this.dtpNgayTiem.Name = "dtpNgayTiem";
            this.dtpNgayTiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayTiem.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayTiem.Size = new System.Drawing.Size(227, 24);
            this.dtpNgayTiem.TabIndex = 13;
            // 
            // tbChiDinh
            // 
            this.tbChiDinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbChiDinh.Location = new System.Drawing.Point(455, 98);
            this.tbChiDinh.Name = "tbChiDinh";
            this.tbChiDinh.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbChiDinh.Size = new System.Drawing.Size(253, 73);
            this.tbChiDinh.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl6.Location = new System.Drawing.Point(382, 100);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 18);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Chỉ định";
            // 
            // tbDonGia
            // 
            this.tbDonGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDonGia.Location = new System.Drawing.Point(455, 49);
            this.tbDonGia.Name = "tbDonGia";
            this.tbDonGia.Size = new System.Drawing.Size(253, 24);
            this.tbDonGia.TabIndex = 8;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl5.Location = new System.Drawing.Point(382, 52);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Đơn giá";
            // 
            // tbLieuLuong
            // 
            this.tbLieuLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbLieuLuong.Location = new System.Drawing.Point(120, 147);
            this.tbLieuLuong.Name = "tbLieuLuong";
            this.tbLieuLuong.Size = new System.Drawing.Size(227, 24);
            this.tbLieuLuong.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl4.Location = new System.Drawing.Point(36, 150);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 18);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Liều lượng";
            // 
            // tbTenVC
            // 
            this.tbTenVC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTenVC.Location = new System.Drawing.Point(120, 97);
            this.tbTenVC.Name = "tbTenVC";
            this.tbTenVC.Size = new System.Drawing.Size(227, 24);
            this.tbTenVC.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Location = new System.Drawing.Point(36, 100);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Tên vaccine";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Location = new System.Drawing.Point(36, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ngày tiêm";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.97998F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.02002F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1049, 208);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // LichSuGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gridLichSu);
            this.Name = "LichSuGUI";
            this.Size = new System.Drawing.Size(1049, 765);
            ((System.ComponentModel.ISupportInitialize)(this.gridLichSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayTiem.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayTiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbChiDinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLieuLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenVC.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridLichSu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnTraCuu;
        private DevExpress.XtraEditors.TextEdit tbMaKH;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.MemoEdit tbChiDinh;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit tbDonGia;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit tbLieuLuong;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit tbTenVC;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtpNgayTiem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
