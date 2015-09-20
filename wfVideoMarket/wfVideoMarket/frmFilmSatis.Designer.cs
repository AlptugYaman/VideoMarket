namespace wfVideoMarket
{
    partial class frmFilmSatis
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
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMusteriBul = new System.Windows.Forms.Button();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.txtFilmID = new System.Windows.Forms.TextBox();
            this.btnFilmBul = new System.Windows.Forms.Button();
            this.txtFilm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lvSatislar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtToplamAdet = new System.Windows.Forms.TextBox();
            this.txtToplamTutar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSatisNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih :";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(104, 68);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(110, 20);
            this.txtTarih.TabIndex = 1;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(215, 68);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(22, 20);
            this.dtpTarih.TabIndex = 2;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(104, 125);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.ReadOnly = true;
            this.txtMusteri.Size = new System.Drawing.Size(110, 20);
            this.txtMusteri.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Müşteri";
            // 
            // btnMusteriBul
            // 
            this.btnMusteriBul.Location = new System.Drawing.Point(215, 124);
            this.btnMusteriBul.Name = "btnMusteriBul";
            this.btnMusteriBul.Size = new System.Drawing.Size(39, 23);
            this.btnMusteriBul.TabIndex = 5;
            this.btnMusteriBul.Text = "...";
            this.btnMusteriBul.UseVisualStyleBackColor = true;
            this.btnMusteriBul.Click += new System.EventHandler(this.btnMusteriBul_Click);
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Location = new System.Drawing.Point(26, 124);
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.ReadOnly = true;
            this.txtMusteriID.Size = new System.Drawing.Size(26, 20);
            this.txtMusteriID.TabIndex = 15;
            // 
            // txtFilmID
            // 
            this.txtFilmID.Location = new System.Drawing.Point(520, 125);
            this.txtFilmID.Name = "txtFilmID";
            this.txtFilmID.ReadOnly = true;
            this.txtFilmID.Size = new System.Drawing.Size(26, 20);
            this.txtFilmID.TabIndex = 19;
            // 
            // btnFilmBul
            // 
            this.btnFilmBul.Location = new System.Drawing.Point(466, 124);
            this.btnFilmBul.Name = "btnFilmBul";
            this.btnFilmBul.Size = new System.Drawing.Size(39, 23);
            this.btnFilmBul.TabIndex = 18;
            this.btnFilmBul.Text = "...";
            this.btnFilmBul.UseVisualStyleBackColor = true;
            this.btnFilmBul.Click += new System.EventHandler(this.btnFilmBul_Click);
            // 
            // txtFilm
            // 
            this.txtFilm.Location = new System.Drawing.Point(355, 125);
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.ReadOnly = true;
            this.txtFilm.Size = new System.Drawing.Size(110, 20);
            this.txtFilm.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Film";
            // 
            // lvSatislar
            // 
            this.lvSatislar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvSatislar.FullRowSelect = true;
            this.lvSatislar.GridLines = true;
            this.lvSatislar.Location = new System.Drawing.Point(28, 235);
            this.lvSatislar.Name = "lvSatislar";
            this.lvSatislar.Size = new System.Drawing.Size(516, 197);
            this.lvSatislar.TabIndex = 34;
            this.lvSatislar.UseCompatibleStateImageBehavior = false;
            this.lvSatislar.View = System.Windows.Forms.View.Details;
            this.lvSatislar.DoubleClick += new System.EventHandler(this.lvSatislar_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Satış Tarihi";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Film Adı";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Miktar";
            this.columnHeader4.Width = 45;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Müşteri";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Fiyat";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Adet";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tutar";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "FilmNo";
            this.columnHeader9.Width = 1;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "MusteriNo";
            this.columnHeader10.Width = 1;
            // 
            // btnSil
            // 
            this.btnSil.Enabled = false;
            this.btnSil.Location = new System.Drawing.Point(497, 184);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(47, 23);
            this.btnSil.TabIndex = 38;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Enabled = false;
            this.btnDegistir.Location = new System.Drawing.Point(433, 184);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(51, 23);
            this.btnDegistir.TabIndex = 37;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Enabled = false;
            this.btnKaydet.Location = new System.Drawing.Point(369, 184);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(51, 23);
            this.btnKaydet.TabIndex = 36;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(30, 184);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(47, 23);
            this.btnYeni.TabIndex = 35;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(104, 186);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(53, 20);
            this.txtAdet.TabIndex = 39;
            this.txtAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdet.TextChanged += new System.EventHandler(this.txtAdet_TextChanged);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(163, 186);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(53, 20);
            this.txtFiyat.TabIndex = 40;
            this.txtFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiyat.TextChanged += new System.EventHandler(this.txtFiyat_TextChanged);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(222, 186);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.ReadOnly = true;
            this.txtTutar.Size = new System.Drawing.Size(68, 20);
            this.txtTutar.TabIndex = 41;
            this.txtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Adet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Fiyat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Tutar";
            // 
            // txtToplamAdet
            // 
            this.txtToplamAdet.Location = new System.Drawing.Point(425, 438);
            this.txtToplamAdet.Name = "txtToplamAdet";
            this.txtToplamAdet.ReadOnly = true;
            this.txtToplamAdet.Size = new System.Drawing.Size(51, 20);
            this.txtToplamAdet.TabIndex = 45;
            this.txtToplamAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtToplamTutar
            // 
            this.txtToplamTutar.Location = new System.Drawing.Point(477, 438);
            this.txtToplamTutar.Name = "txtToplamTutar";
            this.txtToplamTutar.ReadOnly = true;
            this.txtToplamTutar.Size = new System.Drawing.Size(62, 20);
            this.txtToplamTutar.TabIndex = 46;
            this.txtToplamTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Toplam";
            // 
            // txtSatisNo
            // 
            this.txtSatisNo.Location = new System.Drawing.Point(2, 209);
            this.txtSatisNo.Name = "txtSatisNo";
            this.txtSatisNo.ReadOnly = true;
            this.txtSatisNo.Size = new System.Drawing.Size(26, 20);
            this.txtSatisNo.TabIndex = 48;
            // 
            // frmFilmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(577, 496);
            this.Controls.Add(this.txtSatisNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtToplamTutar);
            this.Controls.Add(this.txtToplamAdet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.lvSatislar);
            this.Controls.Add(this.txtFilmID);
            this.Controls.Add(this.btnFilmBul);
            this.Controls.Add(this.txtFilm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMusteriID);
            this.Controls.Add(this.btnMusteriBul);
            this.Controls.Add(this.txtMusteri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFilmSatis";
            this.Text = "Film Satış İşlemleri";
            this.Load += new System.EventHandler(this.frmFilmSatis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMusteriBul;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.TextBox txtFilmID;
        private System.Windows.Forms.Button btnFilmBul;
        private System.Windows.Forms.TextBox txtFilm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvSatislar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtToplamAdet;
        private System.Windows.Forms.TextBox txtToplamTutar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TextBox txtSatisNo;
    }
}