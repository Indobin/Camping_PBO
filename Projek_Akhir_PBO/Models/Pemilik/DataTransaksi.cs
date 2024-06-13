using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Akhir_PBO.Models.Pemilik
{
    internal class DataTransaksi
    {
    
        public string nama_penyewa {  get; set; }
        public string jenis_ewallet {  get; set; }
        public string nomor_ewallet { get; set; }
        public DateTime tanggal_peminjaman {  get; set; }
        public DateTime tanggalpengembalian { get; set; }
        public long total_harga_keseluruhan { get; set; }
        public int id_peminjaman { get; set; }
    }
}
