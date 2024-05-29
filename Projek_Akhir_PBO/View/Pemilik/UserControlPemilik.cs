using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Projek_Akhir_PBO.View.Pemilik
{
    public partial class UserControlPemilik : UserControl
    {
        Form1 FormParent;
        public UserControlPemilik(Form1 FormParent)
        {
            this.FormParent = FormParent;
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            loadform(new dashboardform());
        }

        private void profil_Click(object sender, EventArgs e)
        {
            loadform(new profilform());
        }

        private void kategori_alat_Click(object sender, EventArgs e)
        {
            loadform(new kategorialatform());
        }

        private void alat_camping_Click(object sender, EventArgs e)
        {
            loadform(new alatcampingform());
        }

        private void permintaan_Click(object sender, EventArgs e)
        {
            loadform(new permintaanform());
        }

        private void transaksi_Click(object sender, EventArgs e)
        {
            loadform(new transaksiform());
        }

        private void ewallet_Click(object sender, EventArgs e)
        {
            loadform(new ewalletform());
        }
    }
}
