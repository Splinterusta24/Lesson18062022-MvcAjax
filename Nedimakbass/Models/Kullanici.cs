using Nedimakbass.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Nedimakbass.Models
{
    public class Kullanici
    {
        SqlProcess process = new SqlProcess();
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Adres { get; set; }


        
        public void KayitOl()
        {
            //crud da cud de execute non query sadece r executereader

            //Kayıt işlemleri Burada yapılacak
            //SqlConnection _connection = new SqlConnection(con.ConnectionString);

            //SqlCommand cmd = new SqlCommand("", _connection);

            //_connection.Open();
            //cmd.ExecuteNonQuery();
            //_connection.Close();

            process.SetExecuteNonQuery("insert into Kullanici (AdSoyad,Telefon,Email,KullaniciAdi,Sifre,Il,Ilce,Adres) values(@adsoyad,@telefon,@email,@kullaniciadi,@sifre,@il,@ilce,@adres)",
                new SqlParameter("@adsoyad", AdSoyad),
                new SqlParameter("@telefon", Telefon),
                new SqlParameter("@email", Email),
                new SqlParameter("@kullaniciadi", KullaniciAdi),
                new SqlParameter("@sifre", Sifre),
                new SqlParameter("@il", Il),
                new SqlParameter("@ilce", Ilce),
                new SqlParameter("@adres", Adres)
                );
        }
        public void GirisYap()
        {
            //Giriş işlemleri Burada yapılacak
            //SqlConnection _connection = new SqlConnection("Server=DESKTOP-63E5VH2;Database=MVCWebSite;Trusted_Connection=True;");

            //SqlCommand cmd = new SqlCommand("", _connection);
            //DataTable dt = new DataTable();
            //_connection.Open();
            //dt.Load(cmd.ExecuteReader());
            //_connection.Close();

            //SqlConn con = new SqlConn();

            
        }

        public void KullanicilariGetir()
        {
            DataTable dt = process.SetExecuteReader("select * from Kullanici");


                   

        }

    }
}