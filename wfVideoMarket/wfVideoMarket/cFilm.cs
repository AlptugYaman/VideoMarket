using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace wfVideoMarket
{
    class cFilm
    {
        cGenel gnl = new cGenel();

        private int _filmNo;
        private string _filmAd;
        private int _filmTurNo;
        private string _yonetmen;
        private string _oyuncular;
        private string _ozet;
        private int _miktar;

        #region Properties
        public int FilmNo
        {
            get { return _filmNo; }
            set { _filmNo = value; }
        }

        public string FilmAd
        {
            get { return _filmAd; }
            set { _filmAd = value; }
        }

        public int FilmTurNo
        {
            get { return _filmTurNo; }
            set { _filmTurNo = value; }
        }

        public string Yonetmen
        {
            get { return _yonetmen; }
            set { _yonetmen = value; }
        }

        public string Oyuncular
        {
            get { return _oyuncular; }
            set { _oyuncular = value; }
        }

        public string Ozet
        {
            get { return _ozet; }
            set { _ozet = value; }
        }

        public int Miktar
        {
            get { return _miktar; }
            set { _miktar = value; }
        } 
        #endregion


        public void FilmleriGoster(ListView liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("select FilmNo,FilmAd,TurAd,Filmler.FilmTurNo,Yonetmen,Oyuncular,Ozet,Miktar from Filmler inner join FilmTurleri on FilmTurleri.FilmTurNo=Filmler.FilmTurNo where Varmi=1", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                liste.Items.Add(dr["FilmNo"].ToString());
                liste.Items[i].SubItems.Add(dr["FilmAd"].ToString());
                liste.Items[i].SubItems.Add(dr["TurAd"].ToString());
                liste.Items[i].SubItems.Add(dr["FilmTurNo"].ToString());
                liste.Items[i].SubItems.Add(dr["Yonetmen"].ToString());
                liste.Items[i].SubItems.Add(dr["Oyuncular"].ToString());
                liste.Items[i].SubItems.Add(dr["Ozet"].ToString());
                liste.Items[i].SubItems.Add(dr["Miktar"].ToString());
                i++;
            }
            dr.Close();
            conn.Close();
        }
        public void FilmlerGetirByAdaGore(ListView liste, string AdaGore)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("select FilmNo,FilmAd,TurAd,Filmler.FilmTurNo,Yonetmen,Oyuncular,Ozet,Miktar from Filmler inner join FilmTurleri on FilmTurleri.FilmTurNo=Filmler.FilmTurNo where Varmi=1 and FilmAd like @FilmAd + '%'", conn);
            comm.Parameters.Add("@FilmAd", SqlDbType.VarChar).Value = AdaGore;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                liste.Items.Add(dr["FilmNo"].ToString());
                liste.Items[i].SubItems.Add(dr["FilmAd"].ToString());
                liste.Items[i].SubItems.Add(dr["TurAd"].ToString());
                liste.Items[i].SubItems.Add(dr["FilmTurNo"].ToString());
                liste.Items[i].SubItems.Add(dr["Yonetmen"].ToString());
                liste.Items[i].SubItems.Add(dr["Oyuncular"].ToString());
                liste.Items[i].SubItems.Add(dr["Ozet"].ToString());
                liste.Items[i].SubItems.Add(dr["Miktar"].ToString());
                i++;
            }
            dr.Close();
            conn.Close();
        }
        public bool FilmGuncelle(cFilm f)
        {
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("update Filmler set FilmAd=@FilmAd,FilmTurNo=@FilmTurNo,Yonetmen=@Yonetmen,Oyuncular=@Oyuncular,Ozet=@Ozet where FilmNo=@FilmNo", conn);
            comm.Parameters.Add("@FilmAd", SqlDbType.VarChar).Value = f._filmAd;
            comm.Parameters.Add("@FilmTurNo", SqlDbType.Int).Value = f._filmTurNo;
            comm.Parameters.Add("@Yonetmen", SqlDbType.VarChar).Value = f._yonetmen;
            comm.Parameters.Add("@Oyuncular", SqlDbType.VarChar).Value = f._oyuncular;
            comm.Parameters.Add("@Ozet", SqlDbType.VarChar).Value = f._ozet;
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = f._filmNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return Sonuc;
        }
        
        public bool FilmGuncelleFromSatisEkle(int FilmNo, int Adet)
        {
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("update Filmler set Miktar=Miktar - @Adet where FilmNo=@FilmNo", conn);
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = Adet;
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = FilmNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return Sonuc;
        }
        public bool FilmGuncelleFromSatisIptal(int FilmNo, int Adet)
        {
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("update Filmler set Miktar=Miktar + @Adet where FilmNo=@FilmNo", conn);
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = Adet;
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = FilmNo;
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return Sonuc;
        }

        public bool FilmSil(int ID)
        {
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("update Filmler set Varmi=0  where FilmNo=@FilmNo", conn);
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return Sonuc;
        }
        public bool FilmEkle(cFilm f)
        {
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("insert into Filmler  (FilmAd,FilmTurNo,Yonetmen,Oyuncular,Ozet) values(@FilmAd,@FilmTurNo,@Yonetmen,@Oyuncular,@Ozet)", conn);
            comm.Parameters.Add("@FilmAd", SqlDbType.VarChar).Value = f._filmAd;
            comm.Parameters.Add("@FilmTurNo", SqlDbType.Int).Value = f._filmTurNo;
            comm.Parameters.Add("@Yonetmen", SqlDbType.VarChar).Value = f._yonetmen;
            comm.Parameters.Add("@Oyuncular", SqlDbType.VarChar).Value = f._oyuncular;
            comm.Parameters.Add("@Ozet", SqlDbType.VarChar).Value = f._ozet;
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return Sonuc;
        }
    }
}
