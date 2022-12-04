using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_App;
using DAL_App;
using System.Data;

namespace BUS_App
{
    public class bus_DonHang
    {
        dal_DonHang daldonHang = new dal_DonHang();
        public DataTable selectDonHang()
        {
            return daldonHang.selectDonHang();
        }
        public bool insertDonHang(dto_DonHang donHang)
        {
            return daldonHang.insertDonHang(donHang);
        }
        public bool updateDonHang(dto_DonHang donHang)
        {
            return daldonHang.updateDonHang(donHang);
        }
        public bool deleteDonHang(string maDonHang)
        {
            return daldonHang.deleteDonHang(maDonHang);
        }
    }
}
