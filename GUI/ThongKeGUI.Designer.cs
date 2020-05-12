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
               this.groupThongKe = new DevExpress.XtraEditors.GroupControl();
               ((System.ComponentModel.ISupportInitialize)(this.groupThongKe)).BeginInit();
               this.SuspendLayout();
               // 
               // groupThongKe
               // 
               this.groupThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.groupThongKe.Location = new System.Drawing.Point(0, 0);
               this.groupThongKe.Name = "groupThongKe";
               this.groupThongKe.Size = new System.Drawing.Size(1049, 765);
               this.groupThongKe.TabIndex = 1;
               this.groupThongKe.Text = "Thống Kê";
               // 
               // ThongKeGUI
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.groupThongKe);
               this.Name = "ThongKeGUI";
               this.Size = new System.Drawing.Size(1049, 765);
               ((System.ComponentModel.ISupportInitialize)(this.groupThongKe)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion
          private DevExpress.XtraEditors.GroupControl groupThongKe;
     }
}
