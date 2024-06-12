using System;
using System.Collections;
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
using Projek_Akhir_PBO.Controller.Pemilik;
using Projek_Akhir_PBO.Models.Admin;
using Projek_Akhir_PBO.Models.Penyewa;
using Projek_Akhir_PBO.Tools;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projek_Akhir_PBO.View.Penyewa
{
    public partial class UCProfilePenyewa : UserControl
    {
        private int _userId;

        ProfilePy ProfilePy;

        public int UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
              
            }
        }
        public UCProfilePenyewa()
        {
            InitializeComponent();
            disabledProfile();
        }

        public void disabledProfile()
        {
            textBoxUsername.Enabled = false;
            textBoxNoHP.Enabled = false;
            textBoxAlamat.Enabled = false;
        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxUsername.Enabled = true;
            textBoxNoHP.Enabled = true;
            textBoxAlamat.Enabled = true;
           
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UCProfilePenyewa_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT nama_penyewa, no_telepon_penyewa, alamat_penyewa FROM penyewa WHERE id_penyewa = @userId";
            using (var db = new DBConnection())
            {
                db.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(selectQuery, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@userId", _userId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ProfilePy profilePy = new ProfilePy();
                  
                            profilePy.nama_penyewa = (string)reader["nama_penyewa"];
                            profilePy.no_telepon_penyewa = (string)reader["no_telepon_penyewa"];
                            profilePy.alamat_penyewa = (string)reader["alamat_penyewa"];
                            textBoxUsername.Text = profilePy.nama_penyewa;
                            textBoxNoHP.Text = profilePy.no_telepon_penyewa;
                            textBoxAlamat.Text = profilePy.alamat_penyewa;

                        }
                    }
                }
            }
        }


        private void NamaPenyewa_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBoxUsername.Enabled == false || textBoxNoHP.Enabled == false || textBoxAlamat.Enabled == false)
            {
                MessageBox.Show("Klik edit terlebih dahulu", "Edit Data",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textBoxUsername.Text.Trim()) || string.IsNullOrEmpty(textBoxNoHP.Text.Trim()) || string.IsNullOrEmpty(textBoxAlamat.Text.Trim()))
            {
                MessageBox.Show("Nama penyewa dan No hp tidak boleh kosong", "Edit Data",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string cekQuery = "SELECT COUNT(*) FROM penyewa WHERE nama_penyewa = @nama_penyewa AND id_penyewa != @userId";
            string updateQuery = "UPDATE penyewa SET nama_penyewa = @nama_penyewa, no_telepon_penyewa = @no_hp, alamat_penyewa = @alamat_penyewa WHERE id_penyewa = @userId";

            try
            {
                using (var db = new DBConnection())
                {
                    db.Open();
                    using (NpgsqlCommand checkCmd = new NpgsqlCommand(cekQuery, db.Connection))
                    {
                        checkCmd.Parameters.AddWithValue("@nama_penyewa", textBoxUsername.Text.Trim());
                        checkCmd.Parameters.AddWithValue("@userId", UserId);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Nama penyewa sudah ada", "Edit Data",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    using (NpgsqlCommand cmd = new NpgsqlCommand(updateQuery, db.Connection))
                    {
                        cmd.Parameters.AddWithValue("@nama_penyewa", textBoxUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@userId", UserId);
                        cmd.Parameters.AddWithValue("@no_hp", textBoxNoHP.Text.Trim());
                        cmd.Parameters.AddWithValue("@alamat_penyewa", textBoxAlamat.Text.Trim());
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil diubah", "Edit Data",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBoxUsername.Enabled = false;
                            textBoxNoHP.Enabled = false;
                            textBoxAlamat.Enabled = false;
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


