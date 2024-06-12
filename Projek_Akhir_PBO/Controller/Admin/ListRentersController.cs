using Npgsql;
using Projek_Akhir_PBO.Models.Admin;
using Projek_Akhir_PBO.Tools;
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
  

        public void Read()
        {
            string query = string.Format(@"select p.id_penyewa, p.nama_penyewa, p.alamat_penyewa, p.no_telepon_penyewa, count(id_peminjaman) as jumlah_peminjaman
                                            from penyewa p
                                            join peminjaman pm on pm.id_penyewa=p.id_penyewa
                                            group by p.id_penyewa, p.nama_penyewa, p.alamat_penyewa, p.no_telepon_penyewa");

            using (var db = new DBConnection())
            {
                db.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, db.Connection))
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
