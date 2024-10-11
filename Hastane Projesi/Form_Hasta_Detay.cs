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
    public partial class Form_Hasta_Detay : Form
    {
        public Form_Hasta_Detay()
        {
            InitializeComponent();
        }
        public string tc;
        sql_baglantisi bgl = new sql_baglantisi();
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Hasta_Detay_Load(object sender, EventArgs e)
        {
            lbl_tc.Text = tc;
            //AD SOYAAD ÇEKME
            SqlCommand komut = new SqlCommand("Select HastaAd, HastaSoyad From Tbl_hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbl_tc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl_adsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter dA = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=" + tc, bgl.baglanti());
            dA.Fill(dt);
            dataGridView1.DataSource = dt;


            //Branşları Çekme

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                combo_brans.Items.Add(dr2[0]);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void combo_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_doktor.Items.Clear();

            SqlCommand komut3 = new SqlCommand("Select DoktorAd, DoktorSoyAd From Tbl_Doktorlar where DoktorBrans=@p1 ", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", combo_brans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                combo_doktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void combo_doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da =new SqlDataAdapter ("Select * From Tbl_Randevular where RandevuBranş='"+ combo_brans.Text+"'" + " and RandevuDoktor='" + combo_doktor.Text + "' and RandevuDurum=0" , bgl.baglanti());
            da.Fill(dt);
            dataGridView3.DataSource = dt;
        }

        private void link_BilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Bilgi_Düzenle fr = new Form_Bilgi_Düzenle();
            fr.TCno = lbl_tc.Text;
            fr.Show();



        }

        private void btn_randevual_Click(object sender, EventArgs e)
        {
            SqlCommand komutRanAl = new SqlCommand("Update Tbl_randevular set RandevuDurum=1, HastaTC=@p1, HastaSikayet=@p2 where Randevuid=@p3", bgl.baglanti());
            komutRanAl.Parameters.AddWithValue("@p1", lbl_tc.Text);
            komutRanAl.Parameters.AddWithValue("@p2", rich_sikayet.Text);
            komutRanAl.Parameters.AddWithValue("@p3", txtID.Text);
            komutRanAl.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView3.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView3.Rows[secilen].Cells[0].Value.ToString();

        }
    }
}
