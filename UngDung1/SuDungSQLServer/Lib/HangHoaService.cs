using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungSQLServer
{
    class HangHoaService : AdapterSQL
    {
        public List<HangHoa> GetAll()
        {
            // Provide the query string with a parameter placeholder.
            List<HangHoa> lNCC = new List<HangHoa>();
            string queryString = "Select *  from HangHoa";
            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lNCC.Add(new HangHoa
                    {
                        MaHH = int.Parse(reader[0].ToString()),
                        TenHH = reader[1].ToString(),
                        MaLoai = int.Parse(reader[2].ToString()),
                        MoTaDonVi = reader[3].ToString(),
                        DonGia = float.Parse(reader[4].ToString()),
                        Hinh = reader[5].ToString(),
                        NgaySX = DateTime.Parse(reader[6].ToString()),
                        GiamGia = float.Parse(reader[7].ToString()),
                        SoLanXem = int.Parse(reader[8].ToString()),
                        MoTa = reader[9].ToString(),
                        MaNCC = reader[10].ToString()
                    });
                }
                reader.Close();
            }
            return lNCC;
        }

        public void Add(HangHoa nCC)
        {
            // Provide the query string with a parameter placeholder
            string queryString = @"insert HangHoa
(TenHH,MaLoai,MoTaDonVi,DonGia,Hinh,NgaySX,GiamGia,SoLanXem,MoTa,MaNCC       
)Values(
@MaHH,
@TenHH      ,
@MaLoai     ,
@MoTaDonVi  ,
@DonGia     ,
@Hinh       ,
@NgaySX     ,
@GiamGia    ,
@SoLanXem   ,
@MoTa       ,
@MaNCC      
)";
            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                
                command.Parameters.AddWithValue("@TenHH", nCC.TenHH);
                command.Parameters.AddWithValue("@MaLoai", nCC.MaLoai);
                command.Parameters.AddWithValue("@MoTaDonV", nCC.MoTaDonVi);
                command.Parameters.AddWithValue("@DonGia", nCC.DonGia);
                command.Parameters.AddWithValue("@Hinh", nCC.Hinh);
                command.Parameters.AddWithValue("@NgaySX", nCC.NgaySX);
                command.Parameters.AddWithValue("@GiamGia", nCC.GiamGia);
                command.Parameters.AddWithValue("@SoLanXem", nCC.SoLanXem);
                command.Parameters.AddWithValue("@MoTa", nCC.MoTa);
                command.Parameters.AddWithValue("@MaNCC", nCC.MaNCC);

                connection.Open();
                command.ExecuteNonQuery();

            }

        }

        public void Edit(HangHoa nCC)
        {
            string queryString = @"update HangHoa 
set

TenHH       =@TenHH     ,
MaLoai      =@MaLoai    ,
MoTaDonVi   =@MoTaDonVi ,
DonGia      =@DonGia    ,
Hinh        =@Hinh      ,
NgaySX      =@NgaySX    ,
GiamGia     =@GiamGia   ,
SoLanXem    =@SoLanXem  ,
MoTa        =@MoTa      ,
MaNCC       =@MaNCC     ,
Where MaHH =@MaHH
";
            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaHH", nCC.MaHH);
                command.Parameters.AddWithValue("@TenHH", nCC.TenHH);
                command.Parameters.AddWithValue("@MaLoai", nCC.MaLoai);
                command.Parameters.AddWithValue("@MoTaDonV", nCC.MoTaDonVi);
                command.Parameters.AddWithValue("@DonGia", nCC.DonGia);
                command.Parameters.AddWithValue("@Hinh", nCC.Hinh);
                command.Parameters.AddWithValue("@NgaySX", nCC.NgaySX);
                command.Parameters.AddWithValue("@GiamGia", nCC.GiamGia);
                command.Parameters.AddWithValue("@SoLanXem", nCC.SoLanXem);
                command.Parameters.AddWithValue("@MoTa", nCC.MoTa);
                command.Parameters.AddWithValue("@MaNCC", nCC.MaNCC);


                connection.Open();
                command.ExecuteNonQuery();

            }
        }

        public void Delete(HangHoa nCC)
        {
            string queryString = @"delete HangHoa Where MaHangHoa =@MaHangHoa";
            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@MaHangHoa", nCC.MaHangHoa);
                connection.Open();
                command.ExecuteNonQuery();

            }
        }

    }
}
