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
            string nama = namabox.Text;
            string alamat = alamatbox.Text;
            string notelp = notelpbox.Text;
            string username = usernamebox.Text;
            string password = passwordbox.Text;
            string konfirmasi = konfirmasibox.Text;

            if (password == konfirmasi)
            {
                using (NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=tiarahmadina;Database=Camping"))
                {
                    con.Open();

                    string checkUsernameQuery = "SELECT COUNT(*) FROM Akun WHERE username = @username";

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

                    string register = "INSERT INTO Akun (nama, alamat, notelp, username, password, konfirmasi) VALUES (@nama, @alamat, @notelp, @username, @password, @konfirmasi)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(register, con))
                    {
                        cmd.Parameters.AddWithValue("nama", nama);
                        cmd.Parameters.AddWithValue("alamat", alamat);
                        cmd.Parameters.AddWithValue("notelp", notelp);
                        cmd.Parameters.AddWithValue("username", username);
                        cmd.Parameters.AddWithValue("password", password);
                        cmd.Parameters.AddWithValue("konfirmasi", konfirmasi);
                        cmd.ExecuteNonQuery();
                    }

                    con.Close();
                }
                MessageBox.Show("Register Berhasil");
                Form1 Form1 = new Form1();
                Form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Konfirmasi Password Salah. Silakan coba lagi.");
            }

        }
    }
}
