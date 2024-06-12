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
using Projek_Akhir_PBO.Tools;

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
            
            string query = "select * from alat_camping ac join kategori_alat_camping kac on (ac.id_kategori=kac.id_kategori)";
            using (var db = new DBConnection())
            {
                db.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, db.Connection))
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
