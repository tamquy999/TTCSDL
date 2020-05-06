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

        List<DTO_ChiTietTiem> listCTT = new List<DTO_ChiTietTiem>();
        string MAPHIEUTIEM;
        public PhieuTiemGUI()
        {
            InitializeComponent();

            dtpNgayTiem.Text = DateTime.Now.ToString("dd/MM/yyyy");

            gridView1.OptionsBehavior.Editable = false;
            gridView1.RowClick += GridView1_RowClick;
            gridView2.RowClick += GridView2_RowClick;

            // tang ma phieu tiem cuoi cung trong sql table len 1 don vi
            MAPHIEUTIEM = busPhieuTiem.GetLastestMAPHIEUTIEM();
            int count = MAPHIEUTIEM.Length - 4;
            int ptIndex = Convert.ToInt32(MAPHIEUTIEM.Substring(2));
            MAPHIEUTIEM = "PT";
            for (int i = 0; i < count - ptIndex.ToString().Length; i++)
                MAPHIEUTIEM += "0";
            MAPHIEUTIEM += (ptIndex + 1).ToString();
        }

        private void tbMaVC_KeyDown(object sender, KeyEventArgs e)
        {
            btnAddVC.PerformClick();
        }

        private void tbLoaiTiem_KeyDown(object sender, KeyEventArgs e)
        {
            btnAddVC.PerformClick();
        }

        private void tbLieuLuong_KeyDown(object sender, KeyEventArgs e)
        {
            btnAddVC.PerformClick();
        }

        private void GridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            tbMaVC.Text = gridView2.GetRowCellValue(e.RowHandle, "MAVACCINE").ToString();
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
            if (tbMaVC.Text != "" && tbLoaiTiem.Text != "" && tbLieuLuong.Text != "")
            {
                if (busVC.IsVCInStock(tbMaVC.Text))
                {
                    DTO_ChiTietTiem ctt = new DTO_ChiTietTiem("", tbMaVC.Text, busVC.getVCPrice(tbMaVC.Text), tbLoaiTiem.Text, dtpNgayTiem.Text, Convert.ToDouble(tbLieuLuong.Text));
                    listCTT.Add(ctt);
                    //gridVaccine.DataSource = listCTT;


                    DataTable dt = new DataTable();
                    dt.Columns.Add("MAVACCINE");
                    dt.Columns.Add("TENVACCINE");
                    dt.Columns.Add("GIABAN");
                    dt.Columns.Add("LOAITIEMCHUNG");
                    dt.Columns.Add("LIEULUONG");

                    for (int i = 0; i < listCTT.Count; i++)
                    {
                        DataRow dr = dt.NewRow();
                        dr["MAVACCINE"] = listCTT[i].MAVACCINE;
                        //dr["TENVACCINE"] = busVC.getVCName(listCTT[i].MAVACCINE);
                        dr["TENVACCINE"] = null;
                        dr["GIABAN"] = listCTT[i].GIABAN;
                        dr["LOAITIEMCHUNG"] = listCTT[i].LOAITIEMCHUNG;
                        dr["LIEULUONG"] = listCTT[i].LIEULUONG;
                        dt.Rows.Add(dr);
                    }

                    gridVaccine.DataSource = dt;
                    gridView2.BestFitColumns();
                }
            }
            else return;
        }

        private void btnSubVC_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listCTT.Count; i++)
            {
                if (listCTT[i].MAVACCINE == tbMaVC.Text)
                {
                    listCTT.RemoveAt(i);
                }
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("MAVACCINE");
            dt.Columns.Add("TENVACCINE");
            dt.Columns.Add("GIABAN");
            dt.Columns.Add("LOAITIEMCHUNG");
            dt.Columns.Add("LIEULUONG");

            for (int i = 0; i < listCTT.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["MAVACCINE"] = listCTT[i].MAVACCINE;
                dr["TENVACCINE"] = busVC.getVCName(listCTT[i].MAVACCINE);
                dr["GIABAN"] = listCTT[i].GIABAN;
                dr["LOAITIEMCHUNG"] = listCTT[i].LOAITIEMCHUNG;
                dr["LIEULUONG"] = listCTT[i].LIEULUONG;
                dt.Rows.Add(dr);
            }

            gridVaccine.DataSource = dt;
            gridView2.BestFitColumns();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }
    }
}