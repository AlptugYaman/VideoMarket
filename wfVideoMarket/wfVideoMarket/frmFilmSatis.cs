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
    public partial class frmFilmSatis : Form
    {
        public frmFilmSatis()
        {
            InitializeComponent();
        }

        private void frmFilmSatis_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            txtTarih.Text = DateTime.Now.ToShortDateString();
            cFilmSatis fs = new cFilmSatis();
            fs.SatislariGetir(lvSatislar, txtToplamAdet, txtToplamTutar);
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            txtTarih.Text = dtpTarih.Value.ToShortDateString();
        }

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            frmMusteriSorgulama frm = new frmMusteriSorgulama();
            frm.ShowDialog();
            txtMusteriID.Text = cGenel.MusteriNo.ToString();
            txtMusteri.Text = cGenel.Musteri;
        }

        private void btnFilmBul_Click(object sender, EventArgs e)
        {
            frmFilmSorgulama frm = new frmFilmSorgulama();
            frm.ShowDialog();
            txtFilmID.Text = cGenel.FilmNo.ToString();
            txtFilm.Text = cGenel.Film;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            btnMusteriBul.Enabled = true;
            btnFilmBul.Enabled = true;
            Temizle();
        }
        private void Temizle()
        {
            txtAdet.Text = "1";
            txtFiyat.Text = "0";
            txtTutar.Text = "0";
            txtFiyat.Focus();
        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            if (txtFiyat.Text.Trim() == "") { txtFiyat.Text = "0"; }
            txtTutar.Text = (Convert.ToInt32(txtAdet.Text) * Convert.ToDecimal(txtFiyat.Text)).ToString();
        }

        private void txtFiyat_TextChanged(object sender, EventArgs e)
        {
            if (txtFiyat.Text.Trim() == "") { txtFiyat.Text = "0"; }
            txtTutar.Text = (Convert.ToInt32(txtAdet.Text) * Convert.ToDecimal(txtFiyat.Text)).ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtFilmID.Text != "" && txtMusteriID.Text != "")
            {
                cFilmSatis fs = new cFilmSatis();
                fs.Tarih = Convert.ToDateTime(txtTarih.Text);
                fs.FilmNo = Convert.ToInt32(txtFilmID.Text);
                fs.MusteriNo = Convert.ToInt32(txtMusteriID.Text);
                fs.Adet = Convert.ToInt32(txtAdet.Text);
                fs.BirimFiyat = Convert.ToDecimal(txtFiyat.Text);
                bool sonuc = fs.SatisEkle(fs);
                if (sonuc)
                {
                    MessageBox.Show("Satış bilgileri kayıt edildi.");
                    cFilm f = new cFilm();
                    sonuc = f.FilmGuncelleFromSatisEkle(fs.FilmNo, fs.Adet);
                    if (sonuc)
                    {
                        MessageBox.Show("Film Stok Miktarı güncellendi.");                      
                        btnKaydet.Enabled = false;
                        fs.SatislariGetir(lvSatislar, txtToplamAdet, txtToplamTutar);
                        Temizle();
                    }
                }
            }
            else
            {
                MessageBox.Show("Film ve Müşteri boş bırakılamaz.");
            }
        }

        private void lvSatislar_DoubleClick(object sender, EventArgs e)
        {
            txtSatisNo.Text = lvSatislar.SelectedItems[0].SubItems[0].Text;
            txtMusteriID.Text = lvSatislar.SelectedItems[0].SubItems[9].Text;
            txtMusteri.Text = lvSatislar.SelectedItems[0].SubItems[4].Text;
            txtFilmID.Text = lvSatislar.SelectedItems[0].SubItems[8].Text;
            txtFilm.Text = lvSatislar.SelectedItems[0].SubItems[2].Text;
            txtAdet.Text = lvSatislar.SelectedItems[0].SubItems[6].Text;
            txtFiyat.Text = lvSatislar.SelectedItems[0].SubItems[5].Text;
            txtTarih.Text = lvSatislar.SelectedItems[0].SubItems[1].Text;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
            btnKaydet.Enabled = false;
            btnMusteriBul.Enabled = false;
            btnFilmBul.Enabled = false;
            txtAdet.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(txtMusteri.Text + " müşteriye yapılan " + txtAdet.Text + " adet " + txtFilm.Text + " film satışı İptal Edilsin mi?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                cFilmSatis fs = new cFilmSatis();
                bool sonuc = fs.SatisIptal(Convert.ToInt32(txtSatisNo.Text));
                if (sonuc)
                {
                    MessageBox.Show("Satış iptal edildi!");
                    cFilm f = new cFilm();
                    sonuc = f.FilmGuncelleFromSatisIptal(Convert.ToInt32(txtFilmID.Text), Convert.ToInt32(txtAdet.Text));
                    if (sonuc)
                    {
                        MessageBox.Show("Stok Güncellendi.");
                        fs.SatislariGetir(lvSatislar, txtToplamAdet, txtToplamTutar);
                        Temizle();
                        btnDegistir.Enabled = false;
                        btnSil.Enabled = false;
                    }
                }
            }
        }
    }
}
