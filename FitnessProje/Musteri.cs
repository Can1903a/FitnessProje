using Fitness;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

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

        public bool DogrulaEskiSifre(string eskiSifre)
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


        public bool GuncelleMusteriSifre(string yeniSifre)
        {
            try
            {
                using (MySqlConnection connection = database.GetConnection())
                {
                    database.OpenConnection(connection);

                    // TODO: Müşteri tablosundaki ilgili alanı güncelleme sorgusu yazın
                    string query = "UPDATE Musteriler SET Sifre = @Sifre WHERE MusteriID = @MusteriID";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Sifre", yeniSifre);
                        cmd.Parameters.AddWithValue("@MusteriID", this.MusteriID);

                        cmd.ExecuteNonQuery();
                    }

                    // TODO: Başarı durumunu döndür
                    return true;
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

                        cmd.ExecuteNonQuery();
                    }

                    // TODO: Başarı durumunu döndür
                    return true;
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


       
    }
}



