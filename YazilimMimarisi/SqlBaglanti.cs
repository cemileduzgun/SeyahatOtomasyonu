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
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-60630FD;Initial Catalog=seyahetRezervasyonu;Integrated Security=True");
            con.Open();
            return con;
        }
    }
}
