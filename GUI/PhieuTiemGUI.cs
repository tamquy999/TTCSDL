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
        BUS_KhachHang busKH = new BUS_KhachHang();

        List<DTO_ChiTietTiem> listCTT = new List<DTO_ChiTietTiem>();
        string MAPHIEUTIEM;
        public PhieuTiemGUI()
        {
            InitializeComponent();

            dtpNgayTiem.Text = DateTime.Now.ToString("dd/MM/yyyy");

            gridView2.RowClick += GridView2_RowClick;
            gridView1.FocusedRowChanged += GridView1_FocusedRowChanged;

            // tang ma phieu tiem cuoi cung trong sql table len 1 don vi
            InitMAPHIEUTIEM();

            InitAutoCompeteTextBox();
        }

        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            tbTenKH.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "TENKH").ToString();
            dtpNgaySinh.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "NGAYSINH").ToString().Substring(0, 10);
            cbGioiTinh.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "GIOITINH").ToString();
            tbTienSu.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "TIEUSUBENHAN").ToString();
        }

        private void InitMAPHIEUTIEM()
        {
            MAPHIEUTIEM = busPhieuTiem.GetLastestMAPHIEUTIEM();
            int count = MAPHIEUTIEM.Length - 4;
            int ptIndex = Convert.ToInt32(MAPHIEUTIEM.Substring(2));
            MAPHIEUTIEM = "PT";
            for (int i = 0; i < count - ptIndex.ToString().Length; i++)
                MAPHIEUTIEM += "0";
            MAPHIEUTIEM += (ptIndex + 1).ToString();
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
            gridKH.DataSource = busKH.getAllKH();
        }

        private void btnAddVC_Click(object sender, EventArgs e)
        {
            if (tbMaVC.Text != "" && tbLoaiTiem.Text != "" && tbLieuLuong.Text != "")
            {
                if (busVC.IsVCInStock(tbMaVC.Text))
                {
                    DTO_ChiTietTiem ctt = new DTO_ChiTietTiem("", tbMaVC.Text, busVC.getVCPrice(tbMaVC.Text), tbLoaiTiem.Text, dtpNgayTiem.Text, Convert.ToDouble(tbLieuLuong.Text));

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
            
        }
    }
}