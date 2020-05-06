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
        private string maKH;
        private string maBS;

        public DTO_PhieuTiem()
        {

        }

        public string MAPHIEUTIEM { get => maPhieuTiem; set => maPhieuTiem = value; }
        public string MAKH { get => maKH; set => maKH = value; }
        public string MABS { get => maBS; set => maBS = value; }
    }
}
