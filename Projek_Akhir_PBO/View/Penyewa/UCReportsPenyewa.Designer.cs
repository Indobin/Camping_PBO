namespace Projek_Akhir_PBO.View.Penyewa
{
    partial class UCReportsPenyewa
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            button1Clear = new Button();
            richTextTanggapan = new RichTextBox();
            guna2ComboBoxPeminjaman = new Guna.UI2.WinForms.Guna2ComboBox();
            label3 = new Label();
            label5 = new Label();
            label1 = new Label();
            button1tambah = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            paneltopdashboard = new Guna.UI2.WinForms.Guna2Panel();
            juduldashboard = new Label();
            richTextBoxLaporan = new RichTextBox();
            guna2tanggal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            paneltopdashboard.SuspendLayout();
            SuspendLayout();
            // 
            // button1Clear
            // 
            button1Clear.BackColor = Color.Red;
            button1Clear.FlatStyle = FlatStyle.Flat;
            button1Clear.Font = new Font("Lufga", 20.25F);
            button1Clear.ForeColor = Color.White;
            button1Clear.Location = new Point(1000, 237);
            button1Clear.Margin = new Padding(2);
            button1Clear.Name = "button1Clear";
            button1Clear.Size = new Size(114, 59);
            button1Clear.TabIndex = 94;
            button1Clear.Text = "Clear";
            button1Clear.UseVisualStyleBackColor = false;
            button1Clear.Click += button1Clear_Click;
            // 
            // richTextTanggapan
            // 
            richTextTanggapan.BorderStyle = BorderStyle.None;
            richTextTanggapan.EnableAutoDragDrop = true;
            richTextTanggapan.Font = new Font("Lufga", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextTanggapan.Location = new Point(611, 530);
            richTextTanggapan.Name = "richTextTanggapan";
            richTextTanggapan.Size = new Size(348, 215);
            richTextTanggapan.TabIndex = 93;
            richTextTanggapan.Text = "";
            // 
            // guna2ComboBoxPeminjaman
            // 
            guna2ComboBoxPeminjaman.BackColor = Color.White;
            guna2ComboBoxPeminjaman.CustomizableEdges = customizableEdges1;
            guna2ComboBoxPeminjaman.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBoxPeminjaman.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBoxPeminjaman.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBoxPeminjaman.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBoxPeminjaman.Font = new Font("Lufga", 14F);
            guna2ComboBoxPeminjaman.ForeColor = Color.Black;
            guna2ComboBoxPeminjaman.ItemHeight = 30;
            guna2ComboBoxPeminjaman.Location = new Point(611, 435);
            guna2ComboBoxPeminjaman.Name = "guna2ComboBoxPeminjaman";
            guna2ComboBoxPeminjaman.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ComboBoxPeminjaman.Size = new Size(299, 36);
            guna2ComboBoxPeminjaman.TabIndex = 88;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lufga", 15F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(611, 492);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 26);
            label3.TabIndex = 87;
            label3.Text = "Isi Tanggapan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lufga", 15F);
            label5.Location = new Point(34, 492);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 26);
            label5.TabIndex = 86;
            label5.Text = "Isi Laporan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lufga", 15F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(611, 397);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 26);
            label1.TabIndex = 83;
            label1.Text = "Peminjaman";
            // 
            // button1tambah
            // 
            button1tambah.BackColor = Color.FromArgb(97, 191, 143);
            button1tambah.FlatStyle = FlatStyle.Flat;
            button1tambah.Font = new Font("Lufga", 20.25F);
            button1tambah.ForeColor = Color.White;
            button1tambah.Location = new Point(1000, 154);
            button1tambah.Margin = new Padding(2);
            button1tambah.Name = "button1tambah";
            button1tambah.Size = new Size(114, 59);
            button1tambah.TabIndex = 82;
            button1tambah.Text = "Add";
            button1tambah.UseVisualStyleBackColor = false;
            button1tambah.Click += button1tambah_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lufga", 15F);
            label2.Location = new Point(34, 396);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(172, 26);
            label2.TabIndex = 80;
            label2.Text = "Tanggal Laporan";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Lufga", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(97, 191, 143);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CausesValidation = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Lufga", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(97, 191, 143);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(34, 154);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(925, 223);
            dataGridView1.TabIndex = 79;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // paneltopdashboard
            // 
            paneltopdashboard.BackColor = Color.FromArgb(245, 248, 241);
            paneltopdashboard.BorderColor = Color.FromArgb(91, 80, 80);
            paneltopdashboard.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            paneltopdashboard.Controls.Add(juduldashboard);
            paneltopdashboard.CustomBorderColor = Color.FromArgb(217, 224, 184);
            paneltopdashboard.CustomBorderThickness = new Padding(0, 0, 0, 1);
            paneltopdashboard.CustomizableEdges = customizableEdges3;
            paneltopdashboard.Dock = DockStyle.Top;
            paneltopdashboard.Location = new Point(0, 0);
            paneltopdashboard.Name = "paneltopdashboard";
            paneltopdashboard.ShadowDecoration.CustomizableEdges = customizableEdges4;
            paneltopdashboard.Size = new Size(1277, 131);
            paneltopdashboard.TabIndex = 78;
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
            juduldashboard.Size = new Size(169, 52);
            juduldashboard.TabIndex = 20;
            juduldashboard.Text = "Reports";
            // 
            // richTextBoxLaporan
            // 
            richTextBoxLaporan.BorderStyle = BorderStyle.None;
            richTextBoxLaporan.Font = new Font("Lufga", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxLaporan.Location = new Point(34, 530);
            richTextBoxLaporan.Name = "richTextBoxLaporan";
            richTextBoxLaporan.Size = new Size(348, 215);
            richTextBoxLaporan.TabIndex = 95;
            richTextBoxLaporan.Text = "";
            // 
            // guna2tanggal
            // 
            guna2tanggal.Checked = true;
            guna2tanggal.CustomizableEdges = customizableEdges5;
            guna2tanggal.FillColor = Color.White;
            guna2tanggal.Font = new Font("Lufga", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2tanggal.Format = DateTimePickerFormat.Long;
            guna2tanggal.Location = new Point(34, 435);
            guna2tanggal.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            guna2tanggal.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            guna2tanggal.Name = "guna2tanggal";
            guna2tanggal.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2tanggal.Size = new Size(200, 36);
            guna2tanggal.TabIndex = 96;
            guna2tanggal.Value = new DateTime(2024, 6, 9, 15, 45, 36, 97);
            // 
            // UCReportsPenyewa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2tanggal);
            Controls.Add(richTextBoxLaporan);
            Controls.Add(button1Clear);
            Controls.Add(richTextTanggapan);
            Controls.Add(guna2ComboBoxPeminjaman);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(button1tambah);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(paneltopdashboard);
            Name = "UCReportsPenyewa";
            Size = new Size(1277, 864);
            Load += UCReportsPenyewa_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            paneltopdashboard.ResumeLayout(false);
            paneltopdashboard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1Clear;
        private RichTextBox richTextTanggapan;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxPeminjaman;
        private Label label3;
        private Label label5;
        private Label label1;
        private Button button1tambah;
        private Label label2;
        private DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Panel paneltopdashboard;
        private Label juduldashboard;
        private RichTextBox richTextBoxLaporan;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2tanggal;
    }
}
