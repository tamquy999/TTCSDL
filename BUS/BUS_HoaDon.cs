using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HoaDon
    {
        DAO_HoaDon dao = new DAO_HoaDon();

        public DataTable GetAllHD()
        {
            return dao.GetAllHD();
        }

        public bool InsertHD(DTO_HoaDon hd)
        {
            return dao.InsertHD(hd);
        }
        public string NextMaHD()
        {
            string MAHD = dao.GetLastestMaHD().Trim();
            int count = MAHD.Length - 2;
            int hdIndex = Convert.ToInt32(MAHD.Substring(2)) + 1;
            MAHD = "HD";
            for (int i = 0; i < count - hdIndex.ToString().Length; i++)
                MAHD += "0";
            MAHD += (hdIndex).ToString();
            return MAHD;
        }
    }
}
