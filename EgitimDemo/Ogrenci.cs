using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimDemo
{
    public class Ogrenci : IDisposable
    {
        public enum Cinsiyet
        {
            Erkek,
            Kadın,
            Diger
        }

        public enum Fakulte
        {
            IktisatveIsletme,
            Tip,
            Muhendislik,
            FenEdebiyat,
            Ziraat
        }

        public struct KimlikBilgileri
        {
            public int SeriNo;
            public int SiraNo;
            public int TipNo;
            public DateTime VerilisTarihi;
            public string KimlikNo;
            public KimlikBilgileri(int tip, int seriNo, int siraNo, DateTime verilisTarihi, string kimlikNo)
            {
                TipNo = tip;
                SeriNo = seriNo;
                SiraNo = siraNo;
                VerilisTarihi = verilisTarihi;
                KimlikNo = kimlikNo;
            }
        }

        public string adiSoyadi;
        public int yasi;
        public string TCKN;
        public Cinsiyet cinsiyet;
        public Fakulte fakulte;
        public KimlikBilgileri kimlikBilgileri;

        public static int ogrenciSayisi;

        public Ogrenci()
        {
            yasi = 18;
            cinsiyet = Cinsiyet.Erkek;
        }

        public Ogrenci(string adi)
        {
            adiSoyadi = adi;
        }

        public Ogrenci(string adi, Cinsiyet cins)
        {
            adiSoyadi = adi;
            cinsiyet = cins;
        }

        public static Ogrenci operator +(Ogrenci ogrenci, int artis)
        {
            ogrenci.yasi += artis;
            return ogrenci;
        }
        public static Ogrenci operator +(int artis, Ogrenci ogrenci)
        {
            ogrenci.yasi += artis;
            return ogrenci;
        }

        public static Ogrenci operator -(Ogrenci ogrenci, int azalis)
        {
            ogrenci.yasi -= azalis;
            return ogrenci;
        }
        public static Ogrenci operator -(int azalis, Ogrenci ogrenci)
        {
            ogrenci.yasi = azalis - ogrenci.yasi;
            return ogrenci;
        }

        public static int OgrenciEkle()
        {
            return ++ogrenciSayisi;
        }

        public void YasEkle(int dogumYili)
        {
            yasi = DateTime.Now.Year - dogumYili;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Adı soyadı {adiSoyadi} olan {yasi} yaşında, {fakulte} fakültesinde okuyan öğrenci " +
                $"{(cinsiyet == Cinsiyet.Kadın ? "kadındır" : "erkektir")}";
        }
    }
}
