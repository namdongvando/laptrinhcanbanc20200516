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


        public List<NhaCungCap> GetAll() {
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

    }
}
