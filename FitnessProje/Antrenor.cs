// Antrenor.cs
using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Fitness;

namespace FitnessProje
{
    public class Antrenor
    {
        private Database database;
        private int antrenorID;

        public int AntrenorID
        {
            get { return antrenorID; }
            private set { antrenorID = value; }
        }

        public Antrenor(Database db)
        {
            database = db;
        }
        public DataTable GetMusteriBilgileri(int musteriID)
        {
            try
            {
                using (MySqlConnection connection = database.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT * FROM musteriler WHERE MusteriID = @MusteriID";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@MusteriID", musteriID);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable musteriBilgileriTable = new DataTable();
                            adapter.Fill(musteriBilgileriTable);

                            return musteriBilgileriTable;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool AntrenorGirisYap(string antrenorTC, string antrenorSifre)
        {
            using (MySqlConnection connection = database.GetConnection())
            {
                database.OpenConnection(connection);

                string query = "SELECT AntrenorID FROM Antrenorler WHERE AntrenorTC = @AntrenorTC AND AntrenorSifre = @AntrenorSifre";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@AntrenorTC", antrenorTC);
                    cmd.Parameters.AddWithValue("@AntrenorSifre", antrenorSifre);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        AntrenorID = Convert.ToInt32(result);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public DataTable GetMusteriListesi()
        {
            try
            {
                using (MySqlConnection connection = database.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT MusteriID, Ad, Soyad, Yas, Boy, Kilo FROM Musteriler WHERE AntrenorID = @AntrenorID";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@AntrenorID", AntrenorID);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable musteriListesiTable = new DataTable();
                            adapter.Fill(musteriListesiTable);

                            return musteriListesiTable;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool AntrenmanEkle(DateTime tarih, string aciklama)
        {
            try
            {
                using (MySqlConnection connection = database.GetConnection())
                {
                    connection.Open();

                    string query = "INSERT INTO antrenmanlar (AntrenorID, Tarih, Aciklama) VALUES (@AntrenorID, @Tarih, @Aciklama)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@AntrenorID", AntrenorID);
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

        public bool DiyetAta(int musteriID, string diyetProgrami)
        {
            try
            {
                using (MySqlConnection connection = database.GetConnection())
                {
                    database.OpenConnection(connection);

                    decimal vucutKitleEndeksi = CalculateVucutKitleEndeksi(musteriID);

                    string query = "INSERT INTO diyet_programlari (MusteriID, Program, VucutKitleEndeksi) " +
                                   "VALUES (@MusteriID, @Program, @VucutKitleEndeksi)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@MusteriID", musteriID);
                        cmd.Parameters.AddWithValue("@Program", diyetProgrami);
                        cmd.Parameters.AddWithValue("@VucutKitleEndeksi", vucutKitleEndeksi);

                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public decimal CalculateVucutKitleEndeksi(int musteriID)
        {
            try
            {
                using (MySqlConnection connection = database.GetConnection())
                {
                    connection.Open();

                    // Müşteri bilgilerini al
                    DataTable musteriBilgileri = GetMusteriBilgileri(musteriID); // Düzeltildi

                    if (musteriBilgileri != null && musteriBilgileri.Rows.Count > 0)
                    {
                        double boy = Convert.ToDouble(musteriBilgileri.Rows[0]["Boy"]);
                        double kilo = Convert.ToDouble(musteriBilgileri.Rows[0]["Kilo"]);

                        double boyMetre = boy / 100.0;
                        double vki = kilo / (boyMetre * boyMetre);

                        return Convert.ToDecimal(vki);
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

    }
}






