namespace wfVideoMarket
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
            this.filmBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmFilmTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmFilmTuruTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmFilmSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmMusteriGirisi = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmMusteriSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.satışİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmFilmSatis = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmSatisSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmDetayliSatisRaporu = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmBilgileriToolStripMenuItem,
            this.müşterilerToolStripMenuItem,
            this.satışİşlemleriToolStripMenuItem,
            this.raporlamaToolStripMenuItem,
            this.mitmCikis});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filmBilgileriToolStripMenuItem
            // 
            this.filmBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmFilmTanimlama,
            this.mitmFilmTuruTanimlama,
            this.mitmFilmSorgulama});
            this.filmBilgileriToolStripMenuItem.Name = "filmBilgileriToolStripMenuItem";
            this.filmBilgileriToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.filmBilgileriToolStripMenuItem.Text = "Film Bilgileri";
            // 
            // mitmFilmTanimlama
            // 
            this.mitmFilmTanimlama.Name = "mitmFilmTanimlama";
            this.mitmFilmTanimlama.Size = new System.Drawing.Size(188, 22);
            this.mitmFilmTanimlama.Text = "Film Tanımlama";
            // 
            // mitmFilmTuruTanimlama
            // 
            this.mitmFilmTuruTanimlama.Name = "mitmFilmTuruTanimlama";
            this.mitmFilmTuruTanimlama.Size = new System.Drawing.Size(188, 22);
            this.mitmFilmTuruTanimlama.Text = "Film Türü Tanımlama";
            this.mitmFilmTuruTanimlama.Click += new System.EventHandler(this.mitmFilmTuruTanimlama_Click);
            // 
            // mitmFilmSorgulama
            // 
            this.mitmFilmSorgulama.Name = "mitmFilmSorgulama";
            this.mitmFilmSorgulama.Size = new System.Drawing.Size(188, 22);
            this.mitmFilmSorgulama.Text = "Flm Sorgulama";
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmMusteriGirisi,
            this.mitmMusteriSorgulama});
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // mitmMusteriGirisi
            // 
            this.mitmMusteriGirisi.Name = "mitmMusteriGirisi";
            this.mitmMusteriGirisi.Size = new System.Drawing.Size(174, 22);
            this.mitmMusteriGirisi.Text = "Müşteri Girişi";
            this.mitmMusteriGirisi.Click += new System.EventHandler(this.mitmMusteriGirisi_Click);
            // 
            // mitmMusteriSorgulama
            // 
            this.mitmMusteriSorgulama.Name = "mitmMusteriSorgulama";
            this.mitmMusteriSorgulama.Size = new System.Drawing.Size(174, 22);
            this.mitmMusteriSorgulama.Text = "Müşteri Sorgulama";
            // 
            // satışİşlemleriToolStripMenuItem
            // 
            this.satışİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmFilmSatis,
            this.mitmSatisSorgulama});
            this.satışİşlemleriToolStripMenuItem.Name = "satışİşlemleriToolStripMenuItem";
            this.satışİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.satışİşlemleriToolStripMenuItem.Text = "Satış İşlemleri";
            // 
            // mitmFilmSatis
            // 
            this.mitmFilmSatis.Name = "mitmFilmSatis";
            this.mitmFilmSatis.Size = new System.Drawing.Size(158, 22);
            this.mitmFilmSatis.Text = "Film Satış";
            // 
            // mitmSatisSorgulama
            // 
            this.mitmSatisSorgulama.Name = "mitmSatisSorgulama";
            this.mitmSatisSorgulama.Size = new System.Drawing.Size(158, 22);
            this.mitmSatisSorgulama.Text = "Satış Sorgulama";
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmDetayliSatisRaporu});
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            // 
            // mitmDetayliSatisRaporu
            // 
            this.mitmDetayliSatisRaporu.Name = "mitmDetayliSatisRaporu";
            this.mitmDetayliSatisRaporu.Size = new System.Drawing.Size(178, 22);
            this.mitmDetayliSatisRaporu.Text = "Detaylı Satış Raporu";
            // 
            // mitmCikis
            // 
            this.mitmCikis.Name = "mitmCikis";
            this.mitmCikis.Size = new System.Drawing.Size(44, 20);
            this.mitmCikis.Text = "Çıkış";
            this.mitmCikis.Click += new System.EventHandler(this.mitmCikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 369);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Video Market AnaSayfa İşlemler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filmBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmFilmTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mitmFilmTuruTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mitmFilmSorgulama;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmMusteriGirisi;
        private System.Windows.Forms.ToolStripMenuItem mitmMusteriSorgulama;
        private System.Windows.Forms.ToolStripMenuItem satışİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmFilmSatis;
        private System.Windows.Forms.ToolStripMenuItem mitmSatisSorgulama;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmDetayliSatisRaporu;
        private System.Windows.Forms.ToolStripMenuItem mitmCikis;
    }
}

