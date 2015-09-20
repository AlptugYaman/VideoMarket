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
    class cFilmSatis
    {
        private int _satisNo;
        private DateTime _tarih;
        private int _filmNo;
        private int _musteriNo;
        private int _adet;
        private decimal _birimFiyat;

        #region Properties
        public int SatisNo
        {
            get { return _satisNo; }
            set { _satisNo = value; }
        }

        public DateTime Tarih
        {
            get { return _tarih; }
            set { _tarih = value; }
        }

        public int FilmNo
        {
            get { return _filmNo; }
            set { _filmNo = value; }
        }

        public int MusteriNo
        {
            get { return _musteriNo; }
            set { _musteriNo = value; }
        }

        public int Adet
        {
            get { return _adet; }
            set { _adet = value; }
        }

        public decimal BirimFiyat
        {
            get { return _birimFiyat; }
            set { _birimFiyat = value; }
        } 
        #endregion

        cGenel gnl = new cGenel();

        public void SatislariGetir(ListView liste, TextBox ToplamAdet, TextBox ToplamTutar)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("select SatisNo,Tarih,FilmAd,Miktar,MusteriAd + ' ' + MusteriSoyad as Musteri,BirimFiyat,Adet,BirimFiyat*Adet as Tutar,FilmSatis.FilmNo,FilmSatis.MusteriNo from FilmSatis inner join Filmler on FilmSatis.FilmNo=Filmler.FilmNo inner join Musteriler on Musteriler.MusteriNo=FilmSatis.MusteriNo where FilmSatis.Silindi=0 order by Tarih desc", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            int i = 0;
            int toplamAdet = 0;
            decimal toplamTutar = 0;
            while (dr.Read())
            {
                liste.Items.Add(dr["SatisNo"].ToString());
                liste.Items[i].SubItems.Add(dr["Tarih"].ToString());
                liste.Items[i].SubItems.Add(dr["FilmAd"].ToString());
                liste.Items[i].SubItems.Add(dr["Miktar"].ToString());
                liste.Items[i].SubItems.Add(dr["Musteri"].ToString());
                liste.Items[i].SubItems.Add(dr["BirimFiyat"].ToString());
                liste.Items[i].SubItems.Add(dr["Adet"].ToString());
                liste.Items[i].SubItems.Add(dr["Tutar"].ToString());
                liste.Items[i].SubItems.Add(dr["FilmNo"].ToString());
                liste.Items[i].SubItems.Add(dr["MusteriNo"].ToString());
                toplamAdet += Convert.ToInt32(dr["Adet"]);
                toplamTutar += Convert.ToDecimal(dr["Tutar"]);
                i++;
            }
            dr.Close();
            conn.Close();
            ToplamAdet.Text = toplamAdet.ToString();
            ToplamTutar.Text = toplamTutar.ToString();
        }
        public bool SatisEkle(cFilmSatis fs)
        {
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("insert into FilmSatis (Tarih,FilmNo,MusteriNo,Adet,BirimFiyat) values(@Tarih,@FilmNo,@MusteriNo,@Adet,@BirimFiyat)", conn);
            comm.Parameters.Add("@Tarih", SqlDbType.DateTime).Value = fs._tarih;
            comm.Parameters.Add("@FilmNo", SqlDbType.Int).Value = fs._filmNo;
            comm.Parameters.Add("@MusteriNo", SqlDbType.Int).Value = fs._musteriNo;
            comm.Parameters.Add("@Adet", SqlDbType.Int).Value = fs._adet;
            comm.Parameters.Add("@BirimFiyat", SqlDbType.Money).Value = fs._birimFiyat;
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return sonuc;
        }
        public bool SatisIptal(int SatisID)
        {
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("update FilmSatis set Silindi=1 where SatisNo=@SatisNo", conn);
            comm.Parameters.Add("@SatisNo", SqlDbType.Int).Value = SatisID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return sonuc;
        }

        public DataTable SatislariGetirByTarihlerArasi(DateTime Tarih1, DateTime Tarih2)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlDataAdapter da = new SqlDataAdapter("select Tarih,FilmAd,MusteriAd + ' ' + MusteriSoyad as Musteri,BirimFiyat,Adet,BirimFiyat*Adet as Tutar from FilmSatis inner join Filmler on FilmSatis.FilmNo=Filmler.FilmNo inner join Musteriler on Musteriler.MusteriNo=FilmSatis.MusteriNo where FilmSatis.Silindi=0 and Convert(VarChar(20),Tarih,104) Between Convert(VarChar(20),@Tarih1,104) and Convert(VarChar(20),@Tarih2,104) order by Tarih desc", conn);
            da.SelectCommand.Parameters.Add("@Tarih1", SqlDbType.DateTime).Value = Tarih1;
            da.SelectCommand.Parameters.Add("@Tarih2", SqlDbType.DateTime).Value = Tarih2;
            da.Fill(dt);
            return dt;
        }
    }
}
