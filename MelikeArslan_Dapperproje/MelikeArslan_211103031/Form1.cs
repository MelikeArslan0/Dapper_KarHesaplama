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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Giris_Click(object sender, EventArgs e)
        {
            var k = new DatabaseCRUD().GetKullanici(textBox_Sifre.Text, textBox_KullaniciAd.Text);

            if (k != null)
            {
                islem isl = new islem();
                isl.ShowDialog();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Hatalı Giriş", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
