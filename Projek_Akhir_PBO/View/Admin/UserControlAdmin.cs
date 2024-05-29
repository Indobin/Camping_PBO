using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_Akhir_PBO.View.Admin
{
    public partial class UserControlAdmin : UserControl
    {
        Form1 FormParent;
        public UserControlAdmin(Form1 FormParent)
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

        private void buttondashboard_Click(object sender, EventArgs e)
        {

        }

        private void button2laporan_Click(object sender, EventArgs e)
        {

        }
    }
}
