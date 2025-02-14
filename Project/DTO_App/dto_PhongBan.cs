﻿using System;
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
            code = code + "PB";
            DateTime dateTime = DateTime.Now;
            code += dateTime.DayOfYear.ToString();
            code += dateTime.Minute.ToString();
            code += dateTime.Second.ToString();
            return code;
        }
    }
}
