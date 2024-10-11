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
    public partial class Form_Doktor_Detay : Form
    {
        public Form_Doktor_Detay()
        {
            InitializeComponent();
        }
        sql_baglantisi bgl = new sql_baglantisi();
        public string TC;
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form_Doktor_Detay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TC;

        }

        private void btn_bilgiduzenle_Click(object sender, EventArgs e)
        {
            Doktor_Bilgi_Guncelle fr = new Doktor_Bilgi_Guncelle();
            fr.Show();
            fr.TCNO = lblTC.Text;
        }

        private void btn_duyrular_Click(object sender, EventArgs e)
        {
            Form_Duyurular frduyuru = new Form_Duyurular();
            frduyuru.Show();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox1.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

                    }

        private void Dokr(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_randevular", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
