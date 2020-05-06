using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietTiem
    {
        private string maPT;
        private string maVC;
        private int giaBan;
        private string loaiTiem;
        private string ngayTiem;
        private double lieuLuong;

        public string MAPHIEUTIEM { get => maPT; set => maPT = value; }
        public string MAVACCINE { get => maVC; set => maVC = value; }
        public int GIABAN { get => giaBan; set => giaBan = value; }
        public string LOAITIEMCHUNG { get => loaiTiem; set => loaiTiem = value; }
        public string NGAYTIEM { get => ngayTiem; set => ngayTiem = value; }
        public double LIEULUONG { get => lieuLuong; set => lieuLuong = value; }

        public DTO_ChiTietTiem(string maPT, string maVC, int giaBan, string loaiTiem, string ngayTiem, double lieuLuong)
        {
            this.maPT = maPT;
            this.maVC = maVC;
            this.giaBan = giaBan;
            this.loaiTiem = loaiTiem;
            this.ngayTiem = ngayTiem;
            this.lieuLuong = lieuLuong;
        }
    }
}
