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
        public int SoLuongVaccineChartMostVC = 7;
        #endregion

        public ThongKeGUI()
        {
            InitializeComponent();
            LoadDataToChartLoaiVC();

            //default date for Chart Doanh Thu:
            dateEditDau.EditValue = new DateTime(2018, 1, 1);
            dateEditCuoi.EditValue = new DateTime(2018, 2, 1);
            LoadDataToChartDoanhThu();

            //Default date for Chart MostVC:
            dateEditVCCuoi.EditValue = new DateTime(2018, 2, 1);
            dateEditVCDau.EditValue = new DateTime(2018, 1, 1);
            cbBoxEditSoMostVC.SelectedIndex = 3;
            LoadDataToChartMostVC();
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
            //chartControlLoaiVC.Series["BDLoaiVC"].LegendText = "#AXISLABEL";
        }

        #endregion

        #region Chart Most VC

        public void LoadDataToChartMostVC()
        {
            //Re check số lượng sẽ hiện ra:
            if (cbBoxEditSoMostVC.SelectedItem != null)
            {
                SoLuongVaccineChartMostVC = int.Parse(cbBoxEditSoMostVC.SelectedItem.ToString());
            }
            
            chartControlMostVC.Series["BDCmostVC"].Points.Clear();

            string NgayDau = dateEditVCDau.DateTime.ToString("yyyy-MM-dd");
            string NgayCuoi = dateEditVCCuoi.DateTime.ToString("yyyy-MM-dd");

            DataTable dt = busThongKe.GetMostUsedVaccineIn(NgayDau, NgayCuoi);

            //Check số row data có đủ để hiện không
            if (SoLuongVaccineChartMostVC > dt.Rows.Count)
            {
                SoLuongVaccineChartMostVC = dt.Rows.Count;
            }
            for (int i = 0; i < SoLuongVaccineChartMostVC; i++)
            {
                DataRow row = dt.Rows[i];
                string MaVC = row["MaVC"].ToString().Trim();
                int SoLuong = int.Parse(row["SoLuong"].ToString());
                chartControlMostVC.Series["BDCmostVC"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(MaVC, SoLuong));

                chartControlMostVC.Refresh();
            }


        }

        #endregion


        //Generate Code for Event Handle:
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

        private void simpleButtonGiam_Click(object sender, EventArgs e)
        {
            if (dateEditCuoi.DateTime.ToString("yyyy-MM-dd") != "0001-01-01"
                && dateEditDau.DateTime.ToString("yyyy-MM-dd") != "0001-01-01")
            {
                dateEditDau.DateTime = dateEditDau.DateTime.AddDays(-1);
                dateEditCuoi.DateTime = dateEditCuoi.DateTime.AddDays(-1);
                LoadDataToChartDoanhThu();
            }
        }

        private void simpleButtonTang_Click(object sender, EventArgs e)
        {
            if (dateEditCuoi.DateTime.ToString("yyyy-MM-dd") != "0001-01-01"
                && dateEditDau.DateTime.ToString("yyyy-MM-dd") != "0001-01-01")
            {
                dateEditDau.DateTime = dateEditDau.DateTime.AddDays(1);
                dateEditCuoi.DateTime = dateEditCuoi.DateTime.AddDays(1);
                LoadDataToChartDoanhThu();
            }
        }

        private void dateEditVCDau_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataToChartMostVC();
        }

        private void dateEditVCCuoi_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataToChartMostVC();
        }

        private void cbBoxEditSoMostVC_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataToChartMostVC();
        }
    }
}
