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
        private string loaiTiemChung;
        private string ngayDangKy;
        private string ngayHenTiem;
        private string ghiChu;
        private string maKH;
        private string maHD;
        private string maBS;
        private string maVC;
        private string giaBan;

        public string MaPhieuTiem { get => maPhieuTiem; set => maPhieuTiem = value; }
        public string LoaiTiemChung { get => loaiTiemChung; set => loaiTiemChung = value; }
        public string NgayDangKy { get => ngayDangKy; set => ngayDangKy = value; }
        public string NgayHenTiem { get => ngayHenTiem; set => ngayHenTiem = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string MaHD { get => maHD; set => maHD = value; }
        public string MaBS { get => maBS; set => maBS = value; }
        public string MaVC { get => maVC; set => maVC = value; }
        public string GiaBan { get => giaBan; set => giaBan = value; }

        public DTO_PhieuTiem(string maPhieuTiem, string loaiTiemChung, string ngayDangKy, string ngayHenTiem, string ghiChu, string maKH, string maHD, string maBS, string maVC, string giaBan)
        {
            this.maPhieuTiem = maPhieuTiem;
            this.loaiTiemChung = loaiTiemChung;
            this.ngayDangKy = ngayDangKy;
            this.ngayHenTiem = ngayHenTiem;
            this.ghiChu = ghiChu;
            this.maKH = maKH;
            this.maHD = maHD;
            this.maBS = maBS;
            this.maVC = maVC;
            this.giaBan = giaBan;
        }

        public DTO_PhieuTiem()
        {

        }
    }
}
