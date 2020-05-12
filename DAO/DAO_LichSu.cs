using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_LichSu : DBProvider
    {
        public DataTable getAllLichSu(string maKH)
        {
            string query = @"SELECT ctt.NGAYTIEM, vc.TENVACCINE, ctt.LIEULUONG, vc.CHIDINH, vc.DONGIA
                        FROM dbo.KHACHHANG kh INNER JOIN dbo.PHIEUTIEM pt INNER JOIN dbo.CHITIETTIEM ctt INNER JOIN dbo.VACCINE vc
                        ON vc.MAVACCINE = ctt.MAVACCINE
                        ON ctt.MAPHIEUTIEM = pt.MAPHIEUTIEM
                        ON pt.MAKH = kh.MAKH
                        WHERE kh.MAKH = @MAKH";

            SqlDataAdapter da = new SqlDataAdapter(query, _conn);

            da.SelectCommand.Parameters.AddWithValue("@MAKH", maKH);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
