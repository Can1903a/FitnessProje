using System;
using System.Drawing;
using System.Windows.Forms;
using Fitness;
using FitnessProje;
using MySql.Data.MySqlClient;

namespace Fitness
{
    public partial class Anasayfa : Form
    {
        private Database database;
        private Yonetici yonetici;
        private Musteri musteri;
        private Antrenor antrenor;

        public Anasayfa(Antrenor antrenor)
        {
            this.antrenor = antrenor;
        }

        public Anasayfa()
        {
            InitializeComponent();

            // MySQL bağlantı bilgilerini buraya ekleyin.
            string connectionString = "server=localhost;user=root;password=1234;database=Fitness";

            database = new Database(connectionString);
            yonetici = new Yonetici(database);
        }


        private void FitnessProje_Load(object sender, EventArgs e)
        {

        }

        private void YoneticiGirisiButton_Click(object sender, EventArgs e)
        {
            YoneticiGirisForm yoneticiGirisForm = new YoneticiGirisForm(database, yonetici);
            yoneticiGirisForm.Show();
            this.Hide();
        }

        private void MusteriGirisiButton_Click(object sender, EventArgs e)
        {
            MusteriGirisForm musteriGirisForm = new MusteriGirisForm(database, musteri);
            musteriGirisForm.Show();
            this.Hide();
        }

        private void Btn_Antrenor_Click(object sender, EventArgs e)
        {
            AntrenorGirisForm antrenorGirisForm = new AntrenorGirisForm(database, antrenor);
            antrenorGirisForm.Show();
            this.Hide();
        }

        private void btnMusteriKayit_Click(object sender, EventArgs e)
        {
            MusteriKayit musteriKayit = new MusteriKayit(database, musteri);
            musteriKayit.Show();
            this.Hide();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

        }

    }
}
