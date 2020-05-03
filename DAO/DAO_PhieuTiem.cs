using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_PhieuTiem : DBProvider
    {
        public DataTable getAllPhieuTiem()
        {
            string query = "SELECT * FROM PHIEUTIEM";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //public DTO_PhieuTiem getAPhieuTiem(string MAPHIEUTIEM)
        //{

        //}
    }
}
