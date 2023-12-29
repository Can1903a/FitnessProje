using Fitness;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using static FitnessProje.Musteri;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace FitnessProje
{
    public class Musteri
    {
        private Database database;
        private Antrenor antrenor;
        private int musteriID;



        public int MusteriID
        {
            get { return musteriID; }
            private set { musteriID = value; }
        }

        public string Ad { get; internal set; } // object yerine string olarak değiştirildi
        public string Soyad { get; internal set; } // object yerine string olarak değiştirildi

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



    public decimal GetToplamGunlukKalori(DateTime tarih)
        {
            using (MySqlConnection connection = database.GetConnection())
            {
                database.OpenConnection(connection);

                string query = "SELECT SUM(Kalori) FROM beslenme_bilgileri WHERE MusteriID = @MusteriID AND Tarih = @Tarih";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MusteriID", this.MusteriID);
                    cmd.Parameters.AddWithValue("@Tarih", tarih.Date); // Sadece tarihi baz alarak filtreleme

                    object result = cmd.ExecuteScalar();

                    return (result == DBNull.Value) ? 0 : Convert.ToDecimal(result);
                }
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
        public decimal GetMusteriMaxGunlukKalori(int musteriID)
        {
            decimal vucutKitleIndeksi = CalculateVucutKitleIndeksi(musteriID);

            decimal maxGunlukKalori = vucutKitleIndeksi * 75;

            return maxGunlukKalori;
        }

        public bool DogrulaEskiSifre(string eskiSifre)
        {
            try
            {
                using (MySqlConnection connection = database.GetConnection())
                {
                    database.OpenConnection(connection);

                    string query = "SELECT COUNT(*) FROM Musteriler WHERE MusteriID = @MusteriID AND Sifre = @EskiSifre";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@MusteriID", this.MusteriID);
                        cmd.Parameters.AddWithValue("@EskiSifre", eskiSifre);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        return count > 0;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Hatası: {ex.Message}\nHata Kodu: {ex.ErrorCode}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable GetMusteriDiyetBilgileri()
        {
            using (MySqlConnection connection = database.GetConnection())
            {
                database.OpenConnection(connection);

                string query = "SELECT ProgramAdi, ProgramIcerik FROM diyetprogramlari WHERE MusteriID = @MusteriID";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@MusteriID", this.MusteriID);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable diyetBilgileriTable = new DataTable();
                        adapter.Fill(diyetBilgileriTable);

                        return diyetBilgileriTable;
                    }
                }
            }
        }


        public bool GuncelleMusteriSifre(string eskiSifre, string yeniSifre)
        {
            try
            {
                using (MySqlConnection connection = database.GetConnection())
                {
                    database.OpenConnection(connection);

                    // TODO: Müşteri tablosundaki ilgili alanı güncelleme sorgusu yazın
                    string query = "UPDATE Musteriler SET Sifre = @YeniSifre WHERE MusteriID = @MusteriID AND Sifre = @EskiSifre";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@YeniSifre", yeniSifre);
                        cmd.Parameters.AddWithValue("@EskiSifre", eskiSifre);
                        cmd.Parameters.AddWithValue("@MusteriID", this.MusteriID);

                        int affectedRows = cmd.ExecuteNonQuery();

                        // Güncelleme başarılı oldu mu kontrol et
                        return affectedRows > 0;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Hatası: {ex.Message}\nHata Kodu: {ex.ErrorCode}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool GuncelleMusteriBilgileri(string yeniAd, string yeniSoyad, string yeniTelefon, string yeniEmail, string yeniAdres, int yeniYas, decimal yeniBoy, decimal yeniKilo)
        {
            try
            {
                using (MySqlConnection connection = database.GetConnection())
                {
                    database.OpenConnection(connection);

                    // TODO: Müşteri tablosundaki ilgili alanları güncelleme sorgusu yazın
                    string query = "UPDATE Musteriler SET Ad = @Ad, Soyad = @Soyad, Telefon = @Telefon, Email = @Email, Adres = @Adres, Yas = @Yas, Boy = @Boy, Kilo = @Kilo WHERE MusteriID = @MusteriID";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Ad", yeniAd);
                        cmd.Parameters.AddWithValue("@Soyad", yeniSoyad);
                        cmd.Parameters.AddWithValue("@Telefon", yeniTelefon);
                        cmd.Parameters.AddWithValue("@Email", yeniEmail);
                        cmd.Parameters.AddWithValue("@Adres", yeniAdres);
                        cmd.Parameters.AddWithValue("@Yas", yeniYas);
                        cmd.Parameters.AddWithValue("@Boy", yeniBoy);
                        cmd.Parameters.AddWithValue("@Kilo", yeniKilo);
                        cmd.Parameters.AddWithValue("@MusteriID", this.MusteriID);

                        int affectedRows = cmd.ExecuteNonQuery();

                        // Güncelleme başarılı oldu mu kontrol et
                        return affectedRows > 0;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Hatası: {ex.Message}\nHata Kodu: {ex.ErrorCode}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool KayitOl(string ad, string soyad, string tc, string telefon, string email, string adres, string sifre, int yas, decimal boy, decimal kilo)
        {
            try
            {
                using (MySqlConnection connection = database.GetConnection())
                {
                    database.OpenConnection(connection);

                    // Müşteri tablosuna ekleme yap
                    string query = "INSERT INTO Musteriler (Ad, Soyad, Email, Telefon, Adres, Sifre, Tc, Yas, Boy, Kilo) " +
                                   "VALUES (@Ad, @Soyad, @Email, @Telefon, @Adres, @Sifre, @Tc, @Yas, @Boy, @Kilo)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Ad", ad);
                        cmd.Parameters.AddWithValue("@Soyad", soyad);
                        cmd.Parameters.AddWithValue("@Email", tc);
                        cmd.Parameters.AddWithValue("@Telefon", telefon);
                        cmd.Parameters.AddWithValue("@Adres", email);
                        cmd.Parameters.AddWithValue("@Sifre", adres);
                        cmd.Parameters.AddWithValue("@Tc", sifre);
                        cmd.Parameters.AddWithValue("@Yas", yas);
                        cmd.Parameters.AddWithValue("@Boy", boy);
                        cmd.Parameters.AddWithValue("@Kilo", kilo);


                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Hatası: {ex.Message}\nHata Kodu: {ex.ErrorCode}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool OdemeYap(decimal odemeMiktari, string odemeTuru)
        {
            try
            {
                using (MySqlConnection connection = database.GetConnection())
                {
                    database.OpenConnection(connection);

                    // Ödeme bilgilerini ekle
                    string odemeEkleQuery = "INSERT INTO odeme_bilgileri (MusteriID, OdemeMiktari, OdemeTuru, OdemeTarihi) " +
                                            "VALUES (@MusteriID, @OdemeMiktari, @OdemeTuru, @OdemeTarihi)";

                    using (MySqlCommand cmd = new MySqlCommand(odemeEkleQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MusteriID", this.MusteriID);
                        cmd.Parameters.AddWithValue("@OdemeMiktari", odemeMiktari);
                        cmd.Parameters.AddWithValue("@OdemeTuru", odemeTuru);
                        cmd.Parameters.AddWithValue("@OdemeTarihi", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Hatası: {ex.Message}\nHata Kodu: {ex.ErrorCode}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
        public DataTable GetOdemeBilgileri()
        {
            try
            {
                using (MySqlConnection connection = database.GetConnection())
                {
                    database.OpenConnection(connection);

                    string query = "SELECT * FROM odeme_bilgileri WHERE MusteriID = @MusteriID";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@MusteriID", this.MusteriID);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable odemeBilgileriTable = new DataTable();
                            adapter.Fill(odemeBilgileriTable);

                            return odemeBilgileriTable;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }

    

       
}




