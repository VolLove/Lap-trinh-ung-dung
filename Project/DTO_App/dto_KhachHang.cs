using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_App
{
    public class dto_KhachHang
    {
        private string cCCD;
        private string phai;
        private string hoVaTen;
        private string diaChi;
        private string sdt;

       
        public dto_KhachHang()
        {
        }
        dto_DonHang _DonHang = new dto_DonHang();
        public dto_KhachHang(string cCCD, string phai, string hoVaTen, string diaChi, string sdt)
        {
            this.cCCD = cCCD.ToUpper();
            this.phai = phai;
            this.hoVaTen = hoVaTen;
            this.diaChi = diaChi;
            this.sdt = sdt;
        }

        public string CCCD { get => cCCD.ToUpper(); set => cCCD = value; }
        public string Phai { get => phai; set => phai = value; }
        public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
