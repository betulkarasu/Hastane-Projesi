using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Projesi
{

    class sql_baglantisi
    {  public SqlConnection baglanti()

    {
        SqlConnection baglan = new SqlConnection("Data Source=BETšSPC\\SQLEXPRESS;Initial Catalog = HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;
    }
    }
}
