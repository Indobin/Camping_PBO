using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Projek_Akhir_PBO.Models.Pemilik;

namespace Projek_Akhir_PBO.Controller.Pemilik
{
    internal class RentersController
    {
        private int _userId;
        public List<Renters> ListRenters = new List<Renters>();
        string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=321;Database=Camping;CommandTimeout=10";

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public void Read()
        {
            string query = @"SELECT p.id_peminjaman, r.nama_penyewa, r.no_telepon_penyewa, r.alamat_penyewa, p.tanggal_peminjaman, p.status_pinjam
                         FROM penyewa r
                         JOIN peminjaman p on r.id_penyewa = p.id_penyewa
                         JOIN detail_transaksi dt on dt.id_peminjaman = p.id_peminjaman
                         JOIN Alat_Camping ac on ac.id_AlatCamping = dt.id_AlatCamping
                         JOIN pemilik pe on pe.id_pemilik = ac.id_pemilik
                         WHERE pe.id_pemilik = @userId
                         ORDER BY p.tanggal_peminjaman ASC;";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                conn.Open();
                using (NpgsqlCommand data = new NpgsqlCommand(query, conn))
                {
                    data.Parameters.AddWithValue("@userId", _userId);
                    NpgsqlDataReader reader = data.ExecuteReader();
                    ListRenters.Clear();
                    while (reader.Read())
                    {
                        Renters renters = new Renters();
                        renters.id_peminjaman = (int)reader["id_peminjaman"];
                        renters.nama_penyewa = (string)reader["nama_penyewa"];
                        renters.no_telepon_penyewa = (string)reader["no_telepon_penyewa"];
                        renters.alamat_penyewa = (string)reader["alamat_penyewa"];
                        renters.tanggal_peminjaman = (DateTime)reader["tanggal_peminjaman"];
                        renters.status_pinjam = (bool)reader["status_pinjam"];
                        renters.status = (bool)reader["status_pinjam"] ? "Diterima" : "Proses";
                        ListRenters.Add(renters);
                        
                    }
                }
            }
        }

        public void Edit(Renters renters, bool status_pinjam)
        {
            string query = @"UPDATE peminjaman SET status_pinjam=@status_pinjam WHERE id_peminjaman=@id_peminjaman";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@status_pinjam", status_pinjam);
                    cmd.Parameters.AddWithValue("@id_peminjaman", renters.id_peminjaman);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
