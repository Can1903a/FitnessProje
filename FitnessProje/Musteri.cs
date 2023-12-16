using Fitness;
using MySql.Data.MySqlClient;
using System;

namespace FitnessProje
{
    public class Musteri
    {
        private Database database;

        public Musteri(Database db)
        {
            database = db;
        }

        public bool GirisYap(string tc, string sifre)
        {
            using (MySqlConnection connection = database.GetConnection())
            {
                database.OpenConnection(connection);


                string query = "SELECT * FROM Musteriler WHERE Tc = @Tc AND Sifre = @Sifre";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Tc", tc);
                    cmd.Parameters.AddWithValue("@Sifre", sifre);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }
    }
}