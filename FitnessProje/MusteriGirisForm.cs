using System;
using System.Windows.Forms;
using Fitness;

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


            musteri = musteriInstance ?? new Musteri(database);
        }

        private void MusteriGirisForm_Load(object sender, EventArgs e)
        {

        }

        private void GirisButon2_Click_1(object sender, EventArgs e)
        {
            try
            {

                string tc = TcTextBox.Text;
                string sifre = SifreTextBox.Text;


                if (musteri.GirisYap(tc, sifre))
                {

                    MusteriIslem musteriIslemleriForm = new MusteriIslem(database, musteri);
                    musteriIslemleriForm.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Geçersiz kullanıcı adı veya şifre.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GeriButon3_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Close();
        }
    }
}

