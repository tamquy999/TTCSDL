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
    public class BUS_ThongKe
    {
        DAO_ThongKe dao = new DAO_ThongKe();

        public DataTable GetHoaDonInTime(string NgayDau, string NgayCuoi)
        {
            return dao.GetAllHoaDonINTIME(NgayDau, NgayCuoi);
        }


        public DataTable GetCountLoaiVC()
        {
            return dao.GetCountLoaiVC();
        }

        public DataTable GetMostUsedVaccineIn(string NgayDau, string NgayCuoi)
        {
            return dao.GetMostUsedVC(NgayDau, NgayCuoi);
        }
    }
}
