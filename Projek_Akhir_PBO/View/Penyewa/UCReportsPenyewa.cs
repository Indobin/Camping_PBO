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
using Projek_Akhir_PBO.Controller.Pemilik;
using Projek_Akhir_PBO.Controller.Penyewa;
using Projek_Akhir_PBO.Models.Pemilik;
using Projek_Akhir_PBO.Models.Penyewa;


namespace Projek_Akhir_PBO.View.Penyewa
{
    public partial class UCReportsPenyewa : UserControl
    {
        private int _userId;

        public int UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
                reportController.UserId = _userId;
            }
        }
        ReportController reportController;
        private int idlaporanSelected = -1;

        public UCReportsPenyewa()
        {
            reportController = new ReportController();
            InitializeComponent();
            //datapeminjaman();
            
        }
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        private void peminjamandata()
        {
            //string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=321;Database=Camping;CommandTimeout=10";
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=12345678;Database=GO-CAMP;CommandTimeout=10";


            string query = $"SELECT tanggal_peminjaman, id_peminjaman FROM peminjaman WHERE id_penyewa=@userId";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", _userId);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime tanggalPeminjaman = (DateTime)reader["tanggal_peminjaman"];
                                int idPeminjaman = (int)reader["id_peminjaman"];
                                guna2ComboBoxPeminjaman.Items.Add(new ComboBoxItem
                                {
                                    //Text = ((DateTime)reader["tanggal_peminjaman"]).ToString("yyyy-MM-dd"),
                                    //Value = (int)reader["id_peminjaman"]
                                    Text = $"ID: {idPeminjaman} - Date: {tanggalPeminjaman:yyyy-MM-dd}",
                                    Value = idPeminjaman
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        public void DataLaporan()
        {
            reportController.Read();
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Tanggal Laporan", typeof(string));
            table.Columns.Add("Status", typeof(string));
            table.Columns.Add("Isi Laporan", typeof(string));
            table.Columns.Add("Isi Tanggapan", typeof(string));
            table.Columns.Add("Nama Penyewa", typeof(string));
            foreach (var laporan in reportController.ListLaporan)
            {
                table.Rows.Add(laporan.id_laporan, laporan.tanggal_laporan, laporan.status_laporan,
                    laporan.isi_laporan, laporan.isi_tanggapan);
            }

            dataGridView1.DataSource = table;
        }
       

        private void button1tambah_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBoxLaporan.Text.Trim()) || string.IsNullOrEmpty(guna2ComboBoxPeminjaman.Text.Trim()))
            {
                MessageBox.Show("Isi laporan dan peminjaman tidak boleh kosong", "Tambah Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ComboBoxItem peminjamanselect = (ComboBoxItem)guna2ComboBoxPeminjaman.SelectedItem;
            ReportsPy reportsPy = new ReportsPy
            {
                isi_laporan = richTextBoxLaporan.Text.Trim(),
                tanggal_laporan = guna2tanggal.Text.Trim(),
                id_peminjaman = peminjamanselect.Value,

            };
            int IdAdmin = 1;
            reportController.Tambah(reportsPy, peminjamanselect.Value, IdAdmin);
            //ResetInputFields();
            peminjamandata();
        }

        private void UCReportsPenyewa_Load(object sender, EventArgs e)
        {
            peminjamandata();
            DataLaporan();
            richTextTanggapan.Enabled = false;
            guna2tanggal.Enabled = false;
        }
    }
}
