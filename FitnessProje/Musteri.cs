using Fitness;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace FitnessProje
{
    public class Musteri
    {
        private Database database;
        private int musteriID;

        public int MusteriID
        {
            get { return musteriID; }
            private set { musteriID = value; }
        }

        public object Ad { get; internal set; }
        public object Soyad { get; internal set; }

        public Musteri(Database db)
        {
            database = db;
        }

        public bool GirisYap(string tc, string sifre)
        {
            using (MySqlConnection connection = database.GetConnection())
            {
                database.OpenConnection(connection);

                string query = "SELECT MusteriID FROM Musteriler WHERE Tc = @Tc AND Sifre = @Sifre";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Tc", tc);
                    cmd.Parameters.AddWithValue("@Sifre", sifre);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        MusteriID = Convert.ToInt32(result);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public DataTable GetMusteriBeslenmeBilgileri()
        {
            using (MySqlConnection connection = database.GetConnection())
            {
                database.OpenConnection(connection);

                string query = "SELECT * FROM beslenme_bilgileri WHERE MusteriID = @MusteriID";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MusteriID", this.MusteriID);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable beslenmeTable = new DataTable();
                        adapter.Fill(beslenmeTable);

                        return beslenmeTable;
                    }
                }
            }
        }


        public DataTable GetMusteriAntrenmanlar()
        {
            using (MySqlConnection connection = database.GetConnection())
            {
                database.OpenConnection(connection);

                string query = "SELECT * FROM antrenmanlar WHERE MusteriID = @MusteriID ORDER BY Tarih ASC";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MusteriID", this.MusteriID);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable antrenmanlarTable = new DataTable();
                        adapter.Fill(antrenmanlarTable);

                        return antrenmanlarTable;
                    }
                }
            }
        }
    }
}



