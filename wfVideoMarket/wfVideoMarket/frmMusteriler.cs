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
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cMusteri m = new cMusteri();
            m.MusterilerGetir(lvMusteriler);
        }

        private void lvMusteriler_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = lvMusteriler.SelectedItems[0].SubItems[0].Text;
            txtAdi.Text = lvMusteriler.SelectedItems[0].SubItems[1].Text;
            txtSoyadi.Text = lvMusteriler.SelectedItems[0].SubItems[2].Text;
            txtTelefon.Text = lvMusteriler.SelectedItems[0].SubItems[3].Text;
            txtAdres.Text = lvMusteriler.SelectedItems[0].SubItems[4].Text;
            btnKaydet.Enabled = false;
            btnDegistir.Enabled = true;
            btnSil.Enabled = true;
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            cMusteri m = new cMusteri();
            m.MusterilerGetirByAdaGore(lvMusteriler, txtAdaGore.Text);
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            cMusteri m = new cMusteri();
            bool sonuc = m.MusteriGuncelle(txtAdi, txtSoyadi, txtTelefon, txtAdres, txtID);
            if (sonuc)
            {
                MessageBox.Show("Bilgiler değiştirildi.");
                m.MusterilerGetir(lvMusteriler);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            cMusteri m = new cMusteri();
            if (MessageBox.Show("Silmek İstiyor musunuz?", "SİLİNSİN Mİ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                bool Sonuc = m.MusteriSil(Convert.ToInt32(txtID.Text));
                if (Sonuc)
                {
                    MessageBox.Show("Müşteri bilgileri silindi.");
                    Temizle();
                    btnDegistir.Enabled = false;
                    btnSil.Enabled = false;
                    m.MusterilerGetir(lvMusteriler);
                }
                else
                {
                    MessageBox.Show("Bilgiler Silinemedi!");
                }
            }
        }
        private void Temizle()
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            txtAdi.Focus();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text != "")
            {
                cMusteri mus = new cMusteri();
                mus.MusteriAd = txtAdi.Text;
                mus.MusteriSoyad = txtSoyadi.Text;
                mus.Telefon = txtTelefon.Text;
                mus.Adres = txtAdres.Text;
                bool sonuc = mus.MusteriEkle(mus);
                if (sonuc)
                {
                    MessageBox.Show("Müşteri kayıt edildi.");
                    Temizle();
                    btnKaydet.Enabled = false;
                    mus.MusterilerGetir(lvMusteriler);
                }
            }
            else { MessageBox.Show("Müşteri Adı boş geçilemez!"); }
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            btnKaydet.Enabled = true;
            btnDegistir.Enabled = false;
            btnSil.Enabled = false;
            Temizle();
        }
    }
}
