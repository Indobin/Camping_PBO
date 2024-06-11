using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Akhir_PBO.Models.Penyewa
{
    internal class HistoryDetailPy
    {
        internal class DetailPeminjaman
        {
            public string NamaAlatCamping { get; set; }
            public int Quantity { get; set; }
            public int HargaAlatCamping { get; set; }
            public int Total_Harga { get; set; }
            //public int LamaSewa { get; set; }
        }

    }
}
