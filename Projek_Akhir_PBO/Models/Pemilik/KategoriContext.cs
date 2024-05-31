using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Projek_Akhir_PBO.Controller.Pemilik;

namespace Projek_Akhir_PBO.Models.Pemilik
{
    public class KategoriContext
    {
        public int id_kategori { get; set; }
        public string namakategori { get; set; }
    }
}
