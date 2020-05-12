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
    public class DAO_GiamHo : DBProvider
    {
        public DataTable GetAllNGH()
        {
            string query = "SELECT * FROM NGUOIGIAMHO";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public string GetLastestMaGH()
        {
            string query = "SELECT TOP(1) MAGH FROM NGUOIGIAMHO ORDER BY MAGH DESC";
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

        public bool InsertNGH(DTO_GiamHo gh)
        {
            try
            {
                _conn.Open();

                string SQL = @"INSERT INTO NGUOIGIAMHO
                            (
                                MAGH,
                                HOTEN,
                                DIACHI,
                                SDT
                            )
                            VALUES
                            (   '" + gh.MaGH + "',  N'" + gh.HoTen + "', N'" + gh.DiaChi + "', '" + gh.Sdt + "' )";

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }

        public bool IsMaGHExists(string maGH)
        {
            string query = "SELECT MAGH FROM NGUOIGIAMHO WHERE MAGH = '" + maGH + "'";
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
                throw;
            }
            return false;
        }

        public bool AddMaGHtoKH(string maGH)
        {
            try
            {
                _conn.Open();

                string query = string.Format(@"UPDATE KHACHHANG SET MAGH = '{0}' WHERE MAKH IN (
	                            SELECT kh.MAKH
	                            FROM NGUOIGIAMHO gh INNER JOIN HOADON hd INNER JOIN PHIEUTIEM pt INNER JOIN KHACHHANG kh
	                            ON kh.MAKH = pt.MAKH ON pt.MAPHIEUTIEM = hd.MAPHIEUTIEM ON hd.MAGH = gh.MAGH
	                            WHERE gh.MAGH = '{0}'
                            )", maGH);

                SqlCommand cmd = new SqlCommand(query, _conn);

                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _conn.Close();
            }

            return false;
        }
    }
}
