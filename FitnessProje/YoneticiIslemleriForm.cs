using System;
using System.Windows.Forms;
using Fitness;
using MySql.Data.MySqlClient;

namespace Fitness
{
    public partial class YoneticiIslemleriForm : Form
    {
        private Database database;
        private Yonetici yonetici;
        private Antrenor antrenor;

        public YoneticiIslemleriForm(Database db, Yonetici yoneticiInstance)
        {
            InitializeComponent();
            database = db;
            yonetici = yoneticiInstance;
        }

        public YoneticiIslemleriForm(Database database, Antrenor antrenor)
        {
            this.database = database;
            this.antrenor = antrenor;
        }

        private void YoneticiIslemleriForm_Load(object sender, EventArgs e)
        {

        }

        // Yönetici işlemleri için gerekli kodlar buraya eklenebilir.
    }
}

