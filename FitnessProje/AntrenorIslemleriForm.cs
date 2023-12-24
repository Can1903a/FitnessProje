// AntrenorIslemleriForm formu
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using Fitness;

namespace FitnessProje
{
    public partial class AntrenorIslemleriForm : Form
    {
        private Database database;
        private Antrenor antrenor;

        public AntrenorIslemleriForm(Database db, Antrenor antrenorInstance)
        {
            InitializeComponent();
            database = db;
            antrenor = antrenorInstance;

            // Form yüklenirken antrenman listesini yükle
            LoadAntrenmanListesi();
        }

        private void LoadAntrenmanListesi()
        {
            try
            {
                using (MySqlConnection connection = database.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT AntrenmanID, Tarih, Aciklama FROM antrenmanlar WHERE AntrenorID = @AntrenorID";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@AntrenorID", antrenor.AntrenorID);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable antrenmanTable = new DataTable();
                            adapter.Fill(antrenmanTable);

                            dataGridViewAntrenmanlar.DataSource = antrenmanTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AntrenorIslemleriForm_Load(object sender, EventArgs e)
        {
            // İlgili işlemler form yüklendiğinde burada yapılabilir.
        }

      
        private void btnAntrenmanEkle_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcının girdiği antrenman bilgilerini al
                DateTime tarih = dateTimePickerTarih.Value.Date; // .Date kullanarak sadece tarihi alıyoruz
                string aciklama = txtAciklama.Text;

                // Antrenmanı eklemek için Antrenor sınıfındaki metodu çağır
                bool eklemeBasarili = antrenor.AntrenmanEkle( tarih, aciklama);

                if (eklemeBasarili)
                {
                    MessageBox.Show("Antrenman başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Antrenman ekledikten sonra antrenman listesini güncelle
                    LoadAntrenmanListesi();
                }
                else
                {
                    MessageBox.Show("Antrenman eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //...
    }
}
