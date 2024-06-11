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
    public partial class UCItemCamping : UserControl
    {

        public UCItemCamping()
        {
            InitializeComponent();
        }

        public event EventHandler onSelect;

        public int id_alatcamping { get; set; }
        public int hargaalatcamping { get; set; }

        public int jumlahalatcamping
        {
            get
            {
                int value;
                if (int.TryParse(lblStock.Text, out value))
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
                lblStock.Text = value.ToString();
            }
        }

        public string namakategori
        {
            get { return lblItemCategory.Text; }
            set { lblItemCategory.Text = value; }
        }
        public string namaalatcamping
        {
            get { return lblItemName.Text; }
            set { lblItemName.Text = value; }
        }

        private void UCItemCamping_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void lblItemName_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void lblItemCategory_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }

        private void guna2ShadowPanel1_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
    }
}
