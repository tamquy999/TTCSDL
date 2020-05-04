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

namespace GUI
{
    public partial class LichSuGUI : DevExpress.XtraEditors.XtraUserControl
    {
        public static LichSuGUI _instance;
        public static LichSuGUI Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LichSuGUI();
                }
                return _instance;
            }
        }

        BUS_LichSu busLS = new BUS_LichSu();

        public LichSuGUI()
        {
            InitializeComponent();
            gridLichSu.DataSource = busLS.getAllLichSu("");
            gridView1.BestFitColumns();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            gridLichSu.DataSource = busLS.getAllLichSu(tbMaKH.Text);
            gridView1.BestFitColumns();
        }

        private void tbMaKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTraCuu.PerformClick();
            }
        }
    }
}
