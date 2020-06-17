using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungSQLServer 
{
    class LoaiService : AdapterSQL
    {

        public List<Loai> GetAll()
        {
            // Provide the query string with a parameter placeholder.
            List<Loai> lNCC = new List<Loai>();
            string queryString = "Select *  from Loai";
            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lNCC.Add(new Loai
                    {
                        MaLoai = int.Parse(reader[0].ToString()),
                        TenLoai = reader[1].ToString(),
                        MoTa = reader[2].ToString(),
                        Hinh = reader[3].ToString(),
                    });
                }
                reader.Close();
            }
            return lNCC;
        }

        public void Add(Loai nCC)
        {
            // Provide the query string with a parameter placeholder
            string queryString = @"insert Loai
(TenLoai,MoTa,Hinh)Values(@TenLoai,@MoTa,@Hinh)";
            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@TenLoai", nCC.TenLoai);
                command.Parameters.AddWithValue("@MoTa", nCC.MoTa);
                command.Parameters.AddWithValue("@Hinh", nCC.Hinh);
                connection.Open();
                command.ExecuteNonQuery();

            }

        }

        public void Edit(Loai nCC)
        {
            string queryString = @"update Loai 
set
TenLoai=@TenCongTy,
Hinh =@DiaChi,
MoTa  =@MoTa
Where MaLoai =@MaLoai
";
            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaLoai", nCC.MaLoai);
                command.Parameters.AddWithValue("@TenLoai", nCC.TenLoai);
                command.Parameters.AddWithValue("@MoTa", nCC.MoTa);
                command.Parameters.AddWithValue("@Hinh", nCC.Hinh);


                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        public void Delete(Loai nCC)
        {
            string queryString = @"delete Loai Where MaLoai =@MaLoai";
            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaLoai", nCC.MaLoai);
                connection.Open();
                command.ExecuteNonQuery();

            }
        }

    }
}
