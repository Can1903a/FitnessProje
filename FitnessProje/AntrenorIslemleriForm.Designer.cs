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
            this.musteriDataGridView = new System.Windows.Forms.DataGridView();
            this.DiyetTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.VKILabel = new System.Windows.Forms.Label();
            this.DiyetAtaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAntrenmanlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAntrenmanlar
            // 
            this.dataGridViewAntrenmanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAntrenmanlar.Location = new System.Drawing.Point(47, 48);
            this.dataGridViewAntrenmanlar.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewAntrenmanlar.Name = "dataGridViewAntrenmanlar";
            this.dataGridViewAntrenmanlar.RowHeadersWidth = 51;
            this.dataGridViewAntrenmanlar.Size = new System.Drawing.Size(403, 161);
            this.dataGridViewAntrenmanlar.TabIndex = 0;
            // 
            // btnAntrenmanEkle
            // 
            this.btnAntrenmanEkle.Location = new System.Drawing.Point(654, 178);
            this.btnAntrenmanEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnAntrenmanEkle.Name = "btnAntrenmanEkle";
            this.btnAntrenmanEkle.Size = new System.Drawing.Size(177, 65);
            this.btnAntrenmanEkle.TabIndex = 0;
            this.btnAntrenmanEkle.Text = "Antrenman Ekle";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(581, 83);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(4);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(308, 86);
            this.txtAciklama.TabIndex = 2;
            this.txtAciklama.Text = "";
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.Location = new System.Drawing.Point(623, 34);
            this.dateTimePickerTarih.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(233, 22);
            this.dateTimePickerTarih.TabIndex = 3;
            // 
            // musteriDataGridView
            // 
            this.musteriDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteriDataGridView.Location = new System.Drawing.Point(32, 335);
            this.musteriDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.musteriDataGridView.Name = "musteriDataGridView";
            this.musteriDataGridView.RowHeadersWidth = 51;
            this.musteriDataGridView.Size = new System.Drawing.Size(403, 161);
            this.musteriDataGridView.TabIndex = 4;
            // 
            // DiyetTextBox
            // 
            this.DiyetTextBox.Location = new System.Drawing.Point(470, 335);
            this.DiyetTextBox.Name = "DiyetTextBox";
            this.DiyetTextBox.Size = new System.Drawing.Size(100, 22);
            this.DiyetTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Diyet";
            // 
            // VKILabel
            // 
            this.VKILabel.AutoSize = true;
            this.VKILabel.Location = new System.Drawing.Point(525, 404);
            this.VKILabel.Name = "VKILabel";
            this.VKILabel.Size = new System.Drawing.Size(44, 16);
            this.VKILabel.TabIndex = 7;
            this.VKILabel.Text = "label2";
            // 
            // DiyetAtaButton
            // 
            this.DiyetAtaButton.Location = new System.Drawing.Point(667, 314);
            this.DiyetAtaButton.Margin = new System.Windows.Forms.Padding(4);
            this.DiyetAtaButton.Name = "DiyetAtaButton";
            this.DiyetAtaButton.Size = new System.Drawing.Size(177, 65);
            this.DiyetAtaButton.TabIndex = 0;
            this.DiyetAtaButton.Text = "Antrenman Ekle";
            // 
            // AntrenorIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.VKILabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DiyetTextBox);
            this.Controls.Add(this.musteriDataGridView);
            this.Controls.Add(this.dateTimePickerTarih);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.DiyetAtaButton);
            this.Controls.Add(this.btnAntrenmanEkle);
            this.Controls.Add(this.dataGridViewAntrenmanlar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AntrenorIslemleriForm";
            this.Text = "AntrenorIslemleriForm";
            this.Load += new System.EventHandler(this.AntrenorIslemleriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAntrenmanlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriDataGridView)).EndInit();
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
    }
}