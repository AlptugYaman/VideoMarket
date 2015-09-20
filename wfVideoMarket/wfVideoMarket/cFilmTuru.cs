using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace wfVideoMarket
{
    class cFilmTuru
    {
        private int _filmTurNo;
        private string _turAd;
        private string _aciklama;

        #region Properties
        public int FilmTurNo
        {
            get { return _filmTurNo; }
            set { _filmTurNo = value; }
        }

        public string TurAd
        {
            get { return _turAd; }
            set { _turAd = value; }
        }

        public string Aciklama
        {
            get { return _aciklama; }
            set { _aciklama = value; }
        } 
        #endregion

        cGenel gnl = new cGenel();

        public void FilmTurleriGoster(ListView liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("select * from FilmTurleri where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                liste.Items.Add(dr["FilmTurNo"].ToString());
                liste.Items[i].SubItems.Add(dr["TurAd"].ToString());
                liste.Items[i].SubItems.Add(dr["Aciklama"].ToString());
                i++;
            }
            dr.Close();
            conn.Close();
        }
        public bool FilmTuruDegistir(string FilmTuru, string Aciklama, int TurNo)
        {
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("update FilmTurleri set TurAd=@TurAd, Aciklama=@Aciklama where FilmTurNo=@FilmTurNo", conn);
            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = FilmTuru;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = Aciklama;
            comm.Parameters.Add("@FilmTurNo", SqlDbType.Int).Value = TurNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return Sonuc;
        }
        public bool FilmTuruSil(int TurNo)
        {
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("update FilmTurleri set Silindi=1 where FilmTurNo=@FilmTurNo", conn);
            comm.Parameters.Add("@FilmTurNo", SqlDbType.Int).Value = TurNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return Sonuc;
        }
        public bool FilmTuruEkle(string FilmTuru, string Aciklama)
        {
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("insert into FilmTurleri (TurAd, Aciklama) values(@TurAd, @Aciklama)", conn);
            comm.Parameters.Add("@TurAd", SqlDbType.VarChar).Value = FilmTuru;
            comm.Parameters.Add("@Aciklama", SqlDbType.VarChar).Value = Aciklama;
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return Sonuc;
        }

        public void FilmTurleriGoster(ComboBox liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("select * from FilmTurleri where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                liste.Items.Add(dr["TurAd"].ToString());
            }
            dr.Close();
            conn.Close();
        }
        public int FilmTurNoGetirByTurAd(string FilmTuru)
        {
            int TurNo = 0;
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("select FilmTurNo from FilmTurleri where TurAd=@TurAd", conn);
            comm.Parameters.Add("TurAd", SqlDbType.VarChar).Value = FilmTuru;
            if (conn.State == ConnectionState.Closed) conn.Open();
            TurNo = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();
            return TurNo;
        }
    }
}
