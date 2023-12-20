namespace FitnessProje
{
    partial class BeslenmeEkleForm
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
            this.textBoxYemekAdi = new System.Windows.Forms.TextBox();
            this.numericUpDownKalori = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            this.buttonKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKalori)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxYemekAdi
            // 
            this.textBoxYemekAdi.Location = new System.Drawing.Point(54, 54);
            this.textBoxYemekAdi.Name = "textBoxYemekAdi";
            this.textBoxYemekAdi.Size = new System.Drawing.Size(164, 20);
            this.textBoxYemekAdi.TabIndex = 0;
            // 
            // numericUpDownKalori
            // 
            this.numericUpDownKalori.Location = new System.Drawing.Point(83, 95);
            this.numericUpDownKalori.Name = "numericUpDownKalori";
            this.numericUpDownKalori.Size = new System.Drawing.Size(103, 20);
            this.numericUpDownKalori.TabIndex = 1;
            this.numericUpDownKalori.ValueChanged += new System.EventHandler(this.numericUpDownKalori_ValueChanged);
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.Location = new System.Drawing.Point(71, 126);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(137, 20);
            this.dateTimePickerTarih.TabIndex = 2;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(94, 168);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(75, 23);
            this.buttonKaydet.TabIndex = 3;
            this.buttonKaydet.Text = "Yemek Ekle";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // BeslenmeEkleForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.dateTimePickerTarih);
            this.Controls.Add(this.numericUpDownKalori);
            this.Controls.Add(this.textBoxYemekAdi);
            this.Name = "BeslenmeEkleForm";
            this.Load += new System.EventHandler(this.BeslenmeEkleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKalori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxYemekAdi;
        private System.Windows.Forms.NumericUpDown numericUpDownKalori;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
        private System.Windows.Forms.Button buttonKaydet;
    }
}