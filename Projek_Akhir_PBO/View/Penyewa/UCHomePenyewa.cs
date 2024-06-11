using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Npgsql;
using Projek_Akhir_PBO.Controller.Pemilik;
using Projek_Akhir_PBO.Models;
using Projek_Akhir_PBO.View.Pemilik;
using Projek_Akhir_PBO.View.Penyewa;

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
            AddCategory();

            ProductPanel.Controls.Clear();
            LoadProducts();
        }
        string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=Renaldi;Database=Camping_PBO;CommandTimeout=10";

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
            string query = string.Format("SELECT * FROM alat_camping;");
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    CategoryPanel.Controls.Clear();

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                            b.FillColor = Color.FromArgb(220, 225, 189);
                            b.Size = new Size(141, 45);
                            b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                            b.Text = row["namaalatcamping"].ToString();

                            // event biar bisa di click
                            b.Click += new EventHandler(b_Click);

                            CategoryPanel.Controls.Add(b);
                        }
                    }
                }
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            foreach (var item in ProductPanel.Controls)
            {
                if (item is UCHomeL pro)
                {
                    pro.Visible = pro.PCategory.ToLower().Contains(b.Text.Trim().ToLower());
                }
            }
        }

        private void AddItems(string namaalatcamping, string hargaalatcamping, string deskripsi)
        {
            var w = new UCHomeL()
            {
                NACamping = namaalatcamping,
                HAcamping = Convert.ToInt32(hargaalatcamping),
                DesPenyewa = deskripsi,
            };

            ProductPanel.Controls.Add(w);
        }

        private void LoadProducts()
        {
            string query = string.Format("SELECT * FROM alat_camping;");
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow item in dt.Rows)
                    {
                        AddItems(item["namaalatcamping"].ToString(),
                            item["hargaalatcamping"].ToString(),
                            item["deskripsi"].ToString());
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
    }
}

