using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_App
{
    public class dto_DonHang
    {
        private string maDonHang;
        private string diaChiNhan;
        private string diaChiGui;
        private string cCCDNhan;
        private string cCCDGui;
        private string mieuTa;
        private float khoiLuong;
        private float kichThuoc;
        private float cuoc;
        private string maNV;

        public dto_DonHang() { }
        public dto_DonHang(string maDonHang, string diaChiNhan, string diaChiGui, string cCCDNhan, string cCCDGui, string mieuTa, float khoiLuong, float kichThuoc, float cuoc, string maNV)
        {
            this.maDonHang = maDonHang;
            this.diaChiNhan = diaChiNhan;
            this.diaChiGui = diaChiGui;
            this.cCCDNhan = cCCDNhan;
            this.cCCDGui = cCCDGui;
            this.mieuTa = mieuTa;
            this.khoiLuong = khoiLuong;
            this.kichThuoc = kichThuoc;
            this.cuoc = cuoc;
            this.maNV = maNV;
        }

        public string MaDonHang { get => maDonHang; set => maDonHang = value; }
        public string DiaChiNhan { get => diaChiNhan; set => diaChiNhan = value; }
        public string DiaChiGui { get => diaChiGui; set => diaChiGui = value; }
        public string CCCDNhan { get => cCCDNhan; set => cCCDNhan = value; }
        public string CCCDGui { get => cCCDGui; set => cCCDGui = value; }
        public string MieuTa { get => mieuTa; set => mieuTa = value; }
        public float KhoiLuong { get => khoiLuong; set => khoiLuong = value; }
        public float KichThuoc { get => kichThuoc; set => kichThuoc = value; }
        public float Cuoc { get => cuoc; set => cuoc = value; }
        public string MaNV { get => maNV; set => maNV = value; }

        public string getMaHDAuto()
        {
            string code = "";       
            DateTime dateTime = DateTime.Now;
            code = code + "DH";
            code = code + dateTime.Day.ToString();
            code= code + dateTime.Month.ToString();
            code= code + dateTime.Year.ToString();
            code= code + dateTime.Hour.ToString();
            code= code + dateTime.Minute.ToString();
            code= code + dateTime.Second.ToString();
            code = code + this.maNV;
            return code;
        }
    }
}
