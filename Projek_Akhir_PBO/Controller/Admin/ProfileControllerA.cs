using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Projek_Akhir_PBO.Models.Admin;
using Projek_Akhir_PBO.Models.Pemilik;

namespace Projek_Akhir_PBO.Controller.Admin
{
    internal class ProfileControllerA
    {
        private int _userId;
        string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=321;Database=Camping;CommandTimeout=10";

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public ProfileA Read(string namaadmin, string no_hp)
        {
            ProfileA profileA = null;
            string selectQuery = "SELECT namaadmin, no_hp FROM admin WHERE id = @userId";

            using (var conn = new NpgsqlConnection(conStr))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(selectQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@userId", _userId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            profileA = new ProfileA
                            {
                                namaadmin = reader["namaadmin"].ToString(),
                                no_hp = reader["no_hp"].ToString()
                            };
                        }
                    }
                }
            }
            return profileA;
        }
    }
}
