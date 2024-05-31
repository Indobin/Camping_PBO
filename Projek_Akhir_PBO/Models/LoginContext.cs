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
            string connectionString = "Server=localhost;Port=5432;UserId=postgres;Password=321;Database=Camping;";
            //string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=firsta;Database=Camping";
            _connection = new NpgsqlConnection(connectionString);
            _connection.Open();
        }
        public (bool isAuthenticated, int userId) AuthenticateAndGetId(string table, string idColumn, string username, string password)
        {
            string query = $"SELECT {idColumn} FROM {table} WHERE username=@username AND password=@password";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, _connection))
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
        //public bool Authenticate(string table, string username, string password)
        //{
        //    string query = $"SELECT COUNT(*) FROM {table} WHERE username=@username AND password=@password";

        //    using (NpgsqlCommand cmd = new NpgsqlCommand(query, _connection))
        //    {
        //        cmd.Parameters.AddWithValue("@username", username);
        //        cmd.Parameters.AddWithValue("@password", password);
        //        int userCount = Convert.ToInt32(cmd.ExecuteScalar());

        //        return userCount == 1;
        //    }
        //}


        public void Dispose()
        {
            if (_connection != null)
            {
                _connection.Close();
                _connection.Dispose();
            }
        }
        //public int Authenticate(string table, string username, string password)
        //{
        //    string idColumn = ""; // Kolom ID yang sesuai
        //    switch (table)
        //    {
        //        case "admin":
        //            idColumn = "id_admin";
        //            break;
        //        case "pemilik":
        //            idColumn = "id_pemilik";
        //            break;
        //        case "penyewa":
        //            idColumn = "id_penyewa";
        //            break;
        //        default:
        //            return null;
        //    }

        //    string query = $"SELECT {idColumn} FROM {table} WHERE username=@username AND password=@password";

        //    using (NpgsqlCommand cmd = new NpgsqlCommand(query, _connection))
        //    {
        //        cmd.Parameters.AddWithValue("@username", username);
        //        cmd.Parameters.AddWithValue("@password", password);
        //        object result = cmd.ExecuteScalar();

        //        if (result != null)
        //        {
        //            return Convert.ToInt32(result);
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //}
    }
}
