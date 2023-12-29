using Fitness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessProje
{
    public partial class OdemeForm : Form
    {
        private Musteri musteri;
        private Database database;

        public OdemeForm(Database db, Musteri musteri)
        {
            InitializeComponent();
            this.database = db;
            this.musteri = musteri;
        }

        public OdemeForm(Musteri musteri, Database db)
        {
            InitializeComponent();
            this.musteri = musteri;
            this.database = db;
        }


        private void RefreshOdemeListesi()
        {
            // Ödeme bilgilerini DataGridView'e yükle
            DataTable odemeBilgileri = musteri.GetOdemeBilgileri();

            if (odemeBilgileri != null)
            {
                dataGridViewOdemeBilgileri.DataSource = odemeBilgileri;
            }
            else
            {
                MessageBox.Show("Ödeme bilgileri yüklenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GeriButon11_Click(object sender, EventArgs e)
        {
            MusteriIslem musteriIslem = new MusteriIslem(database, musteri);
            musteriIslem.Show();
            this.Close();
        }

        private void btnOdemeYap_Click_1(object sender, EventArgs e)
        {
            try
            {
                decimal odemeTutari = numericUpDownOdemeMiktari.Value;
                string odemeTuru = comboBoxOdemeTuru.Text;

                bool odemeSonuc = musteri.OdemeYap(odemeTutari, odemeTuru);

                if (odemeSonuc)
                {
                    MessageBox.Show("Ödeme başarıyla yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshOdemeListesi();
                }
                else
                {
                    MessageBox.Show("Ödeme sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OdemeForm_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }



    }

