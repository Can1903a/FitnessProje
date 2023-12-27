using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Fitness
{
    public partial class YoneticiGirisForm : Form
    {
        private Database database;
        private Yonetici yonetici;

        public YoneticiGirisForm(Database db, Yonetici yoneticiInstance)
        {
            InitializeComponent();
            database = db;
            yonetici = yoneticiInstance;
        }



        private void YoneticiGirisForm_Load(object sender, EventArgs e)
        {

        }

        private void GirisButon_Click(object sender, EventArgs e)
        {
            // Kullanıcı giriş bilgilerini al
            string kullaniciAdi = KullaniciAdiTextBox.Text;
            string sifre = SifreTextBox.Text;

            // Giriş bilgilerini kontrol et
            if (yonetici.GirisYap(kullaniciAdi, sifre))
            {
                // Başarılı giriş durumunda ana menüyü aç
                YoneticiIslemleriForm yoneticiIslemleriForm = new YoneticiIslemleriForm(database, yonetici);
                yoneticiIslemleriForm.Show();

                // Şu anki formu kapat
                this.Close();
            }
            else
            {
                // Hatalı giriş durumunda kullanıcıya bilgi ver
                MessageBox.Show("Geçersiz kullanıcı adı veya şifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GeriButon8_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Close();
        }
    }
}

