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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                cmdDonHang= new SqlCommand();
                cmdDonHang.CommandText = "sp_InsertDonHang";
                cmdDonHang.CommandType = CommandType.StoredProcedure;
                cmdDonHang.Connection = connection;

                cmdDonHang.Parameters.Add(new SqlParameter("@maDH", donHang.MaDH));
                cmdDonHang.Parameters.Add(new SqlParameter("@maNV", donHang.MaNV));
                cmdDonHang.Parameters.Add(new SqlParameter("@cCCdNhan", donHang.CCCDNhan));
                cmdDonHang.Parameters.Add(new SqlParameter("@cCCdGui", donHang.CCCDGui));
                cmdDonHang.Parameters.Add(new SqlParameter("@diaChiNhan", donHang.DiaChiNhan));
                cmdDonHang.Parameters.Add(new SqlParameter("@diaChiGui", donHang.DiaChiGui));
                cmdDonHang.Parameters.Add(new SqlParameter("@mieuTa", donHang.MieuTa));
                cmdDonHang.Parameters.Add(new SqlParameter("@khoiLuong", donHang.KhoiLuong));   
                cmdDonHang.Parameters.Add(new SqlParameter("@kichThuoc", donHang.KichThuoc));
                cmdDonHang.Parameters.Add(new SqlParameter("@cuoc", donHang.Cuoc));
                if (cmdDonHang.ExecuteNonQuery()>0)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
        public bool updateDonHang(dto_DonHang donHang)
        {


            try
            {
                connection.Open();
                cmdDonHang= new SqlCommand();
                cmdDonHang.CommandText = "sp_UpdateDonHang";
                cmdDonHang.CommandType = CommandType.StoredProcedure;
                cmdDonHang.Connection = connection;

                cmdDonHang.Parameters.Add(new SqlParameter("@maDH", donHang.MaDH));
                cmdDonHang.Parameters.Add(new SqlParameter("@maNV", donHang.MaNV));
                cmdDonHang.Parameters.Add(new SqlParameter("@cCCdNhan", donHang.CCCDNhan));
                cmdDonHang.Parameters.Add(new SqlParameter("@cCCdGui", donHang.CCCDGui));
                cmdDonHang.Parameters.Add(new SqlParameter("@diaChiNhan", donHang.DiaChiNhan));
                cmdDonHang.Parameters.Add(new SqlParameter("@diaChiGui", donHang.DiaChiGui));
                cmdDonHang.Parameters.Add(new SqlParameter("@mieuTa", donHang.MieuTa));
                cmdDonHang.Parameters.Add(new SqlParameter("@khoiLuong", donHang.KhoiLuong));
                cmdDonHang.Parameters.Add(new SqlParameter("@kichThuoc", donHang.KichThuoc));
                cmdDonHang.Parameters.Add(new SqlParameter("@cuoc", donHang.Cuoc));

                if (cmdDonHang.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            {
                connection.Close();
            }
            return false;
        }
        public bool deleteDonHang(string MaDonHang)
        {


            try
            {
                connection.Open();
                cmdDonHang= new SqlCommand();
                cmdDonHang.CommandText = "sp_DeleteDonHang";
                cmdDonHang.CommandType = CommandType.StoredProcedure;
                cmdDonHang.Connection = connection;

                cmdDonHang.Parameters.Add(new SqlParameter("@maDH", MaDonHang));

                if (cmdDonHang.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            {
                connection.Close();
            }
            return false;
        }
        public DataTable sp_SearchDonHangByCC(string cCCD)
        {

            try
            {


                connection.Open();
                cmdDonHang = new SqlCommand();
                cmdDonHang.CommandText = "sp_SearchDonHangByCC";  
                cmdDonHang.CommandType = CommandType.StoredProcedure;
                cmdDonHang.Connection = connection;

                cmdDonHang.Parameters.Add(new SqlParameter("@CCCD",cCCD));

                dataAdapter = new SqlDataAdapter(cmdDonHang);
                tbDonHang = new DataTable();
                dataAdapter.Fill(tbDonHang);

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            {
                connection.Close();
            }
            return tbDonHang ;
        }
        public DataSet report()
        {
                    DataSet dataSet = new DataSet();
            try
            {
                connection.Open();
                cmdDonHang = new SqlCommand();
                cmdDonHang.CommandText = "sp_SelectDonHang";
                cmdDonHang.CommandType = CommandType.StoredProcedure;
                cmdDonHang.Connection = connection;
                dataAdapter = new SqlDataAdapter(cmdDonHang);
        
                dataAdapter.Fill(dataSet);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            {

            }
            return dataSet;
        }
        public DataTable sp_SearchDonHangByCCNhan(string cCCD)
        {

            try
            {


                connection.Open();
                cmdDonHang = new SqlCommand();
                cmdDonHang.CommandText = "sp_SearchDonHangByCCNhan";
                cmdDonHang.CommandType = CommandType.StoredProcedure;
                cmdDonHang.Connection = connection;

                cmdDonHang.Parameters.Add(new SqlParameter("@CCCD", cCCD));

                dataAdapter = new SqlDataAdapter(cmdDonHang);
                tbDonHang = new DataTable();
                dataAdapter.Fill(tbDonHang);

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            {
                connection.Close();
            }
            return tbDonHang;
        }
    }
}
