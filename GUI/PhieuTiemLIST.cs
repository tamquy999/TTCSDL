using BUS;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class PhieuTiemLIST : DevExpress.XtraEditors.XtraForm
    {

        BUS_PhieuTiem busPT = new BUS_PhieuTiem();

        public PhieuTiemLIST()
        {
            InitializeComponent();
        }

        private void PhieuTiemLIST_Load(object sender, EventArgs e)
        {
            gridPT.DataSource = busPT.getAllPhieuTiem();
        }

        private void gridPT_ProcessGridKey(object sender, KeyEventArgs e)
        {
            var grid = sender as GridControl;
            var view = grid.FocusedView as GridView;
            if (e.KeyData == Keys.Delete)
            {
                view.DeleteSelectedRows();
                e.Handled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Các thay đổi chưa lưu sẽ bị mất. Bạn có chắc chắn muốn đặt lại?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridPT.DataSource = busPT.getAllPhieuTiem();
            }
        }
    }
}
