using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Properties;

namespace GUI
{
    public partial class ThanhToanGUI : UserControl
    {
        public static ThanhToanGUI _instance;
        public static ThanhToanGUI Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ThanhToanGUI();
                }
                return _instance;
            }
        }
        public ThanhToanGUI()
        {
            InitializeComponent();
            dtpNgayTao.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void tbMaPT_Leave(object sender, EventArgs e)
        {

        }
    }
}
