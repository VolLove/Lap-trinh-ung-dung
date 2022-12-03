using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL_App;
using DTO_App;

namespace BUS_App
{
    public class bus_KhachHang
    {
        dal_KhachHang dalKhachHang = new dal_KhachHang();
        public DataTable selectKhachHang()
        {
            return dalKhachHang.selectKhachHang();
        }
        public bool insertKhachHang(dto_KhachHang khachHang)
        {
            return dalKhachHang.insertKhachHang(khachHang);
        }
        public bool updateKhachHang(dto_KhachHang khachHang)
        {
            return dalKhachHang.updateKhachHang(khachHang) ;
        }
        public bool deletKhachHang(string cCCD)
        {
            return dalKhachHang.deleteKhachHang(cCCD);
        }
    }
}
