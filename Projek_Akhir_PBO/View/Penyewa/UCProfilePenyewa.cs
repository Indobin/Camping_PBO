using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Projek_Akhir_PBO.View.Penyewa
{
    public partial class UCProfilePenyewa : UserControl
    {
        public UCProfilePenyewa()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=Renaldi;Database=Camping_PBO;CommandTimeout=10";
            string query = "UPDATE penyewa SET nama_penyewa = @NAMA";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NAMA", textBoxUsername.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Profil pengguna berhasil diperbarui.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=Renaldi;Database=Camping_PBO;CommandTimeout=10";
            string query = "SELECT nama_penyewa FROM penyewa ";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.CommandText = query;
                        NpgsqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            textBoxUsername.Text = reader["nama_penyewa"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Profil pengguna tidak ditemukan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
