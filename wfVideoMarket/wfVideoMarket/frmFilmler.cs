using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfVideoMarket
{
    public partial class frmFilmler : Form
    {
        public frmFilmler()
        {
            InitializeComponent();
        }

        private void frmFilmler_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cFilmTuru ft = new cFilmTuru();
            ft.FilmTurleriGoster(cbFilmTurleri);

            cFilm f = new cFilm();
            f.FilmleriGoster(lvFilmler);
        }

        private void cbFilmTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilmTuru.Text = cbFilmTurleri.SelectedItem.ToString();
            cFilmTuru ft = new cFilmTuru();
            txtTurID.Text = ft.FilmTurNoGetirByTurAd(txtFilmTuru.Text).ToString();
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            cFilm f = new cFilm();
            f.FilmlerGetirByAdaGore(lvFilmler, txtAdaGore.Text);
        }

        private void lvFilmler_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = lvFilmler.SelectedItems[0].SubItems[0].Text;
            txtFilmAdi.Text = lvFilmler.SelectedItems[0].SubItems[1].Text;
            txtFilmTuru.Text = lvFilmler.SelectedItems[0].SubItems[2].Text;
            txtTurID.Text = lvFilmler.SelectedItems[0].SubItems[3].Text;
            txtYonetmen.Text = lvFilmler.SelectedItems[0].SubItems[4].Text;
            txtOyuncular.Text = lvFilmler.SelectedItems[0].SubItems[5].Text;
            txtOzet.Text = lvFilmler.SelectedItems[0].SubItems[6].Text;
            txtMiktar.Text = lvFilmler.SelectedItems[0].SubItems[7].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            cFilm f = new cFilm();
            f.FilmNo = Convert.ToInt32(txtID.Text);
            f.FilmAd = txtFilmAdi.Text;
            f.FilmTurNo = Convert.ToInt32(txtTurID.Text);
            f.Yonetmen = txtYonetmen.Text;
            f.Oyuncular = txtOyuncular.Text;
            f.Ozet = txtOzet.Text;
            f.Miktar = Convert.ToInt32(txtMiktar.Text);
            bool Sonuc = f.FilmGuncelle(f);
            if (Sonuc)
            {
                MessageBox.Show("Film bilgileri değiştirildi.");
                Temizle();
                btnDegistir.Enabled = false;
                btnSil.Enabled = false;
                f.FilmleriGoster(lvFilmler);
            }
            else
            {
                MessageBox.Show("Bilgiler Değiştirilemedi!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            cFilm f = new cFilm();
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                bool Sonuc = f.FilmSil(Convert.ToInt32(txtID.Text));
                if (Sonuc)
                {
                    MessageBox.Show("Film bilgileri silindi.");
                    Temizle();
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    f.FilmleriGoster(lvFilmler);
                }
                else
                {
                    MessageBox.Show("Bilgiler Silinemedi!");
                }
            }
        }
        private void Temizle()
        {
            txtFilmAdi.Clear();
            txtYonetmen.Clear();
            txtOyuncular.Clear();
            txtOzet.Clear();
            txtMiktar.Clear();
            txtFilmAdi.Focus();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            cFilm f = new cFilm();
            f.FilmAd = txtFilmAdi.Text;
            f.FilmTurNo = Convert.ToInt32(txtTurID.Text);
            f.Yonetmen = txtYonetmen.Text;
            f.Oyuncular = txtOyuncular.Text;
            f.Ozet = txtOzet.Text;
            //f.Miktar = Convert.ToInt32(txtMiktar.Text);   //Default 10 değeri veriliyor.
            bool Sonuc = f.FilmEkle(f);
            if (Sonuc)
            {
                MessageBox.Show("Film bilgileri kayıt edildi.");
                Temizle();
                btnKaydet.Enabled = false;
                f.FilmleriGoster(lvFilmler);
            }
            else
            {
                MessageBox.Show("Bilgiler Kayıt edilemedi!");
            }
        }
    }
}
