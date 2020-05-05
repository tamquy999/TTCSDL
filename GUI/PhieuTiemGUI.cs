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
using GUI.Properties;
using DTO;

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
        BUS_Vaccine busVC = new BUS_Vaccine();

        List<DTO_Vaccine> listVC = new List<DTO_Vaccine>();

        string selectedMaVC = "";

        public PhieuTiemGUI()
        {
            InitializeComponent();

            deNgayTiem.Text = DateTime.Now.ToString("dd/MM/yyyy");

            gridView1.OptionsBehavior.Editable = false;
            gridView1.RowClick += GridView1_RowClick;
            gridView2.RowClick += GridView2_RowClick;
        }

        private void GridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            selectedMaVC = gridView2.GetRowCellValue(e.RowHandle, "MAVACCINE").ToString();
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

        private void btnAddVC_Click(object sender, EventArgs e)
        {
            DTO_Vaccine vc = busVC.getVaccineFromID(tbMaVC.Text);
            if (vc != null)
            {
                listVC.Add(vc);
                gridVaccine.DataSource = listVC;
                gridView2.BestFitColumns();
            }
            else return;
        }

        private void btnSubVC_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listVC.Count; i++)
            {
                if (listVC[i].MAVACCINE == selectedMaVC)
                {
                    listVC.RemoveAt(i);
                    gridVaccine.DataSource = listVC;
                    gridView2.BestFitColumns();
                }
            }
        }
    }
}