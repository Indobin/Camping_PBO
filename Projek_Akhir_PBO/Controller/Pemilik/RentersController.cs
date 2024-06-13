using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Projek_Akhir_PBO.Models.Pemilik;
using Projek_Akhir_PBO.Models.Penyewa;
using Projek_Akhir_PBO.Tools;

namespace Projek_Akhir_PBO.Controller.Pemilik
{
    internal class RentersController
    {
        private int _userId;
        public List<Renters> ListRenters = new List<Renters>();
       
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public void Read()
        {
            string query = @"SELECT p.id_peminjaman, r.nama_penyewa, pe.nomor_ewallet, p.tanggal_peminjaman, 
                             p.status_pinjam, peng.tanggalpengembalian, peng.status_kembali,
                             SUM(ac.hargaalatcamping * dt.quantity * dt.lama_sewa) AS total_harga_keseluruhan
                             FROM penyewa r
                             JOIN peminjaman p ON r.id_penyewa = p.id_penyewa
                             JOIN detail_transaksi dt ON dt.id_peminjaman = p.id_peminjaman
                             JOIN alat_camping ac ON ac.id_alatcamping = dt.id_alatcamping
                             LEFT JOIN pengembalian peng ON p.id_peminjaman = peng.id_peminjaman
                             JOIN pembayaran_ewallet pe ON p.id_ewallet = pe.id_ewallet
                             JOIN pemilik pem ON pem.id_pemilik = ac.id_pemilik
                             WHERE pem.id_pemilik = @userId  AND (p.status_pinjam = true OR p.status_pinjam = false) 
    						 AND (peng.status_kembali IS NULL OR peng.status_kembali = false)
                             GROUP BY p.id_peminjaman, r.nama_penyewa, pe.nomor_ewallet, p.tanggal_peminjaman, 
                             p.status_pinjam, peng.tanggalpengembalian, peng.status_kembali, dt.lama_sewa
                             ORDER BY p.tanggal_peminjaman ASC;";

            using (var db = new DBConnection())
            {
                db.Open();
                using (NpgsqlCommand data = new NpgsqlCommand(query, db.Connection))
                {
                    data.Parameters.AddWithValue("@userId", _userId);
                    NpgsqlDataReader reader = data.ExecuteReader();
                    ListRenters.Clear();
                    while (reader.Read())
                    {
                        Renters renters = new Renters();
                        renters.id_peminjaman = (int)reader["id_peminjaman"];
                        renters.nama_penyewa = (string)reader["nama_penyewa"];
                        renters.nomor_ewallet = (string)reader["nomor_ewallet"];
                        renters.tanggal_peminjaman = ((DateTime)reader["tanggal_peminjaman"]).ToString("yyyy-MM-dd");
                        renters.status_pinjam = (bool)reader["status_pinjam"];
                        renters.status_pinjam_string = (bool)reader["status_pinjam"] ? "Terkirim" : "Proses";
                        renters.total_harga_keseluruhan = (long)reader["total_harga_keseluruhan"];
                        if (reader["tanggalpengembalian"] != DBNull.Value)
                        {
                            renters.tanggalpengembalian = ((DateTime)reader["tanggalpengembalian"]).ToString("yyyy-MM-dd"); // Format return date
                        }
                        else
                        {
                            renters.tanggalpengembalian = "Belum ada";
                        }
                       
                        if (reader["status_kembali"] != DBNull.Value)
                        {
                            renters.status_kembali = (bool?)reader["status_kembali"];
                            renters.status_kembali_string = renters.status_kembali.GetValueOrDefault() ? "Diterima" : "Proses";
                        }
                        else
                        {
                            renters.status_kembali = false;
                            renters.status_kembali_string = "Proses";
                        }
                      
                        ListRenters.Add(renters);
                    }
                }
            }
        }
        public void UpdateStatusPinjam(Renters renters)
        {
            if (renters.status_pinjam)
            {
                string query = @"UPDATE peminjaman SET status_pinjam = @status_pinjam WHERE id_peminjaman = @id_peminjaman";
                using (var db = new DBConnection())
                {
                    db.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, db.Connection))
                    {
                        cmd.Parameters.AddWithValue("@status_pinjam", renters.status_pinjam);
                        cmd.Parameters.AddWithValue("@id_peminjaman", renters.id_peminjaman);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("status peminjaman berhasil diedit.", "Edit Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Status tidak dapat diubah kembali", "Edit Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void UpdateStatusKembali(int id_peminjaman, bool status_kembali, bool status_pinjam)
        {
            if (status_pinjam)
            {
                if (status_kembali)
                {
                    string query = @"Insert into pengembalian (tanggalpengembalian, status_kembali, id_peminjaman)
                                     Values(@tanggalpengembalian, @status_kembali, @id_peminjaman )";
                    using (var db = new DBConnection())
                    {
                        db.Open();
                        using (NpgsqlCommand cmd = new NpgsqlCommand(query, db.Connection))
                        {
                            cmd.Parameters.AddWithValue("@status_kembali", status_kembali);
                            cmd.Parameters.AddWithValue("@tanggalpengembalian", DateTime.Now);
                            cmd.Parameters.AddWithValue("@id_peminjaman", id_peminjaman);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Status pengembalian berhasil diedit.", "Edit Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Status pengembalian tidak dapat diubah kembali.", "Edit Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Peminjaman belum terkirim.", "Edit Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public List<RentersDetail> GetDetailPeminjaman(int idPeminjaman)
        {
            string query = @"SELECT ac.namaalatcamping, dt.quantity, ac.hargaalatcamping, (dt.quantity * ac.hargaalatcamping) AS Total_Harga
                             FROM detail_transaksi dt
                             JOIN alat_camping ac ON dt.id_alatcamping = ac.id_alatcamping
                             WHERE dt.id_peminjaman = @idPeminjaman";

            List<RentersDetail> details = new List<RentersDetail>();

            using (var db = new DBConnection())
            {
                db.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@idPeminjaman", idPeminjaman);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        RentersDetail detail = new RentersDetail
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
