using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    //Class to make connect sqlcmd for thongke
    public class DAO_ThongKe : DBProvider
    {
        #region DoanhThu

        /// <summary>
        /// Get NgayThu + TongTien tat ca hoa don
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllHoaDon()
        {
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("sp_GetHoaDonINTIME_TK", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                rd = cmd.ExecuteReader();
                dt.Load(rd);
                
            }
            catch (Exception)
            {

                
            }
            finally
            {
                _conn.Close();
            }
            
            return dt;
        }

        /// <summary>
        /// Get NgayThu + TongTien cua cac hoa don trong 1 khoang tgian.
        /// </summary>
        /// <param name="NgayDau">string ngay</param>
        /// <param name="NgayCuoi">string ngay</param>
        /// <returns></returns>
        public DataTable GetAllHoaDonINTIME(string NgayDau, string NgayCuoi)
        {
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("sp_GetHoaDonINTIME_TK", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@NgayDau", NgayDau);
                cmd.Parameters.AddWithValue("@NgayCuoi", NgayCuoi);
                rd = cmd.ExecuteReader();
                dt.Load(rd);

            }
            catch (Exception)
            {

                
            }
            finally
            {
                _conn.Close();
            }

            return dt;
        }

        #endregion


        #region LoaiVC

        public DataTable GetCountLoaiVC()
        {
            DataTable dt = new DataTable();
            SqlDataReader rd;
            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand("sp_CountVCTheoLoaiVC",_conn);
                cmd.CommandType = CommandType.StoredProcedure;
                rd = cmd.ExecuteReader();
                dt.Load(rd);
            }
            catch (Exception)
            {

                
            }
            finally
            {
                _conn.Close();
            }
            return dt;
        }
        #endregion
    }
}
