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
    public partial class Form1 : Form
    {
        public Form1()
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
            frm.mdi
        }
    }
}
