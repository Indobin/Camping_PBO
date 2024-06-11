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
        public string status { get; set; }
    }
}
