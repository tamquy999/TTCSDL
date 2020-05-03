namespace GUI
{
    partial class PhieuTiemGUI
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gridPhieuTiem = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.deNgayTiem = new DevExpress.XtraEditors.DateEdit();
            this.tbMaVC = new DevExpress.XtraEditors.TextEdit();
            this.tbMaBS = new DevExpress.XtraEditors.TextEdit();
            this.lbMaVC = new DevExpress.XtraEditors.LabelControl();
            this.lbMaBS = new DevExpress.XtraEditors.LabelControl();
            this.tbMaKH = new DevExpress.XtraEditors.TextEdit();
            this.lbMaKH = new DevExpress.XtraEditors.LabelControl();
            this.tbGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.lbGhiChu = new DevExpress.XtraEditors.LabelControl();
            this.lbNgayTiem = new DevExpress.XtraEditors.LabelControl();
            this.tbLoaiTiem = new DevExpress.XtraEditors.TextEdit();
            this.lbLoaiTiem = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhieuTiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayTiem.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayTiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaVC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaBS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLoaiTiem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.btnSua);
            this.panelControl1.Controls.Add(this.btnThem);
            this.panelControl1.Location = new System.Drawing.Point(754, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(242, 290);
            this.panelControl1.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnXoa.Appearance.Options.UseBackColor = true;
            this.btnXoa.Location = new System.Drawing.Point(45, 197);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(154, 50);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnSua.Appearance.Options.UseBackColor = true;
            this.btnSua.Location = new System.Drawing.Point(45, 119);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(154, 50);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnThem.Appearance.Options.UseBackColor = true;
            this.btnThem.Location = new System.Drawing.Point(45, 41);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(154, 50);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gridPhieuTiem
            // 
            this.gridPhieuTiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPhieuTiem.Location = new System.Drawing.Point(0, 301);
            this.gridPhieuTiem.MainView = this.gridView1;
            this.gridPhieuTiem.Name = "gridPhieuTiem";
            this.gridPhieuTiem.Size = new System.Drawing.Size(1001, 464);
            this.gridPhieuTiem.TabIndex = 2;
            this.gridPhieuTiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 394;
            this.gridView1.GridControl = this.gridPhieuTiem;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.deNgayTiem);
            this.panelControl2.Controls.Add(this.tbMaVC);
            this.panelControl2.Controls.Add(this.tbMaBS);
            this.panelControl2.Controls.Add(this.lbMaVC);
            this.panelControl2.Controls.Add(this.lbMaBS);
            this.panelControl2.Controls.Add(this.tbMaKH);
            this.panelControl2.Controls.Add(this.lbMaKH);
            this.panelControl2.Controls.Add(this.tbGhiChu);
            this.panelControl2.Controls.Add(this.lbGhiChu);
            this.panelControl2.Controls.Add(this.lbNgayTiem);
            this.panelControl2.Controls.Add(this.tbLoaiTiem);
            this.panelControl2.Controls.Add(this.lbLoaiTiem);
            this.panelControl2.Location = new System.Drawing.Point(5, 5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(750, 290);
            this.panelControl2.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(239, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(297, 29);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "THÔNG TIN PHIẾU TIÊM";
            // 
            // deNgayTiem
            // 
            this.deNgayTiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deNgayTiem.EditValue = null;
            this.deNgayTiem.Location = new System.Drawing.Point(162, 153);
            this.deNgayTiem.Name = "deNgayTiem";
            this.deNgayTiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayTiem.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNgayTiem.Size = new System.Drawing.Size(198, 24);
            this.deNgayTiem.TabIndex = 15;
            // 
            // tbMaVC
            // 
            this.tbMaVC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMaVC.Location = new System.Drawing.Point(520, 221);
            this.tbMaVC.Name = "tbMaVC";
            this.tbMaVC.Size = new System.Drawing.Size(193, 24);
            this.tbMaVC.TabIndex = 14;
            // 
            // tbMaBS
            // 
            this.tbMaBS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMaBS.Location = new System.Drawing.Point(520, 153);
            this.tbMaBS.Name = "tbMaBS";
            this.tbMaBS.Size = new System.Drawing.Size(193, 24);
            this.tbMaBS.TabIndex = 13;
            // 
            // lbMaVC
            // 
            this.lbMaVC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMaVC.Location = new System.Drawing.Point(400, 224);
            this.lbMaVC.Name = "lbMaVC";
            this.lbMaVC.Size = new System.Drawing.Size(73, 18);
            this.lbMaVC.TabIndex = 11;
            this.lbMaVC.Text = "Mã vaccine";
            // 
            // lbMaBS
            // 
            this.lbMaBS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMaBS.Location = new System.Drawing.Point(400, 156);
            this.lbMaBS.Name = "lbMaBS";
            this.lbMaBS.Size = new System.Drawing.Size(68, 18);
            this.lbMaBS.TabIndex = 10;
            this.lbMaBS.Text = "Mã bác sỹ";
            // 
            // tbMaKH
            // 
            this.tbMaKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMaKH.Location = new System.Drawing.Point(520, 85);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(193, 24);
            this.tbMaKH.TabIndex = 9;
            // 
            // lbMaKH
            // 
            this.lbMaKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMaKH.Location = new System.Drawing.Point(400, 88);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(100, 18);
            this.lbMaKH.TabIndex = 8;
            this.lbMaKH.Text = "Mã khách hàng";
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbGhiChu.Location = new System.Drawing.Point(162, 221);
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(198, 24);
            this.tbGhiChu.TabIndex = 6;
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbGhiChu.Location = new System.Drawing.Point(42, 224);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(48, 18);
            this.lbGhiChu.TabIndex = 3;
            this.lbGhiChu.Text = "Ghi chú";
            // 
            // lbNgayTiem
            // 
            this.lbNgayTiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNgayTiem.Location = new System.Drawing.Point(42, 156);
            this.lbNgayTiem.Name = "lbNgayTiem";
            this.lbNgayTiem.Size = new System.Drawing.Size(67, 18);
            this.lbNgayTiem.TabIndex = 2;
            this.lbNgayTiem.Text = "Ngày tiêm";
            // 
            // tbLoaiTiem
            // 
            this.tbLoaiTiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbLoaiTiem.Location = new System.Drawing.Point(162, 85);
            this.tbLoaiTiem.Name = "tbLoaiTiem";
            this.tbLoaiTiem.Size = new System.Drawing.Size(198, 24);
            this.tbLoaiTiem.TabIndex = 1;
            // 
            // lbLoaiTiem
            // 
            this.lbLoaiTiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbLoaiTiem.Location = new System.Drawing.Point(42, 88);
            this.lbLoaiTiem.Name = "lbLoaiTiem";
            this.lbLoaiTiem.Size = new System.Drawing.Size(102, 18);
            this.lbLoaiTiem.TabIndex = 0;
            this.lbLoaiTiem.Text = "Loại tiêm chủng";
            // 
            // PhieuTiemGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gridPhieuTiem);
            this.Controls.Add(this.panelControl1);
            this.Name = "PhieuTiemGUI";
            this.Size = new System.Drawing.Size(1001, 765);
            this.Load += new System.EventHandler(this.PhieuTiemGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPhieuTiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayTiem.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNgayTiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaVC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaBS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLoaiTiem.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridPhieuTiem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit tbGhiChu;
        private DevExpress.XtraEditors.LabelControl lbGhiChu;
        private DevExpress.XtraEditors.LabelControl lbNgayTiem;
        private DevExpress.XtraEditors.TextEdit tbLoaiTiem;
        private DevExpress.XtraEditors.LabelControl lbLoaiTiem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.TextEdit tbMaVC;
        private DevExpress.XtraEditors.TextEdit tbMaBS;
        private DevExpress.XtraEditors.LabelControl lbMaVC;
        private DevExpress.XtraEditors.LabelControl lbMaBS;
        private DevExpress.XtraEditors.TextEdit tbMaKH;
        private DevExpress.XtraEditors.LabelControl lbMaKH;
        private DevExpress.XtraEditors.DateEdit deNgayTiem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
