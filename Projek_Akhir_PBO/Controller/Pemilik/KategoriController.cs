using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Projek_Akhir_PBO.Models.Pemilik;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projek_Akhir_PBO.Controller.Pemilik
{
    public class KategoriController
    {
        private int _userId;
        public List<KategoriContext> ListKategori = new List<KategoriContext>();
        string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=321;Database=Camping;CommandTimeout=10";
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public void Read()
        {
            string query = string.Format(@"SELECT row_number(*) over() as nomor, id_kategori, namakategori, dihentikan 
                                FROM kategori_alat_camping WHERE id_pemilik=@userId ORDER BY id_kategori ASC;");

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", _userId);
                    //cmd.CommandText = query;
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    ListKategori.Clear();
                    while (reader.Read())
                    {
                        KategoriContext kategoriContext = new KategoriContext();
                        kategoriContext.id_kategori = (int)reader["id_kategori"];
                        kategoriContext.namakategori = (string)reader["namakategori"];
                        kategoriContext.dihentikan = (bool)reader["dihentikan"];
                        kategoriContext.Status = (bool)reader["dihentikan"] ? "Tidak Aktif" : "Aktif";
                        ListKategori.Add(kategoriContext);
                    }
                }
            }
        }
        public void Tambah(string Namakategori, bool dihentikan, string status)
        {
            
            //MessageBox.Show($"User ID: {_userId}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string cekQuery = "SELECT COUNT(*) FROM kategori_alat_camping WHERE namakategori = @namakategori";
            string insertQuery = "INSERT INTO kategori_alat_camping (namakategori,id_pemilik,dihentikan) VALUES (@namakategori,@userId,@dihentikan)";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
                {
                    conn.Open();
                    using (NpgsqlCommand cmdcek = new NpgsqlCommand(cekQuery, conn))
                    {

                        cmdcek.Parameters.AddWithValue("@namakategori", Namakategori.Trim());

                        int count = Convert.ToInt32(cmdcek.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Nama Kategori sudah ada", "Insert Data",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                    }
                    using (NpgsqlCommand cmd = new NpgsqlCommand(insertQuery, conn))
                    {
                        
                        cmd.Parameters.AddWithValue("@namakategori", Namakategori.Trim());
                        cmd.Parameters.AddWithValue("@userId", _userId);
                        cmd.Parameters.AddWithValue("@dihentikan", dihentikan);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil ditambah", "Insert Data",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Optional: Update DataGridView if it exists
                        }
                        else
                        {
                            MessageBox.Show("Data gagal diubah", "Insert Data",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Edit(int idkategori, string namaKategori, bool dihentikan)
        {
            if (string.IsNullOrEmpty(namaKategori.Trim()))
            {
                MessageBox.Show("Nama Kategori tidak boleh kosong", "Edit Data",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string cekQuery = "SELECT COUNT(*) FROM kategori_alat_camping WHERE namakategori = @namakategori AND id_kategori != @id";
            string updateQuery = "UPDATE kategori_alat_camping SET namakategori = @namakategori, dihentikan = @dihentikan WHERE id_kategori = @id";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
                {
                    conn.Open();
                    using (NpgsqlCommand checkCmd = new NpgsqlCommand(cekQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@namakategori", namaKategori.Trim());
                        checkCmd.Parameters.AddWithValue("@id", idkategori);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Nama Kategori sudah ada", "Edit Data",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    using (NpgsqlCommand cmd = new NpgsqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@namakategori", namaKategori.Trim());
                        cmd.Parameters.AddWithValue("@id", idkategori);
                        cmd.Parameters.AddWithValue("@dihentikan", dihentikan);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil diubah", "Edit Data",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Optional: Update DataGridView if it exists
                        }
                        else
                        {
                            MessageBox.Show("Data gagal diubah", "Edit Data",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
