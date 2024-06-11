namespace Projek_Akhir_PBO.Models
{
    partial class UCHomeL
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
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            namaalat = new Label();
            deskripsialat = new Label();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(namaalat);
            guna2ShadowPanel1.Controls.Add(deskripsialat);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(3, 3);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(251, 213);
            guna2ShadowPanel1.TabIndex = 0;
            // 
            // namaalat
            // 
            namaalat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namaalat.ForeColor = Color.FromArgb(14, 115, 116);
            namaalat.Location = new Point(14, 14);
            namaalat.Name = "namaalat";
            namaalat.Size = new Size(222, 31);
            namaalat.TabIndex = 1;
            namaalat.Text = "Nama Produk";
            namaalat.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deskripsialat
            // 
            deskripsialat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            deskripsialat.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deskripsialat.ForeColor = Color.FromArgb(14, 115, 116);
            deskripsialat.Location = new Point(14, 45);
            deskripsialat.Name = "deskripsialat";
            deskripsialat.Size = new Size(222, 153);
            deskripsialat.TabIndex = 0;
            deskripsialat.Text = "Deskripsi";
            deskripsialat.TextAlign = ContentAlignment.MiddleCenter;
            deskripsialat.Click += deskripsialat_Click;
            // 
            // UCHomeL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2ShadowPanel1);
            Name = "UCHomeL";
            Size = new Size(257, 219);
            guna2ShadowPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Label namaalat;
        private Label deskripsialat;
    }
}
