using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projek_Akhir_PBO.Controller.Pemilik;

namespace Projek_Akhir_PBO.View.Penyewa
{
    public partial class UCHomePenyewa : UserControl
    {
        private int _userId;

        public int UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
                //kategoriController.UserId = _userId;
                // Load data or perform operations based on the new UserId value
            }
        }
        public UCHomePenyewa()
        {
            InitializeComponent();
        }

        private void paneltopdashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UCHomePenyewa_Load(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
