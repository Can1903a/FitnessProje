using System;
using System.Data;
using System.Windows.Forms;
using Fitness;

namespace FitnessProje
{
    public partial class MusteriBilgiGuncelleForm : Form
    {
        private Database database;
        private Musteri musteri;

        public MusteriBilgiGuncelleForm(Database db, Musteri musteriInstance)
        {
            InitializeComponent();
            database = db;
            musteri = musteriInstance ?? new Musteri(database);

            // TODO: Giriş alanları ve diğer kontrolleri burada başlatın
        }

        private void MusteriBilgiGuncelleForm_Load(object sender, EventArgs e)
        {

        }


        private void btnBilgiGuncelle_Click_1(object sender, EventArgs e)
        {

            try
            {
                // TODO: Giriş alanlarından güncellenecek bilgileri alın
                string yeniAd = txtYeniAd.Text;
                string yeniSoyad = txtYeniSoyad.Text;
                string yeniTelefon = txtYeniTelefon.Text;
                string yeniEmail = txtYeniEmail.Text;
                string yeniAdres = txtYeniAdres.Text;
                int yeniYas = Convert.ToInt32(txtYeniYas.Text);
                decimal yeniBoy = Convert.ToDecimal(txtYeniBoy.Text);
                decimal yeniKilo = Convert.ToDecimal(txtYeniKilo.Text);

                // TODO: Musteri sınıfındaki güncelleme yöntemini çağırın
                bool guncellemeBasarili = musteri.GuncelleMusteriBilgileri(yeniAd, yeniSoyad, yeniTelefon, yeniEmail, yeniAdres, yeniYas, yeniBoy, yeniKilo);

                if (guncellemeBasarili)
                {
                    MessageBox.Show("Müşteri bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // TODO: Formu kapatın veya başka bir işlem gerçekleştirin
                }
                else
                {
                    MessageBox.Show("Müşteri bilgileri güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: Eski şifre, yeni şifre ve yeni şifre tekrarı alanlarından bilgi alın
                string eskiSifre = txtEskiSifre.Text;
                string yeniSifre = txtYeniSifre.Text;
                string yeniSifreTekrar = txtYeniSifreTekrar.Text;

                // TODO: Eski şifreyi doğrula
                bool eskiSifreDogru = musteri.DogrulaEskiSifre(eskiSifre);

                if (!eskiSifreDogru)
                {
                    MessageBox.Show("Eski şifre doğrulanamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // TODO: Yeni şifreleri kontrol et
                if (yeniSifre != yeniSifreTekrar)
                {
                    MessageBox.Show("Yeni şifreler eşleşmiyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // TODO: Musteri sınıfındaki şifre güncelleme yöntemini çağırın
                bool sifreGuncellemeBasarili = musteri.GuncelleMusteriSifre(yeniSifre);

                if (sifreGuncellemeBasarili)
                {
                    MessageBox.Show("Şifre güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // TODO: Formu kapatın veya başka bir işlem gerçekleştirin
                }
                else
                {
                    MessageBox.Show("Şifre güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void GeriButon3_Click(object sender, EventArgs e)
        {
            MusteriIslem musteriIslem = new MusteriIslem(database, musteri);
            musteriIslem.Show();
            this.Close();
        }
    }
}

