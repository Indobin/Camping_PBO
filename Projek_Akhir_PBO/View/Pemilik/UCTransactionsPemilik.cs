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

namespace Projek_Akhir_PBO.View.Pemilik
{
    public partial class UCTransactionsPemilik : UserControl
    {
        private int _userId;

        public int UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
                datatransaksiController.UserId = _userId;
                LoadDataGrid();  
            }
        }

        private int idDataTransaksiSelected = -1;
        DataTransaksiContoller datatransaksiController;

        public UCTransactionsPemilik()
        {
            datatransaksiController = new DataTransaksiContoller();
            InitializeComponent();
        }

        private void LoadDataGrid()
        {
            datatransaksiController.Read();
            DataTable table = new DataTable();
            table.Columns.Add("Id Peminjaman", typeof(int));
            table.Columns.Add("Nama Penyewa", typeof(string));
            table.Columns.Add("Jenis Ewallet", typeof(string));
            table.Columns.Add("Nomor Ewallet", typeof(string));
            table.Columns.Add("Tanggal Peminjaman", typeof(DateTime));
            table.Columns.Add("Tanggal Pengembalian", typeof(DateTime));
            table.Columns.Add("Total Harga Keseluruhan", typeof(long));
            foreach (var datatransaksi in datatransaksiController.Listdatatransaksi)
            {
                table.Rows.Add(datatransaksi.id_peminjaman, datatransaksi.nama_penyewa, datatransaksi.jenis_ewallet, datatransaksi.nomor_ewallet, datatransaksi.tanggal_peminjaman, datatransaksi.tanggalpengembalian, datatransaksi.total_harga_keseluruhan);
            }

            dataGridView1.DataSource = table;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UCTransactionsPemilik_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                dataGridView2.Visible = true;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                idDataTransaksiSelected = Convert.ToInt32(row.Cells[0].Value);
                //labelStatus.Text = row.Cells[2].Value.ToString();
                var details = datatransaksiController.GetDetailPeminjamanDT(idDataTransaksiSelected);
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
