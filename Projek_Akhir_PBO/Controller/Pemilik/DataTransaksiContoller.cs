using Npgsql;
using Projek_Akhir_PBO.Models.Pemilik;
using Projek_Akhir_PBO.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Projek_Akhir_PBO.Models.Pemilik.DataTransaksiDetail;

namespace Projek_Akhir_PBO.Controller.Pemilik
{
    internal class DataTransaksiContoller
    {
        private int _userId;
        public List<DataTransaksi> Listdatatransaksi = new List<DataTransaksi>();
        
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public void Read()
        {
            string query = @"select p.id_penyewa,p.nama_penyewa, pee.jenis_ewallet,pee.nomor_ewallet, pem.tanggal_peminjaman,peng.tanggalpengembalian,
                         SUM(ac.hargaalatcamping * dt.quantity * dt.lama_sewa) AS total_harga_keseluruhan
                            from peminjaman pem
							join pembayaran_ewallet pee on pee.id_ewallet = pem.id_ewallet
                            JOIN detail_transaksi dt ON pem.id_peminjaman = dt.id_peminjaman
                            join penyewa p on p.id_penyewa = pem.id_penyewa
                            JOIN alat_camping ac ON ac.id_alatcamping = dt.id_alatcamping
                            join pengembalian peng on pem.id_peminjaman = peng.id_peminjaman
							where peng.status_kembali = true
                            group by p.id_penyewa,p.nama_penyewa,pem.tanggal_peminjaman,peng.tanggalpengembalian,pee.jenis_ewallet,pee.nomor_ewallet
							Order By p.id_penyewa;";

             using (var db = new DBConnection())
            {
                db.Open();
                using (NpgsqlCommand data = new NpgsqlCommand(query, db.Connection))
                {
                    data.Parameters.AddWithValue("@userId", _userId);
                    NpgsqlDataReader reader = data.ExecuteReader();
                    Listdatatransaksi.Clear();
                    while (reader.Read())
                    {
                        DataTransaksi dataTransakasi = new DataTransaksi();
                        dataTransakasi.id_penyewa = (int)reader["id_penyewa"];
                        dataTransakasi.nama_penyewa = (string)reader["nama_penyewa"];
                        dataTransakasi.jenis_ewallet = (string)reader["jenis_ewallet"];
                        dataTransakasi.nomor_ewallet = (string)reader["nomor_ewallet"];
                        dataTransakasi.tanggal_peminjaman = (DateTime)reader["tanggal_peminjaman"];
                        dataTransakasi.tanggalpengembalian = (DateTime)reader["tanggalpengembalian"];
                        dataTransakasi.total_harga_keseluruhan = (long)reader["total_harga_keseluruhan"];
                        Listdatatransaksi.Add(dataTransakasi);
                    }
                }
            }
        }
        public List<DetailPeminjamanDT> GetDetailPeminjamanDT(int idPenyewa)
        {
            string query = @"SELECT ac.namaalatcamping, dt.quantity, ac.hargaalatcamping, (dt.quantity * ac.hargaalatcamping) as Total_Harga
                     FROM detail_transaksi dt
                     JOIN alat_camping ac ON dt.id_alatcamping = ac.id_alatcamping
					 join peminjaman pem on pem.id_peminjaman = dt.id_peminjaman
					 join penyewa p on p.id_penyewa = pem.id_penyewa
					 where p.id_penyewa = @idPenyewa"
            ;
            List<DetailPeminjamanDT> details = new List<DetailPeminjamanDT>();

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idPenyewa", idPenyewa);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        DetailPeminjamanDT detail = new DetailPeminjamanDT
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
