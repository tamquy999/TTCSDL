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

        public string GetLastestMAPHIEUTIEM()
        {
            string query = "SELECT TOP(1) MAPHIEUTIEM FROM PHIEUTIEM ORDER BY MAPHIEUTIEM DESC";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);

            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0][0].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        public bool InsertPhieuTiem(DTO_PhieuTiem pt)
        {
            try
            {
                _conn.Open();

                string SQL = "INSERT INTO PHIEUTIEM (MAPHIEUTIEM, MAKH, MABS) VALUES ('" + pt.MAPHIEUTIEM + "', '" + pt.MAKH + "', '" + pt.MABS + "')";

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
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
