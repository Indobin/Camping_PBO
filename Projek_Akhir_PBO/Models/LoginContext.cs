using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Projek_Akhir_PBO.Tools;
namespace Projek_Akhir_PBO.Models
{
    public class LoginContext: IDisposable
    {
        private NpgsqlConnection _connection;

        public LoginContext()
        {
            
        }
        public (bool isAuthenticated, int userId) AuthenticateAndGetId(string table, string idColumn, string username, string password)
        {
            string query = $"SELECT {idColumn} FROM {table} WHERE username=@username AND password=@password";
            using (var db = new DBConnection())
            {
                db.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, db.Connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    var result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int userId = Convert.ToInt32(result);
                        return (true, userId);
                    }
                    else
                    {
                        return (false, -1);
                    }
                }
            }
        }
      


        public void Dispose()
        {
            if (_connection != null)
            {
                _connection.Close();
                _connection.Dispose();
            }
        }
       
    }
}
