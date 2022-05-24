using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
namespace YazilimMimarisi
{
    public partial class RaporEkrani : Form
    {
        private readonly string dosyaYolu = $"C:\\Users\\windows\\Source\\Repos\\SeyahatOtomasyonuk\\YazilimMimarisi\\Seyehat.json";
        public RaporEkrani()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            try
            {
                string sorgu = "SELECT * FROM tblRezervasyon r INNER JOIN MusteriBilgisi m ON r.kimlik_no = m.kimlik_no ";

                var seyehatJson = DbManager.Instance().seyehat(sorgu);

                var jsonToWrite = JsonConvert.SerializeObject(seyehatJson, Formatting.Indented);

                using (var writer = new StreamWriter(dosyaYolu))
                {
                    writer.Write(jsonToWrite);
                }
            }
            catch (Exception exception)
            {
                //ignored
            }
        }
    }
}
