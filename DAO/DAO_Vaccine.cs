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

        public DTO_Vaccine getVaccineFromID(string maVC)
        {
            
            try
            {
                _conn.Open();
                string query = "SELECT * FROM VACCINE WHERE	MAVACCINE = @MAVACCINE";
                SqlCommand cmd = new SqlCommand(query, _conn);

                cmd.Parameters.AddWithValue("@MAVACCINE", maVC);

                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    string tenVC = dataReader[1].ToString();
                    string nhaSX = dataReader[2].ToString();
                    string ngaySX = ((DateTime)dataReader[3]).ToString("dd/MM/yyyy");
                    string hanSD = ((DateTime)dataReader[4]).ToString("dd/MM/yyyy");
                    string soLo = dataReader[5].ToString();
                    int soLuongSan = int.Parse(dataReader[6].ToString());
                    string chiDinh = dataReader[7].ToString();
                    int donGia = int.Parse(dataReader[8].ToString());

                    return new DTO_Vaccine(maVC, tenVC, nhaSX, ngaySX, hanSD, soLo, soLuongSan, chiDinh, donGia);
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
            return null;
        }
        
        public List<DTO_Vaccine> SearchAll(string value)
        {

            List<DTO_Vaccine> list = new List<DTO_Vaccine>();
            try
            {
                _conn.Open(); 
                string query = "SELECT * FROM VACCINE " +
                             "WHERE MAVACCINE LIKE @MAVACCINE " +
                             "OR TENVACCINE LIKE @TENVACCINE " +
                             "OR NHASX LIKE @NHASX " +
                             "OR NGAYSX LIKE @NGAYSX " +
                             "OR HANSD  LIKE @HANSD " +
                             "OR SOLO LIKE @SOLO " +
                             "OR SOLUONGCOSAN LIKE @SOLUONGCOSAN " +
                             "OR CHIDINH LIKE @CHIDINH " +
                             "OR DONGIA LIKE @DONGIA";
                SqlCommand cmd = new SqlCommand(query, _conn);

                cmd.Parameters.AddWithValue("@MAVACCINE", "%" + value + "%");
                cmd.Parameters.AddWithValue("@TENVACCINE", "%" + value + "%");
                cmd.Parameters.AddWithValue("@NHASX", "%" + value + "%");
                cmd.Parameters.AddWithValue("@NGAYSX", "%" + value + "%");
                cmd.Parameters.AddWithValue("@HANSD", "%" + value + "%");
                cmd.Parameters.AddWithValue("@SOLO", "%" + value + "%");
                cmd.Parameters.AddWithValue("@SOLUONGCOSAN", "%" + value + "%");
                cmd.Parameters.AddWithValue("@CHIDINH", "%" + value + "%");
                cmd.Parameters.AddWithValue("@DONGIA", "%" + value + "%");

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

        public int getVCPrice(string maVC)
        {
            string query = "SELECT DONGIA FROM VACCINE WHERE MAVACCINE = @MAVACCINE";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            da.SelectCommand.Parameters.AddWithValue("@MAVACCINE", maVC);

            DataTable dt = new DataTable();

            try
            {
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return Convert.ToInt32(dt.Rows[0][0].ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
            return -1;
        }

        public string getVCName(string maVC)
        {
            string query = "SELECT TENVACCINE FROM VACCINE WHERE MAVACCINE = @MAVACCINE";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            da.SelectCommand.Parameters.AddWithValue("@MAVACCINE", maVC);

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

        public bool IsVCInStock(string maVC)
        {
            string query = "SELECT MAVACCINE FROM VACCINE WHERE MAVACCINE = @MAVACCINE";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            da.SelectCommand.Parameters.AddWithValue("@MAVACCINE", maVC);

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


    }
}
