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
    public partial class frmFilmSorgulama : Form
    {
        public frmFilmSorgulama()
        {
            InitializeComponent();
        }

        private void frmFilmSorgulama_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cFilm f = new cFilm();
            f.FilmleriGoster(lvFilmler);
        }

        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            cFilm f = new cFilm();
            f.FilmlerGetirByAdaGore(lvFilmler, txtAdaGore.Text);
        }

        private void lvFilmler_DoubleClick(object sender, EventArgs e)
        {
            cGenel.FilmNo = Convert.ToInt32(lvFilmler.SelectedItems[0].SubItems[0].Text);
            cGenel.Film = lvFilmler.SelectedItems[0].SubItems[1].Text;
            this.Close();
        }
    }
}
