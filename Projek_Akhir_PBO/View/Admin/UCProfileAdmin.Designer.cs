namespace Projek_Akhir_PBO.View.Admin
{
    partial class UCProfileAdmin
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
            textBoxNamaAdmin = new TextBox();
            label2 = new Label();
            button2edit = new Button();
            textBoxNoHp = new TextBox();
            label3 = new Label();
            button1tambah = new Button();
            paneltopdashboard.SuspendLayout();
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
            paneltopdashboard.TabIndex = 44;
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
            juduldashboard.Size = new Size(145, 52);
            juduldashboard.TabIndex = 20;
            juduldashboard.Text = "Profile";
            // 
            // textBoxNamaAdmin
            // 
            textBoxNamaAdmin.Font = new Font("Segoe UI", 15F);
            textBoxNamaAdmin.Location = new Point(629, 415);
            textBoxNamaAdmin.Margin = new Padding(2);
            textBoxNamaAdmin.Name = "textBoxNamaAdmin";
            textBoxNamaAdmin.Size = new Size(189, 34);
            textBoxNamaAdmin.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(459, 415);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 49;
            label2.Text = "Nama Admin";
            // 
            // button2edit
            // 
            button2edit.BackColor = Color.RoyalBlue;
            button2edit.FlatStyle = FlatStyle.Flat;
            button2edit.Font = new Font("Segoe UI", 20F);
            button2edit.ForeColor = Color.White;
            button2edit.Location = new Point(459, 562);
            button2edit.Margin = new Padding(2);
            button2edit.Name = "button2edit";
            button2edit.Size = new Size(114, 59);
            button2edit.TabIndex = 53;
            button2edit.Text = "Edit";
            button2edit.UseVisualStyleBackColor = false;
            button2edit.Click += button2edit_Click;
            // 
            // textBoxNoHp
            // 
            textBoxNoHp.Font = new Font("Segoe UI", 15F);
            textBoxNoHp.Location = new Point(629, 484);
            textBoxNoHp.Margin = new Padding(2);
            textBoxNoHp.Name = "textBoxNoHp";
            textBoxNoHp.Size = new Size(189, 34);
            textBoxNoHp.TabIndex = 55;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(459, 484);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 28);
            label3.TabIndex = 54;
            label3.Text = "No Hp";
            // 
            // button1tambah
            // 
            button1tambah.BackColor = Color.FromArgb(97, 191, 143);
            button1tambah.FlatStyle = FlatStyle.Flat;
            button1tambah.Font = new Font("Segoe UI", 20F);
            button1tambah.ForeColor = Color.White;
            button1tambah.Location = new Point(704, 562);
            button1tambah.Margin = new Padding(2);
            button1tambah.Name = "button1tambah";
            button1tambah.Size = new Size(114, 59);
            button1tambah.TabIndex = 56;
            button1tambah.Text = "Save";
            button1tambah.UseVisualStyleBackColor = false;
            // 
            // UCProfileAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1tambah);
            Controls.Add(textBoxNoHp);
            Controls.Add(label3);
            Controls.Add(button2edit);
            Controls.Add(textBoxNamaAdmin);
            Controls.Add(label2);
            Controls.Add(paneltopdashboard);
            Name = "UCProfileAdmin";
            Size = new Size(1277, 864);
            Load += UCProfileAdmin_Load;
            paneltopdashboard.ResumeLayout(false);
            paneltopdashboard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel paneltopdashboard;
        private Label juduldashboard;
        private TextBox textBoxNamaAdmin;
        private Label label2;
        private Button button2edit;
        private TextBox textBoxNoHp;
        private Label label3;
        private Button button1tambah;
    }
}
