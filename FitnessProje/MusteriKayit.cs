using System;
using System.Windows.Forms;
using Fitness;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FitnessProje
{
    public partial class MusteriKayit : Form
    {
        private Database database;
        private Musteri musteri;

        public MusteriKayit(Database db, Musteri musteriInstance)
        {
            InitializeComponent();
            database = db;

            musteri = musteriInstance ?? new Musteri(database);

        }

        private void MusteriKayit_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler (opsiyonel)
        }




        private void KayitOlButton_Click_1(object sender, EventArgs e)
        {
           try
            {
                // Formdaki girişleri al
                string ad = AdTextBox.Text;
                string soyad = SoyadTextBox.Text;
                string tc = TCTextBox.Text;
                string telefon = TelefonTextBox.Text;
                string email = EmailTextBox.Text;
                string adres = AdresTextBox.Text;
                string sifre = SifreTextBox.Text;

                // Yaş, boy ve kilo değerlerini doğrudan NumericUpDown'ten al
                int yas = Convert.ToInt32(YasNumericUpDown.Value);
                decimal boy = BoyNumericUpDown.Value;
                decimal kilo = KiloNumericUpDown.Value;

                // Müşteri oluştur
                Musteri yeniMusteri = new Musteri(database);

                // Müşteri bilgilerini set et
                yeniMusteri.Ad = ad;
                yeniMusteri.Soyad = soyad;

                // Diğer bilgileri de eklerseniz, Musteri sınıfında gerekli property'leri ekleyin.

                // Müşteriyi veritabanına kaydet
                bool kayitBasarili = yeniMusteri.KayitOl(ad, soyad, tc, telefon, email, adres, sifre, yas, boy, kilo);

                if (kayitBasarili)
                {
                    MessageBox.Show("Kayıt işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Kayıt başarılıysa formu kapat
                }
                else
                {
                    MessageBox.Show("Kayıt sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void YasTextBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
