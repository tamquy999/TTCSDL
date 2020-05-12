using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_ChiTietTiem : DBProvider
    {
        public bool InsertCTT(DTO_ChiTietTiem ctt)
        {
            try
            {
                _conn.Open();

                string SQL = @"INSERT INTO CHITIETTIEM
                            ( MAPHIEUTIEM, MAVACCINE, GIABAN, LOAITIEMCHUNG, NGAYTIEM, LIEULUONG )
                            VALUES
                            ( @MAPHIEUTIEM, @MAVACCINE, @GIABAN, @LOAITIEMCHUNG, @NGAYTIEM, @LIEULUONG )";

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                cmd.Parameters.Add(new SqlParameter("MAPHIEUTIEM", ctt.MAPHIEUTIEM));
                cmd.Parameters.Add(new SqlParameter("MAVACCINE", ctt.MAVACCINE));
                cmd.Parameters.Add(new SqlParameter("GIABAN", ctt.GIABAN));
                cmd.Parameters.Add(new SqlParameter("LOAITIEMCHUNG", ctt.LOAITIEMCHUNG));
                cmd.Parameters.Add(new SqlParameter("NGAYTIEM", ctt.NGAYTIEM));
                cmd.Parameters.Add(new SqlParameter("LIEULUONG", ctt.LIEULUONG));

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
