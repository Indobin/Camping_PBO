using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Projek_Akhir_PBO.Controller.Admin;

namespace Projek_Akhir_PBO.View.Admin
{
    public partial class UCProfileAdmin : UserControl
    {
        private int _userId;
        ProfileControllerA profileControllerA;
        public int UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
                profileControllerA.UserId = _userId;
                // Load data or perform operations based on the new UserId value
            }
        }
        public UCProfileAdmin()
        {
            InitializeComponent();
            disabledProfile();
        }
        //string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=321;Database=Camping;CommandTimeout=10";
        
        public void disabledProfile()
        {
            textBoxNamaAdmin.Enabled = false;
            textBoxNoHp.Enabled = false;
        }

        private void button2edit_Click(object sender, EventArgs e)
        {
            textBoxNamaAdmin.Enabled = true;
            textBoxNoHp.Enabled = true;
        }

        private void UCProfileAdmin_Load(object sender, EventArgs e)
        {
            if (_userId > 0)
            {
                var profileData = profileControllerA.Read();
                if (profileData != null)
                {
                    textBoxNamaAdmin.Text = profileData.namaadmin;
                    textBoxNoHp.Text = profileData.no_hp;
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan untuk UserId ini.");
                }
            }
        }
    }
}
