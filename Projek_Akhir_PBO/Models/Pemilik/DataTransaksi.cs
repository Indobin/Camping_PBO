using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Akhir_PBO.Models.Pemilik
{
    internal class DataTransaksi
    {
        public int id_penyewa { get; set; }
        public string nama_penyewa { get; set; }
        public DateTime tanggal_peminjaman { get; set; }
        public DateTime tanggalpengembalian { get; set; }
    }
}
