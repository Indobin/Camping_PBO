using Npgsql;
using Projek_Akhir_PBO.Models.Pemilik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Akhir_PBO.Controller.Pemilik
{
    internal class DataTransaksiContoller
    {
        private int _userId;
        public List<DataTransaksi> Listdatatransaksi = new List<DataTransaksi>();
        string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=spensaganomor1;Database=Camping;CommandTimeout=10";

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public void Read()
        {
            string query = @"select py.id_penyewa,py.nama_penyewa,p.tanggal_peminjaman,pg.tanggalpengembalian
                            from peminjaman p 
                            join penyewa py on p.id_penyewa = py.id_penyewa
                            join pengembalian pg on p.id_peminjaman = pg.id_peminjaman
                            Order By py.id_penyewa;";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                conn.Open();
                using (NpgsqlCommand data = new NpgsqlCommand(query, conn))
                {
                    data.Parameters.AddWithValue("@userId", _userId);
                    NpgsqlDataReader reader = data.ExecuteReader();
                    Listdatatransaksi.Clear();
                    while (reader.Read())
                    {
                        DataTransaksi dataTransakasi = new DataTransaksi();
                        dataTransakasi.id_penyewa = (int)reader["id_penyewa"];
                        dataTransakasi.nama_penyewa = (string)reader["nama_penyewa"];
                        dataTransakasi.tanggal_peminjaman = (DateTime)reader["tanggal_peminjaman"];
                        if (reader["tanggalpengembalian"] != DBNull.Value)
                        {
                            dataTransakasi.tanggalpengembalian = (DateTime)reader["tanggalpengembalian"];
                        }
                        else
                        {
                            dataTransakasi.tanggalpengembalian = null;
                        }

                        Listdatatransaksi.Add(dataTransakasi);
                    }
                }
            }
        }
    }


}
