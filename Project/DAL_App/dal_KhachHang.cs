using DTO_App;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL_App
{
    public class dal_KhachHang
    {
        SqlConnection connection = new SqlConnection(new ConnectionDB().conString);

        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlCommand cmdKhachHang = new SqlCommand();
        DataTable tbKhachHang = new DataTable();
        public DataTable selectKhachHang()
        {

            try
            {
                connection.Open();
                cmdKhachHang = new SqlCommand();
                cmdKhachHang.CommandText = "sp_SelectKhachHang";
                cmdKhachHang.CommandType = CommandType.StoredProcedure;
                cmdKhachHang.Connection = connection;

                dataAdapter = new SqlDataAdapter(cmdKhachHang);
                tbKhachHang = new DataTable();
                dataAdapter.Fill(tbKhachHang);
            }
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }
            return tbKhachHang;
        }
        public bool insertKhachHang(dto_KhachHang khachHang)
        {


            try
            {
                connection.Open();
                cmdKhachHang = new SqlCommand();
                cmdKhachHang.CommandText = "sp_InsertKhachHang";
                cmdKhachHang.CommandType = CommandType.StoredProcedure;
                cmdKhachHang.Connection = connection;

                cmdKhachHang.Parameters.Add(new SqlParameter("@CanCuoc", khachHang.CCCD));
                cmdKhachHang.Parameters.Add(new SqlParameter("@hovaten", khachHang.CCCD));
                cmdKhachHang.Parameters.Add(new SqlParameter("@diaChi", khachHang.CCCD));
                cmdKhachHang.Parameters.Add(new SqlParameter("@sdt", khachHang.CCCD));


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
        public bool updateKhachHang(dto_KhachHang khachHang)
        {


            try
            {
                connection.Open();
                cmdKhachHang = new SqlCommand();
                cmdKhachHang.CommandText = "sp_UpdateKhachHang";
                cmdKhachHang.CommandType = CommandType.StoredProcedure;
                cmdKhachHang.Connection = connection;

                cmdKhachHang.Parameters.Add(new SqlParameter("@CanCuoc", khachHang.CCCD));
                cmdKhachHang.Parameters.Add(new SqlParameter("@hovaten", khachHang.CCCD));
                cmdKhachHang.Parameters.Add(new SqlParameter("@diaChi", khachHang.CCCD));
                cmdKhachHang.Parameters.Add(new SqlParameter("@sdt", khachHang.CCCD));


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
        public bool deleteKhachHang(string cCCD)
        {


            try
            {
                connection.Open();
                cmdKhachHang = new SqlCommand();
                cmdKhachHang.CommandText = "sp_UpdateDonHang";
                cmdKhachHang.CommandType = CommandType.StoredProcedure;
                cmdKhachHang.Connection = connection;

                cmdKhachHang.Parameters.Add(new SqlParameter("@CanCuoc", cCCD));


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
