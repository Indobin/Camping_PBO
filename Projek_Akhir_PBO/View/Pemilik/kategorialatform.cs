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
using Projek_Akhir_PBO.Models.Pemilik;

namespace Projek_Akhir_PBO.View.Pemilik
{
    public partial class kategorialatform : Form
    {
        private int idKategoriSelected = -1;
        //KategoriContext kategoriContext;
        string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=321;Database=Camping;CommandTimeout=10";
        KategoriController kategoriController;
        int index;
        public kategorialatform()
        {
            kategoriController = new KategoriController();
            InitializeComponent();

        }
        private NpgsqlConnection conn;

        DataTable table = new DataTable();
        private void kategorialatform_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Nama Kategori", typeof(string));
            dataGridView1.DataSource = table;
            ShowListKategori();
        }
        public void ShowListKategori()
        {
            kategoriController.Read();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = kategoriController.ListKategori;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBoxKategori.Text);
        }

        private void button1tambah_Click(object sender, EventArgs e)
        {
            kategoriController.Tambah(textBoxKategori.Text);
            ShowListKategori();
            //string connString = "Host=localhost;Username=postgres;Password=321;Database=Camping";


        }
        private void button2_Click(object sender, EventArgs e)
        {
            kategoriController.Edit(idKategoriSelected, textBoxKategori.Text);
            ShowListKategori();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            idKategoriSelected = Convert.ToInt32(row.Cells[0].Value); // Asumsi ID kategori ada di kolom pertama
            textBoxKategori.Text = row.Cells[1].Value.ToString();
        }

        private void button3hapus_Click(object sender, EventArgs e)
        {
            kategoriController.Hapus(idKategoriSelected, textBoxKategori.Text);
            ShowListKategori();
        }
    }
}
