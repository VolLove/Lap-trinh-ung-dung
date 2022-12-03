using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using DTO_App;


namespace DAL_App
{
    public class dal_DonHang
    {
        SqlConnection connection = new SqlConnection(new ConnectionDB().conString);
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlCommand cmdDonHang = new SqlCommand();
        DataTable tbDonHang = new DataTable();
        public DataTable selectDonHang()
        {
       

            try
            {
                connection.Open();
                cmdDonHang = new SqlCommand();
                cmdDonHang.CommandText = "sp_SelectDonHang";
                cmdDonHang.CommandType = CommandType.StoredProcedure;
                cmdDonHang.Connection = connection;

                dataAdapter = new SqlDataAdapter(cmdDonHang);
                tbDonHang = new DataTable();
                dataAdapter.Fill(tbDonHang);
            }
            catch (Exception)
            {
            }
            finally { 
                connection.Close();
            }
            return tbDonHang;
        }
        public bool insertDonHang(dto_DonHang donHang)
        {


            try
            {
                connection.Open();
                cmdDonHang = new SqlCommand();
                cmdDonHang.CommandText = "sp_InsertDonHang";
                cmdDonHang.CommandType = CommandType.StoredProcedure;
                cmdDonHang.Connection = connection;

                cmdDonHang.Parameters.Add(new SqlParameter("@maDonHang", donHang.MaDonHang));
                cmdDonHang.Parameters.Add(new SqlParameter("@diachiGui", donHang.DiaChiGui));
                cmdDonHang.Parameters.Add(new SqlParameter("@diachiNhan", donHang.DiaChiNhan));
                cmdDonHang.Parameters.Add(new SqlParameter("@diachiNhan", donHang.DiaChiGui));
                cmdDonHang.Parameters.Add(new SqlParameter("@cccdNhan", donHang.CCCDGui));
                cmdDonHang.Parameters.Add(new SqlParameter("@cccdGui", donHang.CCCDNhan));
                cmdDonHang.Parameters.Add(new SqlParameter("@mieuta", donHang.MieuTa));
                cmdDonHang.Parameters.Add(new SqlParameter("@khoiLuong", donHang.KhoiLuong));
                cmdDonHang.Parameters.Add(new SqlParameter("@KichThuoc", donHang.KichThuoc));
                cmdDonHang.Parameters.Add(new SqlParameter("@cuoc", donHang.Cuoc));
                cmdDonHang.Parameters.Add(new SqlParameter("@maNV", donHang.MaNV));


            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        public bool updateDonHang(dto_DonHang donHang)
        {


            try
            {
                connection.Open();
                cmdDonHang = new SqlCommand();
                cmdDonHang.CommandText = "sp_UpdateDonHang";
                cmdDonHang.CommandType = CommandType.StoredProcedure;
                cmdDonHang.Connection = connection;

                cmdDonHang.Parameters.Add(new SqlParameter("@maDonHang", donHang.MaDonHang));
                cmdDonHang.Parameters.Add(new SqlParameter("@diachiGui", donHang.DiaChiGui));
                cmdDonHang.Parameters.Add(new SqlParameter("@diachiNhan", donHang.DiaChiNhan));
                cmdDonHang.Parameters.Add(new SqlParameter("@diachiNhan", donHang.DiaChiGui));
                cmdDonHang.Parameters.Add(new SqlParameter("@cccdNhan", donHang.CCCDGui));
                cmdDonHang.Parameters.Add(new SqlParameter("@cccdGui", donHang.CCCDNhan));
                cmdDonHang.Parameters.Add(new SqlParameter("@mieuta", donHang.MieuTa));
                cmdDonHang.Parameters.Add(new SqlParameter("@khoiLuong", donHang.KhoiLuong));
                cmdDonHang.Parameters.Add(new SqlParameter("@KichThuoc", donHang.KichThuoc));
                cmdDonHang.Parameters.Add(new SqlParameter("@cuoc", donHang.Cuoc));
                cmdDonHang.Parameters.Add(new SqlParameter("@maNV", donHang.MaNV));


            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }
        public bool deleteDonHang(string MaDonHang)
        {


            try
            {
                connection.Open();
                cmdDonHang = new SqlCommand();
                cmdDonHang.CommandText = "sp_UpdateDonHang";
                cmdDonHang.CommandType = CommandType.StoredProcedure;
                cmdDonHang.Connection = connection;

                cmdDonHang.Parameters.Add(new SqlParameter("@maDonHang", MaDonHang));


            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
            return true;
        }

    }
}
