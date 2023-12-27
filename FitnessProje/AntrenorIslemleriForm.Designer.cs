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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AntrenorIslemleriForm));
            this.dataGridViewAntrenmanlar = new System.Windows.Forms.DataGridView();
            this.btnAntrenmanEkle = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            this.musteriDataGridView = new System.Windows.Forms.DataGridView();
            this.DiyetTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VKILabel = new System.Windows.Forms.Label();
            this.DiyetAtaButton = new System.Windows.Forms.Button();
            this.diyetProgramIcerikRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GeriButon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAntrenmanlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeriButon)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAntrenmanlar
            // 
            this.dataGridViewAntrenmanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAntrenmanlar.Location = new System.Drawing.Point(167, 43);
            this.dataGridViewAntrenmanlar.Name = "dataGridViewAntrenmanlar";
            this.dataGridViewAntrenmanlar.RowHeadersWidth = 51;
            this.dataGridViewAntrenmanlar.Size = new System.Drawing.Size(302, 131);
            this.dataGridViewAntrenmanlar.TabIndex = 0;
            // 
            // btnAntrenmanEkle
            // 
            this.btnAntrenmanEkle.Location = new System.Drawing.Point(578, 146);
            this.btnAntrenmanEkle.Name = "btnAntrenmanEkle";
            this.btnAntrenmanEkle.Size = new System.Drawing.Size(133, 53);
            this.btnAntrenmanEkle.TabIndex = 0;
            this.btnAntrenmanEkle.Text = "Antrenman Ekle";
            this.btnAntrenmanEkle.Click += new System.EventHandler(this.btnAntrenmanEkle_Click_1);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(524, 68);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(232, 71);
            this.txtAciklama.TabIndex = 2;
            this.txtAciklama.Text = "";
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.Location = new System.Drawing.Point(555, 29);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(176, 20);
            this.dateTimePickerTarih.TabIndex = 3;
            // 
            // musteriDataGridView
            // 
            this.musteriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteriDataGridView.Location = new System.Drawing.Point(186, 279);
            this.musteriDataGridView.Name = "musteriDataGridView";
            this.musteriDataGridView.RowHeadersWidth = 51;
            this.musteriDataGridView.Size = new System.Drawing.Size(302, 131);
            this.musteriDataGridView.TabIndex = 4;
            this.musteriDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.musteriDataGridView_CellClick_1);
            // 
            // DiyetTextBox
            // 
            this.DiyetTextBox.Location = new System.Drawing.Point(516, 259);
            this.DiyetTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DiyetTextBox.Name = "DiyetTextBox";
            this.DiyetTextBox.Size = new System.Drawing.Size(100, 20);
            this.DiyetTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Diyet Programı Adı";
            // 
            // VKILabel
            // 
            this.VKILabel.AutoSize = true;
            this.VKILabel.Location = new System.Drawing.Point(309, 416);
            this.VKILabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VKILabel.Name = "VKILabel";
            this.VKILabel.Size = new System.Drawing.Size(24, 13);
            this.VKILabel.TabIndex = 7;
            this.VKILabel.Text = "VKI";
            // 
            // DiyetAtaButton
            // 
            this.DiyetAtaButton.Location = new System.Drawing.Point(629, 357);
            this.DiyetAtaButton.Name = "DiyetAtaButton";
            this.DiyetAtaButton.Size = new System.Drawing.Size(133, 53);
            this.DiyetAtaButton.TabIndex = 0;
            this.DiyetAtaButton.Text = "Diyet Ata";
            this.DiyetAtaButton.Click += new System.EventHandler(this.DiyetAtaButton_Click);
            // 
            // diyetProgramIcerikRichTextBox
            // 
            this.diyetProgramIcerikRichTextBox.Location = new System.Drawing.Point(516, 314);
            this.diyetProgramIcerikRichTextBox.Name = "diyetProgramIcerikRichTextBox";
            this.diyetProgramIcerikRichTextBox.Size = new System.Drawing.Size(100, 96);
            this.diyetProgramIcerikRichTextBox.TabIndex = 9;
            this.diyetProgramIcerikRichTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Diyet Programı İçerik";
            // 
            // GeriButon
            // 
            this.GeriButon.Image = ((System.Drawing.Image)(resources.GetObject("GeriButon.Image")));
            this.GeriButon.Location = new System.Drawing.Point(12, 43);
            this.GeriButon.Name = "GeriButon";
            this.GeriButon.Size = new System.Drawing.Size(55, 42);
            this.GeriButon.TabIndex = 11;
            this.GeriButon.TabStop = false;
            this.GeriButon.Click += new System.EventHandler(this.GeriButon_Click);
            // 
            // AntrenorIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GeriButon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diyetProgramIcerikRichTextBox);
            this.Controls.Add(this.VKILabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiyetTextBox);
            this.Controls.Add(this.musteriDataGridView);
            this.Controls.Add(this.dateTimePickerTarih);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.DiyetAtaButton);
            this.Controls.Add(this.btnAntrenmanEkle);
            this.Controls.Add(this.dataGridViewAntrenmanlar);
            this.Name = "AntrenorIslemleriForm";
            this.Text = "AntrenorIslemleriForm";
            this.Load += new System.EventHandler(this.AntrenorIslemleriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAntrenmanlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GeriButon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAntrenmanlar;
        private System.Windows.Forms.Button btnAntrenmanEkle;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
        private System.Windows.Forms.DataGridView musteriDataGridView;
        private System.Windows.Forms.TextBox DiyetTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VKILabel;
        private System.Windows.Forms.Button DiyetAtaButton;
        private System.Windows.Forms.RichTextBox diyetProgramIcerikRichTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox GeriButon;
    }
}