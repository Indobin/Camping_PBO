using Projek_Akhir_PBO.View;
using Projek_Akhir_PBO.View.Admin;
using Projek_Akhir_PBO.View.Pemilik;
namespace Projek_Akhir_PBO
{
    public partial class Form1 : Form
    {
        UserControlRegister formRegister;
        UserControlLogin formLogin;
        UserControlAdmin formAdmin;
        UserControlPemilik formPemilik;
        public Form1()
        {
            formRegister = new UserControlRegister(this);
            formLogin = new UserControlLogin(this);
            formAdmin = new UserControlAdmin(this);
            formPemilik = new UserControlPemilik(this);
            InitializeComponent();
            formLogin.Visible = false;
            formRegister.Visible = false;
            formAdmin.Visible = false;
            formPemilik.Visible = true;
            //formPenyewa.Visible = false;
            this.Controls.Add(formLogin);
            this.Controls.Add(formRegister);
            this.Controls.Add(formAdmin);
            this.Controls.Add(formPemilik);
            //this.Controls.Add(formPenyewa);
        }
        public void ShowFormlogin()
        {
            formLogin.Visible = true;
            //formRegister.Visible = false;
            //formAdmin.Visible = false;
            //formPemilik.Visible = false;
            //formPenyewa.Visible = false;
        }
        public void ShowUserControlRegister()
        {
            //formLogin.Visible = false;
            formRegister.Visible = true;
            //formAdmin.Visible = false;
            //formPemilik.Visible = false;
            //formPenyewa.Visible = false;
            //formAdmin.HiddeAllUserControls();
        }
        public void ShowUserControlAdmin()
        {
            //formLogin.Visible = false;
            //formRegister.Visible = false;
            formAdmin.Visible = true;
            //formPemilik.Visible = false;
            //formPenyewa.Visible = false;
            //formAdmin.HiddeAllUserControls();
        }
        public void ShowUserControlPemilik()
        {
            //formLogin.Visible = false;
            //formRegister.Visible = false;
            //formAdmin.Visible = true;
            formPemilik.Visible = true;
            //formPenyewa.Visible = false;
            //formAdmin.HiddeAllUserControls();
        }
    }
}
