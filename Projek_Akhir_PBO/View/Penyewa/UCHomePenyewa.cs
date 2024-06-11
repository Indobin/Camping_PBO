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

        private void AddCategory()
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

