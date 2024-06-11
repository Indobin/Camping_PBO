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
    public partial class UCStockPemilik : UserControl
    {
        private int _userId;

        public int UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
                stockController.UserId = _userId;
                // Load data or perform operations based on the new UserId value
            }
        }
        int index;
        private int idBarangSelected = -1;
        StockController stockController;
        public UCStockPemilik()
        {
            stockController = new StockController();
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
        private void button1tambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2nama.Text.Trim()) || string.IsNullOrEmpty(guna2Harga.Text.Trim()))
            {
                MessageBox.Show("Nama barang atau harga tidak boleh kosong", "Tambah Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(guna2Stok.Text.Trim()) || string.IsNullOrEmpty(richTextDeskripsi.Text.Trim()))
            {
                MessageBox.Show("Stok atau deskirpsi tidak boleh kosong", "Tambah Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(guna2ComboBoxKategori.Text.Trim()) || string.IsNullOrEmpty(guna2ComboBoxStatus.Text.Trim()))
            {
                MessageBox.Show("kategori atau status tidak boleh kosong", "Tambah Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(guna2Harga.Text.Trim(), out int harga))
            {
                MessageBox.Show("Harga harus berupa angka", "Tambah Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(guna2Stok.Text.Trim(), out int stok))
            {
                MessageBox.Show("Jumlah stok harus berupa angka", "Tambah Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string status = guna2ComboBoxStatus.SelectedItem.ToString();
            ComboBoxItem kategoriselect = (ComboBoxItem)guna2ComboBoxKategori.SelectedItem;
            bool dihentikan = (status == "Aktif") ? false : true;
            Stock stock = new Stock
            {
                namaalatcamping = guna2nama.Text.Trim(),
                hargaalatcamping = int.Parse(guna2Harga.Text.Trim()),
                jumlahalatcamping = int.Parse(guna2Stok.Text.Trim()),
                deskripsi = richTextDeskripsi.Text.Trim(),
                id_kategori = kategoriselect.Value,
                dihentikan = dihentikan
            };

            stockController.Tambah(stock, guna2nama.Text);
            MessageBox.Show("Alat camping berhasil ditambahkan.", "Tambah Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //ResetInputFields();
            DataAlat();
        }

        private void UCStockPemilik_Load(object sender, EventArgs e)
        {
            DataAlat();
            datakategori();
        }
        public void DataAlat()
        {
            stockController.Read();
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Nama Barang", typeof(string));
            table.Columns.Add("Harga", typeof(int));
            table.Columns.Add("Stok", typeof(int));
            table.Columns.Add("Status", typeof(string));
            table.Columns.Add("Kategori", typeof(string));
            table.Columns.Add("Deskripsi", typeof(string));
            foreach (var alat in stockController.ListStock)
            {
                table.Rows.Add(alat.id_alatcamping, alat.namaalatcamping, alat.hargaalatcamping
                                , alat.jumlahalatcamping, alat.status, alat.namakategori, alat.deskripsi);
            }

            dataGridView1.DataSource = table;
        }

        private void guna2ComboBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=321;Database=Camping;CommandTimeout=10";
        string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=firsta;Database=Camping;CommandTimeout=10";

        private void datakategori()
        {
            string query = "SELECT namakategori, id_kategori FROM kategori_alat_camping WHERE id_pemilik=@userId AND dihentikan=false";

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
                                guna2ComboBoxKategori.Items.Add(new ComboBoxItem
                                {
                                    Text = reader["namakategori"].ToString(),
                                    Value = (int)reader["id_kategori"]
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

        private void guna2Harga_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1Clear_Click(object sender, EventArgs e)
        {
            guna2nama.Text = string.Empty;
            guna2Harga.Text = string.Empty;
            guna2Stok.Text = string.Empty;
            richTextDeskripsi.Text = string.Empty;
            guna2ComboBoxKategori.SelectedIndex = -1;
            guna2ComboBoxStatus.SelectedIndex = -1;
        }

        private void button2edit_Click(object sender, EventArgs e)
        {
            if (idBarangSelected == -1)
            {
                MessageBox.Show("Pilih Id yang ingin di edit!", "Edit Data",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(guna2nama.Text.Trim()) || string.IsNullOrEmpty(guna2Harga.Text.Trim()))
            {
                MessageBox.Show("Nama barang atau harga tidak boleh kosong", "Edit Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(guna2Stok.Text.Trim()) || string.IsNullOrEmpty(richTextDeskripsi.Text.Trim()))
            {
                MessageBox.Show("Stok atau deskirpsi tidak boleh kosong", "Edit Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(guna2ComboBoxKategori.Text.Trim()) || string.IsNullOrEmpty(guna2ComboBoxStatus.Text.Trim()))
            {
                MessageBox.Show("kategori atau status tidak boleh kosong", "Edit Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(guna2Harga.Text.Trim(), out int harga))
            {
                MessageBox.Show("Harga harus berupa angka", "Edit Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(guna2Stok.Text.Trim(), out int stok))
            {
                MessageBox.Show("Jumlah stok harus berupa angka", "Edit Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string status = guna2ComboBoxStatus.SelectedItem.ToString();
            ComboBoxItem kategoriselect = (ComboBoxItem)guna2ComboBoxKategori.SelectedItem;
            bool dihentikan = (status == "Aktif") ? false : true;
            Stock stock = new Stock
            {
                id_alatcamping = idBarangSelected,
                namaalatcamping = guna2nama.Text.Trim(),
                hargaalatcamping = int.Parse(guna2Harga.Text.Trim()),
                jumlahalatcamping = int.Parse(guna2Stok.Text.Trim()),
                deskripsi = richTextDeskripsi.Text.Trim(),
                id_kategori = kategoriselect.Value,
                dihentikan = dihentikan
            };

            stockController.Edit(stock, guna2nama.Text, idBarangSelected);
            MessageBox.Show("Alat camping berhasil diedit.", "Edit Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //ResetInputFields();
            DataAlat();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                idBarangSelected = Convert.ToInt32(row.Cells[0].Value);
                guna2nama.Text = row.Cells[1].Value.ToString();
                guna2Harga.Text = row.Cells[2].Value.ToString();
                guna2Stok.Text = row.Cells[3].Value.ToString();
                string status = row.Cells[4].Value.ToString();
                guna2ComboBoxStatus.SelectedItem = status;
                foreach (ComboBoxItem item in guna2ComboBoxKategori.Items)
                {
                    if (item.Text == row.Cells[5].Value.ToString())
                    {
                        guna2ComboBoxKategori.SelectedItem = item;
                        break;
                    }
                }
                richTextDeskripsi.Text = row.Cells[6].Value.ToString();
            }
           
        }
    }
}
