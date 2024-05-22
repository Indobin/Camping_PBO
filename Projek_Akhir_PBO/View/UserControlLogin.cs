using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Projek_Akhir_PBO.Controller;
using Projek_Akhir_PBO.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projek_Akhir_PBO.View
{
    public partial class UserControlLogin : UserControl
    {
        Form1 FormParent;
        public UserControlLogin(Form1 FormParent)
        {
            this.FormParent = FormParent;
            InitializeComponent();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string selectedTable = comboBox1.SelectedItem.ToString();
            string username = usernamebox.Text;
            string password = passwordbox.Text;
            LoginController loginController = new LoginController();
            string result = loginController.AuthLogin(selectedTable, username, password);

            if (result == "admin")
            {
                //new AdminDashboard().Show();
                MessageBox.Show("Admin");
            }
            else if (result == "pemilik")
            {
                //new PemilikDashboard().Show();
                MessageBox.Show("Pemilik");
            }
            else if (result == "penyewa")
            {
                //new PenyewaDashboard().Show();
                MessageBox.Show("Penyewa");
            }
            else
            {
                MessageBox.Show(result);
            }
           

        }
    }
}
