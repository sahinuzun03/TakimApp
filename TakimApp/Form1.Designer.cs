namespace TakimApp
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.takimEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takimSahibiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takimGosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takimEkleToolStripMenuItem,
            this.takimSahibiEkleToolStripMenuItem,
            this.personelEkleToolStripMenuItem,
            this.takimGosterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1290, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // takimEkleToolStripMenuItem
            // 
            this.takimEkleToolStripMenuItem.Name = "takimEkleToolStripMenuItem";
            this.takimEkleToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.takimEkleToolStripMenuItem.Text = "Takim Ekle";
            this.takimEkleToolStripMenuItem.Click += new System.EventHandler(this.takimEkleToolStripMenuItem_Click);
            // 
            // takimSahibiEkleToolStripMenuItem
            // 
            this.takimSahibiEkleToolStripMenuItem.Name = "takimSahibiEkleToolStripMenuItem";
            this.takimSahibiEkleToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.takimSahibiEkleToolStripMenuItem.Text = "Takim Sahibi Ekle";
            this.takimSahibiEkleToolStripMenuItem.Click += new System.EventHandler(this.takimSahibiEkleToolStripMenuItem_Click);
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            this.personelEkleToolStripMenuItem.Click += new System.EventHandler(this.personelEkleToolStripMenuItem_Click);
            // 
            // takimGosterToolStripMenuItem
            // 
            this.takimGosterToolStripMenuItem.Name = "takimGosterToolStripMenuItem";
            this.takimGosterToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.takimGosterToolStripMenuItem.Text = "Goster";
            this.takimGosterToolStripMenuItem.Click += new System.EventHandler(this.takimGosterToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 714);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem takimEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takimSahibiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takimGosterToolStripMenuItem;
    }
}

