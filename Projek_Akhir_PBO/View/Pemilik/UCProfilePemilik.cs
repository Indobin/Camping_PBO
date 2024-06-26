﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Projek_Akhir_PBO.Controller.Pemilik;
using Projek_Akhir_PBO.Models.Pemilik;
using Projek_Akhir_PBO.Models.Penyewa;
using Projek_Akhir_PBO.Tools;

namespace Projek_Akhir_PBO.View.Pemilik
{
    public partial class UCProfilePemilik : UserControl
    {
        private int _userId;

        ProfilePm ProfilePm;

        public int UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
              
            }
        }
        public UCProfilePemilik()
        {
            InitializeComponent();
            disabledProfile();
        }

        public void disabledProfile()
        {
            textBoxNamePm.Enabled = false;
            textBoxNoPm.Enabled = false;
            textBoxAlamatPm.Enabled = false;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            textBoxNamePm.Enabled = true;
            textBoxNoPm.Enabled = true;
            textBoxAlamatPm.Enabled = true;
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (textBoxNamePm.Enabled == false || textBoxNoPm.Enabled == false || textBoxAlamatPm.Enabled == false)
            {
                MessageBox.Show("Klik edit terlebih dahulu", "Edit Data",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textBoxNamePm.Text.Trim()) || string.IsNullOrEmpty(textBoxNoPm.Text.Trim()) || string.IsNullOrEmpty(textBoxAlamatPm.Text.Trim()))
            {
                MessageBox.Show("Nama pemilik dan No hp tidak boleh kosong", "Edit Data",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string cekQuery = "SELECT COUNT(*) FROM pemilik WHERE nama_pemilik = @nama_pemilik AND id_pemilik != @userId";
            string updateQuery = "UPDATE pemilik SET nama_pemilik = @nama_pemilik, no_telepon_pemilik = @no_hp, alamat_pemilik = @alamat_pemilik WHERE id_pemilik = @userId";

            try
            {
                using (var db = new DBConnection())
                {
                    db.Open();
                    using (NpgsqlCommand checkCmd = new NpgsqlCommand(cekQuery, db.Connection))
                    {
                        checkCmd.Parameters.AddWithValue("@nama_pemilik", textBoxNamePm.Text.Trim());
                        checkCmd.Parameters.AddWithValue("@userId", UserId);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Nama pemilik sudah ada", "Edit Data",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    using (NpgsqlCommand cmd = new NpgsqlCommand(updateQuery, db.Connection))
                    {
                        cmd.Parameters.AddWithValue("@nama_pemilik", textBoxNamePm.Text.Trim());
                        cmd.Parameters.AddWithValue("@userId", UserId);
                        cmd.Parameters.AddWithValue("@no_hp", textBoxNoPm.Text.Trim());
                        cmd.Parameters.AddWithValue("@alamat_pemilik", textBoxAlamatPm.Text.Trim());
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil diubah", "Edit Data",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBoxNamePm.Enabled = false;
                            textBoxNoPm.Enabled = false;
                            textBoxAlamatPm.Enabled = false;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void UCProfilePemilik_Load_1(object sender, EventArgs e)
        {
            string selectQuery = "SELECT nama_pemilik, no_telepon_pemilik, alamat_pemilik FROM pemilik WHERE id_pemilik = @userId";
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
                            ProfilePm profilePm = new ProfilePm();
                            //profileA.id_admin = (int)reader["id_admin"];
                            profilePm.nama_pemilik = (string)reader["nama_pemilik"];
                            profilePm.no_telepon_pemilik = (string)reader["no_telepon_pemilik"];
                            profilePm.alamat_pemilik = (string)reader["alamat_pemilik"];
                            textBoxNamePm.Text = profilePm.nama_pemilik;
                            textBoxNoPm.Text = profilePm.no_telepon_pemilik;
                            textBoxAlamatPm.Text = profilePm.alamat_pemilik;

                        }
                    }
                }
            }
        }



    }
}
