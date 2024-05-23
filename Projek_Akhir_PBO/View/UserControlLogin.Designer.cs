namespace Projek_Akhir_PBO.View
{
    partial class UserControlLogin
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            usernamebox = new TextBox();
            passwordbox = new TextBox();
            Loginbutton = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(583, 166);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 24);
            label1.TabIndex = 0;
            label1.Text = "Login Go-Camp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(505, 236);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 24);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(505, 285);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 24);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // usernamebox
            // 
            usernamebox.Font = new Font("Segoe UI", 13F);
            usernamebox.Location = new Point(634, 236);
            usernamebox.Margin = new Padding(2, 2, 2, 2);
            usernamebox.Name = "usernamebox";
            usernamebox.Size = new Size(168, 31);
            usernamebox.TabIndex = 4;
            // 
            // passwordbox
            // 
            passwordbox.Font = new Font("Segoe UI", 13F);
            passwordbox.Location = new Point(634, 285);
            passwordbox.Margin = new Padding(2, 2, 2, 2);
            passwordbox.Name = "passwordbox";
            passwordbox.Size = new Size(168, 31);
            passwordbox.TabIndex = 5;
            // 
            // Loginbutton
            // 
            Loginbutton.Font = new Font("Segoe UI", 13F);
            Loginbutton.Location = new Point(561, 409);
            Loginbutton.Margin = new Padding(2, 2, 2, 2);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(167, 31);
            Loginbutton.TabIndex = 6;
            Loginbutton.Text = "Login";
            Loginbutton.UseVisualStyleBackColor = true;
            Loginbutton.Click += Loginbutton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(505, 335);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 24);
            label3.TabIndex = 7;
            label3.Text = "Role";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 13F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "penyewa", "pemilik", "admin" });
            comboBox1.Location = new Point(634, 335);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(168, 32);
            comboBox1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(546, 379);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(150, 17);
            label5.TabIndex = 9;
            label5.Text = "Belum memiliki akun? klik \r\n";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(692, 379);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(96, 17);
            label6.TabIndex = 10;
            label6.Text = "daftar sekarang";
            // 
            // UserControlLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(Loginbutton);
            Controls.Add(passwordbox);
            Controls.Add(usernamebox);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UserControlLogin";
            Size = new Size(829, 487);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox usernamebox;
        private TextBox passwordbox;
        private Button Loginbutton;
        private Label label3;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
    }
}
