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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            paneltopdashboard = new Guna.UI2.WinForms.Guna2Panel();
            juduldashboard = new Label();
            pictureBox1 = new PictureBox();
            textBoxUsername = new TextBox();
            textBoxDeskripsi = new TextBox();
            ButtonEdit = new Button();
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
            paneltopdashboard.CustomizableEdges = customizableEdges3;
            paneltopdashboard.Dock = DockStyle.Top;
            paneltopdashboard.Location = new Point(0, 0);
            paneltopdashboard.Name = "paneltopdashboard";
            paneltopdashboard.ShadowDecoration.CustomizableEdges = customizableEdges4;
            paneltopdashboard.Size = new Size(1277, 131);
            paneltopdashboard.TabIndex = 45;
            // 
            // juduldashboard
            // 
            juduldashboard.AutoSize = true;
            juduldashboard.BackColor = Color.Transparent;
            juduldashboard.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            pictureBox1.Location = new Point(485, 179);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(328, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // textBoxUsername
            // 
            textBoxUsername.BackColor = Color.FromArgb(245, 248, 241);
            textBoxUsername.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxUsername.Location = new Point(484, 463);
            textBoxUsername.Margin = new Padding(0);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(329, 38);
            textBoxUsername.TabIndex = 47;
            textBoxUsername.TextAlign = HorizontalAlignment.Center;
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
            // 
            // textBoxDeskripsi
            // 
            textBoxDeskripsi.BackColor = Color.White;
            textBoxDeskripsi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDeskripsi.Location = new Point(345, 547);
            textBoxDeskripsi.Multiline = true;
            textBoxDeskripsi.Name = "textBoxDeskripsi";
            textBoxDeskripsi.Size = new Size(607, 189);
            textBoxDeskripsi.TabIndex = 48;
            textBoxDeskripsi.Text = "\r\n";
            textBoxDeskripsi.TextChanged += textBox2_TextChanged;
            // 
            // ButtonEdit
            // 
            ButtonEdit.BackColor = Color.FromArgb(217, 217, 217);
            ButtonEdit.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonEdit.ForeColor = Color.FromArgb(14, 115, 116);
            ButtonEdit.Location = new Point(1124, 160);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new Size(110, 40);
            ButtonEdit.TabIndex = 49;
            ButtonEdit.Text = "EDIT";
            ButtonEdit.UseVisualStyleBackColor = false;
            ButtonEdit.Click += button1_Click;
            // 
            // UCProfilePenyewa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 248, 241);
            Controls.Add(ButtonEdit);
            Controls.Add(textBoxDeskripsi);
            Controls.Add(textBoxUsername);
            Controls.Add(pictureBox1);
            Controls.Add(paneltopdashboard);
            Name = "UCProfilePenyewa";
            Size = new Size(1277, 864);
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
        private TextBox textBoxDeskripsi;
        private Button ButtonEdit;
    }
}
