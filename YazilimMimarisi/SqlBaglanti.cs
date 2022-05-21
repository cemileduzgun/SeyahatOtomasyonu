using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace YazilimMimarisi
{
   public class SqlBaglanti
    {
        public SqlConnection connection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-0GQ186F;Initial Catalog=seyahatRezervasyonu;Integrated Security=True");
            con.Open();
            return con;
        }
    }
}
