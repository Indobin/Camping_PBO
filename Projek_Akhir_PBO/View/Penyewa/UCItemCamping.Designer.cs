namespace Projek_Akhir_PBO.View.Penyewa
{
    partial class UCItemCamping
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
            lblStock = new Label();
            Stock = new Label();
            lblItemName = new Label();
            lblItemCategory = new Label();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(lblStock);
            guna2ShadowPanel1.Controls.Add(Stock);
            guna2ShadowPanel1.Controls.Add(lblItemName);
            guna2ShadowPanel1.Controls.Add(lblItemCategory);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(0, 0);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 10;
            guna2ShadowPanel1.RightToLeft = RightToLeft.Yes;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.ShadowDepth = 5;
            guna2ShadowPanel1.ShadowShift = 10;
            guna2ShadowPanel1.Size = new Size(260, 200);
            guna2ShadowPanel1.TabIndex = 53;
            guna2ShadowPanel1.Click += guna2ShadowPanel1_Click;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.Transparent;
            lblStock.Font = new Font("Lufga Medium", 14F, FontStyle.Bold);
            lblStock.ForeColor = Color.FromArgb(140, 140, 140);
            lblStock.ImageAlign = ContentAlignment.MiddleLeft;
            lblStock.Location = new Point(146, 150);
            lblStock.Name = "lblStock";
            lblStock.RightToLeft = RightToLeft.No;
            lblStock.Size = new Size(23, 24);
            lblStock.TabIndex = 24;
            lblStock.Text = "0";
            lblStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Stock
            // 
            Stock.AutoSize = true;
            Stock.BackColor = Color.Transparent;
            Stock.Font = new Font("Lufga Medium", 14F, FontStyle.Bold);
            Stock.ForeColor = Color.FromArgb(140, 140, 140);
            Stock.ImageAlign = ContentAlignment.MiddleLeft;
            Stock.Location = new Point(77, 149);
            Stock.Name = "Stock";
            Stock.RightToLeft = RightToLeft.No;
            Stock.Size = new Size(73, 24);
            Stock.TabIndex = 23;
            Stock.Text = "Stock:";
            Stock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblItemName
            // 
            lblItemName.BackColor = Color.Transparent;
            lblItemName.Font = new Font("Lufga", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemName.ForeColor = Color.FromArgb(90, 80, 80);
            lblItemName.ImageAlign = ContentAlignment.MiddleLeft;
            lblItemName.Location = new Point(13, 59);
            lblItemName.Name = "lblItemName";
            lblItemName.RightToLeft = RightToLeft.No;
            lblItemName.Size = new Size(232, 73);
            lblItemName.TabIndex = 22;
            lblItemName.Text = "The North Face Wawona 6";
            lblItemName.TextAlign = ContentAlignment.MiddleCenter;
            lblItemName.Click += lblItemName_Click;
            // 
            // lblItemCategory
            // 
            lblItemCategory.BackColor = Color.Transparent;
            lblItemCategory.Font = new Font("Lufga Medium", 16F, FontStyle.Bold);
            lblItemCategory.ForeColor = Color.FromArgb(14, 115, 116);
            lblItemCategory.ImageAlign = ContentAlignment.MiddleLeft;
            lblItemCategory.Location = new Point(13, 16);
            lblItemCategory.Name = "lblItemCategory";
            lblItemCategory.Size = new Size(232, 28);
            lblItemCategory.TabIndex = 21;
            lblItemCategory.Text = "Tent";
            lblItemCategory.TextAlign = ContentAlignment.MiddleCenter;
            lblItemCategory.Click += lblItemCategory_Click;
            // 
            // UCItemCamping
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2ShadowPanel1);
            Name = "UCItemCamping";
            Size = new Size(260, 200);
            Click += UCItemCamping_Click;
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Label lblItemCategory;
        private Label Stock;
        private Label lblItemName;
        private Label lblStock;
    }
}
