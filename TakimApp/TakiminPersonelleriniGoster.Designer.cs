namespace TakimApp
{
    partial class TakiminPersonelleriniGoster
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
            this.dgwTakimFutbolculari = new System.Windows.Forms.DataGridView();
            this.dgwTakimIdariPersonelleri = new System.Windows.Forms.DataGridView();
            this.dgwTakimAscilari = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTakimFutbolculari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTakimIdariPersonelleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTakimAscilari)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwTakimFutbolculari
            // 
            this.dgwTakimFutbolculari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTakimFutbolculari.Location = new System.Drawing.Point(12, 53);
            this.dgwTakimFutbolculari.Name = "dgwTakimFutbolculari";
            this.dgwTakimFutbolculari.Size = new System.Drawing.Size(446, 281);
            this.dgwTakimFutbolculari.TabIndex = 0;
            // 
            // dgwTakimIdariPersonelleri
            // 
            this.dgwTakimIdariPersonelleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTakimIdariPersonelleri.Location = new System.Drawing.Point(478, 53);
            this.dgwTakimIdariPersonelleri.Name = "dgwTakimIdariPersonelleri";
            this.dgwTakimIdariPersonelleri.Size = new System.Drawing.Size(446, 281);
            this.dgwTakimIdariPersonelleri.TabIndex = 1;
            // 
            // dgwTakimAscilari
            // 
            this.dgwTakimAscilari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTakimAscilari.Location = new System.Drawing.Point(939, 53);
            this.dgwTakimAscilari.Name = "dgwTakimAscilari";
            this.dgwTakimAscilari.Size = new System.Drawing.Size(446, 281);
            this.dgwTakimAscilari.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(643, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "İDARİ PERSONELLER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "FUTBOLCULAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1122, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "AŞÇILAR";
            // 
            // TakiminPersonelleriniGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 623);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwTakimAscilari);
            this.Controls.Add(this.dgwTakimIdariPersonelleri);
            this.Controls.Add(this.dgwTakimFutbolculari);
            this.Name = "TakiminPersonelleriniGoster";
            this.Text = "TakiminPersonelleriniGoster";
            this.Load += new System.EventHandler(this.TakiminPersonelleriniGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTakimFutbolculari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTakimIdariPersonelleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTakimAscilari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwTakimFutbolculari;
        private System.Windows.Forms.DataGridView dgwTakimIdariPersonelleri;
        private System.Windows.Forms.DataGridView dgwTakimAscilari;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}