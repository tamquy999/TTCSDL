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
        public LichSuGUI()
        {
            InitializeComponent();
        }
    }
}
