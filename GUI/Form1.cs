using BUS;
using DevExpress.XtraBars;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        Login login = new Login();
        BUS_ThuNgan busTN = new BUS_ThuNgan();
        DTO_ThuNgan thungan;
        public Form1(string maTN)
        {
            InitializeComponent();
            thungan = new DTO_ThuNgan(maTN, busTN.getTenThuNgan(maTN));
            barStaticItem.Caption = "Xin chào " + thungan.HOTEN;

            container.Controls.Add(ThanhToanGUI.Instance);
            ThanhToanGUI.Instance.Dock = DockStyle.Fill;
            container.Controls.Add(LichSuGUI.Instance);
            LichSuGUI.Instance.Dock = DockStyle.Fill;
            container.Controls.Add(VaccineGUI.Instance);
            VaccineGUI.Instance.Dock = DockStyle.Fill;
            container.Controls.Add(PhieuTiemGUI.Instance);
            PhieuTiemGUI.Instance.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            acePhieuTiem_Click(sender, e);
        }

        private void aceThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToanGUI.Instance.BringToFront();
        }

        private void aceLichSu_Click(object sender, EventArgs e)
        {
            LichSuGUI.Instance.BringToFront();
        }

        private void aceVaccine_Click(object sender, EventArgs e)
        {
            VaccineGUI.Instance.BringToFront();
        }

        private void acePhieuTiem_Click(object sender, EventArgs e)
        {
            PhieuTiemGUI.Instance.BringToFront();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            login.Show();
            this.Hide();
        }

        private void accordionControl1_ElementClick(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
        {
            accordionControl1.Elements[0].Text = " Quản lý vaccine";
            accordionControl1.Elements[1].Text = " Lịch sử tiêm";
            accordionControl1.Elements[2].Text = " Tạo phiếu tiêm";
            accordionControl1.Elements[3].Text = " Thanh toán";

            switch (e.Element.Text)
            {
                case " Quản lý vaccine":
                    e.Element.Text = " 🠞   Quản lý vaccine";
                    break;
                case " Lịch sử tiêm":
                    e.Element.Text = " 🠞   Lịch sử tiêm";
                    break;
                case " Tạo phiếu tiêm":
                    e.Element.Text = " 🠞   Tạo phiếu tiêm";
                    break;
                case " Thanh toán":
                    e.Element.Text = " 🠞   Thanh toán";
                    break;
            }
        }
    }
}
