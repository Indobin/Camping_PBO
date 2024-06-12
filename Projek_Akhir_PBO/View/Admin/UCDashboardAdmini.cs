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

namespace Projek_Akhir_PBO.View.Admin
{
    public partial class UCDashboardAdmini : UserControl
    {
        private int _userId;
        DashboardControllerA dashboardControllerA;
        public int UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
            }
        }
        public UCDashboardAdmini()
        {
            dashboardControllerA = new DashboardControllerA();
            InitializeComponent();
            Owners();
            Renters();
            Rentals();
        }

       

        public void Owners()
        {
            string query = string.Format(@"SELECT COUNT(id_pemilik) FROM pemilik;");
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
        public void Renters()
        {
            string query = string.Format(@"SELECT COUNT(id_penyewa) FROM penyewa;");
            using (var db = new DBConnection())
            {
                db.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, db.Connection))
                {
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int count = Convert.ToInt32(reader[0]);
                        Total_TRE.Text = count.ToString();
                    }
                    reader.Close();
                }
            }
        }
        public void Rentals()
        {
            string query = string.Format(@"SELECT COUNT(id_peminjaman) FROM peminjaman WHERE status_pinjam=true ;");
            using (var db = new DBConnection())
            {
                db.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, db.Connection))
                {
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int count = Convert.ToInt32(reader[0]);
                        Total_TRA.Text = count.ToString();
                    }
                    reader.Close();
                }
            }
        }
    }
}
