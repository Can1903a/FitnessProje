namespace FitnessProje
{
    partial class BeslenmeTakipForm
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
            this.labelMusteriAdi = new System.Windows.Forms.Label();
            this.labelMusteriID = new System.Windows.Forms.Label();
            this.dataGridViewBeslenme = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeslenme)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMusteriAdi
            // 
            this.labelMusteriAdi.AutoSize = true;
            this.labelMusteriAdi.Location = new System.Drawing.Point(61, 55);
            this.labelMusteriAdi.Name = "labelMusteriAdi";
            this.labelMusteriAdi.Size = new System.Drawing.Size(59, 13);
            this.labelMusteriAdi.TabIndex = 0;
            this.labelMusteriAdi.Text = "Musteri Adi";
            // 
            // labelMusteriID
            // 
            this.labelMusteriID.AutoSize = true;
            this.labelMusteriID.Location = new System.Drawing.Point(61, 99);
            this.labelMusteriID.Name = "labelMusteriID";
            this.labelMusteriID.Size = new System.Drawing.Size(55, 13);
            this.labelMusteriID.TabIndex = 1;
            this.labelMusteriID.Text = "Musteri ID";
            // 
            // dataGridViewBeslenme
            // 
            this.dataGridViewBeslenme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBeslenme.Location = new System.Drawing.Point(185, 25);
            this.dataGridViewBeslenme.Name = "dataGridViewBeslenme";
            this.dataGridViewBeslenme.Size = new System.Drawing.Size(336, 187);
            this.dataGridViewBeslenme.TabIndex = 2;
            // 
            // BeslenmeTakipForm
            // 
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.dataGridViewBeslenme);
            this.Controls.Add(this.labelMusteriID);
            this.Controls.Add(this.labelMusteriAdi);
            this.Name = "BeslenmeTakipForm";
            this.Load += new System.EventHandler(this.BeslenmeTakipForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBeslenme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMusteriAdi;
        private System.Windows.Forms.Label labelMusteriID;
        private System.Windows.Forms.DataGridView dataGridViewBeslenme;
    }
}