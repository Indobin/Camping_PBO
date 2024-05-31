using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projek_Akhir_PBO.Models;
using Projek_Akhir_PBO.View.Admin;
using Projek_Akhir_PBO.View.Pemilik;
using Projek_Akhir_PBO.View.Penyewa;
namespace Projek_Akhir_PBO.Controller
{
    internal class LoginController
    {
        public (string userType, int userId) AuthLogin(string table, string username, string password)
        {
            using (LoginContext context = new LoginContext())
            {
                string idColumn = GetIdColumnForTable(table);
                var (isAuthenticated, userId) = context.AuthenticateAndGetId(table, idColumn, username, password);

                if (isAuthenticated)
                {
                    return (table, userId);
                }
                else
                {
                    return ("Username atau password salah.", -1);
                }
            }
        }

        private string GetIdColumnForTable(string table)
        {
            switch (table)
            {
                case "Admin":
                    return "id_admin";
                case "Pemilik":
                    return "id_pemilik";
                case "Penyewa":
                    return "id_penyewa";
                default:
                    throw new ArgumentException("Invalid table name");
            }
        }
        //public void HandleLogin(string table, string username, string password, Form currentForm)
        //{
        //    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        //    {
        //        MessageBox.Show("Username dan password tidak boleh kosong", "Login Data",
        //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    var result = AuthLogin(table, username, password);

        //    if (result.userId != null)
        //    {
        //        int userId = result.userId.Value;
        //        currentForm.Hide();

        //        if (result.userType == "admin")
        //        {
        //            FormAdmin menuAdmin = new FormAdmin(userId);
        //            menuAdmin.Show();
        //        }
        //        else if (result.userType == "pemilik")
        //        {
        //            //FormPemilik menuPemilik = new FormPemilik(userId);
        //            //menuPemilik.Show();
        //        }
        //        else if (result.userType == "penyewa")
        //        {
        //            //FormPenyewa menuPenyewa = new FormPenyewa(userId);
        //            //menuPenyewa.Show();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show(result.userType); // Display error message
        //    }
        //}

        //public (string userType, int? userId) AuthLogin(string table, string username, string password)
        //{
        //    using (LoginContext context = new LoginContext())
        //    {
        //        int? userId = context.Authenticate(table, username, password);

        //        if (userId != null)
        //        {
        //            return (table, userId);
        //        }
        //        else
        //        {
        //            return ("Username atau password salah.", null);
        //        }
        //    }
        //}
        //public string AuthLogin(string table, string username, string password)
        //{
        //    using (LoginContext context = new LoginContext())
        //    {
        //        bool isAuthenticated = context.Authenticate(table, username, password);

        //        if (isAuthenticated)
        //        {
        //            return table;
        //        }
        //        else
        //        {
        //            return "Username atau password salah.";
        //        }
        //    }
        //}
    }
}
