using System;
using System.Data;
using System.Windows.Forms;
using FitnessProje;
using MySql.Data.MySqlClient;

namespace Fitness
{
    public partial class YoneticiIslemleriForm : Form
    {
        private Database database;
        private Yonetici yonetici;

        public YoneticiIslemleriForm(Database db, Yonetici yoneticiInstance)
        {
            InitializeComponent();
            database = db;
            yonetici = yoneticiInstance;
        }

        private void YoneticiIslemleriForm_Load(object sender, EventArgs e)
        {
            LoadAntrenorListesi();
        }

        private void LoadAntrenorListesi()
        {
            try
            {
                using (MySqlConnection connection = database.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT AntrenorID, Ad, Soyad, Email, Telefon, UzmanlikAlani, AntrenorTC FROM antrenorler";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            // Antrenör listesini DataGridView'e yükleyin
                            DataTable antrenorTable = new DataTable();
                            adapter.Fill(antrenorTable);
                            dataGridViewAntrenorler.DataSource = antrenorTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAntrenorEkle_Click(object sender, EventArgs e)
        {
            // Kullanıcının girdiği antrenör bilgilerini al
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string email = txtEmail.Text;
            string telefon = txtTelefon.Text;
            string uzmanlikAlani = txtUzmanlikAlani.Text;
            string antrenorTC = txtAntrenorTC.Text;
            string antrenorSifre = txtAntrenorSifre.Text;

            // Antrenör bilgilerini veritabanına ekleyen sorgu
            string query = "INSERT INTO antrenorler (Ad, Soyad, Email, Telefon, UzmanlikAlani, AntrenorTC, AntrenorSifre) " +
                           "VALUES (@Ad, @Soyad, @Email, @Telefon, @UzmanlikAlani, @AntrenorTC, @AntrenorSifre)";

            try
            {
                using (MySqlConnection connection = database.GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Ad", ad);
                    cmd.Parameters.AddWithValue("@Soyad", soyad);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Telefon", telefon);
                    cmd.Parameters.AddWithValue("@UzmanlikAlani", uzmanlikAlani);
                    cmd.Parameters.AddWithValue("@AntrenorTC", antrenorTC);
                    cmd.Parameters.AddWithValue("@AntrenorSifre", antrenorSifre);

                    // Veritabanına ekleme işlemini gerçekleştir
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Antrenör başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Antrenör eklenince, antrenör listesini güncelleyin
                        LoadAntrenorListesi();

                        // TextBox'ları temizle
                        ClearTextBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Antrenör eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearTextBoxes()
        {
            // TextBox'ları temizle
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtEmail.Text = "";
            txtTelefon.Text = "";
            txtUzmanlikAlani.Text = "";
            txtAntrenorTC.Text = "";
            txtAntrenorSifre.Text = "";
        }

        private void GeriButon9_Click(object sender, EventArgs e)
        {
            YoneticiGirisForm yoneticiGirisForm = new YoneticiGirisForm(database, yonetici);
            yoneticiGirisForm.Show();
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            MusteriListesiForm musteriListesiForm = new MusteriListesiForm(database);
            musteriListesiForm.Show();
        }
    }
}




