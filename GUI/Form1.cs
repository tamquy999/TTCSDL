using BUS;
using DevExpress.XtraBars;
using DTO;
using GUI.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        bool logout;
        BUS_ThuNgan busTN = new BUS_ThuNgan();
        //public DTO_ThuNgan thungan;

        ThanhToanGUI ttGUI;
        VaccineGUI vcGUI;
        PhieuTiemGUI ptGUI;
        TiemGUI tiemGUI;

        static public string user;

        public Form1(string username)
        {
            InitializeComponent();

            if (username.Contains("TN"))
            {
                acBacSi.Visible = false;
                acAdmin.Visible = false;
                acKhachHang.Visible = false;

                DTO_ThuNgan thungan = new DTO_ThuNgan(username, busTN.getTenThuNgan(username));
                barStaticItem.Caption = "Thu ngân";

                ptGUI = new PhieuTiemGUI();
                container.Controls.Add(ptGUI);
                ptGUI.Dock = DockStyle.Fill;

                ttGUI = new ThanhToanGUI(thungan);
                container.Controls.Add(ttGUI);
                ttGUI.Dock = DockStyle.Fill;

                vcGUI = new VaccineGUI();
                container.Controls.Add(vcGUI);
                vcGUI.Dock = DockStyle.Fill;

                container.Controls.Add(LichSuGUI.Instance);
                LichSuGUI.Instance.Dock = DockStyle.Fill;
            }
            else if (username.Contains("BS"))
            {
                acThuNgan.Visible = false;
                acAdmin.Visible = false;
                acKhachHang.Visible = false;

                barStaticItem.Caption = "Bác sĩ";

                tiemGUI = new TiemGUI();
                container.Controls.Add(tiemGUI);
                tiemGUI.Dock = DockStyle.Fill;

                vcGUI = new VaccineGUI();
                container.Controls.Add(vcGUI);
                vcGUI.Dock = DockStyle.Fill;

                container.Controls.Add(LichSuGUI.Instance);
                LichSuGUI.Instance.Dock = DockStyle.Fill;
            }
            else if (username.ToLower() == "admin")
            {
                acThuNgan.Visible = false;
                acBacSi.Visible = false;
                acKhachHang.Visible = false;

                barStaticItem.Caption = "Quản trị viên";

                container.Controls.Add(ThongKeGUI.Instance);
                ThongKeGUI.Instance.Dock = DockStyle.Fill;
            }
            else
            {
                acThuNgan.Visible = false;
                acBacSi.Visible = false;
                acAdmin.Visible = false;

                barStaticItem.Caption = "Khách";

                vcGUI = new VaccineGUI();
                container.Controls.Add(vcGUI);
                vcGUI.Dock = DockStyle.Fill;

                container.Controls.Add(LichSuGUI.Instance);
                LichSuGUI.Instance.Dock = DockStyle.Fill;
            }

            user = username;

            container.Controls.Add(HomeGUI.Instance);
            HomeGUI.Instance.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //acePhieuTiem_Click(sender, e);
            //acThuNgan.Elements[0].Image = Resources.home_clicked;
            //acThuNgan.Elements[0].Appearance.Normal.ForeColor = Color.FromArgb(31, 187, 166);
            //acThuNgan.Elements[0].Appearance.Hovered.ForeColor = Color.FromArgb(31, 187, 166);
            HomeGUI.Instance.BringToFront();
        }

        private void accordionControl1_ElementClick(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
        {
            //acThuNgan.Elements[0].Image = Resources.home;
            //acThuNgan.Elements[0].Appearance.Normal.ForeColor = Color.White;
            //acThuNgan.Elements[0].Appearance.Hovered.ForeColor = Color.White;

            //acThuNgan.Elements[1].Image = Resources.vaccine;
            //acThuNgan.Elements[1].Appearance.Normal.ForeColor = Color.White;
            //acThuNgan.Elements[1].Appearance.Hovered.ForeColor = Color.White;

            //acThuNgan.Elements[2].Image = Resources.clock;
            //acThuNgan.Elements[2].Appearance.Normal.ForeColor = Color.White;
            //acThuNgan.Elements[2].Appearance.Hovered.ForeColor = Color.White;

            //acThuNgan.Elements[3].Image = Resources.add;
            //acThuNgan.Elements[3].Appearance.Normal.ForeColor = Color.White;
            //acThuNgan.Elements[3].Appearance.Hovered.ForeColor = Color.White;

            //acThuNgan.Elements[4].Image = Resources.pay;
            //acThuNgan.Elements[4].Appearance.Normal.ForeColor = Color.White;
            //acThuNgan.Elements[4].Appearance.Hovered.ForeColor = Color.White;

            //acThuNgan.Elements[5].Image = Resources.statistics;
            //acThuNgan.Elements[5].Appearance.Normal.ForeColor = Color.White;
            //acThuNgan.Elements[5].Appearance.Hovered.ForeColor = Color.White;

            //switch (e.Element.Text)
            //{
            //    case " Trang chủ":
            //        e.Element.Image = Resources.home_clicked;
            //        break;
            //    case " Quản lý vaccine":
            //        e.Element.Image = Resources.vaccine_clicked;
            //        break;
            //    case " Lịch sử tiêm":
            //        e.Element.Image = Resources.clock_clicked;
            //        break;
            //    case " Tạo phiếu tiêm":
            //        e.Element.Image = Resources.add_clicked;
            //        break;
            //    case " Thanh toán":
            //        e.Element.Image = Resources.pay_clicked;
            //        break;
            //    case " Thống kê":
            //        e.Element.Image = Resources.statistics_clicked;
            //        break;
            //}
            //e.Element.Appearance.Normal.ForeColor = Color.FromArgb(31, 187, 166);
            //e.Element.Appearance.Hovered.ForeColor = Color.FromArgb(31, 187, 166);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logout == false)
            {
                Application.Exit();
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            logout = true;
            this.Close();
        }

        #region ThuNgan events
        private void aceThanhToan_Click(object sender, EventArgs e)
        {
            ttGUI.BringToFront();
        }

        private void aceLichSu_Click(object sender, EventArgs e)
        {
            LichSuGUI.Instance.BringToFront();
        }

        private void aceVaccine_Click(object sender, EventArgs e)
        {
            vcGUI.RefreshGrid();
            vcGUI.BringToFront();
        }

        private void acePhieuTiem_Click(object sender, EventArgs e)
        {
            ptGUI.RefreshGrid();
            ptGUI.BringToFront();
        }

        private void aceHome_Click(object sender, EventArgs e)
        {
            HomeGUI.Instance.BringToFront();
        }
        #endregion

        #region BasSy events
        private void aceHomeBS_Click(object sender, EventArgs e)
        {
            HomeGUI.Instance.BringToFront();
        }

        private void aceVaccineBS_Click(object sender, EventArgs e)
        {
            vcGUI.RefreshGrid();
            vcGUI.BringToFront();
        }

        private void aceLichSuBS_Click(object sender, EventArgs e)
        {
            LichSuGUI.Instance.BringToFront();
        }

        private void aceTiemBS_Click(object sender, EventArgs e)
        {
            //ptGUI.RefreshGrid();
            tiemGUI.BringToFront();
        }
        #endregion

        #region Admin events
        private void aceHomeAD_Click(object sender, EventArgs e)
        {
            HomeGUI.Instance.BringToFront();
        }

        private void aceVaccineAD_Click(object sender, EventArgs e)
        {
            AD_QLVaccine.Instance.BringToFront();
        }

        private void aceAccountAD_Click(object sender, EventArgs e)
        {
            AD_QLTaiKhoan.Instance.BringToFront();
        }

        private void aceThongKeAD_Click(object sender, EventArgs e)
        {
            ThongKeGUI.Instance.BringToFront();
        }
        #endregion

        #region KhachHang events
        private void aceHomeKH_Click(object sender, EventArgs e)
        {
            HomeGUI.Instance.BringToFront();
        }

        private void aceVaccineKH_Click(object sender, EventArgs e)
        {
            vcGUI.RefreshGrid();
            vcGUI.BringToFront();
        }

        private void aceLichSuKH_Click(object sender, EventArgs e)
        {
            LichSuGUI.Instance.BringToFront();
        }
        #endregion
    }
}
