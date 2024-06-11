using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_Akhir_PBO.View.Penyewa
{
    public partial class UCItemHome : UserControl
    {
        public UCItemHome()
        {
            InitializeComponent();
        }
        public int id_alatcamping { get; set; }
        public int hargaalatcamping
        {
            get
            {
                int value;
                if (int.TryParse(lblPrice.Text, out value))
                {
                    return value;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                lblPrice.Text = value.ToString();
            }
        }
        public string namakategori { get; set; }

        public string namaalatcamping
        {
            get { return lblNama.Text; }
            set { lblNama.Text = value; }
        }

        public string deskripsialat
        {
            get { return lblDesc.Text; }
            set { lblDesc.Text = value; }
        }
    }
}
