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
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void mitmFilmTuruTanimlama_Click(object sender, EventArgs e)
        {
            frmFilmTurleri frm = new frmFilmTurleri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mitmCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mitmMusteriGirisi_Click(object sender, EventArgs e)
        {
            frmMusteriler frm = new frmMusteriler();
            FormAcikmi(frm);
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void mitmMusteriSorgulama_Click(object sender, EventArgs e)
        {
            frmMusteriSorgulama frm = new frmMusteriSorgulama();
            FormAcikmi(frm);
            //frm.MdiParent = this;
            //frm.Show();
        }

        private void mitmFilmTanimlama_Click(object sender, EventArgs e)
        {
            frmFilmler frm = new frmFilmler();
            FormAcikmi(frm);
            //frm.MdiParent = this;
            //frm.Show();
        }
        private void FormAcikmi(Form AcilacakForm)
        {
            bool Acikmi = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                if (AcilacakForm.Name == MdiChildren[i].Name)
                {
                    AcilacakForm.Focus();
                    Acikmi = true;
                }
            }
            if (Acikmi == false)
            {
                AcilacakForm.MdiParent = this;
                AcilacakForm.Show();
            }
            else
            {
                AcilacakForm.Dispose();
            }
        }

        private void mitmFilmSatis_Click(object sender, EventArgs e)
        {
            frmFilmSatis frm = new frmFilmSatis();
            FormAcikmi(frm);
        }

        private void mitmFilmSorgulama_Click(object sender, EventArgs e)
        {
            frmFilmSorgulama frm = new frmFilmSorgulama();
            FormAcikmi(frm);
        }

        private void mitmSatisSorgulama_Click(object sender, EventArgs e)
        {
            frmSatisSorgulama frm = new frmSatisSorgulama();
            FormAcikmi(frm);
        }
    }
}
