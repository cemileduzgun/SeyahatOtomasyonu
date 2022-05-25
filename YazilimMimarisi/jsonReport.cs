using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace YazilimMimarisi
{
    class jsonReport
    {
       
        SqlBaglanti cs = new SqlBaglanti();

        public void getir()
        {
            try
            {
               
                cs.connection();
                

            }
            catch (Exception e)
            {

              
                MessageBox.Show("Database connection unsuccessful");
                System.Environment.Exit(1);

            }

           
            string exportPath = @"C:\Users\windows\source\Repos\SeyahatOtomasyonue\YazilimMimarisi";
            string exportJson = "personexport.json";

            StreamWriter jsonFile = null;

           
            if (!Directory.Exists(exportPath))
            {

              
           
                MessageBox.Show("File path does not exist.");

              
                System.Environment.Exit(1);

            }

            try
            {

                
                string sqlText = " SELECT *from MusteriBilgisi M INNER JOIN tblRezervasyon R  on M.kimlik_no=R.kimlik_no ";





                
                SqlCommand sqlSelect = new SqlCommand(sqlText, cs.connection());

                
                SqlDataReader reader = sqlSelect.ExecuteReader();

                
                if (reader.HasRows)
                {

                  
                    jsonFile = new StreamWriter(@exportPath + exportJson);

                    var dataTable = new DataTable();
                    dataTable.Load(reader);

                    string jsonString = string.Empty;

                    var collectionWrapper = new
                    {

                        person = dataTable

                    };

                    jsonString = JsonConvert.SerializeObject(collectionWrapper,
                                                                Formatting.Indented);

                    jsonFile.Write(jsonString);

                    jsonFile.Flush();

                    DateTime today = DateTime.Now;

                    string exportBackupJson = exportJson.Substring(0, exportJson.Length - 5) +
                        "-" + (int)today.DayOfWeek + "-" +
                        today.DayOfWeek.ToString().ToLower() + ".json";

                    
                    if (!File.Exists(Path.Combine(exportPath, exportBackupJson)) ||
                        (File.Exists(Path.Combine(exportPath, exportBackupJson)) &&
                        File.GetLastWriteTime(
                            Path.Combine(exportPath, exportBackupJson)).Date !=
                            today.Date))
                    {

                        File.Copy(Path.Combine(exportPath, exportJson),
                            Path.Combine(exportPath, exportBackupJson), true);

                    }

                }
                else
                {

                    MessageBox.Show("There is no data to export.");
                    System.Environment.Exit(1);

                }

                MessageBox.Show("Data export successful.");

            }
            catch (Exception e)
            {
                MessageBox.Show("Data export unsuccessful.");
                System.Environment.Exit(1);

            }
            finally
            {

                cs.connection();
                jsonFile.Close();

            }

        }

    }
}
