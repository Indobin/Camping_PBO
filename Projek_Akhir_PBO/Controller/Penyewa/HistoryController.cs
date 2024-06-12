using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Projek_Akhir_PBO.Models.Pemilik;
using Projek_Akhir_PBO.Models.Penyewa;
using Projek_Akhir_PBO.Tools;
using static Projek_Akhir_PBO.Models.Penyewa.HistoryDetailPy;

namespace Projek_Akhir_PBO.Controller.Penyewa
{
    internal class HistoryController
    {
        private int _userId;
        public List<HistoryPy> ListHistory = new List<HistoryPy>();
       
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public void Read()
        {
            string query = string.Format(@"SELECT pem.id_peminjaman, pe.nomor_ewallet,
       pem.tanggal_peminjaman, pem.status_pinjam, peng.tanggalpengembalian, peng.status_kembali,
       dt.lama_sewa AS total_lama_sewa, SUM(ac.hargaalatcamping * dt.quantity * dt.lama_sewa) AS total_harga_keseluruhan
        FROM penyewa p
        JOIN peminjaman pem ON p.id_penyewa = pem.id_penyewa
        JOIN detail_transaksi dt ON pem.id_peminjaman = dt.id_peminjaman
        JOIN alat_camping ac ON ac.id_alatcamping = dt.id_alatcamping
        LEFT JOIN pengembalian peng ON pem.id_peminjaman = peng.id_peminjaman
        JOIN pembayaran_ewallet pe ON pem.id_ewallet=pe.id_ewallet
        WHERE p.id_penyewa = @userId
        GROUP BY pem.id_peminjaman,
                    pem.tanggal_peminjaman, pem.status_pinjam, pe.nomor_ewallet,
                    peng.tanggalpengembalian, dt.lama_sewa, peng.status_kembali;");
            using (var db = new DBConnection())
            {
                db.Open();
                using (NpgsqlCommand data = new NpgsqlCommand(query, db.Connection))
                {
                    data.Parameters.AddWithValue("@userId", _userId);
                    NpgsqlDataReader reader = data.ExecuteReader();
                    ListHistory.Clear();
                    while (reader.Read())
                    {
                        HistoryPy historyPy = new HistoryPy();
                        historyPy.id_peminjaman = (int)reader["id_peminjaman"];
                        historyPy.tanggal_peminjaman = ((DateTime)reader["tanggal_peminjaman"]).ToString("yyyy-MM-dd");
                        historyPy.status_pinjam_bool = (bool)reader["status_pinjam"];
                        historyPy.status_pinjam = (bool)reader["status_pinjam"] ? "Terkirim" : "Proses";
                        historyPy.nomor_ewallet = (string)reader["nomor_ewallet"];
                        if (reader["tanggalpengembalian"] != DBNull.Value)
                        {
                            historyPy.tanggal_pengembalian = ((DateTime)reader["tanggalpengembalian"]).ToString("yyyy-MM-dd"); // Format return date
                        }
                        else
                        {
                            historyPy.tanggal_pengembalian = "Belum ada"; 
                        }

                        if (reader["status_kembali"] != DBNull.Value)
                        {
                            historyPy.status_kembali_bool = (bool)reader["status_kembali"];
                            historyPy.status_kembali = (bool)reader["status_kembali"] ? "Terkirim" : "Proses";
                        }
                        else
                        {
                            historyPy.status_kembali_bool = false;
                            historyPy.status_kembali = "Belum ada";
                        }
                        historyPy.lama_sewa = (int)reader["total_lama_sewa"];
                        historyPy.total_harga_keseluruhan = (long)reader["total_harga_keseluruhan"];

                        ListHistory.Add(historyPy);
                    }
                }
            }
        }
        public List<DetailPeminjaman> GetDetailPeminjaman(int idPeminjaman)
        {
            string query = @"SELECT ac.namaalatcamping, dt.quantity, ac.hargaalatcamping, (dt.quantity * ac.hargaalatcamping) as Total_Harga
                     FROM detail_transaksi dt
                     JOIN alat_camping ac ON dt.id_alatcamping = ac.id_alatcamping
                     WHERE dt.id_peminjaman = @idPeminjaman";

            List<DetailPeminjaman> details = new List<DetailPeminjaman>();

            using (var db = new DBConnection())
            {
                db.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@idPeminjaman", idPeminjaman);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DetailPeminjaman detail = new DetailPeminjaman
                        {
                            NamaAlatCamping = reader["namaalatcamping"].ToString(),
                            Quantity = (int)reader["quantity"],
                            HargaAlatCamping = (int)reader["hargaalatcamping"],
                            Total_Harga = (int)reader["Total_Harga"]
                        };
                        details.Add(detail);
                    }
                }
            }
            return details;
        }
    }
}
