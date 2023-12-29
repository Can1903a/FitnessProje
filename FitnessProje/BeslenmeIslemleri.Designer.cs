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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GeriButon4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKalori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeslenme)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeriButon4)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxYemekAdi
            // 
            this.textBoxYemekAdi.Location = new System.Drawing.Point(89, 52);
            this.textBoxYemekAdi.Name = "textBoxYemekAdi";
            this.textBoxYemekAdi.Size = new System.Drawing.Size(137, 20);
            this.textBoxYemekAdi.TabIndex = 0;
            // 
            // numericUpDownKalori
            // 
            this.numericUpDownKalori.Location = new System.Drawing.Point(318, 53);
            this.numericUpDownKalori.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownKalori.Name = "numericUpDownKalori";
            this.numericUpDownKalori.Size = new System.Drawing.Size(137, 20);
            this.numericUpDownKalori.TabIndex = 1;
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.Location = new System.Drawing.Point(244, 101);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(137, 20);
            this.dateTimePickerTarih.TabIndex = 2;
            this.dateTimePickerTarih.Value = new System.DateTime(2023, 12, 29, 0, 0, 0, 0);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(201, 147);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(103, 38);
            this.buttonKaydet.TabIndex = 3;
            this.buttonKaydet.Text = "Benlenme Ekle";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // dataGridViewBeslenme
            // 
            this.dataGridViewBeslenme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBeslenme.Location = new System.Drawing.Point(127, 50);
            this.dataGridViewBeslenme.Name = "dataGridViewBeslenme";
            this.dataGridViewBeslenme.Size = new System.Drawing.Size(482, 235);
            this.dataGridViewBeslenme.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kalori";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Yemek Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Bugünün Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cyan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(197, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Müşteri Beslenme Paneli";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonKaydet);
            this.panel1.Controls.Add(this.dateTimePickerTarih);
            this.panel1.Controls.Add(this.numericUpDownKalori);
            this.panel1.Controls.Add(this.textBoxYemekAdi);
            this.panel1.Location = new System.Drawing.Point(127, 278);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 214);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // GeriButon4
            // 
            this.GeriButon4.BackColor = System.Drawing.Color.Cyan;
            this.GeriButon4.Image = ((System.Drawing.Image)(resources.GetObject("GeriButon4.Image")));
            this.GeriButon4.Location = new System.Drawing.Point(13, 11);
            this.GeriButon4.Name = "GeriButon4";
            this.GeriButon4.Size = new System.Drawing.Size(55, 42);
            this.GeriButon4.TabIndex = 12;
            this.GeriButon4.TabStop = false;
            this.GeriButon4.Click += new System.EventHandler(this.GeriButon4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.GeriButon4);
            this.panel2.Location = new System.Drawing.Point(-1, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 53);
            this.panel2.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(129, 441);
            this.panel3.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BeslenmeIslemleri
            // 
            this.ClientSize = new System.Drawing.Size(608, 490);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewBeslenme);
            this.Controls.Add(this.panel1);
            this.Name = "BeslenmeIslemleri";
            this.Load += new System.EventHandler(this.BeslenmeIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKalori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeslenme)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GeriButon4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxYemekAdi;
        private System.Windows.Forms.NumericUpDown numericUpDownKalori;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.DataGridView dataGridViewBeslenme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox GeriButon4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}