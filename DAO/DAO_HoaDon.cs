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
    public class DAO_HoaDon : DBProvider
    {
        public DataTable GetAllHD()
        {
            string query = "SELECT * FROM HOADON";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool InsertHD(DTO_HoaDon hd)
        {
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = @"INSERT INTO HOADON
                            ( MAHOADON, CHIETKHAU, NGAYTHU, TONGTIEN, MAGH, MATHUNGAN, MAPHIEUTIEM )
                            VALUES
                            ( @MAHOADON, @CHIETKHAU, @NGAYTHU, @TONGTIEN, @MAGH, @MATHUNGAN, @MAPHIEUTIEM )";
                cmd.Parameters.Add(new SqlParameter("MAHOADON", hd.MaHD));
                cmd.Parameters.Add(new SqlParameter("CHIETKHAU", hd.ChietKhau));
                cmd.Parameters.Add(new SqlParameter("NGAYTHU", hd.NgayThu));
                cmd.Parameters.Add(new SqlParameter("TONGTIEN", hd.TongTien));
                cmd.Parameters.Add(new SqlParameter("MAGH", hd.MaGH));
                cmd.Parameters.Add(new SqlParameter("MATHUNGAN", hd.MaTN));
                cmd.Parameters.Add(new SqlParameter("MAPHIEUTIEM", hd.MaPT));
                cmd.Connection = _conn;

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

        public string GetLastestMaHD()
        {
            string query = "SELECT TOP(1) MAHOADON FROM HOADON ORDER BY MAHOADON DESC";
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
    }
}
