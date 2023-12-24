// AntrenorGirisForm formu
using Fitness;
using System;
using System.Windows.Forms;

namespace FitnessProje
{
    public partial class AntrenorGirisForm : Form
    {
        private Database database;
        private Antrenor antrenor;

        public AntrenorGirisForm(Database db, Antrenor antrenorInstance)
        {
            InitializeComponent();
            database = db;
            antrenor = antrenorInstance ?? new Antrenor(database);
        }


      
        private void AntrenorGirisForm_Load(object sender, EventArgs e)
        {

        }

        private void GirisButon_Click_1(object sender, EventArgs e)
        {
            // Kullanıcı giriş bilgilerini al
            string antrenorTC = antrenorTCTextBox.Text;
            string antrenorSifre = antrenorSifreTextBox.Text;

            // Giriş bilgilerini kontrol et
            if (antrenor.GirisYap(antrenorTC, antrenorSifre))
            {
                // Başarılı giriş durumunda ana menüyü aç
                AntrenorIslemleriForm antrenorIslemleriForm = new AntrenorIslemleriForm(database, antrenor);
                antrenorIslemleriForm.Show();

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