using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MelikeArslan_211103031;

namespace MelikeArslan_211103031
{
    public class DatabaseCRUD
    {

        string Connectionstring = @"Server=MELIKE;DataBase=Database_;Integrated Security=true;";
        public List<Hareket> GetHareket()
        {
            using (SqlConnection con = new SqlConnection(Connectionstring))
            {
                var result = con.Query<Hareket>("select * from Hareket ");
                return result.ToList();
            }
            //using (SqlConnection connection = new SqlConnection(Connectionstring))
            //{
            // var result = connection.Query<Hareket>("SELECT Hareket.BirimFiyat,Hareket.Tip,Urun.Urun,Hareket.Miktar,Hareket.BirimFiyat FROM Hareket JOIN Urun ON Hareket.Urun = Urun.Urunid");
            //    return result.ToList();
            //}
        }
        public List<Hareket> GetHareketByUrunIdAndTipi(int urunId,Tip tip)
        {
            using (SqlConnection con = new SqlConnection(Connectionstring))
            {
                var result = con.Query<Hareket>("select * from Hareket where Urun=@Urun and Tip=@Tip",new {Urun=urunId,Tip=tip});
                return result.ToList();
            }
        }

        public void AddHareket(Hareket hareket)
        {

            using (SqlConnection con = new SqlConnection(Connectionstring))
            {
                var result = con.Execute("Insert Into Hareket values(@Tarih,@Tip,@Urun,@Miktar,@Birimfiyat)", hareket);
            }

        }
        public void deleteHareket(Hareket hareket)
        {

            using (SqlConnection con = new SqlConnection(Connectionstring))
            {
                var result = con.Execute("Delete from Hareket where id=@id", hareket);

            }

        }
        public void updateHareket(Hareket hareket)
        {

            using (SqlConnection con = new SqlConnection(Connectionstring))
            {
                var result = con.Execute("Update Hareket set Tarih=@Tarih,Tip=@Tip, Urun=@Urun,Miktar=@Miktar,Birimfiyat=@Birimfiyat where id=@id", hareket);

            }

        }
        public List<Urun_> GetUrun()
        {
            using (SqlConnection con = new SqlConnection(Connectionstring))
            {
                var result = con.Query<Urun_>("Select * from Urun");
                return result.ToList();
            }
        }
        public void addUrun(Urun_ urun)
        {

            using (SqlConnection con = new SqlConnection(Connectionstring))
            {
                var result = con.Execute("Insert Into Urun values(@Urun)", urun);

            }

        }

        public void delete(Urun_ urun)
        {

            using (SqlConnection con = new SqlConnection(Connectionstring))
            {
                var result = con.Execute("Delete from Urun where Urunid=@Urunid", urun);

            }

        }
        public void update(Urun_ urun)
        {

            using (SqlConnection con = new SqlConnection(Connectionstring))
            {
                var result = con.Execute("Update Urun set Urun=@Urun where Urunid=@Urunid", urun);

            }

        }
        public List<Kullanici_> GetKullanici()
        {
            using (SqlConnection con = new SqlConnection(Connectionstring))
            {
                var result = con.Query<Kullanici_>("Select * from Kullanici");
                return result.ToList();
            }
        }

        public Kullanici_ GetKullanici(string sifre, string kull)
        {
            using (SqlConnection con = new SqlConnection(Connectionstring))
            {
                var result = con.Query<Kullanici_>("Select * from Kullanici where KullaniciAd=@KullaniciAd and Sifre=@Sifre ", new { KullaniciAd = kull, Sifre = sifre });
                return result.SingleOrDefault();
            }
        }
        public void addKullanici(Kullanici_ kullanici)
        {

            using (SqlConnection con = new SqlConnection(Connectionstring))
            {
                var result = con.Execute("Insert Into Kullanici values(@KullaniciAd,@Sifre)", kullanici);

            }

        }

        public void deleteKullanici(Kullanici_ kullanici)
        {

            using (SqlConnection con = new SqlConnection(Connectionstring))
            {
                var result = con.Execute("Delete from Kullanici where Kullaniciid=@Kullaniciid", kullanici);

            }

        }
        public void updateKullanici(Kullanici_ kullanici)
        {

            using (SqlConnection con = new SqlConnection(Connectionstring))
            {
                var result = con.Execute("Update Kullanici set KullaniciAd=@KullaniciAd,Sifre=@Sifre  where Kullaniciid=@Kullaniciid", kullanici);

            }

        }
  
        public List<Urun_> Urunlerigetir()
        {
            using (SqlConnection db = new SqlConnection(Connectionstring))
            {
                var result = db.Query<Urun_>("select  * from Urun ");
                return result.ToList();
            }
        }


    }
}