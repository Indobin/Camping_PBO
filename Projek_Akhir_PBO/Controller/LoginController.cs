using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projek_Akhir_PBO.Models;
namespace Projek_Akhir_PBO.Controller
{
    internal class LoginController
    {
        public string AuthLogin(string table, string username, string password)
        {
            using (LoginContext context = new LoginContext())
            {
                bool isAuthenticated = context.Authenticate(table, username, password);

                if (isAuthenticated)
                {
                    return table;
                }
                else
                {
                    return "Invalid username or password.";
                }
            }
        }
    }
}
