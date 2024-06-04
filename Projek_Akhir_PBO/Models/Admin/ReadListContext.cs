using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_Akhir_PBO.Models.Admin
{
    public class ReadListContext
    {
        public int id_pemilik { get; set; }
        public string nama_pemilik { get; set; }

        public string username { get; set; }
        public string password { get; set; }
        public string no_telepon_pemilik {get; set; }
        public string alamat_pemilik { get; set; }

    }
}
