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
            this.gridPhieuTiem = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbGioiTinh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtpNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.lbNgaySinh = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.lbTienSu = new DevExpress.XtraEditors.LabelControl();
            this.lbGioiTinh = new DevExpress.XtraEditors.LabelControl();
            this.tbTenKH = new DevExpress.XtraEditors.TextEdit();
            this.dtpNgayTiem = new DevExpress.XtraEditors.DateEdit();
            this.tbMaBS = new DevExpress.XtraEditors.TextEdit();
            this.lbMaBS = new DevExpress.XtraEditors.LabelControl();
            this.lbTenKH = new DevExpress.XtraEditors.LabelControl();
            this.lbNgayTiem = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddVC = new DevExpress.XtraEditors.SimpleButton();
            this.tbMaVC = new DevExpress.XtraEditors.TextEdit();
            this.tbLoaiTiem = new DevExpress.XtraEditors.TextEdit();
            this.lbLoaiTiem = new DevExpress.XtraEditors.LabelControl();
            this.lbMaVC = new DevExpress.XtraEditors.LabelControl();
            this.btnSubVC = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tbLieuLuong = new DevExpress.XtraEditors.TextEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.gridVaccine = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhieuTiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGioiTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayTiem.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayTiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaBS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaVC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLoaiTiem.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbLieuLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVaccine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPhieuTiem
            // 
            this.gridPhieuTiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPhieuTiem.Location = new System.Drawing.Point(3, 469);
            this.gridPhieuTiem.MainView = this.gridView1;
            this.gridPhieuTiem.Name = "gridPhieuTiem";
            this.gridPhieuTiem.Size = new System.Drawing.Size(1049, 293);
            this.gridPhieuTiem.TabIndex = 2;
            this.gridPhieuTiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 394;
            this.gridView1.GridControl = this.gridPhieuTiem;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbGioiTinh.EditValue = "";
            this.cbGioiTinh.Location = new System.Drawing.Point(160, 109);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbGioiTinh.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbGioiTinh.Size = new System.Drawing.Size(226, 24);
            this.cbGioiTinh.TabIndex = 2;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgaySinh.EditValue = null;
            this.dtpNgaySinh.Location = new System.Drawing.Point(160, 60);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgaySinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtpNgaySinh.Size = new System.Drawing.Size(226, 24);
            this.dtpNgaySinh.TabIndex = 1;
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNgaySinh.Location = new System.Drawing.Point(41, 63);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(64, 18);
            this.lbNgaySinh.TabIndex = 24;
            this.lbNgaySinh.Text = "Ngày sinh";
            // 
            // textEdit3
            // 
            this.textEdit3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textEdit3.Location = new System.Drawing.Point(539, 11);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(230, 24);
            this.textEdit3.TabIndex = 3;
            // 
            // lbTienSu
            // 
            this.lbTienSu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTienSu.Location = new System.Drawing.Point(435, 14);
            this.lbTienSu.Name = "lbTienSu";
            this.lbTienSu.Size = new System.Drawing.Size(86, 18);
            this.lbTienSu.TabIndex = 22;
            this.lbTienSu.Text = "Tiền sử bệnh";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbGioiTinh.Location = new System.Drawing.Point(41, 112);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(50, 18);
            this.lbGioiTinh.TabIndex = 20;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // tbTenKH
            // 
            this.tbTenKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTenKH.Location = new System.Drawing.Point(160, 11);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(226, 24);
            this.tbTenKH.TabIndex = 0;
            // 
            // dtpNgayTiem
            // 
            this.dtpNgayTiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayTiem.EditValue = null;
            this.dtpNgayTiem.Location = new System.Drawing.Point(539, 60);
            this.dtpNgayTiem.Name = "dtpNgayTiem";
            this.dtpNgayTiem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayTiem.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayTiem.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtpNgayTiem.Size = new System.Drawing.Size(230, 24);
            this.dtpNgayTiem.TabIndex = 2;
            // 
            // tbMaBS
            // 
            this.tbMaBS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMaBS.Location = new System.Drawing.Point(539, 109);
            this.tbMaBS.Name = "tbMaBS";
            this.tbMaBS.Size = new System.Drawing.Size(230, 24);
            this.tbMaBS.TabIndex = 3;
            // 
            // lbMaBS
            // 
            this.lbMaBS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMaBS.Location = new System.Drawing.Point(434, 112);
            this.lbMaBS.Name = "lbMaBS";
            this.lbMaBS.Size = new System.Drawing.Size(68, 18);
            this.lbMaBS.TabIndex = 10;
            this.lbMaBS.Text = "Mã bác sỹ";
            // 
            // lbTenKH
            // 
            this.lbTenKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTenKH.Location = new System.Drawing.Point(41, 14);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(106, 18);
            this.lbTenKH.TabIndex = 8;
            this.lbTenKH.Text = "Tên khách hàng";
            // 
            // lbNgayTiem
            // 
            this.lbNgayTiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNgayTiem.Location = new System.Drawing.Point(435, 64);
            this.lbNgayTiem.Name = "lbNgayTiem";
            this.lbNgayTiem.Size = new System.Drawing.Size(67, 18);
            this.lbNgayTiem.TabIndex = 2;
            this.lbNgayTiem.Text = "Ngày tiêm";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tableLayoutPanel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(821, 184);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin phiếu tiêm";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(817, 149);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpNgayTiem);
            this.panel1.Controls.Add(this.cbGioiTinh);
            this.panel1.Controls.Add(this.lbMaBS);
            this.panel1.Controls.Add(this.tbTenKH);
            this.panel1.Controls.Add(this.lbTienSu);
            this.panel1.Controls.Add(this.dtpNgaySinh);
            this.panel1.Controls.Add(this.tbMaBS);
            this.panel1.Controls.Add(this.textEdit3);
            this.panel1.Controls.Add(this.lbTenKH);
            this.panel1.Controls.Add(this.lbNgayTiem);
            this.panel1.Controls.Add(this.lbNgaySinh);
            this.panel1.Controls.Add(this.lbGioiTinh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 143);
            this.panel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.22178F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.77822F));
            this.tableLayoutPanel2.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupControl2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 278);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1055, 190);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnXoa);
            this.groupControl2.Controls.Add(this.btnThem);
            this.groupControl2.Controls.Add(this.btnSua);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(828, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(224, 184);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Thao tác";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnXoa.Appearance.Options.UseBackColor = true;
            this.btnXoa.Location = new System.Drawing.Point(37, 136);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(154, 35);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnThem.Appearance.Options.UseBackColor = true;
            this.btnThem.Location = new System.Drawing.Point(37, 48);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(154, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnSua.Appearance.Options.UseBackColor = true;
            this.btnSua.Location = new System.Drawing.Point(37, 92);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(154, 35);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Cập nhật";
            // 
            // btnAddVC
            // 
            this.btnAddVC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddVC.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVC.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.btnAddVC.Appearance.Options.UseFont = true;
            this.btnAddVC.Appearance.Options.UseForeColor = true;
            this.btnAddVC.Location = new System.Drawing.Point(111, 2);
            this.btnAddVC.Name = "btnAddVC";
            this.btnAddVC.Size = new System.Drawing.Size(77, 29);
            this.btnAddVC.TabIndex = 23;
            this.btnAddVC.Text = "+";
            this.btnAddVC.Click += new System.EventHandler(this.btnAddVC_Click);
            // 
            // tbMaVC
            // 
            this.tbMaVC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMaVC.Location = new System.Drawing.Point(111, 3);
            this.tbMaVC.Name = "tbMaVC";
            this.tbMaVC.Size = new System.Drawing.Size(138, 24);
            this.tbMaVC.TabIndex = 19;
            this.tbMaVC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMaVC_KeyDown);
            // 
            // tbLoaiTiem
            // 
            this.tbLoaiTiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbLoaiTiem.Location = new System.Drawing.Point(384, 3);
            this.tbLoaiTiem.Name = "tbLoaiTiem";
            this.tbLoaiTiem.Size = new System.Drawing.Size(202, 24);
            this.tbLoaiTiem.TabIndex = 21;
            this.tbLoaiTiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLoaiTiem_KeyDown);
            // 
            // lbLoaiTiem
            // 
            this.lbLoaiTiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbLoaiTiem.Location = new System.Drawing.Point(276, 6);
            this.lbLoaiTiem.Name = "lbLoaiTiem";
            this.lbLoaiTiem.Size = new System.Drawing.Size(102, 18);
            this.lbLoaiTiem.TabIndex = 20;
            this.lbLoaiTiem.Text = "Loại tiêm chủng";
            // 
            // lbMaVC
            // 
            this.lbMaVC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbMaVC.Location = new System.Drawing.Point(32, 6);
            this.lbMaVC.Name = "lbMaVC";
            this.lbMaVC.Size = new System.Drawing.Size(73, 18);
            this.lbMaVC.TabIndex = 22;
            this.lbMaVC.Text = "Mã vaccine";
            // 
            // btnSubVC
            // 
            this.btnSubVC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubVC.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubVC.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
            this.btnSubVC.Appearance.Options.UseFont = true;
            this.btnSubVC.Appearance.Options.UseForeColor = true;
            this.btnSubVC.Location = new System.Drawing.Point(34, 2);
            this.btnSubVC.Name = "btnSubVC";
            this.btnSubVC.Size = new System.Drawing.Size(77, 29);
            this.btnSubVC.TabIndex = 17;
            this.btnSubVC.Text = "-";
            this.btnSubVC.Click += new System.EventHandler(this.btnSubVC_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSubVC);
            this.panel3.Controls.Add(this.btnAddVC);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(821, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 33);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelControl1);
            this.panel4.Controls.Add(this.tbLieuLuong);
            this.panel4.Controls.Add(this.lbMaVC);
            this.panel4.Controls.Add(this.tbMaVC);
            this.panel4.Controls.Add(this.lbLoaiTiem);
            this.panel4.Controls.Add(this.tbLoaiTiem);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(812, 33);
            this.panel4.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Location = new System.Drawing.Point(611, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 18);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "Liều lượng";
            // 
            // tbLieuLuong
            // 
            this.tbLieuLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbLieuLuong.Location = new System.Drawing.Point(690, 3);
            this.tbLieuLuong.Name = "tbLieuLuong";
            this.tbLieuLuong.Size = new System.Drawing.Size(97, 24);
            this.tbLieuLuong.TabIndex = 23;
            this.tbLieuLuong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLieuLuong_KeyDown);
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl4.Controls.Add(this.gridVaccine);
            this.groupControl4.Controls.Add(this.tableLayoutPanel3);
            this.groupControl4.Location = new System.Drawing.Point(3, 3);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(1049, 274);
            this.groupControl4.TabIndex = 8;
            this.groupControl4.Text = "Danh sách vaccine sử dụng";
            // 
            // gridVaccine
            // 
            this.gridVaccine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVaccine.Location = new System.Drawing.Point(8, 77);
            this.gridVaccine.MainView = this.gridView2;
            this.gridVaccine.Name = "gridVaccine";
            this.gridVaccine.Size = new System.Drawing.Size(1033, 188);
            this.gridVaccine.TabIndex = 1;
            this.gridVaccine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridVaccine;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.78172F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.21827F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 37);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1039, 39);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // PhieuTiemGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.gridPhieuTiem);
            this.Name = "PhieuTiemGUI";
            this.Size = new System.Drawing.Size(1055, 765);
            this.Load += new System.EventHandler(this.PhieuTiemGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPhieuTiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbGioiTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayTiem.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayTiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaBS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbMaVC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLoaiTiem.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbLieuLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVaccine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridPhieuTiem;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl lbNgayTiem;
        private DevExpress.XtraEditors.TextEdit tbMaBS;
        private DevExpress.XtraEditors.LabelControl lbMaBS;
        private DevExpress.XtraEditors.LabelControl lbTenKH;
        private DevExpress.XtraEditors.DateEdit dtpNgayTiem;
        private DevExpress.XtraEditors.TextEdit tbTenKH;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl lbTienSu;
        private DevExpress.XtraEditors.LabelControl lbGioiTinh;
        private DevExpress.XtraEditors.DateEdit dtpNgaySinh;
        private DevExpress.XtraEditors.LabelControl lbNgaySinh;
        private DevExpress.XtraEditors.ComboBoxEdit cbGioiTinh;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btnAddVC;
        private DevExpress.XtraEditors.TextEdit tbMaVC;
        private DevExpress.XtraEditors.TextEdit tbLoaiTiem;
        private DevExpress.XtraEditors.LabelControl lbLoaiTiem;
        private DevExpress.XtraEditors.LabelControl lbMaVC;
        private DevExpress.XtraEditors.SimpleButton btnSubVC;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl gridVaccine;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tbLieuLuong;
    }
}
