using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Akhir_PBO.Models.Pemilik
{
    internal class Renters
    {
        public int id_peminjaman { get; set; }
        public string nama_penyewa { get; set; }
        public string no_telepon_penyewa { get; set; }
        public string alamat_penyewa { get; set; }
        public DateTime tanggal_peminjaman { get; set; }
        public bool status_pinjam { get; set; }
        public string status_pinjam_string { get; set; }
        public DateTime? tanggalpengembalian { get; set; }
        public string status_kembali_string { get; set; }
        public bool? status_kembali { get; set; }
        public long total_harga_keseluruhan { get; set; }
        public string nomor_ewallet { get; set; }
    }
}
