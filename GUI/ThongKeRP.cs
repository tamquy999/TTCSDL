using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace GUI
{
    public partial class ThongKeRP : DevExpress.XtraReports.UI.XtraReport
    {
        
        public ThongKeRP()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor Create RP with input data.
        /// </summary>
        /// <param name="NgayDau">Date start report</param>
        /// <param name="NgayCuoi">Date end report</param>
        /// <param name="inDT">input data in DataTable</param>
        public ThongKeRP(string NgayDau, string NgayCuoi, DataTable inDT, string DoanhThu)
        {
            InitializeComponent();

            xrLabel_ThoiGianTK.Text = "Thời gian: " + NgayDau.ToString() + " đến " + NgayCuoi.ToString();

            xrLabel_DoanhThu.Text ="Tổng Doanh Thu: "+ DoanhThu;
        }
    }
}
