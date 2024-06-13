using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Akhir_PBO.Models.Pemilik
{
    internal class Stock
    {
        public int id_alatcamping { get; set; }
        public string namaalatcamping { get; set; }
        public int hargaalatcamping { get; set; }
        public int jumlahalatcamping { get; set; }
        public string deskripsi { get; set; }
        public int id_kategori { get; set; }
        public bool dihentikan { get; set; }
        public string status { get; set; }
        public string namakategori { get; set; }
        
    }
}
