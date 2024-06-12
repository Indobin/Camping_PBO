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

namespace Projek_Akhir_PBO.View.Pemilik
{
    public partial class FormPemilik : Form
    {
        private int _userId;
        public FormPemilik(int userId)
        {
            _userId = userId;
            InitializeComponent();
            ucDashboardPemilik1.UserId = _userId;
            ucStockPemilik1.UserId = _userId;
            ucCategoriesPemilik1.UserId = _userId;
            ucRentersPemilik1.UserId = _userId;
            ucTransactionsPemilik1.UserId = _userId;
            ucProfilePemilik1.UserId = _userId;
        }

        private void buttonlogoutpemilik_Click(object sender, EventArgs e)
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

        private void buttondashboardPemilik_Click(object sender, EventArgs e)
        {
            ucDashboardPemilik1.Visible = true;
            ucStockPemilik1.Visible = false;
            ucCategoriesPemilik1.Visible = false;
            ucRentersPemilik1.Visible = false;
            ucTransactionsPemilik1.Visible = false;
            ucProfilePemilik1.Visible = false;
        }

        private void buttonstocksPemilik_Click(object sender, EventArgs e)
        {
            ucDashboardPemilik1.Visible = false;
            ucStockPemilik1.Visible = true;
            ucCategoriesPemilik1.Visible = false;
            ucRentersPemilik1.Visible = false;
            ucTransactionsPemilik1.Visible = false;
            ucProfilePemilik1.Visible = false;
        }

        private void buttoncategoriesPemilik_Click(object sender, EventArgs e)
        {
            ucDashboardPemilik1.Visible = false;
            ucStockPemilik1.Visible = false;
            ucCategoriesPemilik1.Visible = true;
            ucRentersPemilik1.Visible = false;
            ucTransactionsPemilik1.Visible = false;
            ucProfilePemilik1.Visible = false;
        }

        private void buttonrentersPemilik_Click(object sender, EventArgs e)
        {
            ucDashboardPemilik1.Visible = false;
            ucStockPemilik1.Visible = false;
            ucCategoriesPemilik1.Visible = false;
            ucRentersPemilik1.Visible = true;
            ucTransactionsPemilik1.Visible = false;
            ucProfilePemilik1.Visible = false;
        }

        private void buttonTransactionsPemilik_Click(object sender, EventArgs e)
        {
            ucDashboardPemilik1.Visible = false;
            ucStockPemilik1.Visible = false;
            ucCategoriesPemilik1.Visible = false;
            ucRentersPemilik1.Visible = false;
            ucTransactionsPemilik1.Visible = true;
            ucProfilePemilik1.Visible = false;
        }

        private void buttonprofilepemilik_Click(object sender, EventArgs e)
        {
            ucDashboardPemilik1.Visible = false;
            ucStockPemilik1.Visible = false;
            ucCategoriesPemilik1.Visible = false;
            ucRentersPemilik1.Visible = false;
            ucTransactionsPemilik1.Visible = false;
            ucProfilePemilik1.Visible = true;
        }
    }
}
