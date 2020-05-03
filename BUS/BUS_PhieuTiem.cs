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
        DAO_PhieuTiem daoPhieuTiem = new DAO_PhieuTiem();

        public DataTable getAllPhieuTiem()
        {
            return daoPhieuTiem.getAllPhieuTiem();
        }
    }
}
