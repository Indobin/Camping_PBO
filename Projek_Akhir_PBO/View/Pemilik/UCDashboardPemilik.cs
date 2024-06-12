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
using Projek_Akhir_PBO.Controller.Admin;
using Projek_Akhir_PBO.Controller.Pemilik;
using Projek_Akhir_PBO.Tools;

namespace Projek_Akhir_PBO.View.Pemilik
{
    public partial class UCDashboardPemilik : UserControl
    {
        private int _userId;
        DashboardControllerPemilik dashboardControllerPemilik;
        public int UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
              
            }
        }
        public UCDashboardPemilik()
        {
            dashboardControllerPemilik = new DashboardControllerPemilik();
            InitializeComponent();
            Order();
            Permintaan();
            Equipments();
            Revenue();
        }
      

        public void Order()
        {
            string query = string.Format(@"select count(distinct pm.id_peminjaman) as total_order from pengembalian pb join peminjaman pm on pm.id_peminjaman = pb.id_peminjaman join detail_transaksi dt on dt.id_peminjaman = pm.id_peminjaman join alat_camping ac on ac.id_alatcamping = dt.id_alatcamping join pemilik pk on pk.id_pemilik = ac.id_pemilik where pm.status_pinjam = true and pb.status_kembali = true group by pm.id_peminjaman ;");
            using (var db = new DBConnection())
            {
                db.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, db.Connection))
                {
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int count = Convert.ToInt32(reader[0]);
                        Total_TO.Text = count.ToString();
                    }
                    reader.Close();
                }
            }
        }
        public void Permintaan()
        {
            string query = string.Format(@"select count(distinct pm.id_peminjaman) as total_permintaan from peminjaman pm join detail_transaksi dt on dt.id_peminjaman = pm.id_peminjaman join alat_camping ac on ac.id_alatcamping = dt.id_alatcamping join pemilik pk on pk.id_pemilik = ac.id_pemilik where status_pinjam = false and pk.id_pemilik = 1 group by pm.id_peminjaman having count(pm.id_peminjaman) > 0 ;");
            using (var db = new DBConnection())
            {
                db.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, db.Connection))
                {
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int count = Convert.ToInt32(reader[0]);
                        Total_TP.Text = count.ToString();
                    }
                    reader.Close();
                }
            }
        }
        public void Equipments()
        {
            string query = string.Format(@"select count(ac.id_alatcamping) from alat_camping ac join pemilik pk on pk.id_pemilik = ac.id_pemilik where pk.id_pemilik = 2 ;");
            using (var db = new DBConnection())
            {
                db.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, db.Connection))
                {
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int count = Convert.ToInt32(reader[0]);
                        Total_TE.Text = count.ToString();
                    }
                    reader.Close();
                }
            }
        }
        public void Revenue()
        {
            string query = string.Format(@"SELECT SUM(dt.lama_sewa * ac.hargaalatcamping * dt.quantity) AS total_revenue FROM pemilik p JOIN alat_camping ac ON p.id_pemilik = ac.id_pemilik JOIN detail_transaksi dt ON ac.id_alatcamping = dt.id_alatcamping JOIN peminjaman pem ON pem.id_peminjaman = dt.id_peminjaman JOIN pengembalian peng ON pem.id_peminjaman = peng.id_peminjaman WHERE peng.status_kembali = true GROUP BY p.id_pemilik
 ;");
            using (var db = new DBConnection())
            {
                db.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, db.Connection))
                {
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int count = Convert.ToInt32(reader[0]);
                        Total_TR.Text = count.ToString();
                    }
                    reader.Close();
                }
            }
        }
        private void paneltopdashboard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
