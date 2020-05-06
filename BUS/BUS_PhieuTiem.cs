using DAO;
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

        public string GetLastestMAPHIEUTIEM()
        {
            return dao.GetLastestMAPHIEUTIEM();
        }
    }
}
