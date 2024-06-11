using Projek_Akhir_PBO.Controller.Admin;
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
    public partial class UCRentersAdmin : UserControl
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

        ListRentersController listRentersController;
        public UCRentersAdmin()
        {
            listRentersController = new ListRentersController();
            InitializeComponent();

        }
        DataTable table = new DataTable();
        private void UCRentersAdmin_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = table;
            ShowListRenters();
        }

        public void ShowListRenters()
        {
            listRentersController.Read();
            guna2DataGridView1.DataSource = null;
            guna2DataGridView1.DataSource = listRentersController.ListRenters;
        }
    }
}
