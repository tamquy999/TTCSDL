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
            this.groupDoanhThu = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDoanhThu
            // 
            this.groupDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDoanhThu.Location = new System.Drawing.Point(3, 0);
            this.groupDoanhThu.Name = "groupDoanhThu";
            this.groupDoanhThu.Size = new System.Drawing.Size(1048, 417);
            this.groupDoanhThu.TabIndex = 1;
            this.groupDoanhThu.Text = "Thống Kê Doanh Thu";
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.ResumeLayout(false);

          }

          #endregion
          private DevExpress.XtraEditors.GroupControl groupDoanhThu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}
