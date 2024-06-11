namespace Projek_Akhir_PBO.View.Penyewa
{
    partial class UCItemHome
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
            lblPrice = new Label();
            price = new Label();
            lblDesc = new Label();
            lblNama = new Label();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(lblPrice);
            guna2ShadowPanel1.Controls.Add(price);
            guna2ShadowPanel1.Controls.Add(lblDesc);
            guna2ShadowPanel1.Controls.Add(lblNama);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(0, 0);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 10;
            guna2ShadowPanel1.RightToLeft = RightToLeft.Yes;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.ShadowDepth = 5;
            guna2ShadowPanel1.ShadowShift = 10;
            guna2ShadowPanel1.Size = new Size(260, 200);
            guna2ShadowPanel1.TabIndex = 54;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Lufga Medium", 14F, FontStyle.Bold);
            lblPrice.ForeColor = Color.FromArgb(140, 140, 140);
            lblPrice.ImageAlign = ContentAlignment.MiddleLeft;
            lblPrice.Location = new Point(76, 150);
            lblPrice.Name = "lblPrice";
            lblPrice.RightToLeft = RightToLeft.No;
            lblPrice.Size = new Size(23, 24);
            lblPrice.TabIndex = 24;
            lblPrice.Text = "0";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // price
            // 
            price.AutoSize = true;
            price.BackColor = Color.Transparent;
            price.Font = new Font("Lufga Medium", 14F, FontStyle.Bold);
            price.ForeColor = Color.FromArgb(140, 140, 140);
            price.ImageAlign = ContentAlignment.MiddleLeft;
            price.Location = new Point(13, 150);
            price.Name = "price";
            price.RightToLeft = RightToLeft.No;
            price.Size = new Size(67, 24);
            price.TabIndex = 23;
            price.Text = "Price:";
            price.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDesc
            // 
            lblDesc.BackColor = Color.Transparent;
            lblDesc.Font = new Font("Lufga", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesc.ForeColor = Color.FromArgb(90, 80, 80);
            lblDesc.ImageAlign = ContentAlignment.MiddleLeft;
            lblDesc.Location = new Point(13, 59);
            lblDesc.Name = "lblDesc";
            lblDesc.RightToLeft = RightToLeft.No;
            lblDesc.Size = new Size(232, 73);
            lblDesc.TabIndex = 22;
            lblDesc.Text = "Deskripsi";
            lblDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNama
            // 
            lblNama.BackColor = Color.Transparent;
            lblNama.Font = new Font("Lufga Medium", 16F, FontStyle.Bold);
            lblNama.ForeColor = Color.FromArgb(14, 115, 116);
            lblNama.ImageAlign = ContentAlignment.MiddleLeft;
            lblNama.Location = new Point(13, 16);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(232, 28);
            lblNama.TabIndex = 21;
            lblNama.Text = "Nama";
            lblNama.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UCItemHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2ShadowPanel1);
            Name = "UCItemHome";
            Size = new Size(260, 200);
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Label lblPrice;
        private Label price;
        private Label lblDesc;
        private Label lblNama;
    }
}
