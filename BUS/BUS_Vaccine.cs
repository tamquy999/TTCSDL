using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Vaccine
    {
        DAO_Vaccine dao = new DAO_Vaccine();

        public DataTable getAllVaccine()
        {
            return dao.getAllVaccine();
        }

        public bool updateVCPrice(string MAVACCINE, int DONGIA)
        {
            return dao.updateVCPrice(MAVACCINE, DONGIA);
        }
    }
}
