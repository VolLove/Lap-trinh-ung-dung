using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_App
{
    public class dto_NhanVien
    {
        private string maNV;
        private string hoNV;
        private string tenNV;
        private DateTime ngaySinh;
        private string diaChi;
        private string cCCD;
        private string sDT;
        private string phai;
        private float luong;
        private string maPhong;

        public dto_NhanVien(string maNV, string hoNV, string tenNV, DateTime ngaySinh, string diaChi, string cCCD, string sDT, string phai, float luong, string maPhong)
        {
            this.maNV = maNV;
            this.hoNV = hoNV;
            this.tenNV = tenNV;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.cCCD = cCCD;
            this.sDT = sDT;
            this.phai = phai;
            this.luong = luong;
            this.maPhong = maPhong;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoNV { get => hoNV; set => hoNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string Phai { get => phai; set => phai = value; }
        public float Luong { get => luong; set => luong = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
    }
}
