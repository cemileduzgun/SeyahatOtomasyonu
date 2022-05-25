using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace YazilimMimarisi
{
   public class DbManager
    {
        private DbManager() { }
        private SqlBaglanti sqlBaglanti = new SqlBaglanti();
        private static DbManager instance;

        public static DbManager Instance()
        {
            if (instance == null)
            {
                instance = new DbManager();
            }
            return instance;
        }

        public void veritabaniKomut(string komut)
        {
            using(SqlConnection baglanti = sqlBaglanti.connection())
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = baglanti;
                    command.CommandText = komut;
                    command.ExecuteNonQuery();
                    baglanti.Close();
                }
            }
        }
        public int musteriCek(string komut, string kimlik_no)
        {
            int musteri_id = 0;
            using (SqlConnection baglanti = sqlBaglanti.connection())
            {
                using (SqlCommand command = new SqlCommand(komut, baglanti))
                {

                    command.Parameters.AddWithValue("@kimlik_no", kimlik_no);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        musteri_id = Convert.ToInt32(reader["musteri_id"]);
                    }

                    baglanti.Close();
                }
            }
            return musteri_id;
        }


        public List<Ulasim> ulasimGetir(string komut)
        {
            List<Ulasim> ulasimList = new List<Ulasim>();

            Ulasim ulasim = new Ulasim();

            using (SqlConnection baglanti = sqlBaglanti.connection())
            {
                using (SqlCommand command = new SqlCommand(komut, baglanti))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        
                        ulasim.bulunduguYer = reader["bulundugu_yer_ulasim"].ToString();
                        ulasim.gidecegiYer = reader["gidecegi_yer_ulasim"].ToString();
                        ulasim.gidisTarihi = Convert.ToDateTime(reader["gidis_tarihi_ulasim"]);
                        ulasim.donusTarihi = Convert.ToDateTime(reader["donus_tarihi_ulasim"]);
                        ulasim.koltukNumara = Convert.ToInt32(reader["koltuk_no_ulasim"].ToString());


                    }

                    baglanti.Close();
                }
            }
            return ulasimList;
        }
    }
}
