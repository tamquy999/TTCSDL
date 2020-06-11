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
               
          }

        #region Event date Edit Changed:

        public void LoadDataToChart()
        {
            //Clear chart:
            chartControlDoanhThu.Series["BDDoanhThu"].Points.Clear();
            
            string NgayDau = dateEditDau.DateTime.ToString("yyyy-MM-dd");
            string NgayCuoi = dateEditCuoi.DateTime.ToString("yyyy-MM-dd");

            DataTable dt = new DataTable();
            dt = busThongKe.GetHoaDonInTime(NgayDau, NgayCuoi);

            foreach (DataRow row in dt.Rows)
            {
                string ThoiGian = row["Ngay"].ToString();
                int Tien = int.Parse(row["Tien"].ToString());

                chartControlDoanhThu.Series["BDDoanhThu"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(ThoiGian, Tien));
            }
            chartControlDoanhThu.Refresh();
        }

        #endregion
        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataToChart();
        }

        private void dateEdit2_EditValueChanged(object sender, EventArgs e)
        {
            LoadDataToChart();
        }
    }
}
