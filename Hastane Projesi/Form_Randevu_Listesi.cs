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
using System.Data.Common;

namespace Hastane_Projesi
{
    public partial class Form_Randevu_Listesi : Form
    {
        public Form_Randevu_Listesi()
        {
            InitializeComponent();
        }
        sql_baglantisi bgl = new sql_baglantisi();

        private void Form_Randevu_Listesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_randevular", bgl.baglanti());

            da.Fill(dt);
            dataGridView1.DataSource = dt;

            
        }
      
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
   
        }
    }
}
