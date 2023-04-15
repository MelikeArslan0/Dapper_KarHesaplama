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
    public partial class islem : Form
    {
        public islem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Urunislemleri a = new Urunislemleri();
            a.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kullaniciislemleri a = new Kullaniciislemleri();
            a.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UrunHareketislemleri a = new UrunHareketislemleri();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hesap a = new hesap();
            a.Show();
            
        }

        private void islem_Load(object sender, EventArgs e)
        {

        }
    }
}
