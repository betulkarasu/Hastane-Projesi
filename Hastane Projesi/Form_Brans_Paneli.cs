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
    public partial class Form_Brans_Paneli : Form
    {
        public Form_Brans_Paneli()
        {
            InitializeComponent();
        }
        sql_baglantisi bgl = new sql_baglantisi();
        
        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand Silkomutu = new SqlCommand("Delete from Tbl_Branslar where bransID=@b1", bgl.baglanti());
            Silkomutu.Parameters.AddWithValue("@b1", txtid.Text);
            Silkomutu.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Form_Brans_Paneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand EkleKomutu = new SqlCommand("Insert into Tbl_Branslar (BransAd) values (@b1) ", bgl.baglanti());
            EkleKomutu.Parameters.AddWithValue("@b1", txtbrans.Text);
            EkleKomutu.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni Branş türü eklenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtbrans.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutgüncelle = new SqlCommand("Update tbl_branslar set bransad=@p1 where bransID=@p2 ", bgl.baglanti());
            komutgüncelle.Parameters.AddWithValue("@p1", txtbrans.Text);
            komutgüncelle.Parameters.AddWithValue("@p2", txtid.Text);
            komutgüncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branşlar güncellenmiştir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                
        }
    }
}
