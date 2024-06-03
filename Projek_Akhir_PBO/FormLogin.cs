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
using Projek_Akhir_PBO.View;
using Projek_Akhir_PBO.View.Admin;
using Projek_Akhir_PBO.View.Pemilik;
using Projek_Akhir_PBO.View.Penyewa;
using Projek_Akhir_PBO.Controller;
using Projek_Akhir_PBO.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projek_Akhir_PBO
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void Loginbutton_Click(object sender, EventArgs e)
        {
          
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FormRegister regForm = new FormRegister();
            regForm.Show();
            this.Hide();
        }

        private void Loginbutton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernamebox.Text.Trim()) || string.IsNullOrEmpty(passwordbox.Text.Trim()))
            {
                MessageBox.Show("Username dan password tidak boleh kosong", "Login Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedTable = comboBox1.SelectedItem.ToString();
            string username = usernamebox.Text;
            string password = passwordbox.Text;
            //LoginController loginController = new LoginController();
            //loginController.HandleLogin(selectedTable, username, password, this);
            LoginController loginController = new LoginController();
            var (result, userId) = loginController.AuthLogin(selectedTable, username, password);

            if (result == "Admin")
            {
                MessageBox.Show("Berhasil Login Admin", "Login Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormAdmin menuAdmin = new FormAdmin(userId);
                menuAdmin.Show();
                this.Hide();
            }
            else if (result == "Pemilik")
            {
                MessageBox.Show("Berhasil Login Pemilik", "Login Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormPemilik menuPemilik = new FormPemilik(userId);
                menuPemilik.Show();
                this.Hide();
            }
            else if (result == "Penyewa")
            {
                MessageBox.Show("Berhasil Login Penyewa", "Login Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormPenyewa menuPenyewa = new FormPenyewa(userId);
                menuPenyewa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(result);
            }
        }
    }
}
