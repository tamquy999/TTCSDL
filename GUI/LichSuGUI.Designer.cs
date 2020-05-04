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
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridLichSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
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
            this.groupControl1.Location = new System.Drawing.Point(3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(298, 198);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Tra cứu lịch sử";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(104, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 18);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Mã khách hàng";
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Location = new System.Drawing.Point(104, 134);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(100, 29);
            this.btnTraCuu.TabIndex = 1;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // tbMaKH
            // 
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
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.memoEdit1);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.textEdit5);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.textEdit4);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.textEdit3);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.textEdit2);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Location = new System.Drawing.Point(307, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(739, 198);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Chi tiết tiêm";
            // 
            // memoEdit1
            // 
            this.memoEdit1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.memoEdit1.Location = new System.Drawing.Point(452, 98);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.memoEdit1.Size = new System.Drawing.Size(261, 73);
            this.memoEdit1.TabIndex = 12;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl6.Location = new System.Drawing.Point(379, 100);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 18);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Chỉ định";
            // 
            // textEdit5
            // 
            this.textEdit5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textEdit5.Location = new System.Drawing.Point(452, 49);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit5.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit5.Size = new System.Drawing.Size(261, 24);
            this.textEdit5.TabIndex = 8;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl5.Location = new System.Drawing.Point(379, 52);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Đơn giá";
            // 
            // textEdit4
            // 
            this.textEdit4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textEdit4.Location = new System.Drawing.Point(106, 147);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit4.Size = new System.Drawing.Size(243, 24);
            this.textEdit4.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl4.Location = new System.Drawing.Point(22, 150);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 18);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Liều lượng";
            // 
            // textEdit3
            // 
            this.textEdit3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textEdit3.Location = new System.Drawing.Point(106, 97);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit3.Size = new System.Drawing.Size(243, 24);
            this.textEdit3.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Location = new System.Drawing.Point(22, 100);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Tên vaccine";
            // 
            // textEdit2
            // 
            this.textEdit2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textEdit2.Location = new System.Drawing.Point(106, 49);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit2.Size = new System.Drawing.Size(243, 24);
            this.textEdit2.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Location = new System.Drawing.Point(22, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ngày tiêm";
            // 
            // LichSuGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
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
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
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
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}
