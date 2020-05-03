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
using System.Diagnostics;

namespace GUI
{
    public partial class VaccineGUI : DevExpress.XtraEditors.XtraUserControl
    {
        public static VaccineGUI _instance;
        public static VaccineGUI Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new VaccineGUI();
                }
                return _instance;
            }
        }

        BUS_Vaccine busVC = new BUS_Vaccine();
        string currMAVACCINE = "";

        public VaccineGUI()
        {
            InitializeComponent();

            gridView1.OptionsBehavior.Editable = false;
            //gridView1.RowClick += GridView1_RowClick;
            gridView1.FocusedRowChanged += GridView1_FocusedRowChanged;
        }

        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //tbGia.Text = gridView1.GetRowCellValue(e.FocusedRowHandle, "DONGIA").ToString();
            //currMAVACCINE = gridView1.GetRowCellValue(e.FocusedRowHandle, "MAVACCINE").ToString();
            //Debug.WriteLine(currMAVACCINE);
        }

        private void GridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
        }

        private void VaccineGUI_Load(object sender, EventArgs e)
        {
            gridVaccine.DataSource = busVC.getAllVaccine();
            tbSearch.Focus();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhatGia_Click(object sender, EventArgs e)
        {
            //if (MessageBoxEx.Show("Bạn có chắc chắn muốn cập nhật không? Thao tác này không thể hoàn tác.", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
            //{
            //    return;
            //}
            
            //if (busVC.updateVCPrice(currMAVACCINE, Convert.ToInt32(tbGia.Text)))
            //{
            //    MessageBoxEx.Show("Cập nhật thành công");
            //}
            //else MessageBoxEx.Show("Có lỗi xảy ra trong quá trình cập nhật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //gridVaccine.DataSource = busVC.getAllVaccine();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
