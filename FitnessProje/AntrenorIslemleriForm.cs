// AntrenorIslemleriForm.cs
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Fitness;

namespace FitnessProje
{
    public partial class AntrenorIslemleriForm : Form
    {
        private Database database;
        private Antrenor antrenor;

        public AntrenorIslemleriForm(Database db, Antrenor antrenorInstance)
        {
            InitializeComponent();
            database = db;
            antrenor = antrenorInstance;

            LoadAntrenmanListesi();
            LoadMusteriListesi();
        }

        private void LoadMusteriListesi()
        {
            try
            {
                DataTable musteriListesi = antrenor.GetMusteriListesi();

                if (musteriListesi != null)
                {
                    musteriDataGridView.DataSource = musteriListesi;
                }
                else
                {
                    MessageBox.Show("Müşteri listesi yüklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAntrenmanListesi()
        {
            try
            {
                using (MySqlConnection connection = database.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT AntrenmanID, Tarih, Aciklama FROM antrenmanlar WHERE AntrenorID = @AntrenorID";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@AntrenorID", antrenor.AntrenorID);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable antrenmanTable = new DataTable();
                            adapter.Fill(antrenmanTable);

                            dataGridViewAntrenmanlar.DataSource = antrenmanTable;
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Antrenman listesi yüklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 



        private void AntrenorIslemleriForm_Load(object sender, EventArgs e)
        {
           
            dateTimePickerTarih.MinDate = DateTime.Now;
            
        }

        private void DiyetAtaButton_Click(object sender, EventArgs e)
        {

            try
            {
                int selectedRowIndex = musteriDataGridView.SelectedCells[0].RowIndex;
                int musteriID = Convert.ToInt32(musteriDataGridView.Rows[selectedRowIndex].Cells["MusteriID"].Value);

                string diyetProgramAdi = DiyetTextBox.Text;
                string diyetProgramIcerik = diyetProgramIcerikRichTextBox.Text;

                bool atamaBasarili = antrenor.DiyetAta(musteriID, diyetProgramAdi, diyetProgramIcerik);


                if (atamaBasarili)
                {
                    MessageBox.Show("Diyet atama işlemi başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // VKI'yi hesapla ve ekrana yazdır
                    decimal vki = antrenor.CalculateVucutKitleIndeksi(musteriID);

                    // VKI'yi ekrana yazdır
                    VKILabel.Text = $"Vücut Kitle İndeksi: {vki}";
                }
                else
                {
                    MessageBox.Show("Diyet atama sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("hata.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void musteriDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedRowIndex = musteriDataGridView.SelectedCells[0].RowIndex;
                int musteriID = Convert.ToInt32(musteriDataGridView.Rows[selectedRowIndex].Cells["MusteriID"].Value);

                // VKI'yi hesapla
                decimal vki = antrenor.CalculateVucutKitleIndeksi(musteriID);

                // VKI'yi ekrana yazdır
                VKILabel.Text = $"Vücut Kitle İndeksi: {vki}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAntrenmanEkle_Click_1(object sender, EventArgs e)
        {

            try
            {
                DateTime tarih = dateTimePickerTarih.Value.Date;
                string aciklama = txtAciklama.Text;

                bool eklemeBasarili = antrenor.AntrenmanEkle(tarih, aciklama);

                if (eklemeBasarili)
                {
                    MessageBox.Show("Antrenman başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAntrenmanListesi();
                }
                else
                {
                    MessageBox.Show("Antrenman eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Antrenman eklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GeriButon_Click(object sender, EventArgs e)
        {

            AntrenorGirisForm antrenorGirisForm = new AntrenorGirisForm(database, antrenor);
            antrenorGirisForm.Show();
            this.Close();
        }
    }
}
