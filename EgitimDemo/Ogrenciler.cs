using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EgitimDemo.Ogrenci;

namespace EgitimDemo
{
    public class Ogrenciler
    {
        Ogrenci[] ogrenciler =
       {
            new Ogrenci { adiSoyadi="Selçuk Cirit", cinsiyet= Cinsiyet.Erkek, fakulte= Fakulte.Tip, yasi=42 },
            new Ogrenci { adiSoyadi="Ahmet Yılmaz", cinsiyet= Cinsiyet.Erkek, fakulte= Fakulte.Ziraat, yasi=25 },
            new Ogrenci { adiSoyadi="Büşra Kaya", cinsiyet= Cinsiyet.Kadın, fakulte= Fakulte.FenEdebiyat, yasi=32 },
        };

        public Ogrenci this[string adi] => OgrenciAra(adi);

        private Ogrenci OgrenciAra(string adi)
        {
            foreach (var ogrenci in ogrenciler)
            {
                if (ogrenci.adiSoyadi == adi) return ogrenci;
            }

            throw new Exception("Öğrenci bulunamadı");
        }
    }
}
