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
    public partial class frmMusteriSorgulama : Form
    {
        public frmMusteriSorgulama()
        {
            InitializeComponent();
        }

        private void frmMusteriSorgulama_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cMusteri m = new cMusteri();
            m.MusterilerGetir(lvMusteriler);
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            cMusteri m = new cMusteri();
            m.MusterilerGetirByAdaGore(lvMusteriler, txtAdaGore.Text);
        }

        private void lvMusteriler_DoubleClick(object sender, EventArgs e)
        {
            cGenel.MusteriNo = Convert.ToInt32(lvMusteriler.SelectedItems[0].SubItems[0].Text);
            cGenel.Musteri = lvMusteriler.SelectedItems[0].SubItems[1].Text + " " + lvMusteriler.SelectedItems[0].SubItems[2].Text;
            this.Close();
        }
    }
}
