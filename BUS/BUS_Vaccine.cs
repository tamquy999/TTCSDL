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
    public class BUS_Vaccine
    {
        DAO_Vaccine dao = new DAO_Vaccine();

        public DataTable getAllVaccine()
        {
            return dao.getAllVaccine();
        }

        public DTO_Vaccine getVaccineFromID(string maVC)
        {
            return dao.getVaccineFromID(maVC);
        }

        public List<DTO_Vaccine> SearchAll(string value)
        {
            return dao.SearchAll(value);
        }

        public int getVCPrice(string maVC)
        {
            return dao.getVCPrice(maVC);
        }

        public string getVCName(string maVC)
        {
            return dao.getVCName(maVC);
        }

        public bool IsVCInStock(string maVC)
        {
            return dao.IsVCInStock(maVC);
        }

    }
}
