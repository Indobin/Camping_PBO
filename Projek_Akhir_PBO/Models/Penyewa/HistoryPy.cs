using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Akhir_PBO.Models.Penyewa
{
    internal class HistoryPy
    {
        public int id_peminjaman {  get; set; }
        public string tanggal_peminjaman;
        public string status_pinjam {  get; set; }
        public bool status_pinjam_bool {  get; set; }
        public string tanggal_pengembalian {  get; set; }
        public string status_kembali {  get; set; }
        public bool status_kembali_bool {  get; set; }
        public int lama_sewa {  get; set; }
        public long total_harga_keseluruhan {  get; set; }
        public string nomor_ewallet {  get; set; }

    }
}
