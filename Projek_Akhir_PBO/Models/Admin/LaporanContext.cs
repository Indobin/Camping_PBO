﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Akhir_PBO.Models.Admin
{
    public class LaporanContext
    {
        public int id_laporan { get; set; }
        public string tanggallaporan { get; set; }
        public string statuslaporan { get; set; }
        public bool statuslaporan_bool { get; set; }
        public string isi_laporan { get; set; }
        public string isi_tanggapan { get; set; }
        public int id_penyewa { get; set; }
        public int id_admin { get; set; }
        public int id_peminjaman { get; set; }
        public string nama_penyewa { get; set; }
        public string tanggal_peminjaman  { get; set; }
        public string peminjaman { get; set; }

    }
}
