namespace GUI
{
    partial class AD_QLVaccine
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gridVaccine = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.tbSearch = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVaccine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(4, 4);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1048, 758);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.Controls.Add(this.gridVaccine);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1046, 722);
            this.xtraTabPage1.Text = "Thông tin Vaccine";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupControl3);
            this.xtraTabPage2.Controls.Add(this.groupControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1046, 722);
            this.xtraTabPage2.Text = "Nhập Vaccine";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.groupControl5);
            this.xtraTabPage3.Controls.Add(this.groupControl4);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1046, 722);
            this.xtraTabPage3.Text = "Xuất Vaccine";
            // 
            // gridVaccine
            // 
            this.gridVaccine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridVaccine.Location = new System.Drawing.Point(3, 96);
            this.gridVaccine.MainView = this.gridView1;
            this.gridVaccine.Name = "gridVaccine";
            this.gridVaccine.Size = new System.Drawing.Size(1043, 623);
            this.gridVaccine.TabIndex = 6;
            this.gridVaccine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridVaccine;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Controls.Add(this.radioGroup1);
            this.groupControl1.Controls.Add(this.tbSearch);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1040, 87);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Tra cứu thông tin vaccine";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnSearch.Appearance.Options.UseBackColor = true;
            this.btnSearch.Location = new System.Drawing.Point(883, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(142, 28);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(8, 46);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tất cả"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Mã"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Tên"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Loại"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Nhà sx")});
            this.radioGroup1.Size = new System.Drawing.Size(476, 29);
            this.radioGroup1.TabIndex = 8;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearch.Location = new System.Drawing.Point(484, 46);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tbSearch.Properties.Appearance.Options.UseFont = true;
            this.tbSearch.Size = new System.Drawing.Size(389, 28);
            this.tbSearch.TabIndex = 6;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Location = new System.Drawing.Point(4, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1039, 293);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Thông tin vaccine nhập vào";
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Location = new System.Drawing.Point(4, 303);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1039, 416);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Vaccine hiện có";
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl4.Location = new System.Drawing.Point(3, 3);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(1040, 336);
            this.groupControl4.TabIndex = 0;
            this.groupControl4.Text = "Thông tin vaccine xuất đi";
            // 
            // groupControl5
            // 
            this.groupControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl5.Location = new System.Drawing.Point(3, 345);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(1040, 374);
            this.groupControl5.TabIndex = 1;
            this.groupControl5.Text = "Vaccine hiện có";
            // 
            // AD_QLVaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "AD_QLVaccine";
            this.Size = new System.Drawing.Size(1055, 765);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVaccine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl gridVaccine;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.TextEdit tbSearch;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GroupControl groupControl4;
    }
}
