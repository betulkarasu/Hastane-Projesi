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
    public partial class Form_Doktor_Giris : Form
    {
        public Form_Doktor_Giris()
        {
            InitializeComponent();
        }
        sql_baglantisi bgl = new sql_baglantisi();

        private void giris_btn_Click(object sender, EventArgs e)
        {
            SqlCommand KomutGiris = new SqlCommand("Select * from tbl_doktorlar where doktortc=@p1 and doktorsifre=@p2", bgl.baglanti());
            KomutGiris.Parameters.AddWithValue("@p1", masked_tc.Text);
            KomutGiris.Parameters.AddWithValue("@p2", txt_sifre.Text);

            SqlDataReader dr = KomutGiris.ExecuteReader();
            if (dr.Read())
            {
                Form_Doktor_Detay fr = new Form_Doktor_Detay();
                fr.TC= masked_tc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre");

            }
            bgl.baglanti().Close();

        }

        private void Form_Doktor_Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
