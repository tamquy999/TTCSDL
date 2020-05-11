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
    public class BUS_PhieuTiem
    {
        DAO_PhieuTiem dao = new DAO_PhieuTiem();

        public DataTable getAllPhieuTiem()
        {
            return dao.getAllPhieuTiem();
        }

        public string NextMAPHIEUTIEM()
        {
            string MAPHIEUTIEM = dao.GetLastestMAPHIEUTIEM().Trim();
            int count = MAPHIEUTIEM.Length - 2;
            int ptIndex = Convert.ToInt32(MAPHIEUTIEM.Substring(2)) + 1;
            MAPHIEUTIEM = "PT";
            for (int i = 0; i < count - ptIndex.ToString().Length; i++)
                MAPHIEUTIEM += "0";
            MAPHIEUTIEM += (ptIndex).ToString();
            return MAPHIEUTIEM;
        }

        public bool InsertPhieuTiem(DTO_PhieuTiem pt)
        {
            return dao.InsertPhieuTiem(pt);
        }
    }
}
