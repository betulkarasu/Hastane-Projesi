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
    public partial class Doktor_Bilgi_Guncelle : Form
    {
        public Doktor_Bilgi_Guncelle()
        {
            InitializeComponent();
        }
        sql_baglantisi bgl = new sql_baglantisi();
        public string TCNO;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Doktor_Bilgi_Guncelle_Load(object sender, EventArgs e)
        {
            masked_tc1.Text = TCNO;
            SqlCommand komut = new SqlCommand("select * from tbl_doktorlar where doktortc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", masked_tc1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txt_ad.Text = dr[1].ToString();
                txt_soyad.Text = dr[2].ToString();
                combo_brans.Text = dr[3].ToString();
                txt_sifre1.Text = dr[4].ToString();
                        }
            bgl.baglanti().Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_doktorlar set doktorad=@p1, doktorsoyad=@2, doktorbrans=@p3, doktorsifre=@p4 where soktortc=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_ad.Text);
            komut.Parameters.AddWithValue("@p2", txt_soyad.Text);
            komut.Parameters.AddWithValue("@p3", combo_brans.Text);
            komut.Parameters.AddWithValue("@p4", txt_sifre1.Text);
            komut.Parameters.AddWithValue("@p5", masked_tc1.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
    }
}
