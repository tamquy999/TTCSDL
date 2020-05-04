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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.acePhieuTiem = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceLichSu = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceThanhToan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceVaccine = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(231, 37);
            this.container.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1069, 863);
            this.container.TabIndex = 0;
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnDangXuat,
            this.barStaticItem1,
            this.barStaticItem2});
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1300, 37);
            this.fluentDesignFormControl1.TabIndex = 4;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.btnDangXuat);
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.barStaticItem2);
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
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Xin chào Hưng";
            this.barStaticItem2.Id = 3;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // accordionControl1
            // 
            this.accordionControl1.Appearance.AccordionControl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Disabled.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceVaccine,
            this.aceLichSu,
            this.acePhieuTiem,
            this.aceThanhToan});
            this.accordionControl1.Location = new System.Drawing.Point(0, 37);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Auto;
            this.accordionControl1.Size = new System.Drawing.Size(231, 863);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // acePhieuTiem
            // 
            this.acePhieuTiem.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acePhieuTiem.Appearance.Normal.Options.UseFont = true;
            this.acePhieuTiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acePhieuTiem.ImageOptions.Image")));
            this.acePhieuTiem.Name = "acePhieuTiem";
            this.acePhieuTiem.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acePhieuTiem.Text = " Tạo phiếu tiêm";
            this.acePhieuTiem.Click += new System.EventHandler(this.acePhieuTiem_Click);
            // 
            // aceLichSu
            // 
            this.aceLichSu.Height = 10;
            this.aceLichSu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceLichSu.ImageOptions.Image")));
            this.aceLichSu.Name = "aceLichSu";
            this.aceLichSu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceLichSu.Text = " Lịch sử tiêm";
            this.aceLichSu.Click += new System.EventHandler(this.aceLichSu_Click);
            // 
            // aceThanhToan
            // 
            this.aceThanhToan.Height = 10;
            this.aceThanhToan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceThanhToan.ImageOptions.Image")));
            this.aceThanhToan.Name = "aceThanhToan";
            this.aceThanhToan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceThanhToan.Text = " Thanh toán";
            this.aceThanhToan.Click += new System.EventHandler(this.aceThanhToan_Click);
            // 
            // aceVaccine
            // 
            this.aceVaccine.Height = 10;
            this.aceVaccine.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("aceVaccine.ImageOptions.Image")));
            this.aceVaccine.Name = "aceVaccine";
            this.aceVaccine.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceVaccine.Text = " Quản lý vaccine";
            this.aceVaccine.Click += new System.EventHandler(this.aceVaccine_Click);
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(104, 64);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 29);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(103, 92);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.OffText = "Off";
            this.toggleSwitch1.Properties.OnText = "On";
            this.toggleSwitch1.Size = new System.Drawing.Size(95, 25);
            this.toggleSwitch1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 900);
            this.ControlContainer = this.container;
            this.Controls.Add(this.container);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Form1.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(1214, 755);
            this.Name = "Form1";
            this.NavigationControl = this.accordionControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer container;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceThanhToan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceLichSu;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceVaccine;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acePhieuTiem;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
    }
}

