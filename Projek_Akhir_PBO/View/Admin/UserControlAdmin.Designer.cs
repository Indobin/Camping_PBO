namespace Projek_Akhir_PBO.View.Admin
{
    partial class UserControlAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlAdmin));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button3logout = new Button();
            buttondashboard = new Button();
            label1 = new Label();
            buttonpemilik = new Button();
            buttonprofil = new Button();
            button2laporan = new Button();
            mainpanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 115, 116);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button3logout);
            panel1.Controls.Add(buttondashboard);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonpemilik);
            panel1.Controls.Add(buttonprofil);
            panel1.Controls.Add(button2laporan);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 540);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button3logout
            // 
            button3logout.BackColor = Color.FromArgb(64, 65, 56);
            button3logout.FlatAppearance.BorderSize = 0;
            button3logout.FlatStyle = FlatStyle.Flat;
            button3logout.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            button3logout.ForeColor = Color.White;
            button3logout.ImageAlign = ContentAlignment.MiddleLeft;
            button3logout.Location = new Point(0, 463);
            button3logout.Name = "button3logout";
            button3logout.Size = new Size(211, 34);
            button3logout.TabIndex = 2;
            button3logout.Text = "LOGOUT";
            button3logout.UseVisualStyleBackColor = false;
            // 
            // buttondashboard
            // 
            buttondashboard.AutoSize = true;
            buttondashboard.BackColor = Color.FromArgb(14, 115, 116);
            buttondashboard.FlatAppearance.BorderSize = 0;
            buttondashboard.FlatStyle = FlatStyle.Flat;
            buttondashboard.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            buttondashboard.ForeColor = Color.White;
            buttondashboard.Image = (Image)resources.GetObject("buttondashboard.Image");
            buttondashboard.ImageAlign = ContentAlignment.MiddleLeft;
            buttondashboard.Location = new Point(1, 91);
            buttondashboard.Name = "buttondashboard";
            buttondashboard.Size = new Size(210, 35);
            buttondashboard.TabIndex = 4;
            buttondashboard.Text = "DASHBOARD";
            buttondashboard.UseVisualStyleBackColor = false;
            buttondashboard.Click += buttondashboard_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(14, 115, 116);
            label1.ForeColor = Color.FromArgb(220, 225, 189);
            label1.Location = new Point(92, 39);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "GO-CAMP";
            // 
            // buttonpemilik
            // 
            buttonpemilik.AutoSize = true;
            buttonpemilik.BackColor = Color.FromArgb(14, 115, 116);
            buttonpemilik.FlatAppearance.BorderSize = 0;
            buttonpemilik.FlatStyle = FlatStyle.Flat;
            buttonpemilik.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            buttonpemilik.ForeColor = Color.White;
            buttonpemilik.Image = (Image)resources.GetObject("buttonpemilik.Image");
            buttonpemilik.ImageAlign = ContentAlignment.MiddleLeft;
            buttonpemilik.Location = new Point(1, 171);
            buttonpemilik.Name = "buttonpemilik";
            buttonpemilik.Size = new Size(210, 34);
            buttonpemilik.TabIndex = 3;
            buttonpemilik.Text = "PEMIIK";
            buttonpemilik.UseVisualStyleBackColor = false;
            // 
            // buttonprofil
            // 
            buttonprofil.AutoSize = true;
            buttonprofil.BackColor = Color.FromArgb(14, 115, 116);
            buttonprofil.FlatAppearance.BorderSize = 0;
            buttonprofil.FlatStyle = FlatStyle.Flat;
            buttonprofil.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            buttonprofil.ForeColor = Color.White;
            buttonprofil.Image = (Image)resources.GetObject("buttonprofil.Image");
            buttonprofil.ImageAlign = ContentAlignment.MiddleLeft;
            buttonprofil.Location = new Point(1, 131);
            buttonprofil.Name = "buttonprofil";
            buttonprofil.Size = new Size(210, 38);
            buttonprofil.TabIndex = 0;
            buttonprofil.Text = "PROFIL";
            buttonprofil.UseVisualStyleBackColor = false;
            buttonprofil.Click += button1_Click;
            // 
            // button2laporan
            // 
            button2laporan.AutoSize = true;
            button2laporan.BackColor = Color.FromArgb(14, 115, 116);
            button2laporan.FlatAppearance.BorderSize = 0;
            button2laporan.FlatStyle = FlatStyle.Flat;
            button2laporan.Font = new Font("Times New Roman", 9F, FontStyle.Bold);
            button2laporan.ForeColor = Color.White;
            button2laporan.Image = (Image)resources.GetObject("button2laporan.Image");
            button2laporan.ImageAlign = ContentAlignment.MiddleLeft;
            button2laporan.Location = new Point(1, 211);
            button2laporan.Name = "button2laporan";
            button2laporan.Size = new Size(210, 34);
            button2laporan.TabIndex = 1;
            button2laporan.Text = "LAPORAN";
            button2laporan.UseVisualStyleBackColor = false;
            // 
            // mainpanel
            // 
            mainpanel.AutoSize = true;
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(208, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(752, 540);
            mainpanel.TabIndex = 5;
            // 
            // UserControlAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 241);
            Controls.Add(mainpanel);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "UserControlAdmin";
            Size = new Size(960, 540);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button buttonprofil;
        private Button button2laporan;
        private Button button3logout;
        private Button buttonpemilik;
        private Button buttondashboard;
        private Panel mainpanel;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
