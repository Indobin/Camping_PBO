using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace Projek_Akhir_PBO.View.Penyewa
{
    
    public partial class FormPenyewa : Form
    {
        FormLogin formloggin;
        private int _userId;
        public FormPenyewa(int userId)
        {
            _userId = userId;
            InitializeComponent();
            ucHomePenyewa1.UserId = _userId;
            ucTransactionsPenyewa1.UserId = _userId;
            ucHistoryPenyewa1.UserId = _userId;
            ucProfilePenyewa1.UserId = _userId;
        }

        private void buttonlogoutpenyewa_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Anda yakin ingin keluar ?",
                "Konfirmasi Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
                this.Hide();
            }
        }

        private void buttonhomepenyewa_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"User ID: {_userId}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ucHomePenyewa1.Visible = true;
            ucTransactionsPenyewa1.Visible = false;
            ucHistoryPenyewa1.Visible = false;
            ucProfilePenyewa1.Visible = false;
        }

        private void buttontransactionpenyewa_Click(object sender, EventArgs e)
        {
            ucHomePenyewa1.Visible = false;
            ucTransactionsPenyewa1.Visible = true;
            ucHistoryPenyewa1.Visible = false;
            ucProfilePenyewa1.Visible = false;
        }

        private void buttohistorypenyewa_Click(object sender, EventArgs e)
        {
            ucHomePenyewa1.Visible = false;
            ucTransactionsPenyewa1.Visible = false;
            ucHistoryPenyewa1.Visible = true;
            ucProfilePenyewa1.Visible = false;
        }

        private void buttonprofilpeyewa_Click(object sender, EventArgs e)
        {
            ucHomePenyewa1.Visible = false;
            ucTransactionsPenyewa1.Visible = false;
            ucHistoryPenyewa1.Visible = false;
            ucProfilePenyewa1.Visible = true;
        }
    }
}
