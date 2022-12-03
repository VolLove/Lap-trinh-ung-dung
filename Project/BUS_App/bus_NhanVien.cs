using DAL_App;
using DTO_App;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS_App
{
    public class bus_NhanVien
    {
        dal_NhanVien dalNhanVien = new dal_NhanVien();
        public DataTable selectNhanVien()
        {
            return dalNhanVien.selectNhanVien();
        }
        public bool insertNhanVien(dto_NhanVien nhanVien)
        {
            return dalNhanVien.insertNhanVien(nhanVien);
        }
        public bool updateKhachHang(dto_NhanVien _NhanVien)
        {
            return dalNhanVien.updateNhanVien(_NhanVien);
        }
        public bool deletKhachHang(string maNV)
        {
            return dalNhanVien.deleteNhanVien(maNV);
        }
    }
}
