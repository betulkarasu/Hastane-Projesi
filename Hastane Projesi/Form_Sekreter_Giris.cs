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
    public partial class Form_Sekreter_Giris : Form
    {
        public Form_Sekreter_Giris()
        {
            InitializeComponent();
        }
        sql_baglantisi bgl = new sql_baglantisi();
        private void giris_btn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_sekreter where SekreterTC=@p1 and sekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", masked_tc.Text);
            komut.Parameters.AddWithValue("@p2", txt_sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form_Sekreter_Detay frs = new Form_Sekreter_Detay();
                frs.TCno = masked_tc.Text;
                frs.Show();
                this.Hide();
                            }
            else
            {
                MessageBox.Show("Hatalı TC ya da Şifre Girişi", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();


        }

        private void Form_Sekreter_Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
