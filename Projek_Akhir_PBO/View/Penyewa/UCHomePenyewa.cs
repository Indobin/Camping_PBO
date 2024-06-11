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

namespace Projek_Akhir_PBO.View.Penyewa
{
    public partial class UCHomePenyewa : UserControl
    {
        string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=firsta;Database=Camping;CommandTimeout=10";

        private int _userId;

        public int UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
                //kategoriController.UserId = _userId;
                // Load data or perform operations based on the new UserId value
            }
        }
        public UCHomePenyewa()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void AddItems(string id, string name, string cat, string price, string desc)
        {
            if (panelItem == null)
            {
                throw new InvalidOperationException("panelitem or datagridTransaction is not initialized.");
            }

            var w = new UCItemHome()
            {
                namaalatcamping = name,
                hargaalatcamping = Convert.ToInt32(price),
                namakategori = cat,
                id_alatcamping = Convert.ToInt32(id),
                deskripsialat = desc
            };

            panelItem.Controls.Add(w);
        }

        private void LoadProducts()
        {
            //string query = "select ac.id_alatcamping, ac.namaalatcamping, ac.jumlahalatcamping, kac.namakategori, ac.hargaalatcamping from alat_camping ac join kategori_alat_camping kac on (ac.id_kategori = kac.id_kategori) where ac.dihentikan = false and ac.jumlahalatcamping > 0";
            string query = "select * from alat_camping ac join kategori_alat_camping kac on (ac.id_kategori=kac.id_kategori)";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        foreach (DataRow item in dt.Rows)
                        {
                            AddItems(item["id_alatcamping"].ToString(), item["namaalatcamping"].ToString(), item["namakategori"].ToString(),
                                item["hargaalatcamping"].ToString(), item["deskripsi"].ToString());
                        }
                    }
                }
            }
        }
        private void paneltopdashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UCHomePenyewa_Load(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
