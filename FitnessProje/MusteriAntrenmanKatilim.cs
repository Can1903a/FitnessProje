// MusteriAntrenmanKatilim sınıfı
using MySql.Data.MySqlClient;
using System;

namespace Fitness
{
    public class MusteriAntrenmanKatilim
    {
        private Database database;

        public MusteriAntrenmanKatilim(Database db)
        {
            database = db;
        }

        public bool KatilimYap(int musteriID, int antrenmanID)
        {
            try
            {
                using (MySqlConnection connection = database.GetConnection())
                {
                    connection.Open();

                    string query = "INSERT INTO musteri_antrenman_katilim (MusteriID, AntrenmanID) VALUES (@MusteriID, @AntrenmanID)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@MusteriID", musteriID);
                        cmd.Parameters.AddWithValue("@AntrenmanID", antrenmanID);

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
