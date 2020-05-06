using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_KhachHang
    {
        DAO_KhachHang dao = new DAO_KhachHang();
        public DataTable getAllKH()
        {
            return dao.GetAllKH();
        }
    }
}
