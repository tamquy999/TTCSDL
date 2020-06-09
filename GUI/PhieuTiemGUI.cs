﻿using System;
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
using DevExpress.XtraGrid.Localization;

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
        BUS_KhachHang busKH = new BUS_KhachHang();
        BUS_ChiTietTiem busCTT = new BUS_ChiTietTiem();

        List<DTO_ChiTietTiem> listCTT = new List<DTO_ChiTietTiem>();


        public PhieuTiemGUI()
        {
            InitializeComponent();

            dtpNgayTiem.Text = DateTime.Now.ToString("dd/MM/yyyy");

            gridView2.RowClick += GridView2_RowClick;
            gridView1.RowClick += GridView1_RowClick;

            GridLocalizer.Active = new MyGridLocalizer();

            InitAutoCompeteTextBox();
        }

        private void InitAutoCompeteTextBox()
        {
            //tbMaVC autocomplete test
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            DataTable dt = busVC.getAllVaccine();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                collection.Add(dt.Rows[i][0].ToString().Trim());
            }

            tbMaVC.MaskBox.AutoCompleteCustomSource = collection;
            tbMaVC.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbMaVC.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void tbMaVC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddVC.PerformClick();
            }
        }

        private void tbLoaiTiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddVC.PerformClick();
            }
        }

        private void tbLieuLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddVC.PerformClick();
            }
        }

        private void GridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            tbMaVC.Text = gridView2.GetRowCellValue(e.RowHandle, "MAVACCINE").ToString().Trim();
        }

        private void GridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            tbMaKH.Text = gridView1.GetRowCellValue(e.RowHandle, "MAKH").ToString().Trim();
            tbTenKH.Text = gridView1.GetRowCellValue(e.RowHandle, "TENKH").ToString().Trim();
            dtpNgaySinh.Text = gridView1.GetRowCellValue(e.RowHandle, "NGAYSINH").ToString().Substring(0, 10);
            cbGioiTinh.Text = gridView1.GetRowCellValue(e.RowHandle, "GIOITINH").ToString();
            tbTienSu.Text = gridView1.GetRowCellValue(e.RowHandle, "TIEUSUBENHAN").ToString().Trim();
        }

        private void PhieuTiemGUI_Load(object sender, EventArgs e)
        {
            gridKH.DataSource = busKH.getAllKH();
            gridView1.Columns["MAKH"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
        }

        private void btnAddVC_Click(object sender, EventArgs e)
        {
            if (tbMaVC.Text != "" && tbLoaiTiem.Text != "" && tbLieuLuong.Text != "")
            {
                if (busVC.IsVCInStock(tbMaVC.Text))
                {
                    DTO_ChiTietTiem ctt = new DTO_ChiTietTiem(busPhieuTiem.NextMAPHIEUTIEM(), tbMaVC.Text, busVC.getVCPrice(tbMaVC.Text), tbLoaiTiem.Text, dtpNgayTiem.Text, Convert.ToDouble(tbLieuLuong.Text));

                    for (int i = 0; i < listCTT.Count; i++)
                    {
                        if (ctt.MAVACCINE == listCTT[i].MAVACCINE)
                        {
                            listCTT[i].LIEULUONG += ctt.LIEULUONG; 
                            DataTable dtb = new DataTable();
                            dtb.Columns.Add("MAVACCINE");
                            dtb.Columns.Add("TENVACCINE");
                            dtb.Columns.Add("GIABAN");
                            dtb.Columns.Add("LOAITIEMCHUNG");
                            dtb.Columns.Add("LIEULUONG");

                            for (int j = 0; j < listCTT.Count; j++)
                            {
                                DataRow dr = dtb.NewRow();
                                dr["MAVACCINE"] = listCTT[j].MAVACCINE;
                                dr["TENVACCINE"] = busVC.getVCName(listCTT[j].MAVACCINE);
                                dr["GIABAN"] = listCTT[j].GIABAN;
                                dr["LOAITIEMCHUNG"] = listCTT[j].LOAITIEMCHUNG;
                                dr["LIEULUONG"] = listCTT[j].LIEULUONG;
                                dtb.Rows.Add(dr);
                            }

                            gridVaccine.DataSource = dtb;
                            gridView2.BestFitColumns();

                            return;
                        }
                    }
                    
                    listCTT.Add(ctt);

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
                    break;
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
            if (tbTenKH.Text != "" && dtpNgaySinh.Text != "" && tbTienSu.Text != "" && tbMaBS.Text != "" && cbGioiTinh.Text != "")
            {
                if (tbMaKH.Text == "")
                {
                    tbMaKH.Text = busKH.NextMaKH();
                    busKH.InsertKHWithoutNGH(new DTO_KhachHang(tbMaKH.Text, tbTenKH.Text, dtpNgaySinh.DateTime.ToString("yyyy-MM-dd"), cbGioiTinh.Text, tbTienSu.Text, null));
                }
                else if (!busKH.IsMaKHExists(tbMaKH.Text))
                {
                    busKH.InsertKHWithoutNGH(new DTO_KhachHang(tbMaKH.Text, tbTenKH.Text, dtpNgaySinh.DateTime.ToString("yyyy-MM-dd"), cbGioiTinh.Text, tbTienSu.Text, null));
                }
            }
            if (busPhieuTiem.InsertPhieuTiem(new DTO_PhieuTiem(busPhieuTiem.NextMAPHIEUTIEM(), tbMaKH.Text, tbMaBS.Text)))
            {
                for (int i = 0; i < listCTT.Count; i++)
                {
                    if (busCTT.InsertCTT(listCTT[i]))
                    {
                    }
                }
                MessageBox.Show("Thêm thành công");
            }
            gridKH.DataSource = busKH.getAllKH();
        }

        private void tbMaVC_Leave(object sender, EventArgs e)
        {
            tbMaVC.Text = tbMaVC.Text.ToUpper();
        }

        private void tbMaBS_Leave(object sender, EventArgs e)
        {
            tbMaBS.Text = tbMaBS.Text.ToUpper();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            gridKH.DataSource = busKH.getAllKH();
            gridVaccine.DataSource = null;
            listCTT.Clear();
            tbTenKH.Text = "";
            tbTienSu.Text = "";
            dtpNgaySinh.Text = "";
            dtpNgayTiem.Text = "";
            cbGioiTinh.Text = "";
            tbMaBS.Text = "";
            tbMaKH.Text = "";
            tbMaVC.Text = "";
            tbLoaiTiem.Text = "";
            tbLieuLuong.Text = "";
        }

        private void tbTienSu_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgaySinh_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tbTenKH_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void tbMaKH_Click(object sender, EventArgs e)
        {
            labelTooltipMaKH.Visible = true;
        }

        private void tbTenKH_Click(object sender, EventArgs e)
        {
            if(tbTenKH.Text == "Họ và Tên")
            {
                tbTenKH.Text = "";
            }
        }

        private void tbMaKH_Leave(object sender, EventArgs e)
        {
            labelTooltipMaKH.Visible = false;
        }

        private void tbTenKH_Leave(object sender, EventArgs e)
        {
            if(tbTenKH.Text == "")
            {
                tbTenKH.Text = "Họ và Tên";
            }
        }
    }
}