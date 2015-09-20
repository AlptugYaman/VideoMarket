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
    class cMusteri
    {
        private int _musteriNo;
        private string _musteriAd;
        private string _musteriSoyad;
        private string _telefon;
        private string _adres;

        #region Properties
        public int MusteriNo
        {
            get { return _musteriNo; }
            set { _musteriNo = value; }
        }

        public string MusteriAd
        {
            get { return _musteriAd; }
            set { _musteriAd = value; }
        }

        public string MusteriSoyad
        {
            get { return _musteriSoyad; }
            set { _musteriSoyad = value; }
        }

        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }

        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        } 
        #endregion

        cGenel gnl = new cGenel();

        public void MusterilerGetir(ListView liste)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("select * from Musteriler where Silindi=0", conn);
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                liste.Items.Add(dr["MusteriNo"].ToString());
                liste.Items[i].SubItems.Add(dr["MusteriAd"].ToString());
                liste.Items[i].SubItems.Add(dr["MusteriSoyad"].ToString());
                liste.Items[i].SubItems.Add(dr["Telefon"].ToString());
                liste.Items[i].SubItems.Add(dr["Adres"].ToString());
                i++;
            }
            dr.Close();
            conn.Close();
        }

        public void MusterilerGetirByAdaGore(ListView liste, string AdaGore)
        {
            liste.Items.Clear();
            SqlConnection conn = new SqlConnection(gnl.connStr);
            //SqlCommand comm = new SqlCommand("select * from Musteriler where Silindi=0 and MusteriAd like '" + AdaGore + "%'", conn);
            SqlCommand comm = new SqlCommand("select * from Musteriler where Silindi=0 and MusteriAd like @MusteriAd + '%'", conn);
            comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = AdaGore;
            if (conn.State == ConnectionState.Closed) conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                liste.Items.Add(dr["MusteriNo"].ToString());
                liste.Items[i].SubItems.Add(dr["MusteriAd"].ToString());
                liste.Items[i].SubItems.Add(dr["MusteriSoyad"].ToString());
                liste.Items[i].SubItems.Add(dr["Telefon"].ToString());
                liste.Items[i].SubItems.Add(dr["Adres"].ToString());
                i++;
            }
            dr.Close();
            conn.Close();
        }
        public bool MusteriGuncelle(TextBox Adi, TextBox Soyadi, TextBox Telefon, TextBox Adres, TextBox ID)
        {
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("update Musteriler set MusteriAd=@MusteriAd, MusteriSoyad=@MusteriSoyad, Telefon=@Telefon, Adres=@Adres  where MusteriNo=@MusteriNo", conn);
            comm.Parameters.Add("@MusteriAd", SqlDbType.VarChar).Value = Adi.Text;
            comm.Parameters.Add("@MusteriSoyad", SqlDbType.VarChar).Value = Soyadi.Text;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = Telefon.Text;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = Adres.Text;
            comm.Parameters.Add("@MusteriNo", SqlDbType.Int).Value = Convert.ToInt32(ID.Text);
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return Sonuc;
        }
        public bool MusteriSil(int ID)
        {
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("update Musteriler set Silindi=1  where MusteriNo=@MusteriNo", conn);
            comm.Parameters.Add("@MusteriNo", SqlDbType.Int).Value = ID;
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return Sonuc;
        }
        public bool MusteriEkle(cMusteri m)
        {
            SqlConnection conn = new SqlConnection(gnl.connStr);
            SqlCommand comm = new SqlCommand("insert into Musteriler (MusteriAd, MusteriSoyad, Telefon, Adres) values(@Ad, @Soyad, @Telefon, @Adres)", conn);
            comm.Parameters.Add("@Ad", SqlDbType.VarChar).Value = m._musteriAd;
            comm.Parameters.Add("@Soyad", SqlDbType.VarChar).Value = m._musteriSoyad;
            comm.Parameters.Add("@Telefon", SqlDbType.VarChar).Value = m._telefon;
            comm.Parameters.Add("@Adres", SqlDbType.VarChar).Value = m._adres;
            if (conn.State == ConnectionState.Closed) conn.Open();
            bool Sonuc = Convert.ToBoolean(comm.ExecuteNonQuery());
            conn.Close();
            return Sonuc;
        }
    }
}
