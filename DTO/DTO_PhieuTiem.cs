using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuTiem
    {
        private string maPhieuTiem;
        private string ngayTiem;
        private string maKH;
        private string maBS;
        private int daTiem;

        public DTO_PhieuTiem(string maPhieuTiem, string ngayTiem, string maKH, string maBS, int daTiem)
        {
            this.maPhieuTiem = maPhieuTiem;
            this.ngayTiem = ngayTiem;
            this.MAKH = maKH;
            this.maBS = maBS;
            this.daTiem = daTiem;
        }

        public string MAPHIEUTIEM { get => maPhieuTiem; set => maPhieuTiem = value; }
        public string NGAYTIEM { get => ngayTiem; set => ngayTiem = value; }
        public string MAKH { get => maKH; set => maKH = value; }
        public string MABS { get => maBS; set => maBS = value; }
        public int DATIEM { get => daTiem; set => daTiem = value; }
    }
}
