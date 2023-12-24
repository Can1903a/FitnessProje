using System;
using System.Windows.Forms;
using Fitness;
using FitnessProje;
using MySql.Data.MySqlClient;

namespace Fitness
{
    public partial class FitnessProje : Form
    {
        private Database database;
        private Yonetici yonetici;
        private Musteri musteri;
        private Antrenor antrenor;

        public FitnessProje()
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

        private void YoneticiGirisiButton_Click_1(object sender, EventArgs e)
        {
            YoneticiGirisForm yoneticiGirisForm = new YoneticiGirisForm(database, yonetici);
            yoneticiGirisForm.Show();
            this.Hide();
        }

        private void MusteriGirisiButton_Click_1(object sender, EventArgs e)
        {
            MusteriGirisForm musteriGirisForm = new MusteriGirisForm(database, musteri);
            musteriGirisForm.Show();
            this.Hide();
        }

        private void Btn_Antrenor_Click(object sender, EventArgs e)
        {
            AntrenorGirisForm antrenorGirisForm = new AntrenorGirisForm(database,antrenor);
            antrenorGirisForm.Show();
            this.Hide();
        }
    }
}
