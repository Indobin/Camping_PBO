using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Akhir_PBO.Models.Penyewa
{
    internal class HistoryPy
    {
        public int id_peminjaman;
        public string tanggal_peminjaman;
        public string status_pinjam;
        public bool status_pinjam_bool;
        public string tanggal_pengembalian;
        public string status_kembali;
        public bool status_kembali_bool;
        public int lama_sewa;
        public long total_harga_keseluruhan;
        public string nomor_ewallet;

    }
}
