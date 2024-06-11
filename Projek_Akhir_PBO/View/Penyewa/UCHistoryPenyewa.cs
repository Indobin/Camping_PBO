using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projek_Akhir_PBO.Controller.Pemilik;
using Projek_Akhir_PBO.Controller.Penyewa;
using static Projek_Akhir_PBO.View.Pemilik.UCStockPemilik;

namespace Projek_Akhir_PBO.View.Penyewa
{
    public partial class UCHistoryPenyewa : UserControl
    {
        private int _userId;

        public int UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
                historyController.UserId = _userId;
                // Load data or perform operations based on the new UserId value
            }
        }
        HistoryController historyController;
        private int idhistorySelected = -1;
        public UCHistoryPenyewa()
        {
            historyController = new HistoryController();
            InitializeComponent();
        }

        private void UCHistoryPenyewa_Load(object sender, EventArgs e)
        {
            DataHistory();
        }
        public void DataHistory()
        {
            historyController.Read();
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Tgl Peminjaman", typeof(string));
            table.Columns.Add("Status Peminjaman", typeof(string));
            table.Columns.Add("Nomor E-wallet", typeof(string));
            table.Columns.Add("Tgl Pengembalian", typeof(string));
            table.Columns.Add("Status Pengembalian", typeof(string));
            table.Columns.Add("Total Harga", typeof(int));
            foreach (var histori in historyController.ListHistory)
            {
                table.Rows.Add(histori.id_peminjaman, histori.tanggal_peminjaman, histori.status_pinjam
                                , histori.nomor_ewallet, histori.tanggal_pengembalian, histori.status_kembali,
                                histori.total_harga_keseluruhan);
            }

            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                dataGridView2.Visible = true;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                idhistorySelected = Convert.ToInt32(row.Cells[0].Value);
                //labelStatus.Text = row.Cells[2].Value.ToString();
                var details = historyController.GetDetailPeminjaman(idhistorySelected);
                //listViewDetails.Items.Clear();
                //guna2Panel1.Controls.Clear();
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

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
