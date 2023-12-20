using System;
using System.Windows.Forms;
using Fitness;
using MySql.Data.MySqlClient;

namespace FitnessProje
{
    public partial class BeslenmeEkleForm : Form
    {
        private Database database;
        private Musteri musteri;

        public BeslenmeEkleForm(Database db, Musteri musteriInstance)
        {
            InitializeComponent();
            database = db;

            // musteriInstance null kontrolü ekleyerek nesnenin oluşturulup oluşturulmadığını kontrol edin.
            musteri = musteriInstance ?? new Musteri(database);
        }



        private void YemekEkle()
        {
            using (MySqlConnection connection = database.GetConnection())
            {
                database.OpenConnection(connection);

                // Yeni yemek bilgisi ekleyin
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
            }

            MessageBox.Show("Yemek bilgisi başarıyla eklendi.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Formu kapat
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BeslenmeEkleForm_Load(object sender, EventArgs e)
        {
            numericUpDownKalori.Maximum = 500;
        }

        private void numericUpDownKalori_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Yeni yemek bilgisi ekleyin
                YemekEkle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
