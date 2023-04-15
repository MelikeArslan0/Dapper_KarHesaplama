using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelikeArslan_211103031
{
    public enum Tip
    {
        Alis, Satis
    }
    public class Hareket

    {
        public int id { get; set; }
        public DateTime Tarih { get; set; }
        public Tip Tip { get; set; }
        public int Urun { get; set; }
        public int Miktar { get; set; }

        public decimal Birimfiyat { get; set; }

    }
    public class Urun_
    {
        public int Urunid { get; set; }
        public String Urun { get; set; }

    }
    public class Kullanici_
    {
        public int Kullaniciid { get; set; }
        public String Kullaniciad { get; set; }
        public String Sifre { get; set; }

    }
}
