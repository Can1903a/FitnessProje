namespace FitnessProje
{
    partial class AntrenorIslemleriForm
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
            this.dataGridViewAntrenmanlar = new System.Windows.Forms.DataGridView();
            this.btnAntrenmanEkle = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAntrenmanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAntrenmanlar
            // 
            this.dataGridViewAntrenmanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAntrenmanlar.Location = new System.Drawing.Point(31, 39);
            this.dataGridViewAntrenmanlar.Name = "dataGridViewAntrenmanlar";
            this.dataGridViewAntrenmanlar.Size = new System.Drawing.Size(305, 171);
            this.dataGridViewAntrenmanlar.TabIndex = 0;
            // 
            // btnAntrenmanEkle
            // 
            this.btnAntrenmanEkle.Location = new System.Drawing.Point(486, 177);
            this.btnAntrenmanEkle.Name = "btnAntrenmanEkle";
            this.btnAntrenmanEkle.Size = new System.Drawing.Size(133, 53);
            this.btnAntrenmanEkle.TabIndex = 0;
            this.btnAntrenmanEkle.Text = "Antrenman Ekle";
            this.btnAntrenmanEkle.Click += new System.EventHandler(this.btnAntrenmanEkle_Click_1);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(431, 100);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(232, 71);
            this.txtAciklama.TabIndex = 2;
            this.txtAciklama.Text = "";
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.Location = new System.Drawing.Point(463, 60);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(176, 20);
            this.dateTimePickerTarih.TabIndex = 3;
            // 
            // AntrenorIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerTarih);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.btnAntrenmanEkle);
            this.Controls.Add(this.dataGridViewAntrenmanlar);
            this.Name = "AntrenorIslemleriForm";
            this.Text = "AntrenorIslemleriForm";
            this.Load += new System.EventHandler(this.AntrenorIslemleriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAntrenmanlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAntrenmanlar;
        private System.Windows.Forms.Button btnAntrenmanEkle;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
    }
}