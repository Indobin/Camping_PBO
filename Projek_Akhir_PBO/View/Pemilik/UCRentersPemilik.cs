using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Projek_Akhir_PBO.Controller.Pemilik;
using Projek_Akhir_PBO.Models.Pemilik;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projek_Akhir_PBO.View.Pemilik
{
    public partial class UCRentersPemilik : UserControl
    {
        private int _userId;

        public int UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
                rentersController.UserId = _userId;
                LoadDataGrid();  // Panggil LoadDataGrid setelah UserId diatur
            }
        }

        int index;
        private int idRentersSelected = -1;
        RentersController rentersController;

        public UCRentersPemilik()
        {
            rentersController = new RentersController();
            InitializeComponent();
        }

        private void LoadDataGrid()
        {
            rentersController.Read(); 
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Nama Penyewa", typeof(string));
            table.Columns.Add("No. Telp", typeof(string));
            table.Columns.Add("Alamat", typeof(string));
            table.Columns.Add("Tanggal Peminjaman", typeof(DateTime));
            table.Columns.Add("Status", typeof(string));
            foreach (var renters in rentersController.ListRenters)
            {
                table.Rows.Add(renters.id_peminjaman, renters.nama_penyewa, renters.alamat_penyewa
                                , renters.no_telepon_penyewa, renters.tanggal_peminjaman, renters.status);
            }

            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                idRentersSelected = Convert.ToInt32(row.Cells[0].Value);
                tbnama.Text = row.Cells[1].Value.ToString();
                tbnotelp.Text = row.Cells[2].Value.ToString();
                tbalamat.Text = row.Cells[3].Value.ToString();
                tbtglpinjam.Text = row.Cells[4].Value.ToString();
                string status = row.Cells[5].Value.ToString();
                cbstatus.SelectedItem = status;

                tbnama.Enabled = false;
                tbnotelp.Enabled = false;
                tbalamat.Enabled = false;
                tbtglpinjam.Enabled = false;
            }
        }

        private void button1Clear_Click(object sender, EventArgs e)
        {
            tbnama.Text = string.Empty;
            tbalamat.Text = string.Empty;
            tbnotelp.Text = string.Empty;
            tbtglpinjam.Text = string.Empty;
            cbstatus.SelectedIndex = -1;
        }

        private void button2edit_Click(object sender, EventArgs e)
        {
            if (idRentersSelected == -1)
            {
                MessageBox.Show("Pilih Id Peminjaman yang ingin di edit!", "Edit Data",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string status = cbstatus.SelectedItem.ToString();
            bool status_pinjam = (status == "Proses") ? false : true;
            Renters renters = new Renters
            {
                id_peminjaman = idRentersSelected,
                nama_penyewa = tbnama.Text.Trim(),
                alamat_penyewa = tbalamat.Text.Trim(),
                no_telepon_penyewa = tbnotelp.Text.Trim(),
                tanggal_peminjaman = DateTime.Parse(tbtglpinjam.Text.Trim()),
                status_pinjam = status_pinjam
            };

            rentersController.Edit(renters, status_pinjam);
            MessageBox.Show("status peminjaman berhasil diedit.", "Edit Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGrid();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void paneltopdashboard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
