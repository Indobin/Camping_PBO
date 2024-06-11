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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projek_Akhir_PBO.View.Pemilik
{
    public partial class UCCategoriesPemilik : UserControl
    {
        private int _userId;

        public int UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
                kategoriController.UserId = _userId;
                // Load data or perform operations based on the new UserId value
            }
        }
        private int idKategoriSelected = -1;
        //KategoriContext kategoriContext;
        //string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=321;Database=Camping;CommandTimeout=10";
        string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=firsta;Database=Camping;CommandTimeout=10";

        KategoriController kategoriController;
        int index;
        public UCCategoriesPemilik()
        {
            kategoriController = new KategoriController();
            InitializeComponent();
        }
        private NpgsqlConnection conn;

        DataTable table = new DataTable();
        private void button2edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxKategori.Text.Trim()))
            {
                MessageBox.Show("Nama Kategori tidak boleh kosong", "Tambah Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(comboBox1Status.Text.Trim()))
            {
                MessageBox.Show("Nama Kategori tidak boleh kosong", "Tambah Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string status = comboBox1Status.SelectedItem.ToString();
            bool dihentikan = (status == "Aktif") ? false : true;
            kategoriController.Edit(idKategoriSelected, textBoxKategori.Text, dihentikan);
            ShowListKategori();
        }

        private void button1tambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxKategori.Text.Trim()))
            {
                MessageBox.Show("Nama Kategori tidak boleh kosong", "Tambah Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(comboBox1Status.Text.Trim()))
            {
                MessageBox.Show("Nama Kategori tidak boleh kosong", "Tambah Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string status = comboBox1Status.SelectedItem.ToString();
            bool dihentikan = (status == "Aktif") ? false : true;
            kategoriController.Tambah(textBoxKategori.Text, dihentikan, status);
            ShowListKategori();
        }

        private void UCCategoriesPemilik_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Nama Kategori", typeof(string));
            table.Columns.Add("Status", typeof(string));
            dataGridView1.DataSource = table;
            ShowListKategori();
        }
        public void ShowListKategori()
        {
            kategoriController.Read();
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Nama Kategori", typeof(string));
            table.Columns.Add("Status", typeof(string));

            foreach (var kategori in kategoriController.ListKategori)
            {
                table.Rows.Add(kategori.id_kategori, kategori.namakategori, kategori.Status);
            }

            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                idKategoriSelected = Convert.ToInt32(row.Cells[0].Value);
                textBoxKategori.Text = row.Cells[1].Value.ToString();
                string status = row.Cells[2].Value.ToString();
                comboBox1Status.SelectedItem = status;
            }
        }

        //private void button3hapus_Click(object sender, EventArgs e)
        //{
        //    kategoriController.Hapus(idKategoriSelected, textBoxKategori.Text);
        //    ShowListKategori();
        //}
    }
}
