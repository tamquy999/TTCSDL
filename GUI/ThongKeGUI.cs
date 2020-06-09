using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
     public partial class ThongKeGUI : DevExpress.XtraEditors.XtraUserControl
     {
          public static ThongKeGUI _instance;

          public static ThongKeGUI Instance
          {
               get
               {
                    if (_instance == null)
                    {
                         _instance = new ThongKeGUI();
                    }
                    return _instance;
               }
          }
          public ThongKeGUI()
          {
               InitializeComponent();
               
          }
     }
}
