using System;
using System.Data;
using System.Windows.Forms;
using Fitness;
using MySql.Data.MySqlClient;

namespace FitnessProje
{
    public partial class BeslenmeIslemleri : Form
    {
        private Database database;
        private Musteri musteri;

        public BeslenmeIslemleri(Database db, Musteri musteriInstance)
        {
            InitializeComponent();
            database = db;

            musteri = musteriInstance ?? new Musteri(database);

            LoadBeslenmeBilgileri();
        }



        private void LoadBeslenmeBilgileri()
        {
            try
            {
                DataTable beslenmeTable = musteri.GetMusteriBeslenmeBilgileri();
                dataGridViewBeslenme.DataSource = beslenmeTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void YemekEkle()
        {
            try
            {
                using (MySqlConnection connection = database.GetConnection())
                {
                    database.OpenConnection(connection);

                    // Yemeği eklerken kullanıcının günlük maksimum kalorisini aşıp aşmadığını kontrol et
                    decimal toplamGunlukKalori = musteri.GetToplamGunlukKalori(dateTimePickerTarih.Value);
                    decimal maxGunlukKalori = musteri.GetMusteriMaxGunlukKalori(musteri.MusteriID);

                    if (toplamGunlukKalori + numericUpDownKalori.Value > maxGunlukKalori)
                    {
                        MessageBox.Show($"Günlük maksimum kalori sınırını aşıyorsunuz. Maksimum kalori: {maxGunlukKalori}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query = "INSERT INTO beslenme_bilgileri (MusteriID, YemekAdi, Kalori, Tarih) " +
                                   "VALUES (@MusteriID, @YemekAdi, @Kalori, @Tarih)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@MusteriID", musteri.MusteriID);
                        cmd.Parameters.AddWithValue("@YemekAdi", textBoxYemekAdi.Text);
                        cmd.Parameters.AddWithValue("@Kalori", numericUpDownKalori.Value);
                        cmd.Parameters.AddWithValue("@Tarih", dateTimePickerTarih.Value);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Yemek bilgisi başarıyla eklendi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                YemekEkle();
                LoadBeslenmeBilgileri();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GeriButon4_Click(object sender, EventArgs e)
        {
            MusteriIslem austeriIslem = new MusteriIslem(database, musteri);
            austeriIslem.Show();
            this.Close();
        }

        private void BeslenmeIslemleri_Load(object sender, EventArgs e)
        {
            dateTimePickerTarih.MaxDate = DateTime.Now;
            dateTimePickerTarih.MinDate = DateTime.Now;
            dateTimePickerTarih.Value = DateTime.Now;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
