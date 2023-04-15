using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelikeArslan_211103031
{
    public partial class hesap : Form
    {
        public hesap()
        {
            InitializeComponent();
        }
        DatabaseCRUD db = new DatabaseCRUD();
      

        private void hesap_Load(object sender, EventArgs e)
        {
            List<hesapla> hesaplaList = new List<hesapla>();    
            foreach (var item in db.Urunlerigetir())
            {
                hesapla a = new hesapla();
                var alıs = db.GetHareketByUrunIdAndTipi(item.Urunid,Tip.Alis);
                var satıs = db.GetHareketByUrunIdAndTipi(item.Urunid,Tip.Satis);

                decimal ToplamAlıs = 0;
                decimal ToplamSatis = 0;

                foreach (var itemAlıs in alıs)
                {
                    ToplamAlıs += itemAlıs.Birimfiyat * itemAlıs.Miktar;
                }
                foreach (var itemSatıs in satıs)
                {
                    ToplamSatis += itemSatıs.Birimfiyat * itemSatıs.Miktar;

                }
                a.Urunadi = item.Urun;
                a.alıstutar = ToplamAlıs;
                a.satıstutar = ToplamSatis;               
                a.Kar = a.satıstutar-a.alıstutar;
                hesaplaList.Add(a); 

            }
            dataGridView1.DataSource = hesaplaList;
           
        }
    }
}
