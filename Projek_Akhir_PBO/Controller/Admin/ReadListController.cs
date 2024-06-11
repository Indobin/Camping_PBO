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
            string query = string.Format(@"SELECT p.id_pemilik, p.nama_pemilik, p.no_telepon_pemilik, p.alamat_pemilik,
                            SUM(dt.lama_sewa * ac.hargaalatcamping * dt.quantity) AS total_revenue
                     FROM pemilik p
                     JOIN alat_camping ac ON p.id_pemilik = ac.id_pemilik
                     JOIN detail_transaksi dt ON ac.id_alatcamping = dt.id_alatcamping
                     JOIN peminjaman pem ON pem.id_peminjaman = dt.id_peminjaman
                     JOIN pengembalian peng ON pem.id_peminjaman = peng.id_peminjaman
                     WHERE peng.status_kembali = true
                     GROUP BY p.id_pemilik, p.nama_pemilik, p.no_telepon_pemilik, p.alamat_pemilik;");

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
                        ReadListContext listRenters = new ReadListContext();
                        long pendapatanFormat = (long)reader["total_revenue"];
                        listRenters.ID = (int)reader["id_pemilik"];
                        listRenters.Nama_Pemilik = (string)reader["nama_pemilik"];
                        listRenters.No_Telepon_Pemilik = (string)reader["no_telepon_pemilik"];
                        listRenters.Alamat_Pemilik = (string)reader["alamat_pemilik"];
                        listRenters.Pendapatan = $"Rp.{pendapatanFormat}";
                        ListOwner.Add(listRenters);
                    }
                }
            }
        }
    }
}
