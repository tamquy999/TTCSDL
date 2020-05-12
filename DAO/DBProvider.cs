using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace DAO
{
    public class DBProvider
    {
        protected SqlConnection _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["GUI.Properties.Settings.Setting"].ConnectionString);

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