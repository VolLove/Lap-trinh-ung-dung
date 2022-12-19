using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using DTO_App;
using System.Text;
using System.Data;

namespace DAL_App
{
    public class dal_NhanVien
    {
        SqlConnection connection = new SqlConnection(new ConnectionDB().conString);
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlCommand cmdNhanVien = new SqlCommand();
        DataTable tbNhanVien = new DataTable();
        public DataTable selectNhanVien()
        {


            try
            {
                connection.Open();
                cmdNhanVien = new SqlCommand();
                cmdNhanVien.CommandText = "sp_SelectNhanVien";
                cmdNhanVien.CommandType = CommandType.StoredProcedure;
                cmdNhanVien.Connection = connection;

                dataAdapter = new SqlDataAdapter(cmdNhanVien);
                tbNhanVien = new DataTable();
                dataAdapter.Fill(tbNhanVien);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            {
                connection.Close();
            }
            return tbNhanVien;
        }
        public bool insertNhanVien(dto_NhanVien nhanVien)
        {


            try
            {
                connection.Open();
                cmdNhanVien = new SqlCommand();
                cmdNhanVien.CommandText = "sp_InsertNhanVien";
                cmdNhanVien.CommandType = CommandType.StoredProcedure;
                cmdNhanVien.Connection = connection;

                cmdNhanVien.Parameters.Add(new SqlParameter("@maNV", nhanVien.MaNV));
                cmdNhanVien.Parameters.Add(new SqlParameter("@hoVaTen", nhanVien.HoVaTenNV));
                cmdNhanVien.Parameters.Add(new SqlParameter("@ngaySinh", nhanVien.NgaySinh));
                cmdNhanVien.Parameters.Add(new SqlParameter("@diaChi", nhanVien.DiaChi));
                cmdNhanVien.Parameters.Add(new SqlParameter("@cCCD", nhanVien.CCCD));
                cmdNhanVien.Parameters.Add(new SqlParameter("@sdt", nhanVien.SDT));
                cmdNhanVien.Parameters.Add(new SqlParameter("@phai", nhanVien.Phai));
                cmdNhanVien.Parameters.Add(new SqlParameter("@luong", nhanVien.Luong));
                cmdNhanVien.Parameters.Add(new SqlParameter("@maPhong", nhanVien.MaPhong));
                if (cmdNhanVien.ExecuteNonQuery()>0)
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
        public bool updateNhanVien(dto_NhanVien nhanVien)
        {


            try
            {
                connection.Open();
                cmdNhanVien = new SqlCommand();
                cmdNhanVien.CommandText = "sp_UpdateNhanVien";
                cmdNhanVien.CommandType = CommandType.StoredProcedure;
                cmdNhanVien.Connection = connection;

                cmdNhanVien.Parameters.Add(new SqlParameter("@maNV", nhanVien.MaNV));
                cmdNhanVien.Parameters.Add(new SqlParameter("@hoVaTen", nhanVien.HoVaTenNV));
                cmdNhanVien.Parameters.Add(new SqlParameter("@ngaySinh", nhanVien.NgaySinh));
                cmdNhanVien.Parameters.Add(new SqlParameter("@diaChi", nhanVien.DiaChi));
                cmdNhanVien.Parameters.Add(new SqlParameter("@cCCD", nhanVien.CCCD));
                cmdNhanVien.Parameters.Add(new SqlParameter("@sdt", nhanVien.SDT));
                cmdNhanVien.Parameters.Add(new SqlParameter("@phai", nhanVien.Phai));
                cmdNhanVien.Parameters.Add(new SqlParameter("@luong", nhanVien.Luong));
                cmdNhanVien.Parameters.Add(new SqlParameter("@maPhong", nhanVien.MaPhong));
                if (cmdNhanVien.ExecuteNonQuery() > 0)
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
        public bool deleteNhanVien(string maNV)
        {


            try
            {
                connection.Open();
                cmdNhanVien = new SqlCommand();
                cmdNhanVien.CommandText = "sp_DeleteNhanVien";
                cmdNhanVien.CommandType = CommandType.StoredProcedure;
                cmdNhanVien.Connection = connection;

                cmdNhanVien.Parameters.Add(new SqlParameter("@manv", maNV));
                if (cmdNhanVien.ExecuteNonQuery() > 0)
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

    }
}
