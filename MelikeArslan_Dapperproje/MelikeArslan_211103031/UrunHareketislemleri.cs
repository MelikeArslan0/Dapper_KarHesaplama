using Dapper;
using MelikeArslan_211103031;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MelikeArslan_211103031
{
    public partial class UrunHareketislemleri : Form
    {
       
        public UrunHareketislemleri()
        {
            InitializeComponent();
            comboBox_Tip.DataSource = Enum.GetValues(typeof(Tip));
        }
        private int islemyapilanid = 0;
        private string strkaydet = "Ekle";
        private string strGÜncelle = "Güncelle";

       

        public void GridGuncelle()
        {
           dataGridView1.DataSource = new DatabaseCRUD().GetHareket();         
        }
     
        private void UrunHareketislemleri_Load(object sender, EventArgs e)
        {
            DatabaseCRUD db = new DatabaseCRUD();

            comboBox_Urun.ValueMember = "Urunid";
            comboBox_Urun.DisplayMember = "Urun";
            comboBox_Urun.DataSource = db.Urunlerigetir();
            GridGuncelle();
        }

        private void Formtemizle()
        {
            textBox_Bfiyat.Clear();
            textBox_Miktar.Clear();
            comboBox_Urun.SelectedIndex=0;
            comboBox_Tip.SelectedIndex = 1;
            dateTimePicker1.Value = DateTime.Now;
            button_Ekle.Text = strkaydet;
        }
    

        private void button_Ekle_Click(object sender, EventArgs e)
        {
            try
            {

                Hareket Hareket = new Hareket();

                Hareket.id = islemyapilanid;
                Hareket.Tarih = dateTimePicker1.Value;
                Hareket.Tip = (Tip)comboBox_Tip.SelectedValue;
                Hareket.Urun = Convert.ToInt16(comboBox_Urun.SelectedValue);
                Hareket.Miktar = int.Parse(textBox_Miktar.Text);
                Hareket.Birimfiyat = decimal.Parse(textBox_Bfiyat.Text);

                if (button_Ekle.Text.Equals(strkaydet))
                {
                    new DatabaseCRUD().AddHareket(Hareket);
                }

                else if (button_Ekle.Text.Equals(strGÜncelle))
                {
                    Hareket.id = islemyapilanid;
                    new DatabaseCRUD().updateHareket(Hareket);
                    GridGuncelle();
                    button_Ekle.Text = strkaydet;
                }


                GridGuncelle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void temizle_Click(object sender, EventArgs e)
        {
          
            Formtemizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_Ekle.Text = strkaydet;
            Formtemizle();
        }

        private void button_Sil_Click(object sender, EventArgs e)
        {
            try
            {


                Hareket deletehareket = new Hareket();
                deletehareket.id = islemyapilanid;
                deletehareket.Tarih = dateTimePicker1.Value;
                deletehareket.Tip = (Tip)comboBox_Tip.SelectedValue;
                deletehareket.Urun = Convert.ToInt16(comboBox_Urun.SelectedValue);
                deletehareket.Miktar = int.Parse(textBox_Miktar.Text);
                deletehareket.Birimfiyat = decimal.Parse(textBox_Bfiyat.Text);



                new DatabaseCRUD().deleteHareket(deletehareket);
                MessageBox.Show("Kayıt Silindi");
                GridGuncelle();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

     

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

            button_Ekle.Text = strGÜncelle;
            islemyapilanid = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox_Tip.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            comboBox_Urun.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[3].Value;
            textBox_Miktar.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox_Bfiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
