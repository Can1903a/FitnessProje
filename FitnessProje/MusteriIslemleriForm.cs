using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Fitness;
using FitnessProje;
using MySql.Data.MySqlClient;

namespace Fitness
{
    public partial class MusteriIslemleriForm : Form
    {
        private Database database;
        private Yonetici yonetici;
        private Musteri musteri;

        public MusteriIslemleriForm(Database db, Yonetici yoneticiInstance)
        {
            InitializeComponent();
            database = db;
            yonetici = yoneticiInstance;
        }

        public MusteriIslemleriForm(Database database, Musteri musteri)
        {
            this.database = database;
            this.musteri = musteri;
        }

        private void MusteriIslemleriForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılması gereken işlemleri buraya ekleyin.
        }

        // Müşteri işlemleri için gerekli kodlar buraya eklenebilir.
    }
}
