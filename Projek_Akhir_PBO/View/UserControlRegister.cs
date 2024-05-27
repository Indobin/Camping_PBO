using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Projek_Akhir_PBO.Controller;
using Projek_Akhir_PBO.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projek_Akhir_PBO
{
    public partial class UserControlRegister : UserControl
    {
        Form1 FormParent;
        public UserControlRegister(Form1 FormParent)
        {
            this.FormParent = FormParent;
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string namapenyewa = namabox.Text;
            string alamat_penyewa = alamatbox.Text;
            string no_teleponpenyewa = notelpbox.Text;
            string namapemilik = namabox.Text;
            string alamat_pemilik = alamatbox.Text;
            string no_teleponpemilik = notelpbox.Text;
            string username = usernamebox.Text;
            string password = passwordbox.Text;
            string konfirmasi = konfirmasibox.Text;
            string selectedTable = sebagai.SelectedItem.ToString();

            if (password == konfirmasi)
            {
                using (NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=tiarahmadina;Database=Camping"))
                {
                    if (selectedTable == "Penyewa")
                    {
                        con.Open();

                        string checkUsernameQuery = "SELECT COUNT(*) FROM penyewa WHERE username = @username";

                        using (NpgsqlCommand checkCmd = new NpgsqlCommand(checkUsernameQuery, con))
                        {
                            checkCmd.Parameters.AddWithValue("@username", username);
                            int existingUserCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                            if (existingUserCount > 0)
                            {
                                MessageBox.Show("username sudah ada. Silakan ganti username anda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        string register = "INSERT INTO penyewa (id_penyewa, namapenyewa, alamat_penyewa, no_teleponpenyewa, username, password) VALUES (nextval('id_penyewa_seq'), @namapenyewa, @alamat_penyewa, @no_teleponpenyewa, @username, @password)";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(register, con))
                        {
                            cmd.Parameters.AddWithValue("namapenyewa", namapenyewa);
                            cmd.Parameters.AddWithValue("alamat_penyewa", alamat_penyewa);
                            cmd.Parameters.AddWithValue("no_teleponpenyewa", no_teleponpenyewa);
                            cmd.Parameters.AddWithValue("username", username);
                            cmd.Parameters.AddWithValue("password", password);
                            cmd.ExecuteNonQuery();
                        }
                        con.Close();
                    }
                    else if (selectedTable == "Pemilik")
                    {
                        con.Open();

                        string checkUsernameQuery = "SELECT COUNT(*) FROM pemilik WHERE username = @username";

                        using (NpgsqlCommand checkCmd = new NpgsqlCommand(checkUsernameQuery, con))
                        {
                            checkCmd.Parameters.AddWithValue("@username", username);
                            int existingUserCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                            if (existingUserCount > 0)
                            {
                                MessageBox.Show("username sudah ada. Silakan ganti username anda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        string register = "INSERT INTO pemilik (id_pemilik, namapemilik, alamat_pemilik, no_teleponpemilik, username, password) VALUES (nextval('id_pemilik_seq'), @namapemilik, @alamat_pemilik, @no_teleponpemilik, @username, @password)";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(register, con))
                        {
                            cmd.Parameters.AddWithValue("namapemilik", namapemilik);
                            cmd.Parameters.AddWithValue("alamat_pemilik", alamat_pemilik);
                            cmd.Parameters.AddWithValue("no_teleponpemilik", no_teleponpemilik);
                            cmd.Parameters.AddWithValue("username", username);
                            cmd.Parameters.AddWithValue("password", password);
                            cmd.ExecuteNonQuery();
                        }
                        con.Close();
                    }
                }
                MessageBox.Show("Register Berhasil");
                this.FormParent.ShowFormlogin();
            }
            else
            {
                MessageBox.Show("Konfirmasi Password Salah. Silakan coba lagi.");
            }
        }

        private void UserControlRegister_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
