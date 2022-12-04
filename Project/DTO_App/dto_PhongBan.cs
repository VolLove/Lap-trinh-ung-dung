using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO_App
{
    public class dto_PhongBan
    {
        private string maPhong;
        private string maQL;
        private string tenPhong;

        public dto_PhongBan()
        {

        }
        public dto_PhongBan(string maPhong, string maQL, string tenPhong)
        {
            this.maPhong = maPhong;
            this.maQL = maQL;
            this.tenPhong = tenPhong;
        }

        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string MaQL { get => maQL; set => maQL = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string GetMaPhongAuto()
        {
            string code = "";
            DateTime dateTime = DateTime.Now;
            code = code + "PB";
            code = code + dateTime.Day.ToString();
            code = code + dateTime.Month.ToString();
            code = code + dateTime.Year.ToString();
            code = code + dateTime.Hour.ToString();
            code = code + dateTime.Minute.ToString();
            code = code + dateTime.Second.ToString();
            return code;
        }
    }
}
