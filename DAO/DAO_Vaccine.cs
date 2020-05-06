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
            string query = "SELECT * FROM VACCINE WHERE	MAVACCINE = '" + maVC + "'";
            
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.CommandType = CommandType.Text;
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
            string query = "SELECT * FROM VACCINE WHERE MAVACCINE LIKE N'%" + value + "%' OR TENVACCINE LIKE N'%" + value + "%' OR NHASX LIKE N'%" + value + "%' OR NGAYSX LIKE N'%" + value + "%'  OR HANSD  LIKE N'%" + value + "%'  OR SOLO LIKE N'%" + value + "%' OR SOLUONGCOSAN LIKE N'%" + value + "%' OR CHIDINH LIKE N'%" + value + "%'  OR DONGIA LIKE N'%" + value + "%' ";
            List<DTO_Vaccine> list = new List<DTO_Vaccine>();
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.CommandType = CommandType.Text;
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
            string query = "SELECT DONGIA FROM VACCINE WHERE MAVACCINE = '" + maVC + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);

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
            string query = "SELECT TENVACCINE FROM VACCINE WHERE MAVACCINE = '" + maVC + "'";
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

        public bool IsVCInStock(string maVC)
        {
            string query = "SELECT MAVACCINE FROM VACCINE WHERE MAVACCINE = '" + maVC + "'";
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
    }
}
