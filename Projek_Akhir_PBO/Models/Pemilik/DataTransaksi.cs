using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Akhir_PBO.Models.Pemilik
{
    internal class DataTransaksi
    {
        public int id_penyewa;
        public string nama_penyewa;
        public string jenis_ewallet;
        public string nomor_ewallet;
        public DateTime tanggal_peminjaman;
        public DateTime tanggalpengembalian;
        public long total_harga_keseluruhan;
    }
}
