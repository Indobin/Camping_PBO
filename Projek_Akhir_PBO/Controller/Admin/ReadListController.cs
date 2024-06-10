using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Projek_Akhir_PBO.Models.Admin;
using Projek_Akhir_PBO.Models.Pemilik;

namespace Projek_Akhir_PBO.Controller.Admin
{
    internal class ReadListController
    {
        public List<ReadListContext> ListOwner = new List<ReadListContext>();
        string conStr = "Server=localhost;Port=5432;User Id=postgres; Password=12345678 ;Database=GO-CAMP;CommandTimeout=10";
        public void Read()
        {
            string query = string.Format(@"SELECT id_pemilik, nama_pemilik, no_telepon_pemilik, alamat_pemilik
                                FROM pemilik;");

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.CommandText = query;
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    ListOwner.Clear();
                    while (reader.Read())
                    {
                        ReadListContext readListContext = new ReadListContext();
                        readListContext.id_pemilik = (int)reader["id_pemilik"];
                        readListContext.nama_pemilik = (string)reader["nama_pemilik"];
                        readListContext.no_telepon_pemilik = (string)reader["no_telepon_pemilik"];
                        readListContext.alamat_pemilik = (string)reader["alamat_pemilik"];
                        ListOwner.Add(readListContext);
                    }
                }
            }
        }
    }
}
