namespace Projek_Akhir_PBO.View.Pemilik
{
    partial class kategorialatform
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            textBoxKategori = new TextBox();
            button2edit = new Button();
            button3hapus = new Button();
            button1tambah = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(-1, -2);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(228, 41);
            label1.TabIndex = 1;
            label1.Text = "KATEGORI ALAT";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(500, 152);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 263);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 3;
            label2.Text = "Nama Kategori";
            // 
            // textBoxKategori
            // 
            textBoxKategori.Location = new Point(174, 263);
            textBoxKategori.Name = "textBoxKategori";
            textBoxKategori.Size = new Size(188, 31);
            textBoxKategori.TabIndex = 4;
            // 
            // button2edit
            // 
            button2edit.BackColor = Color.RoyalBlue;
            button2edit.FlatStyle = FlatStyle.Flat;
            button2edit.ForeColor = Color.White;
            button2edit.Location = new Point(205, 319);
            button2edit.Name = "button2edit";
            button2edit.Size = new Size(112, 34);
            button2edit.TabIndex = 6;
            button2edit.Text = "Edit";
            button2edit.UseVisualStyleBackColor = false;
            button2edit.Click += button2_Click;
            // 
            // button3hapus
            // 
            button3hapus.BackColor = Color.IndianRed;
            button3hapus.FlatStyle = FlatStyle.Flat;
            button3hapus.ForeColor = Color.White;
            button3hapus.Location = new Point(400, 319);
            button3hapus.Name = "button3hapus";
            button3hapus.Size = new Size(112, 34);
            button3hapus.TabIndex = 7;
            button3hapus.Text = "Hapus";
            button3hapus.UseVisualStyleBackColor = false;
            button3hapus.Click += button3hapus_Click;
            // 
            // button1tambah
            // 
            button1tambah.BackColor = Color.FromArgb(97, 191, 143);
            button1tambah.FlatStyle = FlatStyle.Flat;
            button1tambah.ForeColor = Color.White;
            button1tambah.Location = new Point(12, 319);
            button1tambah.Name = "button1tambah";
            button1tambah.Size = new Size(112, 34);
            button1tambah.TabIndex = 8;
            button1tambah.Text = "Tambah";
            button1tambah.UseVisualStyleBackColor = false;
            button1tambah.Click += button1tambah_Click;
            // 
            // kategorialatform
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 900);
            Controls.Add(button1tambah);
            Controls.Add(button3hapus);
            Controls.Add(button2edit);
            Controls.Add(textBoxKategori);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "kategorialatform";
            Text = "kategorialatform";
            Load += kategorialatform_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox textBoxKategori;
        private Button button2edit;
        private Button button3hapus;
        private Button button1tambah;
    }
}