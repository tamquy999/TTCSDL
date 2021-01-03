using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class BUS_Login
    {
        DBProvider dp = new DBProvider();

        public bool Login(string user, string pass)
        {
            if (user.ToLower() == "admin" && pass == "admin")
            {
                return true;
            }
            if (dp.Login(user, pass))
            {
                return true;
            }
            return false;
        }
    }
}
