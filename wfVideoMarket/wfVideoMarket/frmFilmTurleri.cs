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
    public partial class frmFilmTurleri : Form
    {
        public frmFilmTurleri()
        {
            InitializeComponent();
        }

        private void frmFilmTurleri_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cFilmTuru ft = new cFilmTuru();
            ft.FilmTurleriGoster(lvFilmTurleri);
        }

        private void lvFilmTurleri_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = lvFilmTurleri.SelectedItems[0].SubItems[0].Text;
            txtFilmTuru.Text = lvFilmTurleri.SelectedItems[0].SubItems[1].Text;
            txtAciklama.Text = lvFilmTurleri.SelectedItems[0].SubItems[2].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Temizle();
        }
        private void Temizle()
        {
            txtFilmTuru.Clear();
            txtAciklama.Clear();
            txtFilmTuru.Focus();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            cFilmTuru ft = new cFilmTuru();
            bool Sonuc = ft.FilmTuruDegistir(txtFilmTuru.Text, txtAciklama.Text, Convert.ToInt32(txtID.Text));
            if (Sonuc)
            {
                MessageBox.Show("Film Türü değiştirildi.");
                Temizle();
                btnDegistir.Enabled = false;
                btnSil.Enabled = false;
                ft.FilmTurleriGoster(lvFilmTurleri);
            }
            else
            {
                MessageBox.Show("Bilgiler Değiştirilemedi!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                cFilmTuru ft = new cFilmTuru();
                bool Sonuc = ft.FilmTuruSil(Convert.ToInt32(txtID.Text));
                if (Sonuc)
                {
                    MessageBox.Show("Film Türü silindi.");
                    Temizle();
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    ft.FilmTurleriGoster(lvFilmTurleri);
                }
                else
                {
                    MessageBox.Show("Bilgiler Silinemedi!");
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtFilmTuru.Text.Trim() != "")
            {
                cFilmTuru ft = new cFilmTuru();
                bool Sonuc = ft.FilmTuruEkle(txtFilmTuru.Text, txtAciklama.Text);
                if (Sonuc)
                {
                    MessageBox.Show("Film Türü kayıt edildi.");
                    Temizle();
                    btnKaydet.Enabled = false;
                    ft.FilmTurleriGoster(lvFilmTurleri);
                }
                else
                {
                    MessageBox.Show("Bilgiler Kayıt Edilemedi!");
                }

            }
        }
    }
}
