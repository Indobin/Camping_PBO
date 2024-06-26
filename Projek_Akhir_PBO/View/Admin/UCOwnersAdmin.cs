﻿using Projek_Akhir_PBO.Controller.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Projek_Akhir_PBO.Controller.Pemilik;

namespace Projek_Akhir_PBO.View.Admin
{
    public partial class UCOwner : UserControl
    {
        private int _userId;
        ReadListController readListController;

        public int UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
                LoadDataGrid();
                //kategoriController.UserId = _userId;
                // Load data or perform operations based on the new UserId value
            }
        }


        public UCOwner()
        {
            readListController = new ReadListController();
            InitializeComponent();

        }
        DataTable table = new DataTable();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void juduldashboard_Click(object sender, EventArgs e)
        {

        }

        private void UCOwner_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = table;
            ShowListOwner();
            LoadDataGrid();
        }
        private void LoadDataGrid()
        {
            readListController.Read();
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nama Pemilik", typeof(string));
            table.Columns.Add("Nomor Telepon", typeof(string));
            table.Columns.Add("Alamat", typeof(string));
            table.Columns.Add("Pendapatan", typeof(string));
            foreach (var owner in readListController.ListOwner)
            {
                table.Rows.Add(owner.ID, owner.Nama_Pemilik, owner.No_Telepon_Pemilik
                                , owner.Alamat_Pemilik, owner.Pendapatan);
            }

            guna2DataGridView1.DataSource = table;
        }
        public void ShowListOwner()
        {
            LoadDataGrid();
            readListController.Read();
            guna2DataGridView1.DataSource = null;
            guna2DataGridView1.DataSource = readListController.ListOwner;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void list_pemilik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
