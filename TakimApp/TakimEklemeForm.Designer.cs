namespace TakimApp
{
    partial class TakimEklemeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTakimAdi = new System.Windows.Forms.TextBox();
            this.nupSampSayisi = new System.Windows.Forms.NumericUpDown();
            this.dtpKurulusTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtCalisanSayisi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupSampSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Takım Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şampiyonluk Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toplam Çalışan Sayısı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kuruluş Tarihi :";
            // 
            // txtTakimAdi
            // 
            this.txtTakimAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTakimAdi.Location = new System.Drawing.Point(258, 21);
            this.txtTakimAdi.Name = "txtTakimAdi";
            this.txtTakimAdi.Size = new System.Drawing.Size(198, 29);
            this.txtTakimAdi.TabIndex = 4;
            // 
            // nupSampSayisi
            // 
            this.nupSampSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nupSampSayisi.Location = new System.Drawing.Point(258, 59);
            this.nupSampSayisi.Name = "nupSampSayisi";
            this.nupSampSayisi.Size = new System.Drawing.Size(198, 29);
            this.nupSampSayisi.TabIndex = 5;
            // 
            // dtpKurulusTarihi
            // 
            this.dtpKurulusTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpKurulusTarihi.Location = new System.Drawing.Point(258, 94);
            this.dtpKurulusTarihi.Name = "dtpKurulusTarihi";
            this.dtpKurulusTarihi.Size = new System.Drawing.Size(198, 29);
            this.dtpKurulusTarihi.TabIndex = 6;
            // 
            // txtCalisanSayisi
            // 
            this.txtCalisanSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCalisanSayisi.Location = new System.Drawing.Point(258, 135);
            this.txtCalisanSayisi.Name = "txtCalisanSayisi";
            this.txtCalisanSayisi.Size = new System.Drawing.Size(198, 29);
            this.txtCalisanSayisi.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(258, 180);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(198, 56);
            this.btnEkle.TabIndex = 8;
            this.btnEkle.Text = "Takim Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // TakimEklemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 260);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtCalisanSayisi);
            this.Controls.Add(this.dtpKurulusTarihi);
            this.Controls.Add(this.nupSampSayisi);
            this.Controls.Add(this.txtTakimAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TakimEklemeForm";
            this.Text = "TakimEklemeForm";
            ((System.ComponentModel.ISupportInitialize)(this.nupSampSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTakimAdi;
        private System.Windows.Forms.NumericUpDown nupSampSayisi;
        private System.Windows.Forms.DateTimePicker dtpKurulusTarihi;
        private System.Windows.Forms.TextBox txtCalisanSayisi;
        private System.Windows.Forms.Button btnEkle;
    }
}