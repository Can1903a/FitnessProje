namespace FitnessProje
{
    partial class BeslenmeIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeslenmeIslemleri));
            this.textBoxYemekAdi = new System.Windows.Forms.TextBox();
            this.numericUpDownKalori = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.dataGridViewBeslenme = new System.Windows.Forms.DataGridView();
            this.GeriButon4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKalori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeslenme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeriButon4)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxYemekAdi
            // 
            this.textBoxYemekAdi.Location = new System.Drawing.Point(94, 53);
            this.textBoxYemekAdi.Name = "textBoxYemekAdi";
            this.textBoxYemekAdi.Size = new System.Drawing.Size(164, 20);
            this.textBoxYemekAdi.TabIndex = 0;
            // 
            // numericUpDownKalori
            // 
            this.numericUpDownKalori.Location = new System.Drawing.Point(120, 95);
            this.numericUpDownKalori.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownKalori.Name = "numericUpDownKalori";
            this.numericUpDownKalori.Size = new System.Drawing.Size(103, 20);
            this.numericUpDownKalori.TabIndex = 1;
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.Location = new System.Drawing.Point(108, 126);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(137, 20);
            this.dateTimePickerTarih.TabIndex = 2;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(131, 168);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(75, 23);
            this.buttonKaydet.TabIndex = 3;
            this.buttonKaydet.Text = "Yemek Ekle";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // dataGridViewBeslenme
            // 
            this.dataGridViewBeslenme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBeslenme.Location = new System.Drawing.Point(296, 12);
            this.dataGridViewBeslenme.Name = "dataGridViewBeslenme";
            this.dataGridViewBeslenme.Size = new System.Drawing.Size(289, 143);
            this.dataGridViewBeslenme.TabIndex = 4;
            // 
            // GeriButon4
            // 
            this.GeriButon4.Image = ((System.Drawing.Image)(resources.GetObject("GeriButon4.Image")));
            this.GeriButon4.Location = new System.Drawing.Point(12, 31);
            this.GeriButon4.Name = "GeriButon4";
            this.GeriButon4.Size = new System.Drawing.Size(55, 42);
            this.GeriButon4.TabIndex = 12;
            this.GeriButon4.TabStop = false;
            this.GeriButon4.Click += new System.EventHandler(this.GeriButon4_Click);
            // 
            // BeslenmeIslemleri
            // 
            this.ClientSize = new System.Drawing.Size(597, 283);
            this.Controls.Add(this.GeriButon4);
            this.Controls.Add(this.dataGridViewBeslenme);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.dateTimePickerTarih);
            this.Controls.Add(this.numericUpDownKalori);
            this.Controls.Add(this.textBoxYemekAdi);
            this.Name = "BeslenmeIslemleri";
            this.Load += new System.EventHandler(this.BeslenmeEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKalori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeslenme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeriButon4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxYemekAdi;
        private System.Windows.Forms.NumericUpDown numericUpDownKalori;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.DataGridView dataGridViewBeslenme;
        private System.Windows.Forms.PictureBox GeriButon4;
    }
}