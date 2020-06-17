using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungSQLServer
{
    class NhaCungCapService : AdapterSQL
    {


        public List<NhaCungCap> GetAll()
        {
            // Provide the query string with a parameter placeholder.
            List<NhaCungCap> lNCC = new List<NhaCungCap>();
            string queryString = "Select *  from NhaCungCap";
            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lNCC.Add(new NhaCungCap
                    {
                        MaNCC = reader[0].ToString(),
                        TenCongTy = reader[1].ToString(),
                        Logo = reader[2].ToString(),
                        NguoiLienLac = reader[3].ToString(),
                        Email = reader[4].ToString(),
                        DienThoai = reader[5].ToString(),
                        DiaChi = reader[6].ToString(),
                        MoTa = reader[7].ToString(),

                    });
                }
                reader.Close();
            }
            return lNCC;
        }

        public void Add(NhaCungCap nCC)
        {
            // Provide the query string with a parameter placeholder.

            string queryString = @"insert NhaCungCap
(
MaNCC,
TenCongTy,Logo,NguoiLienLac,
Email,DienThoai,
DiaChi,MoTa
)Values(@MaNCC,@TenCongTy,
@Logo,@NguoiLienLac,@Email,@DienThoai,
@DiaChi,@MoTa)";
            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaNCC", nCC.MaNCC);
                command.Parameters.AddWithValue("@TenCongTy", nCC.TenCongTy);
                command.Parameters.AddWithValue("@DiaChi", nCC.DiaChi);
                command.Parameters.AddWithValue("@NguoiLienLac", nCC.NguoiLienLac);
                command.Parameters.AddWithValue("@Email", nCC.Email);
                command.Parameters.AddWithValue("@DienThoai", nCC.DienThoai);
                command.Parameters.AddWithValue("@MoTa", nCC.MoTa);
                command.Parameters.AddWithValue("@Logo", nCC.Logo);

                connection.Open();
                command.ExecuteNonQuery();

            }

        }

        public void Edit(NhaCungCap nCC)
        {
            string queryString = @"update NhaCungCap 
set
TenCongTy=@TenCongTy,
Logo =@Logo,
NguoiLienLac =@NguoiLienLac,
Email = @Email,
DienThoai =@DienThoai,
DiaChi =@DiaChi,
MoTa  =@MoTa
Where MaNCC =@MaNCC
";
            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaNCC", nCC.MaNCC);
                command.Parameters.AddWithValue("@TenCongTy", nCC.TenCongTy);
                command.Parameters.AddWithValue("@DiaChi", nCC.DiaChi);
                command.Parameters.AddWithValue("@NguoiLienLac", nCC.NguoiLienLac);
                command.Parameters.AddWithValue("@Email", nCC.Email);
                command.Parameters.AddWithValue("@DienThoai", nCC.DienThoai);
                command.Parameters.AddWithValue("@MoTa", nCC.MoTa);
                command.Parameters.AddWithValue("@Logo", nCC.Logo);

                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        public void Delete(NhaCungCap nCC)
        {
            string queryString = @"delete NhaCungCap Where MaNCC =@MaNCC ";
            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaNCC", nCC.MaNCC);
                connection.Open();
                command.ExecuteNonQuery();

            }
        }
    }
}
