using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Vaccine : DBProvider
    {
        public DataTable getAllVaccine()
        {
            string query = "SELECT * FROM VACCINE";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool updateVCPrice(string MAVACCINE, int DONGIA)
        {
            try
            {
                _conn.Open();
                string query = "UPDATE dbo.VACCINE SET DONGIA = " + DONGIA + " WHERE MAVACCINE = '" + MAVACCINE + "'";
                SqlCommand command = new SqlCommand(query, _conn);
                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception)
            {
            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
    }
}
