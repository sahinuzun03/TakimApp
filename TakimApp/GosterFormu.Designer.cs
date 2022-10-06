namespace TakimApp
{
    partial class GosterFormu
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
            this.dgwTakimlar = new System.Windows.Forms.DataGridView();
            this.dgwTakimSahipleri = new System.Windows.Forms.DataGridView();
            this.dgwPersoneller = new System.Windows.Forms.DataGridView();
            this.btnTakimaSahipEkle = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTakimlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTakimSahipleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersoneller)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwTakimlar
            // 
            this.dgwTakimlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTakimlar.Location = new System.Drawing.Point(12, 12);
            this.dgwTakimlar.Name = "dgwTakimlar";
            this.dgwTakimlar.Size = new System.Drawing.Size(512, 349);
            this.dgwTakimlar.TabIndex = 0;
            this.dgwTakimlar.SelectionChanged += new System.EventHandler(this.dgwTakimlar_SelectionChanged);
            // 
            // dgwTakimSahipleri
            // 
            this.dgwTakimSahipleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTakimSahipleri.Location = new System.Drawing.Point(530, 12);
            this.dgwTakimSahipleri.Name = "dgwTakimSahipleri";
            this.dgwTakimSahipleri.Size = new System.Drawing.Size(512, 349);
            this.dgwTakimSahipleri.TabIndex = 1;
            this.dgwTakimSahipleri.SelectionChanged += new System.EventHandler(this.dgwTakimSahipleri_SelectionChanged);
            // 
            // dgwPersoneller
            // 
            this.dgwPersoneller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersoneller.Location = new System.Drawing.Point(12, 367);
            this.dgwPersoneller.Name = "dgwPersoneller";
            this.dgwPersoneller.Size = new System.Drawing.Size(512, 349);
            this.dgwPersoneller.TabIndex = 2;
            this.dgwPersoneller.SelectionChanged += new System.EventHandler(this.dgwPersoneller_SelectionChanged);
            // 
            // btnTakimaSahipEkle
            // 
            this.btnTakimaSahipEkle.Location = new System.Drawing.Point(530, 386);
            this.btnTakimaSahipEkle.Name = "btnTakimaSahipEkle";
            this.btnTakimaSahipEkle.Size = new System.Drawing.Size(174, 72);
            this.btnTakimaSahipEkle.TabIndex = 3;
            this.btnTakimaSahipEkle.Text = "Takima Sahip Ekle";
            this.btnTakimaSahipEkle.UseVisualStyleBackColor = true;
            this.btnTakimaSahipEkle.Click += new System.EventHandler(this.btnTakimaSahipEkle_Click);
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.Location = new System.Drawing.Point(710, 386);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(158, 72);
            this.btnPersonelEkle.TabIndex = 4;
            this.btnPersonelEkle.Text = "Personel Ekle";
            this.btnPersonelEkle.UseVisualStyleBackColor = true;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(877, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 72);
            this.button3.TabIndex = 5;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 72);
            this.button1.TabIndex = 6;
            this.button1.Text = "Takimin Personellerini Goster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GosterFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 738);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnPersonelEkle);
            this.Controls.Add(this.btnTakimaSahipEkle);
            this.Controls.Add(this.dgwPersoneller);
            this.Controls.Add(this.dgwTakimSahipleri);
            this.Controls.Add(this.dgwTakimlar);
            this.Name = "GosterFormu";
            this.Text = "GosterFormu";
            this.Load += new System.EventHandler(this.GosterFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTakimlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTakimSahipleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersoneller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTakimlar;
        private System.Windows.Forms.DataGridView dgwTakimSahipleri;
        private System.Windows.Forms.DataGridView dgwPersoneller;
        private System.Windows.Forms.Button btnTakimaSahipEkle;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}