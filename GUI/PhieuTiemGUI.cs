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

        public void RefreshGrid()
        {
            gridKH.DataSource = busKH.getAllKH();
            gridView1.Columns["MAKH"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
        }

        private void InitAutoCompeteTextBox()
        {
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
            tbTienSu.Text = gridView1.GetRowCellValue(e.RowHandle, "TIEUSU").ToString().Trim();
        }

        private void PhieuTiemGUI_Load(object sender, EventArgs e)
        {
            //gridKH.DataSource = busKH.getAllKH();
            //gridView1.Columns["MAKH"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
        }

        private void btnAddVC_Click(object sender, EventArgs e)
        {
            if (tbMaVC.Text != "" && tbMuiThu.Text != "" && tbLieuLuong.Text != "")
            {
                if (busVC.IsVCInStock(tbMaVC.Text))
                {
                    if (Convert.ToDouble(tbLieuLuong.Text) <= busVC.GetSoLuongConLai(tbMaVC.Text))
                    {
                        DTO_ChiTietTiem ctt = new DTO_ChiTietTiem(busPhieuTiem.NextMAPHIEUTIEM(), tbMaVC.Text, busVC.getVCPrice(tbMaVC.Text), int.Parse(tbMuiThu.Text), dtpNgayTiem.DateTime.AddMonths(Convert.ToInt32(tbNhacLai.Text)).ToString("yyyy-MM-dd"), Convert.ToDouble(tbLieuLuong.Text));

                        for (int i = 0; i < listCTT.Count; i++)
                        {
                            if (ctt.MAVACCINE == listCTT[i].MAVACCINE)
                            {
                                if (Convert.ToDouble(tbLieuLuong.Text) <= busVC.GetSoLuongConLai(tbMaVC.Text) - listCTT[i].LIEULUONG)
                                {
                                    listCTT[i].LIEULUONG += ctt.LIEULUONG;
                                    DataTable dtb = new DataTable();
                                    dtb.Columns.Add("MAVACCINE");
                                    dtb.Columns.Add("TENVACCINE");
                                    dtb.Columns.Add("GIABAN");
                                    dtb.Columns.Add("MUITHU");
                                    dtb.Columns.Add("LIEULUONG");
                                    dtb.Columns.Add("NGAYNHACLAI");

                                    for (int j = 0; j < listCTT.Count; j++)
                                    {
                                        DataRow dr = dtb.NewRow();
                                        dr["MAVACCINE"] = listCTT[j].MAVACCINE;
                                        dr["TENVACCINE"] = busVC.getVCName(listCTT[j].MAVACCINE);
                                        dr["GIABAN"] = listCTT[j].GIABAN;
                                        dr["MUITHU"] = listCTT[j].MUITHU;
                                        dr["LIEULUONG"] = listCTT[j].LIEULUONG;
                                        dr["NGAYNHACLAI"] = listCTT[j].NGAYNHACLAI;
                                        dtb.Rows.Add(dr);
                                    }

                                    gridVaccine.DataSource = dtb;
                                    gridView2.BestFitColumns();
                                }
                                else MessageBoxEx.Show("Liều lượng vừa nhập lớn hơn số lượng trong kho. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                return;
                            }
                        }

                        listCTT.Add(ctt);

                        DataTable dt = new DataTable();
                        dt.Columns.Add("MAVACCINE");
                        dt.Columns.Add("TENVACCINE");
                        dt.Columns.Add("GIABAN");
                        dt.Columns.Add("MUITHU");
                        dt.Columns.Add("LIEULUONG");
                        dt.Columns.Add("NGAYNHACLAI");

                        for (int i = 0; i < listCTT.Count; i++)
                        {
                            DataRow dr = dt.NewRow();
                            dr["MAVACCINE"] = listCTT[i].MAVACCINE;
                            dr["TENVACCINE"] = busVC.getVCName(listCTT[i].MAVACCINE);
                            dr["GIABAN"] = listCTT[i].GIABAN;
                            dr["MUITHU"] = listCTT[i].MUITHU;
                            dr["LIEULUONG"] = listCTT[i].LIEULUONG;
                            dr["NGAYNHACLAI"] = listCTT[i].NGAYNHACLAI;
                            dt.Rows.Add(dr);
                        }

                        gridVaccine.DataSource = dt;
                        gridView2.BestFitColumns();
                    }
                    else MessageBoxEx.Show("Liều lượng vừa nhập lớn hơn số lượng trong kho. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBoxEx.Show("Vaccine với mã \"" + tbMaVC.Text + "\" đã hết hoặc không tồn tại. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            dt.Columns.Add("MUITHU");
            dt.Columns.Add("LIEULUONG");
            dt.Columns.Add("NGAYNHACLAI");

            for (int i = 0; i < listCTT.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["MAVACCINE"] = listCTT[i].MAVACCINE;
                dr["TENVACCINE"] = busVC.getVCName(listCTT[i].MAVACCINE);
                dr["GIABAN"] = listCTT[i].GIABAN;
                dr["MUITHU"] = listCTT[i].MUITHU;
                dr["LIEULUONG"] = listCTT[i].LIEULUONG;
                dr["NGAYNHACLAI"] = listCTT[i].NGAYNHACLAI;
                dt.Rows.Add(dr); 
            }

            gridVaccine.DataSource = dt;
            gridView2.BestFitColumns();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaPT = busPhieuTiem.NextMAPHIEUTIEM();

            if (tbTenKH.Text != "" && dtpNgaySinh.Text != "" && tbTienSu.Text != "" && cbGioiTinh.Text != "")
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

                gridKH.DataSource = busKH.getAllKH();

                if (busPhieuTiem.InsertPhieuTiem(new DTO_PhieuTiem(MaPT, dtpNgayTiem.DateTime.ToString("yyyy-MM-dd"), tbMaKH.Text, "NULL", 0)))
                {
                    //for (int i = 0; i < listCTT.Count; i++)
                    //{
                    //    if (busCTT.InsertCTT(listCTT[i]))
                    //    {
                    //    }
                    //}
                    //if (MessageBoxEx.Show("Thêm thành công. Bạn có muốn in phiếu tiêm không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    //{
                    //    return;
                    //}
                    MessageBoxEx.Show("Thêm thành công");
                }

                btnReset.PerformClick();
            }
            else
            {
                MessageBoxEx.Show("Ban chưa nhập đầy đủ thông tin");
                return;
            }

            //if (listCTT.Count > 0)
            //{
            //    if (busPhieuTiem.InsertPhieuTiem(new DTO_PhieuTiem(busPhieuTiem.NextMAPHIEUTIEM(), dtpNgayTiem.DateTime.ToString("yyyy-MM-dd"), tbMaKH.Text, tbMaBS.Text)))
            //    {
            //        for (int i = 0; i < listCTT.Count; i++)
            //        {
            //            if (busCTT.InsertCTT(listCTT[i]))
            //            {
            //            }
            //        }
            //        MessageBox.Show("Thêm thành công");
            //    }
            //}
            //else MessageBoxEx.Show("Ban chưa nhập danh sách vaccine");


            //gridKH.DataSource = busKH.getAllKH();

            //PhieuTiemRP_Provider ptRP = new PhieuTiemRP_Provider(MaPT);
            //ptRP.ShowReport();

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
            dtpNgayTiem.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cbGioiTinh.Text = "";
            tbMaBS.Text = "";
            tbMaKH.Text = "";
            tbMaVC.Text = "";
            tbMuiThu.Text = "";
            tbLieuLuong.Text = "";
            tbNhacLai.Text = "";
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
        }

        //only accept number in textbox
        private void tbMuiThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbLieuLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
        private void tbNhacLai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void btnList_Click(object sender, EventArgs e)
        {
            PhieuTiemLIST pt = new PhieuTiemLIST();
            pt.ShowDialog();
        }

        private void tbNhacLai_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}