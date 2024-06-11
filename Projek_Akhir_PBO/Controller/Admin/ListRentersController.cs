using Npgsql;
using Projek_Akhir_PBO.Models.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Akhir_PBO.Controller.Admin
{
    internal class ListRentersController
    {
        public List<ListRentersContext> ListRenters = new List<ListRentersContext>();
        string conStr = "Server=localhost;Port=5432;User Id=postgres; Password=12345678 ;Database=GO-CAMP;CommandTimeout=10";
        public void Read()
        {
            string query = string.Format(@"select p.id_penyewa, p.nama_penyewa, p.alamat_penyewa, p.no_telepon_penyewa, count(id_peminjaman) as jumlah_peminjaman
                                            from penyewa p
                                            join peminjaman pm on pm.id_penyewa=p.id_penyewa
                                            group by p.id_penyewa, p.nama_penyewa, p.alamat_penyewa, p.no_telepon_penyewa");

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.CommandText = query;
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    ListRenters.Clear();
                    while (reader.Read())
                    {
                        ListRentersContext listRenters = new ListRentersContext();
                        listRenters.ID = (int)reader["id_penyewa"];
                        listRenters.Nama_Penyewa = (string)reader["nama_penyewa"];
                        listRenters.no_telepon_penyewa = (string)reader["no_telepon_penyewa"];
                        listRenters.alamat_penyewa = (string)reader["alamat_penyewa"];;
                        listRenters.jumlah_peminjaman = (long)reader["jumlah_peminjaman"];
                        ListRenters.Add(listRenters);
                    }
                }
            }
        }
    }
}
