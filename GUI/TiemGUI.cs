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
using DevExpress.XtraGrid.Localization;

namespace GUI
{
    public partial class TiemGUI : DevExpress.XtraEditors.XtraUserControl
    {
        public static TiemGUI _instance;
        public static TiemGUI Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TiemGUI();
                }
                return _instance;
            }
        }

        BUS_PhieuTiem busPhieuTiem = new BUS_PhieuTiem();
        BUS_Vaccine busVC = new BUS_Vaccine();
        BUS_KhachHang busKH = new BUS_KhachHang();
        BUS_ChiTietTiem busCTT = new BUS_ChiTietTiem();

        List<DTO_ChiTietTiem> listCTT = new List<DTO_ChiTietTiem>();

        public TiemGUI()
        {
            InitializeComponent();

            dtpNgayTiem.Text = DateTime.Now.ToString("dd/MM/yyyy");

            gridView2.RowClick += GridView2_RowClick;


            GridLocalizer.Active = new MyGridLocalizer();

            InitAutoCompeteTextBox();
        }

        public void RefreshGrid()
        {
            gridPT.DataSource = busPhieuTiem.GetAllPhieuTiemInfo();
            gridVaccine.DataSource = null;

            //tbMaVC.Text = "";
            //tbMuiThu.Text = "";
            //tbLieuLuong.Text = "";
            //tbNhacLai.Text = "";

            btnReset.PerformClick();
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
            tbMaPT.Text = gridView1.GetRowCellValue(e.RowHandle, "MAPHIEUTIEM").ToString().Trim();
            tbMaKH.Text = gridView1.GetRowCellValue(e.RowHandle, "MAKH").ToString().Trim();
            tbTenKH.Text = gridView1.GetRowCellValue(e.RowHandle, "TENKH").ToString().Trim();
            dtpNgaySinh.Text = gridView1.GetRowCellValue(e.RowHandle, "NGAYSINH").ToString().Substring(0, 10);
            cbGioiTinh.Text = gridView1.GetRowCellValue(e.RowHandle, "GIOITINH").ToString();
            tbTienSu.Text = gridView1.GetRowCellValue(e.RowHandle, "TIEUSU").ToString().Trim();

            int datiem = (int)gridView1.GetRowCellValue(e.RowHandle, "DATIEM");
            if (datiem == 1)
            {
                gcVaccine.Enabled = false;
                btnXacNhan.Enabled = false;
            }
            else
            {
                gcVaccine.Enabled = true;
                btnXacNhan.Enabled = true;
            }

            listCTT.Clear();
            DataTable dt = busPhieuTiem.GetVCFromPHIEUTIEM(gridView1.GetRowCellValue(e.RowHandle, "MAPHIEUTIEM").ToString());
            dt.Columns.Remove("LOAIVACCINE");
            dt.Columns.Remove("NHASX");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string maVC = dt.Rows[i]["MAVACCINE"].ToString().Trim();
                int muiThu = (int)dt.Rows[i]["MUITHU"];
                string ngayNhacLai = Convert.ToDateTime(dt.Rows[i]["NGAYTIEMNHACLAI"]).ToString("yyyy-MM-dd");
                double lieuLuong = (double)dt.Rows[i]["LIEULUONG"];
                DTO_ChiTietTiem ctt = new DTO_ChiTietTiem(tbMaPT.Text, maVC, busVC.getVCPrice(maVC), muiThu, ngayNhacLai, lieuLuong);
                listCTT.Add(ctt);
            }
            gridVaccine.DataSource = dt;

            //gridVaccine.DataSource = 
        }

        private void TiemGUI_Load(object sender, EventArgs e)
        {
            //gridKH.DataSource = busKH.getAllKH();
            //gridView1.Columns["MAKH"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;
            DataTable dt = busPhieuTiem.GetAllPhieuTiemInfo();

            dt.Columns.Add("DATHANHTOAN", typeof(Int32));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (busPhieuTiem.IsPhieutiemDaThanhToan(dt.Rows[i]["MAPHIEUTIEM"].ToString().Trim()))
                {
                    dt.Rows[i]["DATHANHTOAN"] = 1;
                }
                else dt.Rows[i]["DATHANHTOAN"] = 0;
            }


            gridPT.DataSource = dt;
        }

        private void btnAddVC_Click(object sender, EventArgs e)
        {
            if (tbMaVC.Text != "" && tbMuiThu.Text != "" && tbLieuLuong.Text != "")
            {
                if (busVC.IsVCInStock(tbMaVC.Text))
                {
                    if (Convert.ToDouble(tbLieuLuong.Text) <= busVC.GetSoLuongConLai(tbMaVC.Text))
                    {
                        DTO_ChiTietTiem ctt = new DTO_ChiTietTiem(tbMaPT.Text, tbMaVC.Text, busVC.getVCPrice(tbMaVC.Text), int.Parse(tbMuiThu.Text), dtpNgayTiem.DateTime.AddMonths(Convert.ToInt32(tbNhacLai.Text)).ToString("yyyy-MM-dd"), Convert.ToDouble(tbLieuLuong.Text));

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
                                    dtb.Columns.Add("DONGIA");
                                    dtb.Columns.Add("MUITHU");
                                    dtb.Columns.Add("LIEULUONG");
                                    dtb.Columns.Add("NGAYTIEMNHACLAI");

                                    for (int j = 0; j < listCTT.Count; j++)
                                    {
                                        DataRow dr = dtb.NewRow();
                                        dr["MAVACCINE"] = listCTT[j].MAVACCINE;
                                        dr["TENVACCINE"] = busVC.getVCName(listCTT[j].MAVACCINE);
                                        dr["DONGIA"] = listCTT[j].GIABAN;
                                        dr["MUITHU"] = listCTT[j].MUITHU;
                                        dr["LIEULUONG"] = listCTT[j].LIEULUONG;
                                        dr["NGAYTIEMNHACLAI"] = listCTT[j].NGAYNHACLAI;
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
                        dt.Columns.Add("DONGIA");
                        dt.Columns.Add("MUITHU");
                        dt.Columns.Add("LIEULUONG");
                        dt.Columns.Add("NGAYTIEMNHACLAI");

                        for (int i = 0; i < listCTT.Count; i++)
                        {
                            DataRow dr = dt.NewRow();
                            dr["MAVACCINE"] = listCTT[i].MAVACCINE;
                            dr["TENVACCINE"] = busVC.getVCName(listCTT[i].MAVACCINE);
                            dr["DONGIA"] = listCTT[i].GIABAN;
                            dr["MUITHU"] = listCTT[i].MUITHU;
                            dr["LIEULUONG"] = listCTT[i].LIEULUONG;
                            dr["NGAYTIEMNHACLAI"] = listCTT[i].NGAYNHACLAI;
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
            dt.Columns.Add("DONGIA");
            dt.Columns.Add("MUITHU");
            dt.Columns.Add("LIEULUONG");
            dt.Columns.Add("NGAYTIEMNHACLAI");

            for (int i = 0; i < listCTT.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["MAVACCINE"] = listCTT[i].MAVACCINE;
                dr["TENVACCINE"] = busVC.getVCName(listCTT[i].MAVACCINE);
                dr["DONGIA"] = listCTT[i].GIABAN;
                dr["MUITHU"] = listCTT[i].MUITHU;
                dr["LIEULUONG"] = listCTT[i].LIEULUONG;
                dr["NGAYTIEMNHACLAI"] = listCTT[i].NGAYNHACLAI;
                dt.Rows.Add(dr); 
            }

            gridVaccine.DataSource = dt;
            gridView2.BestFitColumns();
        }

        private void tbMaVC_Leave(object sender, EventArgs e)
        {
            tbMaVC.Text = tbMaVC.Text.ToUpper();
        }

        private void tbMaBS_Leave(object sender, EventArgs e)
        {
            tbMaKH.Text = tbMaKH.Text.ToUpper();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //gridKH.DataSource = busKH.getAllKH();
            gridVaccine.DataSource = null;
            listCTT.Clear();
            tbTenKH.Text = "";
            tbTienSu.Text = "";
            dtpNgaySinh.Text = "";
            dtpNgayTiem.Text = DateTime.Now.ToString("dd/MM/yyyy");
            cbGioiTinh.Text = "";
            tbMaKH.Text = "";
            tbMaPT.Text = "";
            tbMaVC.Text = "";
            tbMuiThu.Text = "";
            tbLieuLuong.Text = "";
            tbNhacLai.Text = "";
        }

        private void tbMaKH_Click(object sender, EventArgs e)
        {
            //labelTooltipMaKH.Visible = true;
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
            //labelTooltipMaKH.Visible = false;
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
            //PhieuTiemLIST pt = new PhieuTiemLIST();
            //pt.ShowDialog();
        }

        private void tbNhacLai_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupControl3_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            PhieuTiemLIST pt = new PhieuTiemLIST();
            pt.ShowDialog();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (busPhieuTiem.XacNhanDaTiem(tbMaPT.Text, Form1.user))
            {
                MessageBoxEx.Show("Xác nhận thành công");
                RefreshGrid();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            busCTT.ClearAllCTTFromPT(tbMaPT.Text);
            for (int i = 0; i < listCTT.Count; i++)
            {
                if (busCTT.InsertCTT(listCTT[i]))
                {
                }
            }
            MessageBoxEx.Show("Lưu thành công");
            //RefreshGrid();
        }

        private void gridPT_DataSourceChanged(object sender, EventArgs e)
        {
            //this.ActiveControl = this.gridPT;
            //this.gridView1.FocusedRowHandle = 30;
        }
    }
}