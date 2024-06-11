using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

using Projek_Akhir_PBO.Models.Penyewa;

namespace Projek_Akhir_PBO.Controller.Penyewa
{
    internal class ReportController
    {
        private int _userId;
        public List<ReportsPy> ListLaporan = new List<ReportsPy>();
        string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=321;Database=Camping;CommandTimeout=10";
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public void Read()
        {
            //MessageBox.Show($"User ID: {_userId}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string query = string.Format(@"SELECT *
                                        FROM laporan l
                                        INNER JOIN peminjaman p on p.id_peminjaman = l.id_peminjaman
                                        WHERE l.id_penyewa=@userId");
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                conn.Open();
                using (NpgsqlCommand data = new NpgsqlCommand(query, conn))
                {
                    data.Parameters.AddWithValue("@userId", _userId);
                    NpgsqlDataReader reader = data.ExecuteReader();
                    ListLaporan.Clear();
                    while (reader.Read())
                    {
                        DateTime tanggalPeminjaman = (DateTime)reader["tanggal_peminjaman"];
                        int idPeminjaman = (int)reader["id_peminjaman"];
                        ReportsPy reportsPy = new ReportsPy();
                        reportsPy.id_laporan = (int)reader["id_laporan"];
                        reportsPy.tanggal_laporan = ((DateTime)reader["tanggallaporan"]).ToString("yyyy-MM-dd");
                        reportsPy.isi_laporan = (string)reader["isi_laporan"];
                        if (reader["isi_tanggapan"] != DBNull.Value)
                        {
                            reportsPy.isi_tanggapan = (string)reader["isi_tanggapan"];
                        }
                        else
                        {
                            reportsPy.isi_tanggapan = "Belum ada";
                        }
                        reportsPy.status_laporan_bool = (bool)reader["statuslaporan"];
                        reportsPy.status_laporan = (bool)reader["statuslaporan"] ? "Terkirim" : "Proses";
                        reportsPy.peminjaman = $"ID: {idPeminjaman} - Date: {tanggalPeminjaman:yyyy-MM-dd}";
                        ListLaporan.Add(reportsPy);
                    }
                }
            }
        }
        public void Tambah(ReportsPy reportsPy, int idPeminjaman, int idAdmin)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM laporan WHERE id_peminjaman = @id_peminjaman";
                using (NpgsqlCommand checkCmd = new NpgsqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@id_peminjaman", idPeminjaman);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Data dengan peminjaman tersebut sudah dilaporkan.", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string insertQuery = "INSERT INTO laporan (isi_laporan, tanggallaporan, statuslaporan, id_penyewa, id_admin, id_peminjaman) " +
                    "VALUES (@isi_laporan, @tanggal_laporan,@status,@id_penyewa, @id_admin, @id_peminjaman)";
                using (NpgsqlCommand insertCmd = new NpgsqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@isi_laporan", reportsPy.isi_laporan);
                    insertCmd.Parameters.AddWithValue("@tanggal_laporan", DateTime.Now);
                    insertCmd.Parameters.AddWithValue("@status", false);
                    insertCmd.Parameters.AddWithValue("@id_penyewa", _userId);
                    insertCmd.Parameters.AddWithValue("@id_admin", idAdmin);
                    insertCmd.Parameters.AddWithValue("@id_peminjaman", idPeminjaman);
                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Laporan berhasil ditambahkan.", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
