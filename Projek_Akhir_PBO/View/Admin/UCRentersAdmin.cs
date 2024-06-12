using Projek_Akhir_PBO.Controller.Admin;
using Projek_Akhir_PBO.Controller.Pemilik;
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
    public partial class UCRentersAdmin : UserControl
    {
        private int _userId;

        public int UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
                LoadDataGrid();
            }
        }

        ListRentersController listRentersController;
        public UCRentersAdmin()
        {
            listRentersController = new ListRentersController();
            InitializeComponent();

        }
        DataTable table = new DataTable();
        private void UCRentersAdmin_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = table;
            ShowListRenters();
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            listRentersController.Read();
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Nama Penyewa", typeof(string));
            table.Columns.Add("Nomor Telepon", typeof(string));
            table.Columns.Add("Alamat", typeof(string));
            table.Columns.Add("Jumlah Peminjaman", typeof(long));
            foreach (var renters in listRentersController.ListRenters)
            {
                table.Rows.Add(renters.ID, renters.Nama_Penyewa, renters.no_telepon_penyewa
                                , renters.alamat_penyewa, renters.jumlah_peminjaman);
            }

            guna2DataGridView1.DataSource = table;
        }

        public void ShowListRenters()
        {
            //LoadDataGrid();
            listRentersController.Read();
            guna2DataGridView1.DataSource = null;
            guna2DataGridView1.DataSource = listRentersController.ListRenters;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
