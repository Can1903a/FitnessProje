using System;
using System.Windows.Forms;
using Fitness;
using FitnessProje;

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

        private void antrenorTCTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void GirisButon2_Click(object sender, EventArgs e)
        {
            try
            {
                string antrenorTC = antrenorTCTextBox.Text;
                string antrenorSifre = antrenorSifreTextBox.Text;

                if (antrenor.AntrenorGirisYap(antrenorTC, antrenorSifre))
                {
                    AntrenorIslemleriForm antrenorIslemleriForm = new AntrenorIslemleriForm(database, antrenor);
                    antrenorIslemleriForm.Show();
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

        private void GeriButon2_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Close();
        }


    }
}
