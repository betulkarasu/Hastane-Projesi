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
    public partial class Form_HastaKayit : Form
    {
        public Form_HastaKayit()
        {
            InitializeComponent();
        }
        
        sql_baglantisi bgl = new sql_baglantisi();
        private void Form_HastaKayit_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_kayitol_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar (hastaAd, hastaSoyad, hastaTC, hastaTEL, hastaSifre, hastaCinsiyet) values (@p1, @p2, @p3, @p4, @p5, @p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_soyad.Text);
            komut.Parameters.AddWithValue("@p3", masked_tc1.Text);
            komut.Parameters.AddWithValue("@p4", masked_tel.Text);
            komut.Parameters.AddWithValue("@p5", txt_sifre1.Text);
            komut.Parameters.AddWithValue("@p6", combo_cins.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Oluşmuştur. Şifreniz:" + txt_sifre1.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
