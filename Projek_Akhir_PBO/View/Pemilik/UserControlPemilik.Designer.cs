namespace Projek_Akhir_PBO.View.Pemilik
{
    partial class UserControlPemilik
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
            panel1 = new Panel();
            mainpanel = new Panel();
            dashboard = new Button();
            profil = new Button();
            kategori_alat = new Button();
            alat_camping = new Button();
            ewallet = new Button();
            transaksi = new Button();
            logout = new Button();
            permintaan = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(mainpanel);
            panel1.Location = new Point(220, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(740, 437);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // mainpanel
            // 
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(0, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(740, 437);
            mainpanel.TabIndex = 0;
            // 
            // dashboard
            // 
            dashboard.BackgroundImage = Properties.Resources.Background_Dashboard;
            dashboard.FlatStyle = FlatStyle.Flat;
            dashboard.Image = Properties.Resources.icon_dashboard;
            dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            dashboard.Location = new Point(10, 120);
            dashboard.Name = "dashboard";
            dashboard.Size = new Size(198, 36);
            dashboard.TabIndex = 0;
            dashboard.Text = "DASHBOARD";
            dashboard.UseVisualStyleBackColor = true;
            dashboard.Click += dashboard_Click;
            // 
            // profil
            // 
            profil.BackgroundImage = Properties.Resources.Background_Dashboard;
            profil.FlatStyle = FlatStyle.Flat;
            profil.Image = Properties.Resources.icon_profil;
            profil.ImageAlign = ContentAlignment.MiddleLeft;
            profil.Location = new Point(10, 162);
            profil.Name = "profil";
            profil.Size = new Size(198, 36);
            profil.TabIndex = 1;
            profil.Text = "PROFIL";
            profil.UseVisualStyleBackColor = true;
            profil.Click += profil_Click;
            // 
            // kategori_alat
            // 
            kategori_alat.BackgroundImage = Properties.Resources.Background_Dashboard;
            kategori_alat.FlatStyle = FlatStyle.Flat;
            kategori_alat.Image = Properties.Resources.icon_kategori_alat;
            kategori_alat.ImageAlign = ContentAlignment.MiddleLeft;
            kategori_alat.Location = new Point(10, 204);
            kategori_alat.Name = "kategori_alat";
            kategori_alat.Size = new Size(198, 36);
            kategori_alat.TabIndex = 2;
            kategori_alat.Text = "KATEGORI ALAT";
            kategori_alat.UseVisualStyleBackColor = true;
            kategori_alat.Click += kategori_alat_Click;
            // 
            // alat_camping
            // 
            alat_camping.BackgroundImage = Properties.Resources.Background_Dashboard;
            alat_camping.FlatStyle = FlatStyle.Flat;
            alat_camping.Image = Properties.Resources.icon_alat_camping;
            alat_camping.ImageAlign = ContentAlignment.MiddleLeft;
            alat_camping.Location = new Point(10, 246);
            alat_camping.Name = "alat_camping";
            alat_camping.Size = new Size(198, 36);
            alat_camping.TabIndex = 3;
            alat_camping.Text = "ALAT CAMPING";
            alat_camping.UseVisualStyleBackColor = true;
            alat_camping.Click += alat_camping_Click;
            // 
            // ewallet
            // 
            ewallet.BackgroundImage = Properties.Resources.Background_Dashboard;
            ewallet.FlatStyle = FlatStyle.Flat;
            ewallet.Image = Properties.Resources.icon_ewallet;
            ewallet.ImageAlign = ContentAlignment.MiddleLeft;
            ewallet.Location = new Point(10, 372);
            ewallet.Name = "ewallet";
            ewallet.Size = new Size(198, 36);
            ewallet.TabIndex = 4;
            ewallet.Text = "E-WALLET";
            ewallet.UseVisualStyleBackColor = true;
            ewallet.Click += ewallet_Click;
            // 
            // transaksi
            // 
            transaksi.BackgroundImage = Properties.Resources.Background_Dashboard;
            transaksi.FlatStyle = FlatStyle.Flat;
            transaksi.Image = Properties.Resources.icon_transaksi;
            transaksi.ImageAlign = ContentAlignment.MiddleLeft;
            transaksi.Location = new Point(10, 330);
            transaksi.Name = "transaksi";
            transaksi.Size = new Size(198, 36);
            transaksi.TabIndex = 5;
            transaksi.Text = "TRANSAKSI";
            transaksi.UseVisualStyleBackColor = true;
            transaksi.Click += transaksi_Click;
            // 
            // logout
            // 
            logout.BackgroundImage = Properties.Resources.Background_Dashboard;
            logout.FlatStyle = FlatStyle.Flat;
            logout.Image = Properties.Resources.icon_logout;
            logout.ImageAlign = ContentAlignment.MiddleLeft;
            logout.Location = new Point(10, 414);
            logout.Name = "logout";
            logout.Size = new Size(198, 36);
            logout.TabIndex = 6;
            logout.Text = "LOGOUT";
            logout.UseVisualStyleBackColor = true;
            logout.Click += button1_Click;
            // 
            // permintaan
            // 
            permintaan.BackgroundImage = Properties.Resources.Background_Dashboard;
            permintaan.FlatStyle = FlatStyle.Flat;
            permintaan.Image = Properties.Resources.icon_permintaan;
            permintaan.ImageAlign = ContentAlignment.MiddleLeft;
            permintaan.Location = new Point(10, 288);
            permintaan.Name = "permintaan";
            permintaan.Size = new Size(198, 36);
            permintaan.TabIndex = 8;
            permintaan.Text = "PERMINTAAN";
            permintaan.UseVisualStyleBackColor = true;
            permintaan.Click += permintaan_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(960, 72);
            panel2.TabIndex = 9;
            // 
            // UserControlPemilik
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Background_Dashboard;
            Controls.Add(panel2);
            Controls.Add(permintaan);
            Controls.Add(logout);
            Controls.Add(transaksi);
            Controls.Add(ewallet);
            Controls.Add(alat_camping);
            Controls.Add(kategori_alat);
            Controls.Add(profil);
            Controls.Add(dashboard);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "UserControlPemilik";
            Size = new Size(960, 540);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button dashboard;
        private Button profil;
        private Button kategori_alat;
        private Button alat_camping;
        private Button ewallet;
        private Button transaksi;
        private Button logout;
        private Button permintaan;
        private Panel mainpanel;
        private Panel panel2;
    }
}
