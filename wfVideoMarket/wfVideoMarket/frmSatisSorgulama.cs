﻿using System;
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
    public partial class frmSatisSorgulama : Form
    {
        public frmSatisSorgulama()
        {
            InitializeComponent();
        }

        private void frmSatisSorgulama_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            cFilmSatis fs = new cFilmSatis();
            DataTable dt = fs.SatislariGetirByTarihlerArasi(dtpIlkTarih.Value, dtpSonTarih.Value);
            dgvSatislar.DataSource = dt;
        }
    }
}
