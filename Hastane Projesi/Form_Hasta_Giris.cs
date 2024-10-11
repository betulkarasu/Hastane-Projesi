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
    public partial class Form_Hasta_Giris : Form
    {
        public Form_Hasta_Giris()
        {
            InitializeComponent();
        }
        sql_baglantisi bgl = new sql_baglantisi();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_HastaKayit hastaKayit = new Form_HastaKayit();
            hastaKayit.Show();
           

        }

        private void giris_btn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_hastalar where HastaTC=@p1 and Hastasifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", masked_tc.Text);
            komut.Parameters.AddWithValue("@p2", txt_sifre.Text);
            SqlDataReader DR = komut.ExecuteReader();
            if (DR.Read())
            {
                Form_Hasta_Detay fr = new Form_Hasta_Detay();
                fr.tc = masked_tc.Text;
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı TC ya da Şifre", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            bgl.baglanti().Close();
        }

        private void Form_Hasta_Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
