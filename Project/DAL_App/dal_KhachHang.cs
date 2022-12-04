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

                cmdKhachHang.Parameters.Add(new SqlParameter("@cccd", khachHang.CCCD));
                cmdKhachHang.Parameters.Add(new SqlParameter("@phai", khachHang.Phai));
                cmdKhachHang.Parameters.Add(new SqlParameter("@hoVaTen", khachHang.HoVaTen));
                cmdKhachHang.Parameters.Add(new SqlParameter("@diaChi", khachHang.DiaChi));
                cmdKhachHang.Parameters.Add(new SqlParameter("@sdt", khachHang.Sdt));
                if (cmdKhachHang.ExecuteNonQuery()>0)
                {
                    return true;
                }

            }
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }
            return false;
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

                cmdKhachHang.Parameters.Add(new SqlParameter("@cccd", khachHang.CCCD));
                cmdKhachHang.Parameters.Add(new SqlParameter("@phai", khachHang.Phai));
                cmdKhachHang.Parameters.Add(new SqlParameter("@hoVaTen", khachHang.HoVaTen));
                cmdKhachHang.Parameters.Add(new SqlParameter("@diaChi", khachHang.DiaChi));
                cmdKhachHang.Parameters.Add(new SqlParameter("@sdt", khachHang.Sdt));
                if (cmdKhachHang.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
        public bool deleteKhachHang(string cCCD)
        {


            try
            {
                connection.Open();
                cmdKhachHang = new SqlCommand();
                cmdKhachHang.CommandText = "sp_DeleteKhachHang";
                cmdKhachHang.CommandType = CommandType.StoredProcedure;
                cmdKhachHang.Connection = connection;

                cmdKhachHang.Parameters.Add(new SqlParameter("@cccd", cCCD));

                if (cmdKhachHang.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
    }
}
