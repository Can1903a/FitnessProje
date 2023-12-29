using System;
using System.Data;
using System.Windows.Forms;
using Fitness;

namespace FitnessProje
{
    public partial class MusteriIslem : Form
    {
        private Database database;
        private Musteri musteri;

        public MusteriIslem(Database db, Musteri musteriInstance)
        {
            InitializeComponent();
            database = db;

            musteri = musteriInstance ?? new Musteri(database);

        }
        private void LoadAntrenmanListesi()
        {
            try
            {
                // Antrenmanları yükle
                DataTable antrenmanTable = database.GetAntrenmanListesi(); // Bu metodu oluşturmanız gerekecek

                // DataGridView'e verileri ata
                musteriAntrenman.DataSource = antrenmanTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MusteriIslem_Load(object sender, EventArgs e)

        {
            LoadAntrenmanListesi();

            DataTable diyetBilgileri = musteri.GetMusteriDiyetBilgileri();

            if (diyetBilgileri != null)
            {
                dataGridViewDiyetBilgileri.DataSource = diyetBilgileri;
            }
            else
            {
                MessageBox.Show("Diyet bilgileri yüklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private int GetSelectedAntrenmanID()
        {
            // DataGridView'den seçili antrenmanın ID'sini al
            if (musteriAntrenman.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = musteriAntrenman.SelectedRows[0];
                return Convert.ToInt32(selectedRow.Cells["AntrenmanID"].Value);
            }

            return -1; // Seçili antrenman yoksa -1 döndür
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BeslenmeIslemleri beslenmeEkleForm = new BeslenmeIslemleri(database, musteri);
            beslenmeEkleForm.Show();
            this.Hide();
        }

        private void KatilimYapButton_Click_1(object sender, EventArgs e)
        {
            int selectedAntrenmanID = GetSelectedAntrenmanID(); // Seçili antrenmanın ID'sini al

            if (selectedAntrenmanID != -1)
            {
                MusteriAntrenmanKatilim katilim = new MusteriAntrenmanKatilim(database);

                // Müşteri ve antrenman bilgilerini al
                int musteriID = musteri.MusteriID;

                // Katılım yap
                bool katilimBasarili = katilim.KatilimYap(musteriID, selectedAntrenmanID);

                if (katilimBasarili)
                {
                    MessageBox.Show("Antrenmana katılım başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Antrenmana katılım sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir antrenman seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GeriButon3_Click(object sender, EventArgs e)
        {
            MusteriGirisForm musteriGirisForm = new MusteriGirisForm(database, musteri);
            musteriGirisForm.Show();
            this.Close();
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            MusteriBilgiGuncelleForm musteriBilgiGuncelleForm = new MusteriBilgiGuncelleForm(database, musteri);
            musteriBilgiGuncelleForm.Show();
            this.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnodeme_Click(object sender, EventArgs e)
        {
            OdemeForm odemeForm = new OdemeForm(database, musteri);
            odemeForm.Show();
            this.Close();
        }


    }
}
