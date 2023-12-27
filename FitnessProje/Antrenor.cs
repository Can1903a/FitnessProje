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

            // Antrenor.cs
            public DataTable GetMusteriListesi()
            {
                try
                {
                    using (MySqlConnection connection = database.GetConnection())
                    {
                        connection.Open();

                        string query = "SELECT MusteriID, Ad, Soyad, Yas, Boy, Kilo FROM musteriler";
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
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

                    string query = "SELECT AntrenorID FROM antrenorler WHERE AntrenorTC = @AntrenorTC AND AntrenorSifre = @AntrenorSifre";
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


            // Antrenor.cs
            public bool DiyetAta(int musteriID, string diyetProgramAdi, string diyetProgramIcerik)
            {
                try
                {
                    using (MySqlConnection connection = database.GetConnection())
                    {
                        database.OpenConnection(connection);

                        decimal vucutKitleEndeksi = CalculateVucutKitleIndeksi(musteriID);

                        // DiyetProgramID ve ProgramIcerik sütunlarına değer ekledim
                        string diyetQuery = "INSERT INTO diyetprogramlari (MusteriID, AntrenorID, ProgramAdi, ProgramIcerik) " +
                                           "VALUES (@MusteriID, @AntrenorID, @ProgramAdi, @ProgramIcerik)";

                        // VKI'yi vki_tablosu'na ekleyen sorgu
                        string vkiQuery = "INSERT INTO vki_tablosu (MusteriID, VKI, Tarih) " +
                                          "VALUES (@MusteriID, @VKI, NOW())";

                        using (MySqlCommand diyetCmd = new MySqlCommand(diyetQuery, connection))
                        using (MySqlCommand vkiCmd = new MySqlCommand(vkiQuery, connection))
                        {
                            diyetCmd.Parameters.AddWithValue("@MusteriID", musteriID);
                            diyetCmd.Parameters.AddWithValue("@AntrenorID", AntrenorID);
                            diyetCmd.Parameters.AddWithValue("@ProgramAdi", diyetProgramAdi);
                            diyetCmd.Parameters.AddWithValue("@ProgramIcerik", diyetProgramIcerik);

                            vkiCmd.Parameters.AddWithValue("@MusteriID", musteriID);
                            vkiCmd.Parameters.AddWithValue("@VKI", vucutKitleEndeksi);

                            // Transaction başlat
                            using (MySqlTransaction transaction = connection.BeginTransaction())
                            {
                                try
                                {
                                    // Diyet sorgusunu çalıştır
                                    diyetCmd.Transaction = transaction;
                                    diyetCmd.ExecuteNonQuery();

                                    // VKI sorgusunu çalıştır
                                    vkiCmd.Transaction = transaction;
                                    vkiCmd.ExecuteNonQuery();

                                    // Transaction'ı commit et
                                    transaction.Commit();

                                    return true;
                                }
                                catch (Exception)
                                {
                                    // Hata durumunda Transaction'ı rollback et
                                    transaction.Rollback();
                                    return false;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"DiyetAta Error: {ex.Message}"); // Debugging için
                    return false;
                }
            }




            public decimal CalculateVucutKitleIndeksi(int musteriID)
            {
                try
                {
                    using (MySqlConnection connection = database.GetConnection())
                    {
                        connection.Open();

                        // Müşteri bilgilerini al
                        DataTable musteriBilgileri = GetMusteriBilgileri(musteriID);

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






