using DAL_App;
using DTO_App;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BUS_App
{
    public class bus_PhongBan
    {
        dal_PhongBan dalPhongBan = new dal_PhongBan();
        public DataTable selectPhongBan()
        {
            return dalPhongBan.selectPhongBan();
        }
        public bool insertPhongBan(dto_PhongBan phongBan)
        {
            return dalPhongBan.insertPhongBan(phongBan);
        }
        public bool updatePhongBan(dto_PhongBan phongBan)
        {
            return dalPhongBan.updateDonHang(phongBan);
        }
        public bool deletKhachHang(string cCCD)
        {
            return dalPhongBan.deleteDonHang(cCCD);
        }
    }
}
