using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_Akhir_PBO.View.Admin
{
    
    public partial class FormAdmin : Form
    {
        private int _userId;


        public FormAdmin(int userId)
        {
            _userId = userId;
            InitializeComponent();
            ucDashboardAdmini1.UserId = _userId;
            ucOwner1.UserId = _userId;
            ucRentersAdmin1.UserId = _userId;
            ucReportsAdmin1.UserId = _userId;
            ucProfileAdmin1.UserId = _userId;
        }

        private void buttonlogoutadm_Click(object sender, EventArgs e)
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

        private void buttondashboardadmin_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"User ID: {_userId}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ucDashboardAdmini1.Visible = true;
            ucOwner1.Visible = false;
            ucRentersAdmin1.Visible = false;
            ucReportsAdmin1.Visible = false;
            ucProfileAdmin1.Visible = false;
        }

        private void buttonowners_Click(object sender, EventArgs e)
        {
            ucDashboardAdmini1.Visible = false;
            ucOwner1.Visible = true;
            ucRentersAdmin1.Visible = false;
            ucReportsAdmin1.Visible = false;
            ucProfileAdmin1.Visible = false;
        }

        private void buttonrenters_Click(object sender, EventArgs e)
        {
            ucDashboardAdmini1.Visible = false;
            ucOwner1.Visible = false;
            ucRentersAdmin1.Visible = true;
            ucReportsAdmin1.Visible = false;
            ucProfileAdmin1.Visible = false;
        }

        private void buttonlaporan_Click(object sender, EventArgs e)
        {
            ucDashboardAdmini1.Visible = false;
            ucOwner1.Visible = false;
            ucRentersAdmin1.Visible = false;
            ucReportsAdmin1.Visible = true;
            ucProfileAdmin1.Visible = false;
        }

        private void buttonprofiladmin_Click(object sender, EventArgs e)
        {
            ucDashboardAdmini1.Visible = false;
            ucOwner1.Visible = false;
            ucRentersAdmin1.Visible = false;
            ucReportsAdmin1.Visible = false;
            ucProfileAdmin1.Visible = true;
        }
    }
}
