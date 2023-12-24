// Antrenor sınıfı
using System;
using MySql.Data.MySqlClient;

namespace Fitness
{
    public class Antrenor
    {
        private Database database;

        public Antrenor(Database db)
        {
            database = db;
        }

        public object AntrenorID { get; internal set; }

        public bool GirisYap(string antrenorTC, string antrenorSifre)
        {
            using (MySqlConnection connection = database.GetConnection())
            {
                database.OpenConnection(connection);

                string query = "SELECT * FROM Antrenorler WHERE AntrenorTC = @AntrenorTC AND AntrenorSifre = @AntrenorSifre";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@AntrenorTC", antrenorTC);
                    cmd.Parameters.AddWithValue("@AntrenorSifre", antrenorSifre);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
            }
        }

        public bool AntrenmanEkle(DateTime tarih, string aciklama)
        {
            try
            {
                using (MySqlConnection connection = database.GetConnection())
                {
                    connection.Open();

                    string query = "INSERT INTO antrenmanlar (Tarih, Aciklama) VALUES (@Tarih, @Aciklama)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Tarih", tarih);
                        cmd.Parameters.AddWithValue("@Aciklama", aciklama);

                        cmd.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}