namespace GUI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.progressPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem = new DevExpress.XtraBars.BarStaticItem();
            this.acThuNgan = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.aceHome = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acePhieuTiem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceThanhToan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acBacSi = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.aceHomeBS = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceVaccineBS = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceLichSuBS = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceTiemBS = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acAdmin = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.aceHomeAD = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceVaccineAD = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceAccountAD = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceThongKeAD = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acKhachHang = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.aceHomeKH = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceVaccineKH = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceLichSuKH = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement10 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement11 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceVaccine = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceLichSu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acThuNgan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acBacSi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.container.Controls.Add(this.progressPanel);
            this.container.Location = new System.Drawing.Point(207, 37);
            this.container.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1093, 863);
            this.container.TabIndex = 0;
            // 
            // progressPanel
            // 
            this.progressPanel.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.progressPanel.Appearance.Options.UseBackColor = true;
            this.progressPanel.Caption = "Vui lòng đợi";
            this.progressPanel.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.progressPanel.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressPanel.Description = "Đang tải...";
            this.progressPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressPanel.Location = new System.Drawing.Point(0, 0);
            this.progressPanel.Margin = new System.Windows.Forms.Padding(4);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(1093, 863);
            this.progressPanel.TabIndex = 0;
            this.progressPanel.Text = "progressPanel1";
            this.progressPanel.Visible = false;
            //this.progressPanel.Click += new System.EventHandler(this.progressPanel_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnDangXuat,
            this.barStaticItem1,
            this.barStaticItem});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1300, 37);
            this.fluentDesignFormControl1.TabIndex = 4;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.btnDangXuat);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.barStaticItem);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 0;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem1.Caption = "barStaticItem1";
            this.barStaticItem1.Id = 0;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barStaticItem
            // 
            this.barStaticItem.Caption = "Xin chào Hưng";
            this.barStaticItem.Id = 3;
            this.barStaticItem.Name = "barStaticItem";
            // 
            // acThuNgan
            // 
            this.acThuNgan.AllowItemSelection = true;
            this.acThuNgan.Appearance.AccordionControl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acThuNgan.Appearance.AccordionControl.Options.UseFont = true;
            this.acThuNgan.Appearance.Item.Disabled.Options.UseFont = true;
            this.acThuNgan.Appearance.Item.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acThuNgan.Appearance.Item.Hovered.Options.UseFont = true;
            this.acThuNgan.Appearance.Item.Normal.Options.UseFont = true;
            this.acThuNgan.Dock = System.Windows.Forms.DockStyle.Left;
            this.acThuNgan.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceHome,
            this.acePhieuTiem,
            this.aceThanhToan,
            this.aceVaccine,
            this.aceLichSu});
            this.acThuNgan.Location = new System.Drawing.Point(0, 37);
            this.acThuNgan.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.acThuNgan.Name = "acThuNgan";
            this.acThuNgan.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.acThuNgan.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Auto;
            this.acThuNgan.Size = new System.Drawing.Size(207, 863);
            this.acThuNgan.TabIndex = 1;
            this.acThuNgan.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            this.acThuNgan.ElementClick += new DevExpress.XtraBars.Navigation.ElementClickEventHandler(this.accordionControl1_ElementClick);
            // 
            // aceHome
            // 
            this.aceHome.ImageOptions.Image = global::GUI.Properties.Resources.home;
            this.aceHome.Name = "aceHome";
            this.aceHome.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceHome.Text = " Trang chủ";
            this.aceHome.Click += new System.EventHandler(this.aceHome_Click);
            // 
            // acePhieuTiem
            // 
            this.acePhieuTiem.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acePhieuTiem.Appearance.Normal.Options.UseFont = true;
            this.acePhieuTiem.ImageOptions.Image = global::GUI.Properties.Resources.add;
            this.acePhieuTiem.Name = "acePhieuTiem";
            this.acePhieuTiem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acePhieuTiem.Text = " Tạo phiếu tiêm";
            this.acePhieuTiem.Click += new System.EventHandler(this.acePhieuTiem_Click);
            // 
            // aceThanhToan
            // 
            this.aceThanhToan.Height = 10;
            this.aceThanhToan.ImageOptions.Image = global::GUI.Properties.Resources.pay;
            this.aceThanhToan.Name = "aceThanhToan";
            this.aceThanhToan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceThanhToan.Text = " Thanh toán";
            this.aceThanhToan.Click += new System.EventHandler(this.aceThanhToan_Click);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // acBacSi
            // 
            this.acBacSi.AllowItemSelection = true;
            this.acBacSi.Appearance.AccordionControl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acBacSi.Appearance.AccordionControl.Options.UseFont = true;
            this.acBacSi.Appearance.Item.Disabled.Options.UseFont = true;
            this.acBacSi.Appearance.Item.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acBacSi.Appearance.Item.Hovered.Options.UseFont = true;
            this.acBacSi.Appearance.Item.Normal.Options.UseFont = true;
            this.acBacSi.Dock = System.Windows.Forms.DockStyle.Left;
            this.acBacSi.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceHomeBS,
            this.aceVaccineBS,
            this.aceLichSuBS,
            this.aceTiemBS});
            this.acBacSi.Location = new System.Drawing.Point(207, 37);
            this.acBacSi.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.acBacSi.Name = "acBacSi";
            this.acBacSi.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.acBacSi.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Auto;
            this.acBacSi.Size = new System.Drawing.Size(207, 863);
            this.acBacSi.TabIndex = 5;
            this.acBacSi.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // aceHomeBS
            // 
            this.aceHomeBS.ImageOptions.Image = global::GUI.Properties.Resources.home;
            this.aceHomeBS.Name = "aceHomeBS";
            this.aceHomeBS.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceHomeBS.Text = " Trang chủ";
            this.aceHomeBS.Click += new System.EventHandler(this.aceHomeBS_Click);
            // 
            // aceVaccineBS
            // 
            this.aceVaccineBS.Height = 10;
            this.aceVaccineBS.ImageOptions.Image = global::GUI.Properties.Resources.vial;
            this.aceVaccineBS.Name = "aceVaccineBS";
            this.aceVaccineBS.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceVaccineBS.Text = " Vaccine";
            this.aceVaccineBS.Click += new System.EventHandler(this.aceVaccineBS_Click);
            // 
            // aceLichSuBS
            // 
            this.aceLichSuBS.Height = 10;
            this.aceLichSuBS.ImageOptions.Image = global::GUI.Properties.Resources.clock;
            this.aceLichSuBS.Name = "aceLichSuBS";
            this.aceLichSuBS.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceLichSuBS.Text = " Lịch sử tiêm KH";
            this.aceLichSuBS.Click += new System.EventHandler(this.aceLichSuBS_Click);
            // 
            // aceTiemBS
            // 
            this.aceTiemBS.ImageOptions.Image = global::GUI.Properties.Resources.vaccine;
            this.aceTiemBS.Name = "aceTiemBS";
            this.aceTiemBS.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceTiemBS.Text = " Tiêm";
            this.aceTiemBS.Click += new System.EventHandler(this.aceTiemBS_Click);
            // 
            // acAdmin
            // 
            this.acAdmin.AllowItemSelection = true;
            this.acAdmin.Appearance.AccordionControl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acAdmin.Appearance.AccordionControl.Options.UseFont = true;
            this.acAdmin.Appearance.Item.Disabled.Options.UseFont = true;
            this.acAdmin.Appearance.Item.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acAdmin.Appearance.Item.Hovered.Options.UseFont = true;
            this.acAdmin.Appearance.Item.Normal.Options.UseFont = true;
            this.acAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.acAdmin.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceHomeAD,
            this.aceVaccineAD,
            this.aceAccountAD,
            this.aceThongKeAD});
            this.acAdmin.Location = new System.Drawing.Point(414, 37);
            this.acAdmin.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.acAdmin.Name = "acAdmin";
            this.acAdmin.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.acAdmin.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Auto;
            this.acAdmin.Size = new System.Drawing.Size(207, 863);
            this.acAdmin.TabIndex = 6;
            this.acAdmin.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // aceHomeAD
            // 
            this.aceHomeAD.ImageOptions.Image = global::GUI.Properties.Resources.home;
            this.aceHomeAD.Name = "aceHomeAD";
            this.aceHomeAD.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceHomeAD.Text = " Trang chủ";
            this.aceHomeAD.Click += new System.EventHandler(this.aceHomeAD_Click);
            // 
            // aceVaccineAD
            // 
            this.aceVaccineAD.Height = 10;
            this.aceVaccineAD.ImageOptions.Image = global::GUI.Properties.Resources.vial;
            this.aceVaccineAD.Name = "aceVaccineAD";
            this.aceVaccineAD.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceVaccineAD.Text = " Quản lý vaccine";
            this.aceVaccineAD.Click += new System.EventHandler(this.aceVaccineAD_Click);
            // 
            // aceAccountAD
            // 
            this.aceAccountAD.ImageOptions.Image = global::GUI.Properties.Resources.user;
            this.aceAccountAD.Name = "aceAccountAD";
            this.aceAccountAD.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceAccountAD.Text = " Quản lý tài khoản";
            this.aceAccountAD.Click += new System.EventHandler(this.aceAccountAD_Click);
            // 
            // aceThongKeAD
            // 
            this.aceThongKeAD.ImageOptions.Image = global::GUI.Properties.Resources.statistics;
            this.aceThongKeAD.Name = "aceThongKeAD";
            this.aceThongKeAD.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceThongKeAD.Text = " Thống kê";
            this.aceThongKeAD.Click += new System.EventHandler(this.aceThongKeAD_Click);
            // 
            // acKhachHang
            // 
            this.acKhachHang.AllowItemSelection = true;
            this.acKhachHang.Appearance.AccordionControl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acKhachHang.Appearance.AccordionControl.Options.UseFont = true;
            this.acKhachHang.Appearance.Item.Disabled.Options.UseFont = true;
            this.acKhachHang.Appearance.Item.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acKhachHang.Appearance.Item.Hovered.Options.UseFont = true;
            this.acKhachHang.Appearance.Item.Normal.Options.UseFont = true;
            this.acKhachHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.acKhachHang.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceHomeKH,
            this.aceVaccineKH,
            this.aceLichSuKH});
            this.acKhachHang.Location = new System.Drawing.Point(621, 37);
            this.acKhachHang.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.acKhachHang.Name = "acKhachHang";
            this.acKhachHang.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.acKhachHang.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Auto;
            this.acKhachHang.Size = new System.Drawing.Size(207, 863);
            this.acKhachHang.TabIndex = 7;
            this.acKhachHang.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // aceHomeKH
            // 
            this.aceHomeKH.ImageOptions.Image = global::GUI.Properties.Resources.home;
            this.aceHomeKH.Name = "aceHomeKH";
            this.aceHomeKH.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceHomeKH.Text = " Trang chủ";
            this.aceHomeKH.Click += new System.EventHandler(this.aceHomeKH_Click);
            // 
            // aceVaccineKH
            // 
            this.aceVaccineKH.ImageOptions.Image = global::GUI.Properties.Resources.vial;
            this.aceVaccineKH.Name = "aceVaccineKH";
            this.aceVaccineKH.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceVaccineKH.Text = " Vaccine";
            this.aceVaccineKH.Click += new System.EventHandler(this.aceVaccineKH_Click);
            // 
            // aceLichSuKH
            // 
            this.aceLichSuKH.Height = 10;
            this.aceLichSuKH.ImageOptions.Image = global::GUI.Properties.Resources.clock;
            this.aceLichSuKH.Name = "aceLichSuKH";
            this.aceLichSuKH.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceLichSuKH.Text = " Lịch sử tiêm";
            this.aceLichSuKH.Click += new System.EventHandler(this.aceLichSuKH_Click);
            // 
            // accordionControlElement10
            // 
            this.accordionControlElement10.Height = 10;
            this.accordionControlElement10.ImageOptions.Image = global::GUI.Properties.Resources.vaccine;
            this.accordionControlElement10.Name = "accordionControlElement10";
            this.accordionControlElement10.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement10.Text = " Vaccine";
            // 
            // accordionControlElement11
            // 
            this.accordionControlElement11.Height = 10;
            this.accordionControlElement11.ImageOptions.Image = global::GUI.Properties.Resources.vaccine;
            this.accordionControlElement11.Name = "accordionControlElement11";
            this.accordionControlElement11.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement11.Text = " Vaccine";
            // 
            // aceVaccine
            // 
            this.aceVaccine.ImageOptions.Image = global::GUI.Properties.Resources.vial;
            this.aceVaccine.Name = "aceVaccine";
            this.aceVaccine.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceVaccine.Text = " Vaccine";
            this.aceVaccine.Click += new System.EventHandler(this.aceVaccine_Click);
            // 
            // aceLichSu
            // 
            this.aceLichSu.ImageOptions.Image = global::GUI.Properties.Resources.clock;
            this.aceLichSu.Name = "aceLichSu";
            this.aceLichSu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceLichSu.Text = " Lịch sử tiêm KH";
            this.aceLichSu.Click += new System.EventHandler(this.aceLichSu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 900);
            this.ControlContainer = this.container;
            this.Controls.Add(this.acKhachHang);
            this.Controls.Add(this.acAdmin);
            this.Controls.Add(this.acBacSi);
            this.Controls.Add(this.container);
            this.Controls.Add(this.acThuNgan);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Form1.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(1214, 755);
            this.Name = "Form1";
            this.NavigationControl = this.acKhachHang;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acThuNgan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acBacSi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer container;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControl acThuNgan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceThanhToan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acePhieuTiem;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceHome;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel;
        private DevExpress.XtraBars.Navigation.AccordionControl acBacSi;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceHomeBS;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceVaccineBS;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceLichSuBS;
        private DevExpress.XtraBars.Navigation.AccordionControl acKhachHang;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceHomeKH;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceLichSuKH;
        private DevExpress.XtraBars.Navigation.AccordionControl acAdmin;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceHomeAD;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceVaccineAD;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceThongKeAD;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceTiemBS;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceVaccineKH;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceAccountAD;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement10;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement11;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceVaccine;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceLichSu;
    }
}

