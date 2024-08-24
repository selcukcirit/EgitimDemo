using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimDemo
{
    public static class LogException
    {

        public static bool Logla(Exception ex)
        {
            //dosya ve ya veritabanına loglama detaylarını kaydet

            try
            {
                var fileName = $"./Log_{DateTime.Now.ToString("yyyyMMdd")}.txt";
                using (var sw = new StreamWriter(fileName, true))
                {
                    sw.WriteLine($"Hatanın tarihi: {DateTime.Now}");
                    sw.WriteLine($"Hatanın tipi: {ex.GetType()}");
                    sw.WriteLine($"Hatanın mesajı: {ex.Message}");
                }
            }
            catch (Exception e)
            {

            }

            return true;
        }
    }
}
