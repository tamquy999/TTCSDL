using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuTiem
    {
        private string tenKH;
        private string ngaySinh;
        private string gioiTinh;
        private string tienSu;
        private string maVC;
        private string loaiTiem;
        private string ngayTiem;
        private string maBS;

        public DTO_PhieuTiem()
        {

        }

        public string TENKH { get => tenKH; set => tenKH = value; }
        public string NGAYSINH { get => ngaySinh; set => ngaySinh = value; }
        public string GIOITINH { get => gioiTinh; set => gioiTinh = value; }
        public string TIEUSU { get => tienSu; set => tienSu = value; }
        public string MAVACCINE { get => maVC; set => maVC = value; }
        public string LOAITIEMCHUNG { get => loaiTiem; set => loaiTiem = value; }
        public string NGAYTIEM { get => ngayTiem; set => ngayTiem = value; }
        public string MABS { get => maBS; set => maBS = value; }
    }
}
