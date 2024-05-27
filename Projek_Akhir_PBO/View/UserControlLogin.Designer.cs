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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlLogin));
            label1 = new Label();
            usernamebox = new TextBox();
            passwordbox = new TextBox();
            Loginbutton = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lufga SemiBold", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(551, 85);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 44);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // usernamebox
            // 
            usernamebox.Anchor = AnchorStyles.None;
            usernamebox.BackColor = Color.MediumAquamarine;
            usernamebox.BorderStyle = BorderStyle.FixedSingle;
            usernamebox.Font = new Font("Lufga Medium", 13F);
            usernamebox.ForeColor = Color.FromArgb(250, 250, 250);
            usernamebox.Location = new Point(561, 172);
            usernamebox.Margin = new Padding(2);
            usernamebox.Name = "usernamebox";
            usernamebox.Size = new Size(285, 36);
            usernamebox.TabIndex = 4;
            usernamebox.TextChanged += usernamebox_TextChanged;
            // 
            // passwordbox
            // 
            passwordbox.Anchor = AnchorStyles.None;
            passwordbox.BackColor = Color.MediumAquamarine;
            passwordbox.BorderStyle = BorderStyle.FixedSingle;
            passwordbox.Font = new Font("Lufga Medium", 13F);
            passwordbox.ForeColor = Color.FromArgb(250, 250, 250);
            passwordbox.Location = new Point(561, 248);
            passwordbox.Margin = new Padding(2);
            passwordbox.Name = "passwordbox";
            passwordbox.Size = new Size(285, 36);
            passwordbox.TabIndex = 5;
            // 
            // Loginbutton
            // 
            Loginbutton.BackColor = Color.FromArgb(74, 75, 67);
            Loginbutton.Font = new Font("Lufga", 12F, FontStyle.Bold);
            Loginbutton.ForeColor = Color.FromArgb(250, 250, 250);
            Loginbutton.Location = new Point(627, 388);
            Loginbutton.Margin = new Padding(2);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(165, 50);
            Loginbutton.TabIndex = 6;
            Loginbutton.Text = "Submit";
            Loginbutton.UseVisualStyleBackColor = false;
            Loginbutton.Click += Loginbutton_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.MediumAquamarine;
            comboBox1.DropDownHeight = 100;
            comboBox1.Font = new Font("Lufga", 13F);
            comboBox1.ForeColor = Color.FromArgb(250, 250, 250);
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Items.AddRange(new object[] { "Admin", "Pemilik", "Penyewa" });
            comboBox1.Location = new Point(561, 321);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(285, 36);
            comboBox1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Lufga", 9F);
            label5.ForeColor = Color.FromArgb(0, 64, 64);
            label5.Location = new Point(588, 443);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(182, 20);
            label5.TabIndex = 9;
            label5.Text = "Don't have an account?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Lufga", 9F);
            label6.ForeColor = Color.FromArgb(74, 75, 67);
            label6.Location = new Point(767, 444);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 10;
            label6.Text = "Register";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Lufga", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(74, 75, 67);
            label7.Location = new Point(153, 126);
            label7.Name = "label7";
            label7.Size = new Size(215, 44);
            label7.TabIndex = 11;
            label7.Text = "Welcome To";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Lufga Black", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(74, 75, 67);
            label8.Location = new Point(79, 170);
            label8.Name = "label8";
            label8.Size = new Size(365, 87);
            label8.TabIndex = 12;
            label8.Text = "GO-CAMP";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Lufga SemiBold", 10F, FontStyle.Bold);
            label9.ForeColor = Color.FromArgb(74, 75, 67);
            label9.Location = new Point(58, 258);
            label9.Name = "label9";
            label9.Size = new Size(400, 66);
            label9.TabIndex = 13;
            label9.Text = "“A Camping Equipment Rental App. \nExperience the convenience of camping without\nthe hassle of owning gear.”";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lufga Medium", 12F);
            label2.ForeColor = Color.FromArgb(0, 64, 64);
            label2.Location = new Point(556, 146);
            label2.Name = "label2";
            label2.Size = new Size(111, 26);
            label2.TabIndex = 14;
            label2.Text = "Username";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lufga Medium", 12F);
            label3.ForeColor = Color.FromArgb(0, 64, 64);
            label3.Location = new Point(555, 220);
            label3.Name = "label3";
            label3.Size = new Size(105, 26);
            label3.TabIndex = 15;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Lufga Medium", 12F);
            label4.ForeColor = Color.FromArgb(0, 64, 64);
            label4.Location = new Point(556, 294);
            label4.Name = "label4";
            label4.Size = new Size(54, 26);
            label4.TabIndex = 16;
            label4.Text = "Role";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserControlLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(Loginbutton);
            Controls.Add(passwordbox);
            Controls.Add(usernamebox);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "UserControlLogin";
            Size = new Size(960, 540);
            Load += UserControlLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox usernamebox;
        private TextBox passwordbox;
        private Button Loginbutton;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
