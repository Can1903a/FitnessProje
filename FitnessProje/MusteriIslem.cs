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

        private void MusteriIslem_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewAntrenmanlar.ReadOnly = true;

                LoadMusteriAntrenmanlar();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}\n{ex.StackTrace}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMusteriAntrenmanlar()
        {

            DataTable antrenmanlarTable = musteri.GetMusteriAntrenmanlar();


            dataGridViewAntrenmanlar.DataSource = antrenmanlarTable;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BeslenmeTakipForm beslenmeTakipForm = new BeslenmeTakipForm(database, musteri);
            beslenmeTakipForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BeslenmeEkleForm beslenmeEkleForm = new BeslenmeEkleForm(database, musteri);
            beslenmeEkleForm.Show();
            this.Hide();
        }
    }
}
