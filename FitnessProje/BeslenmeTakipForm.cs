using Fitness;
using System;
using System.Data;
using System.Windows.Forms;

namespace FitnessProje
{
    public partial class BeslenmeTakipForm : Form
    {
        private Database database;
        private Musteri musteri;

        public BeslenmeTakipForm(Database db, Musteri musteriInstance)
        {
            InitializeComponent();
            database = db;

            // musteriInstance null kontrolü ekleyerek nesnenin oluşturulup oluşturulmadığını kontrol edin.
            musteri = musteriInstance ?? new Musteri(database);

            // Form yüklenirken müşteri bilgilerini göster
            LoadMusteriBilgileri();
            // Müşteriye ait beslenme bilgilerini yükle
            LoadBeslenmeBilgileri();
        }

        private void LoadMusteriBilgileri()
        {
            // Müşteri bilgilerini göster
            labelMusteriAdi.Text = $"Müşteri Adı: {musteri.Ad} {musteri.Soyad}";
            labelMusteriID.Text = $"Müşteri ID: {musteri.MusteriID}";
        }

        private void LoadBeslenmeBilgileri()
        {
            try
            {
                // Müşteriye ait beslenme bilgilerini çek
                DataTable beslenmeTable = musteri.GetMusteriBeslenmeBilgileri();

                // DataGridView'a beslenme bilgilerini yükle
                dataGridViewBeslenme.DataSource = beslenmeTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonYemekEkle_Click(object sender, EventArgs e)
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

        private void YemekEkle()
        {
            using (BeslenmeEkleForm beslenmeEkleForm = new BeslenmeEkleForm(database, musteri))
            {
                // BeslenmeEkleForm'u açın
                if (beslenmeEkleForm.ShowDialog() == DialogResult.OK)
                {
                    // Eğer kullanıcı yeni bir yemek eklediyse, beslenme bilgilerini güncelle
                    LoadBeslenmeBilgileri();
                }
            }
        }

        private void BeslenmeTakipForm_Load(object sender, EventArgs e)
        {

        }
    }
}
