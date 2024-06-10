using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Akhir_PBO.Controller.Admin
{
    internal class LaporanController
    {
        public List<LaporanContext> LaporanOwner = new List<LaporanContext>();
        string conStr = "Server=localhost;Port=5432;User Id=postgres; Password=12345678; Database=GO-CAMP; CommandTimeout=10";

        public void Read()
        {
            string query = @"SELECT id_laporan, tanggallaporan, statuslaporan, isi_tanggapan, id_penyewa,
                                        id_admin, id_peminjaman FROM laporan;"; // Ubah tabel sesuai dengan struktur yang benar

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    LaporanOwner.Clear();
                    while (reader.Read())
                    {
                        LaporanContext laporanContext = new LaporanContext();
                        laporanContext.id_laporan = (int)reader["id_laporan"];
                        laporanContext.tanggallaporan = ((DateTime)reader["tanggallaporan"]).ToString();
                        laporanContext.statuslaporan = (string)reader["statuslaporan"];
                        laporanContext.isi_tanggapan = (string)reader["isi_tanggapan"];
                        laporanContext.id_penyewa = (int)reader["id_penyewa"];
                        laporanContext.id_admin = (int)reader["id_admin"];
                        laporanContext.id_peminjaman = (int)reader["id_peminjaman"];
                        LaporanOwner.Add(laporanContext);
                    }
                }
            }
        }
    }

    // Pastikan untuk mendefinisikan kelas LaporanContext
    public class LaporanContext
    {
        public int id_laporan { get; set; }
        public string tanggallaporan { get; set; }
        public string statuslaporan { get; set; }
        public string isi_tanggapan { get; set; }
        public int id_penyewa { get; set; }
        public int id_admin { get; set; }
        public int id_peminjaman { get; set; }
    }
}

