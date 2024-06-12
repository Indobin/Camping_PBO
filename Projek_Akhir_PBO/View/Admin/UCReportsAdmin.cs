using Projek_Akhir_PBO.Controller.Admin;
using Projek_Akhir_PBO.Models.Admin;
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
using Projek_Akhir_PBO.Controller.Penyewa;
using Projek_Akhir_PBO.Models.Penyewa;
using Guna.UI2.WinForms.Suite;

namespace Projek_Akhir_PBO.View.Admin
{
    public partial class UCReportsAdmin : UserControl
    {
        private int _userId;

        public int UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
                laporanController.UserId = _userId;
             
            }
        }
        LaporanController laporanController;
        public UCReportsAdmin()
        {
            laporanController = new LaporanController();
            InitializeComponent();
        }

        private int idLaporanSelected = -1;


        public void DataLaporanAdmin()
        {
            laporanController.Read();
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Tanggal Laporan", typeof(string));
            table.Columns.Add("Status", typeof(string));
            table.Columns.Add("Isi Laporan", typeof(string));
            table.Columns.Add("Isi Tanggapan", typeof(string));
            table.Columns.Add("Nama Penyewa", typeof(string));
            table.Columns.Add("Peminjaman", typeof(string)); // Kolom baru


            foreach (var laporan in laporanController.Laporan)
            {
                table.Rows.Add(laporan.id_laporan, laporan.tanggallaporan, laporan.statuslaporan,
                               laporan.isi_laporan, laporan.isi_tanggapan, laporan.nama_penyewa,
                               laporan.peminjaman); // Tambahkan data baru
            }

            dataGridView1.DataSource = table;

        }

        private void UCReportsAdmin_Load(object sender, EventArgs e)
        {
            DataLaporanAdmin();
        }

        private void button2edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextTanggapan.Text.Trim()))
            {
                MessageBox.Show("Isi Tanggapan Tidak Boleh Kosong", "Edit Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (idLaporanSelected <= 0)
            {
                MessageBox.Show("Pilih laporan yang valid dari tabel!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LaporanContext reports = new LaporanContext
            {
                isi_tanggapan = richTextTanggapan.Text.Trim(),
                id_laporan = idLaporanSelected

            };

            laporanController.UpdateTanggapan(reports, idLaporanSelected, richTextBoxLaporan.Text.Trim());

            DataLaporanAdmin();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button1Clear_Click(object sender, EventArgs e)
        {
            guna2tanggal.Text = string.Empty;
            guna2TextBox1.Text = string.Empty;
            richTextBoxLaporan.Text = string.Empty;
            richTextTanggapan.Text = string.Empty;
            richTextTanggapan.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                idLaporanSelected = Convert.ToInt32(row.Cells["Id"].Value);
                guna2tanggal.Text = row.Cells["Tanggal Laporan"].Value.ToString();
                richTextBoxLaporan.Text = row.Cells["Isi Laporan"].Value.ToString();
                richTextTanggapan.Text = row.Cells["Isi Tanggapan"].Value.ToString();
                if (row.Cells[4].Value.ToString() == "Belum ada")
                {
                    richTextTanggapan.Enabled = true;
                }
                else
                {
                    richTextTanggapan.Enabled = false;
                }
                guna2TextBox1.Text = row.Cells["Peminjaman"].Value.ToString();

            

            }
        }
    }

}
