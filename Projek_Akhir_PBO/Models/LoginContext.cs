using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace Projek_Akhir_PBO.Models
{
    public class LoginContext: IDisposable
    {
        private NpgsqlConnection _connection;

        public LoginContext()
        {
            string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=firsta;Database=go-camp;";
            //string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=first;Database=go-camp";
            _connection = new NpgsqlConnection(connectionString);
            _connection.Open();
        }

        public bool Authenticate(string table, string username, string password)
        {
            string query = $"SELECT COUNT(*) FROM {table} WHERE username=@username AND password=@password";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, _connection))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                return userCount == 1;
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
