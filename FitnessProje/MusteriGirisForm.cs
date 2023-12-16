using System;
using System.Windows.Forms;
using FitnessProje;
using Fitness;
using MySql.Data.MySqlClient;

namespace FitnessProje
{
    public partial class MusteriGirisForm : Form
    {
        private Database database;
        private Musteri musteri;

        public MusteriGirisForm(Database db, Musteri musteriInstance)
        {
            InitializeComponent();
            database = db;

            // musteriInstance null kontrolü ekleyerek nesnenin oluşturulup oluşturulmadığını kontrol edin.
            musteri = musteriInstance ?? new Musteri(database);
        }



        private void MusteriGirisForm_Load(object sender, EventArgs e)
        {

        }



        private void GirisButon2_Click_1(object sender, EventArgs e)
        {
            // Kullanıcı giriş bilgilerini al
            string tc = TcTextBox.Text;
            string sifre = SifreTextBox.Text;

            // Giriş bilgilerini kontrol et
            if (musteri.GirisYap(tc, sifre))
            {
                // Başarılı giriş durumunda ana menüyü aç
                MusteriIslemleriForm musteriIslemleriForm = new MusteriIslemleriForm(database, musteri);
                musteriIslemleriForm.Show();

                // Şu anki formu kapat
                this.Close();
            }
            else
            {
                // Hatalı giriş durumunda kullanıcıya bilgi ver
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
