namespace Projek_Akhir_PBO.View.Pemilik
{
    partial class UCStockPemilik
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            paneltopdashboard = new Guna.UI2.WinForms.Guna2Panel();
            juduldashboard = new Label();
            label1 = new Label();
            comboBox1Status = new ComboBox();
            button1tambah = new Button();
            button2edit = new Button();
            textBoxKategori = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            Stok = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            paneltopdashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // paneltopdashboard
            // 
            paneltopdashboard.BackColor = Color.FromArgb(245, 248, 241);
            paneltopdashboard.BorderColor = Color.FromArgb(91, 80, 80);
            paneltopdashboard.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            paneltopdashboard.Controls.Add(juduldashboard);
            paneltopdashboard.CustomBorderColor = Color.FromArgb(217, 224, 184);
            paneltopdashboard.CustomBorderThickness = new Padding(0, 0, 0, 1);
            paneltopdashboard.CustomizableEdges = customizableEdges7;
            paneltopdashboard.Dock = DockStyle.Top;
            paneltopdashboard.Location = new Point(0, 0);
            paneltopdashboard.Name = "paneltopdashboard";
            paneltopdashboard.ShadowDecoration.CustomizableEdges = customizableEdges8;
            paneltopdashboard.Size = new Size(1277, 131);
            paneltopdashboard.TabIndex = 45;
            // 
            // juduldashboard
            // 
            juduldashboard.AutoSize = true;
            juduldashboard.BackColor = Color.Transparent;
            juduldashboard.Font = new Font("Lufga", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            juduldashboard.ForeColor = Color.FromArgb(91, 80, 80);
            juduldashboard.ImageAlign = ContentAlignment.MiddleLeft;
            juduldashboard.Location = new Point(34, 41);
            juduldashboard.Name = "juduldashboard";
            juduldashboard.Size = new Size(147, 52);
            juduldashboard.TabIndex = 20;
            juduldashboard.Text = "Stocks";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(443, 452);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 60;
            label1.Text = "Status";
            // 
            // comboBox1Status
            // 
            comboBox1Status.Font = new Font("Segoe UI", 15F);
            comboBox1Status.FormattingEnabled = true;
            comboBox1Status.Items.AddRange(new object[] { "Aktif", "Tidak Aktif" });
            comboBox1Status.Location = new Point(611, 447);
            comboBox1Status.Name = "comboBox1Status";
            comboBox1Status.Size = new Size(189, 36);
            comboBox1Status.TabIndex = 59;
            // 
            // button1tambah
            // 
            button1tambah.BackColor = Color.FromArgb(97, 191, 143);
            button1tambah.FlatStyle = FlatStyle.Flat;
            button1tambah.Font = new Font("Segoe UI", 20F);
            button1tambah.ForeColor = Color.White;
            button1tambah.Location = new Point(37, 613);
            button1tambah.Margin = new Padding(2);
            button1tambah.Name = "button1tambah";
            button1tambah.Size = new Size(144, 59);
            button1tambah.TabIndex = 58;
            button1tambah.Text = "Tambah";
            button1tambah.UseVisualStyleBackColor = false;
            button1tambah.Click += button1tambah_Click;
            // 
            // button2edit
            // 
            button2edit.BackColor = Color.RoyalBlue;
            button2edit.FlatStyle = FlatStyle.Flat;
            button2edit.Font = new Font("Segoe UI", 20F);
            button2edit.ForeColor = Color.White;
            button2edit.Location = new Point(279, 613);
            button2edit.Margin = new Padding(2);
            button2edit.Name = "button2edit";
            button2edit.Size = new Size(114, 59);
            button2edit.TabIndex = 57;
            button2edit.Text = "Edit";
            button2edit.UseVisualStyleBackColor = false;
            // 
            // textBoxKategori
            // 
            textBoxKategori.Font = new Font("Segoe UI", 15F);
            textBoxKategori.Location = new Point(204, 389);
            textBoxKategori.Margin = new Padding(2);
            textBoxKategori.Name = "textBoxKategori";
            textBoxKategori.Size = new Size(189, 34);
            textBoxKategori.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(34, 389);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 55;
            label2.Text = "Nama Barang";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 147);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(766, 223);
            dataGridView1.TabIndex = 54;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(204, 449);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 34);
            textBox1.TabIndex = 62;
            // 
            // Stok
            // 
            Stok.AutoSize = true;
            Stok.Font = new Font("Segoe UI", 15F);
            Stok.Location = new Point(34, 449);
            Stok.Margin = new Padding(2, 0, 2, 0);
            Stok.Name = "Stok";
            Stok.Size = new Size(51, 28);
            Stok.TabIndex = 61;
            Stok.Text = "Stok";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(611, 389);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 34);
            textBox2.TabIndex = 64;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(441, 389);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 63;
            label4.Text = "Harga";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15F);
            textBox3.Location = new Point(204, 511);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(189, 34);
            textBox3.TabIndex = 66;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(34, 511);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 28);
            label5.TabIndex = 65;
            label5.Text = "Deskripsi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(443, 516);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 28);
            label3.TabIndex = 68;
            label3.Text = "Kategori";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 15F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Aktif", "Tidak Aktif" });
            comboBox1.Location = new Point(611, 511);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(189, 36);
            comboBox1.TabIndex = 67;
            // 
            // UCStockPemilik
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(Stok);
            Controls.Add(label1);
            Controls.Add(comboBox1Status);
            Controls.Add(button1tambah);
            Controls.Add(button2edit);
            Controls.Add(textBoxKategori);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(paneltopdashboard);
            Name = "UCStockPemilik";
            Size = new Size(1277, 864);
            paneltopdashboard.ResumeLayout(false);
            paneltopdashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel paneltopdashboard;
        private Label juduldashboard;
        private Label label1;
        private ComboBox comboBox1Status;
        private Button button1tambah;
        private Button button2edit;
        private TextBox textBoxKategori;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label Stok;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private Label label3;
        private ComboBox comboBox1;
    }
}
