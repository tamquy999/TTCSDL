using System;
using BUS;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ThongKeGUI : DevExpress.XtraEditors.XtraUserControl
    {
        public static ThongKeGUI _instance;

        public static ThongKeGUI Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ThongKeGUI();
                }
                return _instance;
            }
        }

        #region Define Variable
        BUS_ThongKe busThongKe = new BUS_ThongKe();
        #endregion

        public ThongKeGUI()
        {
            InitializeComponent();
            LoadDataToChartLoaiVC();
        }

        #region Chart Doanh Thu

        public void LoadDataToChartDoanhThu()
        {
            //Clear chart:
            chartControlDoanhThu.Series["BDDoanhThu"].Points.Clear();

            string NgayDau = dateEditDau.DateTime.ToString("yyyy-MM-dd");
            string NgayCuoi = dateEditCuoi.DateTime.ToString("yyyy-MM-dd");

            DataTable dt = new DataTable();
            dt = busThongKe.GetHoaDonInTime(NgayDau, NgayCuoi);
            int TongDoanhThu = 0;
            foreach (DataRow row in dt.Rows)
            {
                string ThoiGian = row["Ngay"].ToString();
                int Tien = int.Parse(row["Tien"].ToString());
                TongDoanhThu += Tien;
                chartControlDoanhThu.Series["BDDoanhThu"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(ThoiGian, Tien));
            }
            chartControlDoanhThu.Refresh();
            tedTongDoanhThu.Text = TongDoanhThu.ToString();
        }

        #endregion

        #region Chart LoaiVC

        public void LoadDataToChartLoaiVC()
        {
            DataTable dt = busThongKe.GetCountLoaiVC();

            chartControlLoaiVC.Series["BDLoaiVC"].Points.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string TenVC = row["Loai"].ToString();
                TenVC = TenVC.Trim();
                int SoLuong = int.Parse(row["SoLuong"].ToString());
                chartControlLoaiVC.Series["BDLoaiVC"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(TenVC, SoLuong));
            }
            chartControlLoaiVC.Refresh();
            chartControlLoaiVC.Series["BDLoaiVC"].LegendText = "#AXISLABEL";
        }

        #endregion

        #region Chart Most VC

        public void LoadDataToChartMostVC()
        {
            
        }

        #endregion

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataToChartDoanhThu();
        }

        private void dateEdit2_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataToChartDoanhThu();
        }

        private void tedTongDoanhThu_DoubleClick(object sender, EventArgs e)
        {
            if (tedTongDoanhThu.Text != "")
            {
                Clipboard.SetText(tedTongDoanhThu.Text);
            }
        }
    }
}
