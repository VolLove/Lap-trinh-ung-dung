using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_App
{
    public class dto_DonHang
    {
        private string maDH;
        private string maNV;
        private string cCCDNhan;
        private string cCCDGui;
        private string diaChiNhan;
        private string diaChiGui;
        private string mieuTa;
        private double khoiLuong;
        private double kichThuoc;
        private double cuoc;

        public dto_DonHang() { }

        public dto_DonHang(string maDH, string maNV, string cCCDNhan, string cCCDGui, string diaChiNhan, string diaChiGui, string mieuTa, double khoiLuong, double kichThuoc, double cuoc)
        {
            this.maDH = maDH;
            this.maNV = maNV;
            this.cCCDNhan = cCCDNhan;
            this.cCCDGui = cCCDGui;
            this.diaChiNhan = diaChiNhan;
            this.diaChiGui = diaChiGui;
            this.mieuTa = mieuTa;
            this.khoiLuong = khoiLuong;
            this.kichThuoc = kichThuoc;
            this.cuoc = cuoc;
        }

        public string MaDH { get => maDH; set => maDH = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string CCCDNhan { get => cCCDNhan; set => cCCDNhan = value; }
        public string CCCDGui { get => cCCDGui; set => cCCDGui = value; }
        public string DiaChiNhan { get => diaChiNhan; set => diaChiNhan = value; }
        public string DiaChiGui { get => diaChiGui; set => diaChiGui = value; }
        public string MieuTa { get => mieuTa; set => mieuTa = value; }
        public double KhoiLuong { get => khoiLuong; set => khoiLuong = value; }
        public double KichThuoc { get => kichThuoc; set => kichThuoc = value; }
        public double Cuoc { get => cuoc; set => cuoc = value; }

        public string getMaHDAuto()
        {
            string code = "HD";       
            DateTime dateTime = DateTime.Now;
            code += dateTime.DayOfYear.ToString();
            code += dateTime.Minute.ToString();
            code += dateTime.Second.ToString();
            return code;
        }
    }
}
