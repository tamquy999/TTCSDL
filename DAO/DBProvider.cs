using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DBProvider
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=DESKTOP-NATE\SQLEXPRESS;Initial Catalog=TTCSDL;Integrated Security=True");
     
        public bool Login(string user, string pass)
        {
            string query = "SELECT * FROM THUNGAN WHERE MATHUNGAN = '" + user + "' AND PASSWORD = '" + pass + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            
            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
            }
            return false;

        }
    }
}