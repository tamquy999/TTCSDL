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
                //_conn.Open();

                //string SQL = "INSERT INTO PHIEUTIEM " +
                //    "(MAPHIEUTIEM, MAKH, MABS) " +
                //    "VALUES " +
                //    "(@MAPHIEUTIEM, @MAKH, @MABS)";

                //SqlCommand cmd = new SqlCommand(SQL, _conn);

                //cmd.Parameters.AddWithValue("@MAPHIEUTIEM", pt.MAPHIEUTIEM);
                //cmd.Parameters.AddWithValue("@MAKH", pt.MAKH);
                //cmd.Parameters.AddWithValue("@MABS", pt.MABS);

                //if (cmd.ExecuteNonQuery() > 0)
                //    return true;


                _conn.Open();


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

        public List<DTO_Vaccine> GetVCFromPHIEUTIEM(string maPT)
        { 
            List<DTO_Vaccine> list = new List<DTO_Vaccine>();
            try
            {
                _conn.Open();
                string query = @"SELECT vc.*
                            FROM dbo.PHIEUTIEM pt INNER JOIN dbo.CHITIETTIEM ctt INNER JOIN dbo.VACCINE vc
                            ON vc.MAVACCINE = ctt.MAVACCINE
                            ON ctt.MAPHIEUTIEM = pt.MAPHIEUTIEM
                            WHERE ctt.MAPHIEUTIEM = @MAPHIEUTIEM";
                SqlCommand cmd = new SqlCommand(query, _conn);

                cmd.Parameters.AddWithValue("@MAPHIEUTIEM", maPT);

                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    string maVC = dataReader[0].ToString();
                    string tenVC = dataReader[1].ToString();
                    string nhaSX = dataReader[2].ToString();
                    string ngaySX = ((DateTime)dataReader[3]).ToString("dd/MM/yyyy");
                    string hanSD = ((DateTime)dataReader[4]).ToString("dd/MM/yyyy");
                    string soLo = dataReader[5].ToString();
                    int soLuongSan = int.Parse(dataReader[6].ToString());
                    string chiDinh = dataReader[7].ToString();
                    int donGia = int.Parse(dataReader[8].ToString());

                    DTO_Vaccine vaccine = new DTO_Vaccine(maVC, tenVC, nhaSX, ngaySX, hanSD, soLo, soLuongSan, chiDinh, donGia);
                    list.Add(vaccine);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _conn.Close();
            }
            return list;
        }

        public string GetTenKHFromPHIEUTIEM(string maPT)
        {
            string query = @"SELECT kh.TENKH 
                            FROM KHACHHANG kh INNER JOIN PHIEUTIEM pt
                            ON pt.MAKH = kh.MAKH
                            WHERE pt.MAPHIEUTIEM = @MAPHIEUTIEM";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);

            da.SelectCommand.Parameters.AddWithValue("@MAPHIEUTIEM", maPT);

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
            return "";
        }
    }
}
