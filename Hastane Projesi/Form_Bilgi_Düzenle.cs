using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Projesi
{
    public partial class Form_Bilgi_Düzenle : Form
    {
        public Form_Bilgi_Düzenle()
        {
            InitializeComponent();
        }

        private void txt_sifre1_TextChanged(object sender, EventArgs e)
        {

        }
        public string TCno;

        sql_baglantisi bgl = new sql_baglantisi();
        private void Form_Bilgi_Düzenle_Load(object sender, EventArgs e)
        {
            masked_tc1.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", masked_tc1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txt_ad.Text = dr[1].ToString();
                txt_soyad.Text = dr[2].ToString();
                masked_tel.Text = dr[4].ToString();
                txt_sifre1.Text = dr[5].ToString();
                combo_cins.Text = dr[6].ToString();
             
            }
            bgl.baglanti().Close();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1, hastaSoyAd=@p2, hastaTel=@p3, hastaSifre=@p4, hastaCinsiyet=@p5 where HastaTc=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txt_ad.Text);
            komut2.Parameters.AddWithValue("@p2", txt_soyad.Text);
            komut2.Parameters.AddWithValue("@p3", masked_tel.Text);
            komut2.Parameters.AddWithValue("@p4", txt_sifre1.Text);
            komut2.Parameters.AddWithValue("@p5", combo_cins.Text);
            komut2.Parameters.AddWithValue("@p6", masked_tc1.Text);


            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz güncellenmiştir.", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Warning);


        }
    }
}
