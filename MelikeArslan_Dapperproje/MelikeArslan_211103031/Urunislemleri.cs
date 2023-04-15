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
    public partial class Urunislemleri : Form
    {
        public Urunislemleri()
        {
            InitializeComponent();
        }
        int IslemYapılanId = 0;
        private string strkaydet = "Ekle";
        private string strGÜncelle = "Güncelle";
        void gridGuncelle()
        {

            dataGridView1.DataSource = new DatabaseCRUD().GetUrun();
        }
       
        private void UruIİslemleri_Load(object sender, EventArgs e)
        {
            gridGuncelle();
        }
        private void Formtemizle()
        {
          
            textBox2.Clear();
            button_ekle.Text = strkaydet;

        }
        private void button_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                Urun_ urun = new Urun_();
                urun.Urunid = IslemYapılanId;
                urun.Urun = textBox2.Text;
                if (button_ekle.Text.Equals(strkaydet))
                {
                    new DatabaseCRUD().addUrun(urun);
                }

                else if (button_ekle.Text.Equals(strGÜncelle))
                {
                    new DatabaseCRUD().update(urun);
                    MessageBox.Show("Kayıt Güncellendi.");
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            button_ekle.Text = strGÜncelle;
            IslemYapılanId = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[0].Value);           
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void button_Sil_Click(object sender, EventArgs e)
        {

            Urun_ sil = new Urun_();
            sil.Urunid = IslemYapılanId;

            sil.Urun = textBox2.Text;


            new DatabaseCRUD().delete(sil);
            MessageBox.Show("Kayıt Silindi");
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

        private void Urunislemleri_Load(object sender, EventArgs e)
        {
            gridGuncelle();
        }
    }
}
