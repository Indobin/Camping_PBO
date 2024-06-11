﻿using System;
using System.Collections;
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
using Projek_Akhir_PBO.Models.Pemilik;

namespace Projek_Akhir_PBO.View.Penyewa
{
    public partial class UCTransactionsPenyewa : UserControl
    {
        string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=firsta;Database=Camping;CommandTimeout=10";

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
        public UCTransactionsPenyewa()
        {
            InitializeComponent();
            itemPanel.Controls.Clear();
            LoadProducts();
        }

        private void UCTransactionsPenyewa_Load(object sender, EventArgs e)
        {
            datagridTransaction.BorderStyle = BorderStyle.FixedSingle;
        }

        private void AddItems(string id, string name, string cat, string price, string stock)
        {
            if (itemPanel == null || datagridTransaction == null)
            {
                throw new InvalidOperationException("itemPanel or datagridTransaction is not initialized.");
            }

            var w = new UCItemCamping()
            {
                namaalatcamping = name,
                hargaalatcamping = Convert.ToInt32(price),
                jumlahalatcamping = Convert.ToInt32(stock),
                namakategori = cat,
                id_alatcamping = Convert.ToInt32(id)
            };

            itemPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (UCItemCamping)ss;

                foreach (DataGridViewRow item in datagridTransaction.Rows)
                {
                    if (item.Cells["dgvId"].Value != null && Convert.ToInt32(item.Cells["dgvId"].Value) == wdg.id_alatcamping)
                    {
                        if (item.Cells["dgvQty"].Value != null && item.Cells["dgvPrice"].Value != null)
                        {
                            item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                            item.Cells["dgvAmount"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) * double.Parse(item.Cells["dgvPrice"].Value.ToString());
                            GetTotal();
                            return;
                        }
                    }
                }

                datagridTransaction.Rows.Add(new object[] { 0, wdg.id_alatcamping, wdg.namaalatcamping, 1, wdg.hargaalatcamping, wdg.hargaalatcamping });
                GetTotal();
            };
        }

        private void GetTotal()
        {
            double tot = 0;

            foreach (DataGridViewRow item in datagridTransaction.Rows)
            {
                if (item.Cells["dgvAmount"].Value != null)
                {
                    tot += double.Parse(item.Cells["dgvAmount"].Value.ToString());
                }
            }

            lblTotal.Text = tot.ToString();
        }

        private void LoadProducts()
        {
            //string query = "select ac.id_alatcamping, ac.namaalatcamping, ac.jumlahalatcamping, kac.namakategori, ac.hargaalatcamping from alat_camping ac join kategori_alat_camping kac on (ac.id_kategori = kac.id_kategori) where ac.dihentikan = false and ac.jumlahalatcamping > 0";
            string query = "select * from alat_camping ac join kategori_alat_camping kac on (ac.id_kategori=kac.id_kategori)";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                conn.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        foreach (DataRow item in dt.Rows)
                        {
                            AddItems(item["id_alatcamping"].ToString(), item["namaalatcamping"].ToString(), item["namakategori"].ToString(),
                                item["hargaalatcamping"].ToString(), item["jumlahalatcamping"].ToString());
                        }
                    }
                }
            }
        }

        private void datagridTransaction_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in datagridTransaction.Rows)
            {
                count++;
                row.Cells[0].Value = count;
            }
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            InsertTransaction();
        }

        public void InsertTransaction()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Insert into pembayaran_ewallet
                        string insertPembayaranEwalletQuery = @"
                        INSERT INTO pembayaran_ewallet (nomor_ewallet, jenis_ewallet)
                        VALUES (@nomor_ewallet, @jenis_ewallet)
                        RETURNING id_ewallet";

                        int idEwallet;
                        using (var cmd = new NpgsqlCommand(insertPembayaranEwalletQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@nomor_ewallet", boxNoEWallet.Text.Trim());
                            cmd.Parameters.AddWithValue("@jenis_ewallet", comboBoxEWallet.Text.Trim());
                            idEwallet = (int)cmd.ExecuteScalar();
                        }

                        // Insert into peminjaman
                        string insertPeminjamanQuery = @"
                        INSERT INTO peminjaman (id_penyewa, tanggal_peminjaman, id_ewallet, status_pinjam)
                        VALUES (@UserId, @TanggalPinjam, @IdEwallet, @Status)
                        RETURNING id_peminjaman";

                        int idPeminjaman;
                        using (var cmd = new NpgsqlCommand(insertPeminjamanQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@UserId", _userId);
                            cmd.Parameters.AddWithValue("@TanggalPinjam", DateTime.Now);
                            cmd.Parameters.AddWithValue("@IdEwallet", idEwallet);
                            cmd.Parameters.AddWithValue("@Status", false);
                            idPeminjaman = (int)cmd.ExecuteScalar();
                        }

                        // Insert into detail_peminjaman
                        string insertDetailPeminjamanQuery = @"
                        INSERT INTO detail_transaksi (id_peminjaman, id_alatcamping, lama_sewa, quantity)
                        VALUES (@IdPeminjaman, @IdAlatCamping, @LamaSewa, @qty)";

                        foreach (DataGridViewRow row in datagridTransaction.Rows)
                        {
                            if (row.Cells["dgvId"].Value != null)
                            {
                                using (var cmd = new NpgsqlCommand(insertDetailPeminjamanQuery, conn))
                                {
                                    cmd.Parameters.AddWithValue("@IdPeminjaman", idPeminjaman);
                                    cmd.Parameters.AddWithValue("@IdAlatCamping", Convert.ToInt32(row.Cells["dgvId"].Value));
                                    cmd.Parameters.AddWithValue("@qty", Convert.ToInt32(row.Cells["dgvQty"].Value));
                                    cmd.Parameters.AddWithValue("@LamaSewa", int.Parse(guna2TextBoxRent.Text.Trim())); // Assuming 1 for now, adjust as needed
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }

                        // Commit transaction
                        transaction.Commit();
                        clearAll();
                        MessageBox.Show("");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error occurred: " + ex.Message);
                    }
                }
            }
        }

        public void clearAll()
        {
            datagridTransaction.Rows.Clear();
            boxNoEWallet.Text = string.Empty;
            comboBoxEWallet.Text = string.Empty;
            guna2TextBoxRent.Text = string.Empty;
            lblTotal.Text = string.Empty;
        }
        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            datagridTransaction.Rows.Clear();
            boxNoEWallet.Text = string.Empty;
            comboBoxEWallet.Text = string.Empty;
            guna2TextBoxRent.Text = string.Empty;
            lblTotal.Text = string.Empty;
        }

    }
}
