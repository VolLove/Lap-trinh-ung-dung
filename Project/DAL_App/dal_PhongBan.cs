using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using DTO_App;

namespace DAL_App
{
    public class dal_PhongBan
    {
        SqlConnection connection = new SqlConnection(new ConnectionDB().conString);
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        SqlCommand cmdPhongBan = new SqlCommand();
        DataTable tbPhongBan = new DataTable();
        public DataTable selectPhongBan()
        {


            try
            {
                connection.Open();
                cmdPhongBan = new SqlCommand();
                cmdPhongBan.CommandText = "sp_SelectPhongBan";
                cmdPhongBan.CommandType = CommandType.StoredProcedure;
                cmdPhongBan.Connection = connection;

                dataAdapter = new SqlDataAdapter(cmdPhongBan);
                tbPhongBan = new DataTable();
                dataAdapter.Fill(tbPhongBan);
            }
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }
            return tbPhongBan;
        }
        public bool insertPhongBan(dto_PhongBan phongBan)
        {


            try
            {
                connection.Open();
                cmdPhongBan = new SqlCommand();
                cmdPhongBan.CommandText = "sp_InsertPhongBan";
                cmdPhongBan.CommandType = CommandType.StoredProcedure;
                cmdPhongBan.Connection = connection;


                cmdPhongBan.Parameters.Add(new SqlParameter("@maPhong", phongBan.MaPhong));
                cmdPhongBan.Parameters.Add(new SqlParameter("@maQL", phongBan.MaQL));
                cmdPhongBan.Parameters.Add(new SqlParameter("@tenPhong", phongBan.TenPhong));

                if (cmdPhongBan.ExecuteNonQuery()>0)
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
        public bool updateDonHang(dto_PhongBan phongBan)
        {


            try
            {
                connection.Open();
                cmdPhongBan = new SqlCommand();
                cmdPhongBan.CommandText = "sp_UpdatePhongBan";
                cmdPhongBan.CommandType = CommandType.StoredProcedure;
                cmdPhongBan.Connection = connection;

                cmdPhongBan.Parameters.Add(new SqlParameter("@maPhong", phongBan.MaPhong));
                cmdPhongBan.Parameters.Add(new SqlParameter("@maQL", phongBan.MaQL));
                cmdPhongBan.Parameters.Add(new SqlParameter("@tenPhong", phongBan.TenPhong));

                if (cmdPhongBan.ExecuteNonQuery() > 0)
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
        public bool deleteDonHang(string maPhong)
        {


            try
            {
                connection.Open();
                cmdPhongBan = new SqlCommand();
                cmdPhongBan.CommandText = "sp_DeletePhongBan";
                cmdPhongBan.CommandType = CommandType.StoredProcedure;
                cmdPhongBan.Connection = connection;

                cmdPhongBan.Parameters.Add(new SqlParameter("@maPhong", maPhong));

                if (cmdPhongBan.ExecuteNonQuery() > 0)
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
