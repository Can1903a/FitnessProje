using MySql.Data.MySqlClient;
using System;

namespace Fitness
{
    public class Yonetici
    {
        private Database database;

        public Yonetici(Database db)
        {
            database = db;
        }

        public bool GirisYap(string kullaniciAdi, string sifre)
        {
            using (MySqlConnection connection = database.GetConnection())
            {
                database.OpenConnection(connection);

                string query = "SELECT * FROM Yonetici WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@Sifre", sifre);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }
      
    }
}
