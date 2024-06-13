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
using Projek_Akhir_PBO.Controller.Penyewa;
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
                LoadDataGrid();  
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
            table.Columns.Add("Nomor E-wallet", typeof(string));
            table.Columns.Add("Tanggal Peminjaman", typeof(string));
            table.Columns.Add("Status Peminjaman", typeof(string));
            table.Columns.Add("Tanggal Pengembalian", typeof(string));
            table.Columns.Add("Status Pengembalian", typeof(string));
            table.Columns.Add("Total Harga", typeof(int));
            foreach (var renters in rentersController.ListRenters)
            {
                table.Rows.Add(renters.id_peminjaman, renters.nama_penyewa, renters.nomor_ewallet, renters.tanggal_peminjaman, renters.status_pinjam_string
                                , renters.tanggalpengembalian, renters.status_kembali_string,
                                renters.total_harga_keseluruhan);
            }

            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1Clear_Click(object sender, EventArgs e)
        {
            tb1.Text = string.Empty;
            tb4.Text = string.Empty;
            tb2.Text = string.Empty;
            tb3.Text = string.Empty;
            cbpeminjaman.SelectedIndex = -1;
            cbpengembalian.SelectedIndex = -1;
        }

        private void button2edit_Click(object sender, EventArgs e)
        {
            if (idRentersSelected == -1)
            {
                MessageBox.Show("Pilih peminjaman yang ingin di edit!", "Edit Data",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string status_pinjam_string = cbpeminjaman.SelectedItem.ToString();
            bool status_pinjam = (status_pinjam_string == "Proses") ? false : true;
            Renters renters = new Renters
            {
                id_peminjaman = idRentersSelected,
                status_pinjam = status_pinjam
            };
            rentersController.UpdateStatusPinjam(renters);
            LoadDataGrid();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[index];
                idRentersSelected = Convert.ToInt32(row.Cells[0].Value);
                tb1.Text = row.Cells[1].Value.ToString();
                tb2.Text = row.Cells[2].Value.ToString();
                tb4.Text = row.Cells[5].Value.ToString();
                tb3.Text = row.Cells[3].Value.ToString();
                string status_pinjam_string = row.Cells[4].Value.ToString();
                string status_kembali_string = row.Cells[6].Value.ToString();
                cbpeminjaman.SelectedItem = status_pinjam_string;
                cbpengembalian.SelectedItem = status_kembali_string;

                tb1.Enabled = false;
                tb2.Enabled = false;
                tb4.Enabled = false;
                tb3.Enabled = false;

                dataGridView2.Visible = true;
                label3.Visible = true;
                DataGridViewRow baris = dataGridView1.Rows[e.RowIndex];
                idRentersSelected = Convert.ToInt32(row.Cells[0].Value);
                var details = rentersController.GetDetailPeminjaman(idRentersSelected);
                dataGridView2.Controls.Clear();
                DataTable table2 = new DataTable();

                table2.Columns.Add("Nama Barang", typeof(string));
                table2.Columns.Add("Harga Barang", typeof(int));
                table2.Columns.Add("Quantity", typeof(int));
                table2.Columns.Add("Total Harga", typeof(string));
                dataGridView2.DataSource = table2;

                foreach (var detail in details)
                {
                    table2.Rows.Add(detail.NamaAlatCamping, detail.HargaAlatCamping,
                        detail.Quantity, detail.Total_Harga);
                }
            }
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void paneltopdashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (idRentersSelected == -1)
            {
                MessageBox.Show("Pilih peminjaman yang ingin di edit!", "Edit Data",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string status_kembali_string = cbpengembalian.SelectedItem.ToString();
            bool status_kembali = (status_kembali_string == "Proses") ? false : true;
            string status_pinjam_string = cbpeminjaman.SelectedItem.ToString();
            bool status_pinjam = (status_pinjam_string == "Proses") ? false : true;
            Renters renters = new Renters
            {
                id_peminjaman = idRentersSelected,
                status_pinjam = status_pinjam,
                status_kembali = status_kembali
            };

            rentersController.UpdateStatusKembali(renters.id_peminjaman, status_kembali, renters.status_pinjam);
            LoadDataGrid();
        }
    }
}
