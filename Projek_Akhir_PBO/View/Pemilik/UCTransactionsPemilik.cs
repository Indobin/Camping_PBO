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
            table.Columns.Add("Id_penyewa", typeof(int));
            table.Columns.Add("Nama Penyewa", typeof(string));
            table.Columns.Add("Tanggal Peminjaman", typeof(DateTime));
            table.Columns.Add("Tanggal Pengembalian", typeof(DateTime));
            foreach (var datatransaksi in datatransaksiController.Listdatatransaksi)
            {
                table.Rows.Add(datatransaksi.id_penyewa, datatransaksi.nama_penyewa, datatransaksi.tanggal_peminjaman, datatransaksi.tanggalpengembalian);
            }

            dataGridView1.DataSource = table;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UCTransactionsPemilik_Load(object sender, EventArgs e)
        {

        }
    }
}
