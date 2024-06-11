namespace Projek_Akhir_PBO.View.Penyewa
{
    partial class UCProfilePenyewa
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
            pictureBox1 = new PictureBox();
            textBoxUsername = new TextBox();
            textBoxNoHP = new TextBox();
            ButtonEdit = new Button();
            NamaPenyewa = new Label();
            NoHP = new Label();
            ButtonSave = new Button();
            AlamatPenyewa = new Label();
            textBoxAlamat = new TextBox();
            label1 = new Label();
            paneltopdashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            juduldashboard.Font = new Font("Microsoft Sans Serif", 29.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            juduldashboard.ForeColor = Color.FromArgb(91, 80, 80);
            juduldashboard.ImageAlign = ContentAlignment.MiddleLeft;
            juduldashboard.Location = new Point(34, 41);
            juduldashboard.Name = "juduldashboard";
            juduldashboard.Size = new Size(141, 46);
            juduldashboard.TabIndex = 20;
            juduldashboard.Text = "Profile";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icon_profil_removebg_preview;
            pictureBox1.Location = new Point(495, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.White;
            textBoxUsername.Font = new Font("Lufga", 20.2499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.Location = new Point(566, 490);
            textBoxUsername.Margin = new Padding(0);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(257, 43);
            textBoxUsername.TabIndex = 47;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // textBoxNoHP
            // 
            textBoxNoHP.BackColor = Color.White;
            textBoxNoHP.Font = new Font("Lufga", 20.2499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNoHP.Location = new Point(566, 561);
            textBoxNoHP.Multiline = true;
            textBoxNoHP.Name = "textBoxNoHP";
            textBoxNoHP.Size = new Size(257, 43);
            textBoxNoHP.TabIndex = 48;
            textBoxNoHP.Text = "\r\n";
            textBoxNoHP.TextChanged += textBox2_TextChanged;
            // 
            // ButtonEdit
            // 
            ButtonEdit.BackColor = Color.RoyalBlue;
            ButtonEdit.FlatStyle = FlatStyle.Flat;
            ButtonEdit.Font = new Font("Lufga", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonEdit.ForeColor = Color.White;
            ButtonEdit.Location = new Point(479, 703);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new Size(114, 59);
            ButtonEdit.TabIndex = 49;
            ButtonEdit.Text = "EDIT";
            ButtonEdit.UseVisualStyleBackColor = false;
            ButtonEdit.Click += button1_Click;
            // 
            // NamaPenyewa
            // 
            NamaPenyewa.Font = new Font("Lufga", 14.9999981F);
            NamaPenyewa.Location = new Point(387, 500);
            NamaPenyewa.Name = "NamaPenyewa";
            NamaPenyewa.Size = new Size(176, 28);
            NamaPenyewa.TabIndex = 50;
            NamaPenyewa.Text = "Nama Penyewa:";
            NamaPenyewa.Click += NamaPenyewa_Click;
            // 
            // NoHP
            // 
            NoHP.Font = new Font("Lufga", 14.9999981F);
            NoHP.Location = new Point(387, 571);
            NoHP.Name = "NoHP";
            NoHP.Size = new Size(173, 28);
            NoHP.TabIndex = 51;
            NoHP.Text = "Nomor Telepon:";
            // 
            // ButtonSave
            // 
            ButtonSave.BackColor = Color.FromArgb(97, 191, 143);
            ButtonSave.FlatStyle = FlatStyle.Flat;
            ButtonSave.Font = new Font("Lufga", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonSave.ForeColor = Color.White;
            ButtonSave.Location = new Point(709, 703);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(114, 59);
            ButtonSave.TabIndex = 52;
            ButtonSave.Text = "SAVE";
            ButtonSave.UseVisualStyleBackColor = false;
            ButtonSave.Click += button1_Click_1;
            // 
            // AlamatPenyewa
            // 
            AlamatPenyewa.Font = new Font("Lufga", 14.9999981F);
            AlamatPenyewa.Location = new Point(453, 633);
            AlamatPenyewa.Name = "AlamatPenyewa";
            AlamatPenyewa.Size = new Size(96, 28);
            AlamatPenyewa.TabIndex = 54;
            AlamatPenyewa.Text = "Alamat :";
            // 
            // textBoxAlamat
            // 
            textBoxAlamat.BackColor = Color.White;
            textBoxAlamat.Font = new Font("Lufga", 20.2499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAlamat.Location = new Point(566, 623);
            textBoxAlamat.Multiline = true;
            textBoxAlamat.Name = "textBoxAlamat";
            textBoxAlamat.Size = new Size(257, 45);
            textBoxAlamat.TabIndex = 55;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(633, 442);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 56;
            // 
            // UCProfilePenyewa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 241);
            Controls.Add(label1);
            Controls.Add(textBoxAlamat);
            Controls.Add(AlamatPenyewa);
            Controls.Add(ButtonSave);
            Controls.Add(NoHP);
            Controls.Add(NamaPenyewa);
            Controls.Add(ButtonEdit);
            Controls.Add(textBoxNoHP);
            Controls.Add(textBoxUsername);
            Controls.Add(pictureBox1);
            Controls.Add(paneltopdashboard);
            Name = "UCProfilePenyewa";
            Size = new Size(1277, 864);
            Load += UCProfilePenyewa_Load;
            paneltopdashboard.ResumeLayout(false);
            paneltopdashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel paneltopdashboard;
        private Label juduldashboard;
        private PictureBox pictureBox1;
        private TextBox textBoxUsername;
        private TextBox textBoxNoHP;
        private Button ButtonEdit;
        private Label NamaPenyewa;
        private Label NoHP;
        private Button ButtonSave;
        private TextBox textBox1;
        private TextBox textBoxAlamat;
        private Label AlamatPenyewa;
        private Label label1;
    }
}
