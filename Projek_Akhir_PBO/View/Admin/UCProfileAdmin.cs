using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Projek_Akhir_PBO.Controller.Admin;
using Projek_Akhir_PBO.Controller.Pemilik;
using Projek_Akhir_PBO.Models.Admin;
namespace Projek_Akhir_PBO.View.Admin
{
    public partial class UCProfileAdmin : UserControl
    {
        private int _userId;

        public int UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
                //profileControllerA.UserId = _userId;
                // Load data or perform operations based on the new UserId value
            }
        }

        ProfileControllerA profileControllerA;
        int index;
        public UCProfileAdmin()
        {
            InitializeComponent();
            disabledProfile();
        }
        string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=321;Database=Camping;CommandTimeout=10";

        public void disabledProfile()
        {
            guna2nama.Enabled = false;
            guna2Nohp.Enabled = false;
        }

        private void button2edit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"User ID: {_userId}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            guna2nama.Enabled = true;
            guna2Nohp.Enabled = true;

        }

        private void UCProfileAdmin_Load(object sender, EventArgs e)
        {
            string selectQuery = "SELECT nama_admin, no_telepon_admin FROM admin WHERE id_admin = @userId";
            using (var conn = new NpgsqlConnection(conStr))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(selectQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", _userId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ProfileA profileA = new ProfileA();
                            //profileA.id_admin = (int)reader["id_admin"];
                            profileA.nama_admin = (string)reader["nama_admin"];
                            profileA.no_telepon_admin = (string)reader["no_telepon_admin"];
                            guna2nama.Text = profileA.nama_admin;
                            guna2Nohp.Text = profileA.no_telepon_admin;
                            //namaadmin = reader["namaadmin"].ToString();
                            //no_hp = reader["no_hp"].ToString();
                        }
                    }
                }
            }
        }


        private void guna2ButtonSave_Click(object sender, EventArgs e)
        {
            if(guna2nama.Enabled == false || guna2Nohp.Enabled == false)
            {
                MessageBox.Show("Klik edit terlebih dahulu", "Edit Data",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(guna2nama.Text.Trim()) || string.IsNullOrEmpty(guna2Nohp.Text.Trim()))
            {
                MessageBox.Show("Nama admin dan No hp tidak boleh kosong", "Edit Data",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string cekQuery = "SELECT COUNT(*) FROM admin WHERE nama_admin = @nama_admin AND id_admin != @userId";
            string updateQuery = "UPDATE admin SET nama_admin = @nama_admin, no_telepon_admin = @no_hp WHERE id_admin = @userId";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
                {
                    conn.Open();
                    using (NpgsqlCommand checkCmd = new NpgsqlCommand(cekQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@nama_admin", guna2nama.Text.Trim());
                        checkCmd.Parameters.AddWithValue("@userId", UserId);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("Nama admin sudah ada", "Edit Data",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    using (NpgsqlCommand cmd = new NpgsqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama_admin", guna2nama.Text.Trim());
                        cmd.Parameters.AddWithValue("@userId", UserId);
                        cmd.Parameters.AddWithValue("@no_hp", guna2Nohp.Text.Trim());
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil diubah", "Edit Data",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            guna2nama.Enabled = false;
                            guna2Nohp.Enabled = false;
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
