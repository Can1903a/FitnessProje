namespace FitnessProje
{
    partial class MusteriIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriIslem));
            this.button2 = new System.Windows.Forms.Button();
            this.KatilimYapButton = new System.Windows.Forms.Button();
            this.musteriAntrenman = new System.Windows.Forms.DataGridView();
            this.GeriButon3 = new System.Windows.Forms.PictureBox();
            this.btnBilgiGuncelle = new System.Windows.Forms.Button();
            this.dataGridViewDiyetBilgileri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.musteriAntrenman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeriButon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiyetBilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "Beslenme Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KatilimYapButton
            // 
            this.KatilimYapButton.Location = new System.Drawing.Point(379, 225);
            this.KatilimYapButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.KatilimYapButton.Name = "KatilimYapButton";
            this.KatilimYapButton.Size = new System.Drawing.Size(107, 58);
            this.KatilimYapButton.TabIndex = 6;
            this.KatilimYapButton.Text = "Antrenmana Katıl";
            this.KatilimYapButton.UseVisualStyleBackColor = true;
            this.KatilimYapButton.Click += new System.EventHandler(this.KatilimYapButton_Click_1);
            // 
            // musteriAntrenman
            // 
            this.musteriAntrenman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteriAntrenman.Location = new System.Drawing.Point(249, 43);
            this.musteriAntrenman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.musteriAntrenman.Name = "musteriAntrenman";
            this.musteriAntrenman.RowHeadersWidth = 51;
            this.musteriAntrenman.RowTemplate.Height = 24;
            this.musteriAntrenman.Size = new System.Drawing.Size(362, 178);
            this.musteriAntrenman.TabIndex = 7;
            // 
            // GeriButon3
            // 
            this.GeriButon3.Image = ((System.Drawing.Image)(resources.GetObject("GeriButon3.Image")));
            this.GeriButon3.Location = new System.Drawing.Point(12, 43);
            this.GeriButon3.Name = "GeriButon3";
            this.GeriButon3.Size = new System.Drawing.Size(57, 36);
            this.GeriButon3.TabIndex = 8;
            this.GeriButon3.TabStop = false;
            this.GeriButon3.Click += new System.EventHandler(this.GeriButon3_Click);
            // 
            // btnBilgiGuncelle
            // 
            this.btnBilgiGuncelle.Location = new System.Drawing.Point(30, 213);
            this.btnBilgiGuncelle.Name = "btnBilgiGuncelle";
            this.btnBilgiGuncelle.Size = new System.Drawing.Size(111, 58);
            this.btnBilgiGuncelle.TabIndex = 9;
            this.btnBilgiGuncelle.Text = "Bilgilerimi Güncelle";
            this.btnBilgiGuncelle.UseVisualStyleBackColor = true;
            this.btnBilgiGuncelle.Click += new System.EventHandler(this.btnBilgiGuncelle_Click);
            // 
            // dataGridViewDiyetBilgileri
            // 
            this.dataGridViewDiyetBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiyetBilgileri.Location = new System.Drawing.Point(262, 294);
            this.dataGridViewDiyetBilgileri.Name = "dataGridViewDiyetBilgileri";
            this.dataGridViewDiyetBilgileri.Size = new System.Drawing.Size(264, 120);
            this.dataGridViewDiyetBilgileri.TabIndex = 10;
            // 
            // MusteriIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 431);
            this.Controls.Add(this.dataGridViewDiyetBilgileri);
            this.Controls.Add(this.btnBilgiGuncelle);
            this.Controls.Add(this.GeriButon3);
            this.Controls.Add(this.musteriAntrenman);
            this.Controls.Add(this.KatilimYapButton);
            this.Controls.Add(this.button2);
            this.Name = "MusteriIslem";
            this.Text = "MusteriIslem";
            this.Load += new System.EventHandler(this.MusteriIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musteriAntrenman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeriButon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiyetBilgileri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button KatilimYapButton;
        private System.Windows.Forms.DataGridView musteriAntrenman;
        private System.Windows.Forms.PictureBox GeriButon3;
        private System.Windows.Forms.Button btnBilgiGuncelle;
        private System.Windows.Forms.DataGridView dataGridViewDiyetBilgileri;
    }
}