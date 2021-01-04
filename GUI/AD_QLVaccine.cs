﻿using BUS;
using DTO;
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
    public partial class AD_QLVaccine : DevExpress.XtraEditors.XtraUserControl
    {
        public static AD_QLVaccine _instance;
        public static AD_QLVaccine Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new AD_QLVaccine();
                }
                return _instance;
            }
        }
        public AD_QLVaccine()
        {
            InitializeComponent();
        }
    }
}