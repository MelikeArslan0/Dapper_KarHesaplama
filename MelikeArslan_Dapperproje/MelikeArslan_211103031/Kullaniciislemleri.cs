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
    public partial class Kullaniciislemleri : Form
    {
        public Kullaniciislemleri()
        {
            InitializeComponent();
        }
        private string strkaydet = "Ekle";
        private string strGÜncelle = "Güncelle";
        int IslemYapılanId = 0;
        void gridGuncelle()
        {
            dataGridView1.DataSource = new DatabaseCRUD().GetKullanici();
        }


        private void button_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanici_ kullanici = new Kullanici_();
                kullanici.Kullaniciid = IslemYapılanId;
                kullanici.Kullaniciad = textBox2.Text;
                kullanici.Sifre = textBox3.Text;
                if (button_ekle.Text.Equals(strkaydet))
                {
                    new DatabaseCRUD().addKullanici(kullanici);
                }

                else if (button_ekle.Text.Equals(strGÜncelle))
                {

                    MessageBox.Show("Kayıt Güncellendi.");
                    new DatabaseCRUD().updateKullanici(kullanici);
                    gridGuncelle();
                    button_ekle.Text = strkaydet;
                }
                gridGuncelle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Kullaniciislemleri_Load(object sender, EventArgs e)
        {
            gridGuncelle();
        }
        private void Formtemizle()
        {
            textBox2.Clear();
            textBox3.Clear();
            button_ekle.Text = strkaydet;
        }
     

        private void button_Sil_Click(object sender, EventArgs e)
        {
            Kullanici_ sil = new Kullanici_();
            sil.Kullaniciid = IslemYapılanId;
            sil.Kullaniciad = textBox2.Text;
            sil.Sifre = textBox3.Text;
            MessageBox.Show("Kayıt silindi.");
            new DatabaseCRUD().deleteKullanici(sil);
            gridGuncelle();
        }

        private void button1_iptal_Click(object sender, EventArgs e)
        {
            button_ekle.Text = strkaydet;
            Formtemizle();
        }

        private void TEMİZLE_Click(object sender, EventArgs e)
        {
            Formtemizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button_ekle.Text = strGÜncelle;
            IslemYapılanId = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

        }
    }
}
