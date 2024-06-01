namespace Projek_Akhir_PBO.View.Penyewa
{
    partial class UCCatalogPenyewa
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
            judulCatalog = new Label();
            judulkatalog = new Guna.UI2.WinForms.Guna2Panel();
            judulkatalog.SuspendLayout();
            SuspendLayout();
            // 
            // judulCatalog
            // 
            judulCatalog.AutoSize = true;
            judulCatalog.Font = new Font("Lufga", 30F, FontStyle.Bold);
            judulCatalog.ForeColor = Color.FromArgb(91, 80, 80);
            judulCatalog.Location = new Point(40, 32);
            judulCatalog.Name = "judulCatalog";
            judulCatalog.Size = new Size(173, 52);
            judulCatalog.TabIndex = 0;
            judulCatalog.Text = "Catalog";
            judulCatalog.Click += judulCatalog_Click;
            // 
            // judulkatalog
            // 
            judulkatalog.BackColor = Color.FromArgb(245, 248, 241);
            judulkatalog.Controls.Add(judulCatalog);
            judulkatalog.CustomizableEdges = customizableEdges1;
            judulkatalog.Location = new Point(1, 2);
            judulkatalog.Name = "judulkatalog";
            judulkatalog.ShadowDecoration.CustomizableEdges = customizableEdges2;
            judulkatalog.Size = new Size(1273, 131);
            judulkatalog.TabIndex = 1;
            // 
            // UCCatalogPenyewa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(judulkatalog);
            Name = "UCCatalogPenyewa";
            Size = new Size(1277, 864);
            judulkatalog.ResumeLayout(false);
            judulkatalog.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label judulCatalog;
        private Guna.UI2.WinForms.Guna2Panel judulkatalog;
    }
}
