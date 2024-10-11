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
    public partial class Form_Sekreter_Detay : Form
    {
        public Form_Sekreter_Detay()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into tbl_randevular (randevutarih, randevusaat, randevubranş, randevudoktor) values (@r1, @r2, @r3, @r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", mskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", mskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", comboBrans.Text);
            komutkaydet.Parameters.AddWithValue("r4", comboDoktor.Text);

            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu.");

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
        public string TCno;
        sql_baglantisi bgl = new sql_baglantisi();
        private void Form_Sekreter_Detay_Load(object sender, EventArgs e)
        {
            lblTc.Text = TCno;

            // AD SOYAD
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lbladsoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            // BRANŞLARI DATAGRIDE AKTARMA
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select Bransad from tbl_branslar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            // DOKTORLARI LİSTEYE AKTARMA
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select DoktorAd, DoktorBrans From Tbl_doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource=dt2;

            // BRANŞI COMBOBOX A AKTARMA
            SqlCommand komut2 = new SqlCommand("Select Bransad from tbl_branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBrans.Items.Add(dr2[0]);

            }
            bgl.baglanti().Close();
        
        
        
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_duyurular (duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", richDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu.");

        }

        private void btnDoktorPanel_Click(object sender, EventArgs e)
        {   
            Form_Doktor_Paneli Doktor_Paneli = new Form_Doktor_Paneli();
            Doktor_Paneli.Show();
           
        }

        private void btnBransPanel_Click(object sender, EventArgs e)
        {
            Form_Brans_Paneli BransFormu = new Form_Brans_Paneli();
            BransFormu.Show();

        }

        private void btnRandevuList_Click(object sender, EventArgs e)
        {
            Form_Randevu_Listesi FormRandevu = new Form_Randevu_Listesi();
            FormRandevu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Duyurular DuyuruFormu = new Form_Duyurular();
            DuyuruFormu.Show();

        }
    }
}
