namespace wfVideoMarket
{
    partial class frmFilmler
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
            this.lvFilmler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAdaGore = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtOyuncular = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYonetmen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilmTuru = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilmTurleri = new System.Windows.Forms.ComboBox();
            this.txtTurID = new System.Windows.Forms.TextBox();
            this.txtOzet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvFilmler
            // 
            this.lvFilmler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvFilmler.FullRowSelect = true;
            this.lvFilmler.GridLines = true;
            this.lvFilmler.Location = new System.Drawing.Point(293, 62);
            this.lvFilmler.Name = "lvFilmler";
            this.lvFilmler.Size = new System.Drawing.Size(289, 249);
            this.lvFilmler.TabIndex = 33;
            this.lvFilmler.UseCompatibleStateImageBehavior = false;
            this.lvFilmler.View = System.Windows.Forms.View.Details;
            this.lvFilmler.DoubleClick += new System.EventHandler(this.lvFilmler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "FilmNo";
            this.columnHeader1.Width = 47;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Film Adı";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "FilmTürü";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TurNo";
            this.columnHeader4.Width = 2;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Yönetmen";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Oyuncular";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ozet";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Miktar";
            // 
            // txtAdaGore
            // 
            this.txtAdaGore.Location = new System.Drawing.Point(99, 62);
            this.txtAdaGore.Name = "txtAdaGore";
            this.txtAdaGore.Size = new System.Drawing.Size(170, 20);
            this.txtAdaGore.TabIndex = 32;
            this.txtAdaGore.TextChanged += new System.EventHandler(this.txtAdaGore_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Film Adına Göre Arama";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(3, 111);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(26, 20);
            this.txtID.TabIndex = 30;
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(230, 327);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(47, 23);
            this.btnSil.TabIndex = 29;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.Location = new System.Drawing.Point(166, 327);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(51, 23);
            this.btnDegistir.TabIndex = 28;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(102, 327);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(51, 23);
            this.btnKaydet.TabIndex = 27;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(40, 327);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(47, 23);
            this.btnYeni.TabIndex = 26;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtOyuncular
            // 
            this.txtOyuncular.Location = new System.Drawing.Point(100, 196);
            this.txtOyuncular.Multiline = true;
            this.txtOyuncular.Name = "txtOyuncular";
            this.txtOyuncular.Size = new System.Drawing.Size(170, 38);
            this.txtOyuncular.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Oyuncular";
            // 
            // txtYonetmen
            // 
            this.txtYonetmen.Location = new System.Drawing.Point(100, 168);
            this.txtYonetmen.Name = "txtYonetmen";
            this.txtYonetmen.Size = new System.Drawing.Size(170, 20);
            this.txtYonetmen.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Yönetmen";
            // 
            // txtFilmTuru
            // 
            this.txtFilmTuru.Location = new System.Drawing.Point(100, 141);
            this.txtFilmTuru.Name = "txtFilmTuru";
            this.txtFilmTuru.ReadOnly = true;
            this.txtFilmTuru.Size = new System.Drawing.Size(140, 20);
            this.txtFilmTuru.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Film Türü";
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.Location = new System.Drawing.Point(99, 113);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(170, 20);
            this.txtFilmAdi.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Film Adı";
            // 
            // cbFilmTurleri
            // 
            this.cbFilmTurleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilmTurleri.DropDownWidth = 100;
            this.cbFilmTurleri.FormattingEnabled = true;
            this.cbFilmTurleri.Location = new System.Drawing.Point(240, 141);
            this.cbFilmTurleri.Name = "cbFilmTurleri";
            this.cbFilmTurleri.Size = new System.Drawing.Size(29, 21);
            this.cbFilmTurleri.TabIndex = 34;
            this.cbFilmTurleri.SelectedIndexChanged += new System.EventHandler(this.cbFilmTurleri_SelectedIndexChanged);
            // 
            // txtTurID
            // 
            this.txtTurID.Location = new System.Drawing.Point(3, 142);
            this.txtTurID.Name = "txtTurID";
            this.txtTurID.ReadOnly = true;
            this.txtTurID.Size = new System.Drawing.Size(26, 20);
            this.txtTurID.TabIndex = 35;
            // 
            // txtOzet
            // 
            this.txtOzet.Location = new System.Drawing.Point(100, 243);
            this.txtOzet.Multiline = true;
            this.txtOzet.Name = "txtOzet";
            this.txtOzet.Size = new System.Drawing.Size(170, 38);
            this.txtOzet.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Özet";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(99, 291);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.ReadOnly = true;
            this.txtMiktar.Size = new System.Drawing.Size(71, 20);
            this.txtMiktar.TabIndex = 39;
            this.txtMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Miktar";
            // 
            // frmFilmler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(585, 430);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOzet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTurID);
            this.Controls.Add(this.cbFilmTurleri);
            this.Controls.Add(this.txtAdaGore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.txtOyuncular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYonetmen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilmTuru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilmAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvFilmler);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFilmler";
            this.Text = "Film Tanımlama";
            this.Load += new System.EventHandler(this.frmFilmler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvFilmler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtAdaGore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtOyuncular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYonetmen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilmTuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilmAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilmTurleri;
        private System.Windows.Forms.TextBox txtTurID;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox txtOzet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label7;
    }
}