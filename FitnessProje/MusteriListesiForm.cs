using System;
using System.Data;
using System.Windows.Forms;
using Fitness;
using MySql.Data.MySqlClient;

namespace FitnessProje
{
    public partial class MusteriListesiForm : Form
    {
        private Database database;

        public MusteriListesiForm(Database db)
        {
            InitializeComponent();
            database = db;
        }

        private void MusteriListesiForm_Load(object sender, EventArgs e)
        {
            LoadMusteriListesi();
        }

        private void LoadMusteriListesi()
        {
            try
            {
                using (MySqlConnection connection = database.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT MusteriID, Ad, Soyad, Email, Telefon, Tc FROM musteriler";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            // Müşteri listesini DataGridView'e yükleyin
                            DataTable musteriTable = new DataTable();
                            adapter.Fill(musteriTable);
                            dataGridViewMusteriler.DataSource = musteriTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}