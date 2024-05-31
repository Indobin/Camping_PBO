using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Projek_Akhir_PBO.Models.Pemilik;

namespace Projek_Akhir_PBO.Controller.Pemilik
{
    public class KategoriController
    {
       
        public List<KategoriContext> ListKategori = new List<KategoriContext>();
        string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=321;Database=Camping;CommandTimeout=10";
        public void Read()
        {
            string query = string.Format(@"SELECT row_number(*) over() as nomor, id_kategori, namakategori 
                                FROM kategori_alat_camping;");

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.CommandText = query;
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    ListKategori.Clear();
                    while (reader.Read())
                    {
                        KategoriContext kategoriContext = new KategoriContext();
                        kategoriContext.id_kategori = (int)reader["id_kategori"];
                        kategoriContext.namakategori = (string)reader["namakategori"];
                        ListKategori.Add(kategoriContext);
                    }
                }
            }
        }
        public void Tambah(string Namakategori)
        {

            if (string.IsNullOrEmpty(Namakategori.Trim()))
            {
                MessageBox.Show("Nama Kategori tidak boleh kosong", "Tambah Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string cekQuery = "SELECT COUNT(*) FROM kategori_alat_camping WHERE namakategori = @namakategori";
            string insertQuery = "INSERT INTO kategori_alat_camping (namakategori) VALUES (@namakategori)";

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
        public void Edit(int idkategori, string namaKategori)
        {
            if (string.IsNullOrEmpty(namaKategori.Trim()))
            {
                MessageBox.Show("Nama Kategori tidak boleh kosong", "Edit Data",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string cekQuery = "SELECT COUNT(*) FROM kategori_alat_camping WHERE namakategori = @namakategori AND id_kategori != @id";
            string updateQuery = "UPDATE kategori_alat_camping SET namakategori = @namakategori WHERE id_kategori = @id";

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
        public void Hapus(int idkategori, string namaKategori)
        {
            if (string.IsNullOrEmpty(namaKategori.Trim()))
            {
                MessageBox.Show("Nama Kategori tidak boleh kosong", "Edit Data",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string deleteQuery = "DELETE FROM kategori_alat_camping WHERE id_kategori = @id";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idkategori);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil dihapus", "Hapus Data",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Optional: Update DataGridView if it exists
                        }
                        else
                        {
                            MessageBox.Show("Data gagal dihapus", "Hapus Data",
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
