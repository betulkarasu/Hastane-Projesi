﻿using System;
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
    public partial class Form_Doktor_Paneli : Form
    {
        public Form_Doktor_Paneli()
        {
            InitializeComponent();
        }
        sql_baglantisi bgl = new sql_baglantisi();


        private void Form_Doktor_Paneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Bransları COMBOboxA AKTARMA

            SqlCommand komut2 = new SqlCommand("Select Bransad from tbl_branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBrans.Items.Add(dr2[0]);

            }
            bgl.baglanti().Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_Doktorlar (Doktorad, DoktorSoyad, DoktorBrans, DoktorTC, DoktorSifre) values (@d1, @d2, @d3, @d4, @d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtad.Text);
            komut.Parameters.AddWithValue("@d2", txtSoyad.Text );
            komut.Parameters.AddWithValue("@d3", comboBrans.Text);
            komut.Parameters.AddWithValue("@d5", txtSifre.Text);
            komut.Parameters.AddWithValue("@d4", mskTc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mskTc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBrans.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTc.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutGuncelle = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@d1, DoktorSoyad=@d2, DoktorBrans=@d3 , DoktorSifre=@d5 Where DoktorTC=@d4", bgl.baglanti());
            komutGuncelle.Parameters.AddWithValue("@d1", txtad.Text);
            komutGuncelle.Parameters.AddWithValue("@d2", txtSoyad.Text);
            komutGuncelle.Parameters.AddWithValue("@d3", comboBrans.Text);
            komutGuncelle.Parameters.AddWithValue("@d4", mskTc.Text);
            komutGuncelle.Parameters.AddWithValue("@d5", txtSifre.Text);

            komutGuncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıtlar Güncellendi.", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

        }
    }
}
