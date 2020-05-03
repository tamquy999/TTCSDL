using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;

namespace GUI
{
    public partial class PhieuTiemGUI : DevExpress.XtraEditors.XtraUserControl
    {
        public static PhieuTiemGUI _instance;
        public static PhieuTiemGUI Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PhieuTiemGUI();
                }
                return _instance;
            }
        }

        BUS_PhieuTiem busPhieuTiem = new BUS_PhieuTiem();

        public PhieuTiemGUI()
        {
            InitializeComponent();

            deNgayTiem.Text = DateTime.Now.ToString("dd/MM/yyyy");

            gridView1.OptionsBehavior.Editable = false;
            gridView1.RowClick += GridView1_RowClick;
        }

        private void GridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //tbLoaiTiem.Text = gridView1.GetRowCellValue(e.RowHandle, "LOAITIEMCHUNG").ToString();
            ////deNgayTiem.Text = gridView1.GetRowCellValue(e.RowHandle, "NGAYTIEM").ToString();
            //tbGhiChu.Text = gridView1.GetRowCellValue(e.RowHandle, "GHICHU").ToString();
            //tbMaKH.Text = gridView1.GetRowCellValue(e.RowHandle, "MAKH").ToString();
            //tbMaBS.Text = gridView1.GetRowCellValue(e.RowHandle, "MABS").ToString();
            //tbMaVC.Text = gridView1.GetRowCellValue(e.RowHandle, "MAVACCINE").ToString();
        }

        private void PhieuTiemGUI_Load(object sender, EventArgs e)
        {
            gridPhieuTiem.DataSource = busPhieuTiem.getAllPhieuTiem();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc chẵn muốn thêm bản ghi này không?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.No)
            {
            }
        }
    }
}