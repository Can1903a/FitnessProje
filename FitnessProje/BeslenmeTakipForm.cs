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

            
            musteri = musteriInstance ?? new Musteri(database);

            LoadMusteriBilgileri();
          
            LoadBeslenmeBilgileri();
        }

        private void LoadMusteriBilgileri()
        {

            labelMusteriAdi.Text = $"Müşteri Adı: {musteri.Ad} {musteri.Soyad}";
            labelMusteriID.Text = $"Müşteri ID: {musteri.MusteriID}";
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

        private void buttonYemekEkle_Click(object sender, EventArgs e)
        {
            try
            {

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

                if (beslenmeEkleForm.ShowDialog() == DialogResult.OK)
                {

                    LoadBeslenmeBilgileri();
                }
            }
        }

        private void BeslenmeTakipForm_Load(object sender, EventArgs e)
        {

        }
    }
}
