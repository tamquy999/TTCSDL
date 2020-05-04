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
using System.Reflection;
using DTO;

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
            gridView1.BestFitColumns();
            tbSearch.Focus();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text == "")
            {
                gridVaccine.DataSource = busVC.getAllVaccine();
            }
            else gridVaccine.DataSource = busVC.SearchAll(tbSearch.Text);
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }
    }
}
