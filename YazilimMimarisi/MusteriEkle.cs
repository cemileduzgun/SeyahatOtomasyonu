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

namespace YazilimMimarisi
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }
        
        private Musteri musteriBilgi()
        {
            Musteri musteri = new Musteri();
            musteri.ad_soyad = tbMusteriAd.Text;
            musteri.kimlik_no = tbKimlikNo.Text;
            musteri.telefon = tbTelefon.Text;

            return musteri;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Musteri musteri = musteriBilgi();
            string komut= "INSERT INTO MusteriBilgisi(ad_soyad, telefon, kimlik_no) " +
                $"values ('{musteri.ad_soyad}', '{musteri.telefon}', '{musteri.kimlik_no}')";
            
            DbManager.Instance().veritabaniKomut(komut);
            MessageBox.Show("Müşteri Eklendi");
            Rezervasyon rezervasyon = new Rezervasyon();
            rezervasyon.musteriKimlikNo = musteri.kimlik_no;
            rezervasyon.Show();
            this.Hide();
            
        }
    }
}
