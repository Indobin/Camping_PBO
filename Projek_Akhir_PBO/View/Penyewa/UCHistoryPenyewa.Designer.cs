namespace Projek_Akhir_PBO.View.Penyewa
{
    partial class UCHistoryPenyewa
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            paneltopdashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            juduldashboard.Size = new Size(158, 52);
            juduldashboard.TabIndex = 20;
            juduldashboard.Text = "History";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.CausesValidation = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 148);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.Size = new Size(925, 223);
            dataGridView1.TabIndex = 78;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView2.CausesValidation = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(34, 472);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView2.Size = new Size(925, 223);
            dataGridView2.TabIndex = 94;
            dataGridView2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lufga", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(91, 80, 80);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(34, 398);
            label1.Name = "label1";
            label1.Size = new Size(153, 52);
            label1.TabIndex = 21;
            label1.Text = "Details";
            // 
            // UCHistoryPenyewa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(paneltopdashboard);
            Name = "UCHistoryPenyewa";
            Size = new Size(1277, 864);
            Load += UCHistoryPenyewa_Load;
            paneltopdashboard.ResumeLayout(false);
            paneltopdashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel paneltopdashboard;
        private Label juduldashboard;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label1;
    }
}
