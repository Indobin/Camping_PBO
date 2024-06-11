using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_Akhir_PBO.Models
{
    public partial class UCHomeL : UserControl
    {
        public UCHomeL()
        {
            InitializeComponent();
        }

        public event EventHandler onSelect = null;

        public int HAcamping { get; set; }

        //buat event click saat memilih alat
        public string PCategory { get; set; }

        public string DesPenyewa
        {
            get { return deskripsialat.Text; }
            set { deskripsialat.Text = value; }
        }

        public string NACamping
        {
            get { return namaalat.Text; }
            set { namaalat.Text = value; }
        }

        private void deskripsialat_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }

}
