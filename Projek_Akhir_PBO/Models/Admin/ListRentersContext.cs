using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Akhir_PBO.Models.Admin
{
    internal class ListRentersContext
    {
        public int ID{ get; set; }
        public string Nama_Penyewa { get; set; }
        public string no_telepon_penyewa { get; set; }
        public string alamat_penyewa { get; set; }
        public long jumlah_peminjaman { get; set; }


    }
}
