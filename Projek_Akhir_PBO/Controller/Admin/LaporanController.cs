using Npgsql;
using Projek_Akhir_PBO.Models.Admin;
using Projek_Akhir_PBO.Models.Penyewa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projek_Akhir_PBO.Controller.Admin
{
    internal class LaporanController
    {
        private int _userId;
        public List<LaporanContext> Laporan = new List<LaporanContext>();
        //string conStr = "Server=localhost;Port=5432;User Id=postgres; Password=12345678; Database=GO-CAMP; CommandTimeout=10";
        string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=firsta;Database=Camping;CommandTimeout=10";


        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public void Read()
        {
            string query = @"select * from penyewa p join laporan l on l.id_penyewa=p.id_penyewa join peminjaman pem on pem.id_peminjaman = l.id_peminjaman"; 

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    Laporan.Clear();
                    while (reader.Read())
                    {
                        LaporanContext reports = new LaporanContext();
                        DateTime tanggalPeminjaman = (DateTime)reader["tanggal_peminjaman"];
                        int idPeminjaman = (int)reader["id_peminjaman"];
                        reports.id_laporan = (int)reader["id_laporan"];
                        reports.tanggallaporan = ((DateTime)reader["tanggallaporan"]).ToString("yyyy-MM-dd");
                        reports.isi_laporan = (string)reader["isi_laporan"];
                        reports.nama_penyewa = (string)reader["nama_penyewa"];
                        if (reader["isi_tanggapan"] != DBNull.Value)
                        {
                            reports.isi_tanggapan = (string)reader["isi_tanggapan"];
                        }
                        else
                        {
                            reports.isi_tanggapan = "Belum ada";
                        }
                        reports.statuslaporan_bool = (bool)reader["statuslaporan"];
                        reports.statuslaporan = (bool)reader["statuslaporan"] ? "Terkirim" : "Proses";
                        reports.peminjaman = $"ID: {idPeminjaman} - Date: {tanggalPeminjaman:yyyy-MM-dd}";
                        Laporan.Add(reports);
                    }
                }
            }
        }

        public void UpdateTanggapan(LaporanContext reports, int id_laporan, string isi_tanggapan)
        {
            string query = @"UPDATE laporan SET isi_tanggapan = @isi_tanggapan WHERE id_laporan = @id_laporan";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@isi_tanggapan", reports.isi_tanggapan);
                    
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Tanggapan Berhasil Diubah", "Edit Tanggapan",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Gagal Edit Tanggapan", "Edit Tanggapan",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
        }

    }

    // Pastikan untuk mendefinisikan kelas LaporanContext
    //public class LaporanContext
    //{
    //    public int id_laporan { get; set; }
    //    public string tanggallaporan { get; set; }
    //    public string statuslaporan { get; set; }
    //    public string isi_laporan { get; set; }
    //    public string isi_tanggapan { get; set; }
    //    public int id_penyewa { get; set; }
    //    public int id_admin { get; set; }
    //    public int id_peminjaman { get; set; }
    //}
}

