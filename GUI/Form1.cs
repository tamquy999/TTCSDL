using DevExpress.XtraBars;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void aceThanhToan_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ThanhToanGUI.Instance))
            {
                container.Controls.Add(ThanhToanGUI.Instance);
                ThanhToanGUI.Instance.Dock = DockStyle.Fill;
            }
            ThanhToanGUI.Instance.BringToFront();
        }

        private void aceLichSu_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(LichSuGUI.Instance))
            {
                container.Controls.Add(LichSuGUI.Instance);
                LichSuGUI.Instance.Dock = DockStyle.Fill;
            }
            LichSuGUI.Instance.BringToFront();
        }

        private void aceVaccine_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(VaccineGUI.Instance))
            {
                container.Controls.Add(VaccineGUI.Instance);
                VaccineGUI.Instance.Dock = DockStyle.Fill;
            }
            VaccineGUI.Instance.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            acePhieuTiem_Click(sender, e);
        }

        private void acePhieuTiem_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(PhieuTiemGUI.Instance))
            {
                container.Controls.Add(PhieuTiemGUI.Instance);
                PhieuTiemGUI.Instance.Dock = DockStyle.Fill;
            }
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
    }
}
