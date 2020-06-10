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
        private int muiThu;
        private string ngayTiem;
        private double lieuLuong;

        public string MAPHIEUTIEM { get => maPT; set => maPT = value; }
        public string MAVACCINE { get => maVC; set => maVC = value; }
        public int GIABAN { get => giaBan; set => giaBan = value; }
        public int MUITHU { get => muiThu; set => muiThu = value; }
        public string NGAYTIEM { get => ngayTiem; set => ngayTiem = value; }
        public double LIEULUONG { get => lieuLuong; set => lieuLuong = value; }

        public DTO_ChiTietTiem(string maPT, string maVC, int giaBan, int muiThu, string ngayTiem, double lieuLuong)
        {
            this.maPT = maPT;
            this.maVC = maVC;
            this.giaBan = giaBan;
            this.muiThu = muiThu;
            this.ngayTiem = ngayTiem;
            this.lieuLuong = lieuLuong;
        }
    }
}
