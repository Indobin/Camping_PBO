using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Projek_Akhir_PBO.Models.Pemilik;
using Projek_Akhir_PBO.Tools;

namespace Projek_Akhir_PBO.Controller.Pemilik
{
    internal class StockController
    {
        private int _userId;
        public List<Stock> ListStock = new List<Stock>();
        
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public void Read()
        {
            string query = string.Format(@"SELECT a.id_alatcamping, a.namaalatcamping, a.hargaalatcamping, a.jumlahalatcamping, a.dihentikan, k.namakategori, a.deskripsi
                                            FROM alat_camping a
                                            JOIN kategori_alat_camping k on a.id_kategori=k.id_kategori
                                            WHERE a.id_pemilik = @userId
                                            ORDER BY id_alatcamping ASC;");
            using (var db = new DBConnection())
            {
                db.Open();
                using (NpgsqlCommand data = new NpgsqlCommand(query, db.Connection))
                {
                    data.Parameters.AddWithValue("@userId", _userId);
                    NpgsqlDataReader reader = data.ExecuteReader();
                    ListStock.Clear();
                    while (reader.Read())
                    {
                        Stock stock = new Stock();
                        stock.id_alatcamping = (int)reader["id_alatcamping"];
                        stock.namaalatcamping = (string)reader["namaalatcamping"];
                        stock.hargaalatcamping = (int)reader["hargaalatcamping"];
                        stock.jumlahalatcamping = (int)reader["jumlahalatcamping"];
                        stock.dihentikan = (bool)reader["dihentikan"];
                        stock.status = (bool)reader["dihentikan"] ? "Tidak Aktif" : "Aktif";
                        stock.namakategori = (string)reader["namakategori"];
                        stock.deskripsi = (string)reader["deskripsi"];
                        ListStock.Add(stock);
                    }
                }
            }
        }
       public void Tambah(Stock stock, string nama_alat)
        {
            string cek = string.Format(@"SELECT * FROM alat_camping WHERE namaalatcamping=@nama_alat");
            string query = string.Format(@"INSERT INTO alat_camping(namaalatcamping,hargaalatcamping,jumlahalatcamping,
                                           deskripsi, dihentikan, id_pemilik, id_kategori)
                                            VALUES (@nama_alat, @harga, @jumlah, @deskripsi, @dihentikan, @userId, @id_kategori)");
            using (var db = new DBConnection())
            {
                db.Open();
                using (NpgsqlCommand cmdcek = new NpgsqlCommand(query, db.Connection))
                {

                    cmdcek.Parameters.AddWithValue("@nama_alat", nama_alat);

                    int count = Convert.ToInt32(cmdcek.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Nama barang sudah ada", "Insert Data",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@nama_alat", stock.namaalatcamping);
                    cmd.Parameters.AddWithValue("@harga", stock.hargaalatcamping);
                    cmd.Parameters.AddWithValue("@jumlah", stock.jumlahalatcamping);
                    cmd.Parameters.AddWithValue("@deskripsi", stock.deskripsi);
                    cmd.Parameters.AddWithValue("@id_kategori", stock.id_kategori);
                    cmd.Parameters.AddWithValue("@dihentikan", stock.dihentikan);
                    cmd.Parameters.AddWithValue("@userId", _userId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Alat camping berhasil ditambahkan.", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }   
        public void Edit(Stock stock, string nama_alat, int id_barang)
        {
            string cek = string.Format(@"SELECT * FROM alat_camping WHERE namaalatcamping=@nama_alat AND id_alatcamping != @idBarang");
            string query = string.Format(@"UPDATE alat_camping SET namaalatcamping=@nama_alat, hargaalatcamping=@harga,
                                           jumlahalatcamping=@jumlah, deskripsi=@deskripsi, dihentikan=@dihentikan, id_kategori=@id_kategori
                                            WHERE id_alatcamping=@idBarang");
            using (var db = new DBConnection())
            {
                db.Open();
                using (NpgsqlCommand cmdcek = new NpgsqlCommand(query, db.Connection))
                {

                    cmdcek.Parameters.AddWithValue("@nama_alat", nama_alat);
                    cmdcek.Parameters.AddWithValue("@idBarang", id_barang);
                    int count = Convert.ToInt32(cmdcek.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Nama barang sudah ada", "Insert Data",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@nama_alat", stock.namaalatcamping);
                    cmd.Parameters.AddWithValue("@harga", stock.hargaalatcamping);
                    cmd.Parameters.AddWithValue("@jumlah", stock.jumlahalatcamping);
                    cmd.Parameters.AddWithValue("@deskripsi", stock.deskripsi);
                    cmd.Parameters.AddWithValue("@id_kategori", stock.id_kategori);
                    cmd.Parameters.AddWithValue("@dihentikan", stock.dihentikan);
                    cmd.Parameters.AddWithValue("@userId", _userId);
                    cmd.Parameters.AddWithValue("@idBarang", stock.id_alatcamping);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
