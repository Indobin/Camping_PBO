namespace Projek_Akhir_PBO.View.Pemilik
{
    partial class UCCategoriesPemilik
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            paneltopdashboard = new Guna.UI2.WinForms.Guna2Panel();
            juduldashboard = new Label();
            button1tambah = new Button();
            button3hapus = new Button();
            button2edit = new Button();
            textBoxKategori = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
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
            paneltopdashboard.CustomizableEdges = customizableEdges1;
            paneltopdashboard.Dock = DockStyle.Top;
            paneltopdashboard.Location = new Point(0, 0);
            paneltopdashboard.Name = "paneltopdashboard";
            paneltopdashboard.ShadowDecoration.CustomizableEdges = customizableEdges2;
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
            juduldashboard.Size = new Size(230, 52);
            juduldashboard.TabIndex = 20;
            juduldashboard.Text = "Categories";
            // 
            // button1tambah
            // 
            button1tambah.BackColor = Color.FromArgb(97, 191, 143);
            button1tambah.FlatStyle = FlatStyle.Flat;
            button1tambah.Font = new Font("Segoe UI", 15F);
            button1tambah.ForeColor = Color.White;
            button1tambah.Location = new Point(34, 460);
            button1tambah.Margin = new Padding(2);
            button1tambah.Name = "button1tambah";
            button1tambah.Size = new Size(100, 40);
            button1tambah.TabIndex = 51;
            button1tambah.Text = "Tambah";
            button1tambah.UseVisualStyleBackColor = false;
            button1tambah.Click += button1tambah_Click;
            // 
            // button3hapus
            // 
            button3hapus.BackColor = Color.IndianRed;
            button3hapus.FlatStyle = FlatStyle.Flat;
            button3hapus.Font = new Font("Segoe UI", 15F);
            button3hapus.ForeColor = Color.White;
            button3hapus.Location = new Point(437, 460);
            button3hapus.Margin = new Padding(2);
            button3hapus.Name = "button3hapus";
            button3hapus.Size = new Size(100, 40);
            button3hapus.TabIndex = 50;
            button3hapus.Text = "Hapus";
            button3hapus.UseVisualStyleBackColor = false;
            button3hapus.Click += button3hapus_Click;
            // 
            // button2edit
            // 
            button2edit.BackColor = Color.RoyalBlue;
            button2edit.FlatStyle = FlatStyle.Flat;
            button2edit.Font = new Font("Segoe UI", 15F);
            button2edit.ForeColor = Color.White;
            button2edit.Location = new Point(226, 460);
            button2edit.Margin = new Padding(2);
            button2edit.Name = "button2edit";
            button2edit.Size = new Size(100, 40);
            button2edit.TabIndex = 49;
            button2edit.Text = "Edit";
            button2edit.UseVisualStyleBackColor = false;
            button2edit.Click += button2edit_Click;
            // 
            // textBoxKategori
            // 
            textBoxKategori.Font = new Font("Segoe UI", 15F);
            textBoxKategori.Location = new Point(204, 389);
            textBoxKategori.Margin = new Padding(2);
            textBoxKategori.Name = "textBoxKategori";
            textBoxKategori.Size = new Size(189, 34);
            textBoxKategori.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(34, 389);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 47;
            label2.Text = "Nama Kategori";
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
            dataGridView1.Size = new Size(503, 223);
            dataGridView1.TabIndex = 46;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // UCCategoriesPemilik
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1tambah);
            Controls.Add(button3hapus);
            Controls.Add(button2edit);
            Controls.Add(textBoxKategori);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(paneltopdashboard);
            Name = "UCCategoriesPemilik";
            Size = new Size(1277, 864);
            Load += UCCategoriesPemilik_Load;
            paneltopdashboard.ResumeLayout(false);
            paneltopdashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel paneltopdashboard;
        private Label juduldashboard;
        private Button button1tambah;
        private Button button3hapus;
        private Button button2edit;
        private TextBox textBoxKategori;
        private Label label2;
        private DataGridView dataGridView1;
    }
}
