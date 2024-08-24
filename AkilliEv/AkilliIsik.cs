namespace AkilliEv
{
    public class AkilliIsik
    {
        public enum Renkler
        {
            SogukBeyaz,
            SicakBeyaz,
            KoyuMavi,
            DogalBeyaz,
            HafifSari
        }

        public enum OtomatikAyarModu
        {
            Gunduz,
            Gece,
            Sinema,
            Okuma
        }

        private int parlaklik;
        private bool isikDurumu;
        private OtomatikAyarModu otomatikMod;
        private readonly string dosyaYolu = "isikAyarlar.txt";

        public int OdaIsikSeviyesi { get; init; } //init-only setter

        public Renkler Renk { get; set; }

        public bool IsikDurumu
        {
            get => isikDurumu;
            set => isikDurumu = value;
        }

        public int Parlaklik
        {
            get => parlaklik;
            // set => parlaklik = value;
            //set
            //{
            //    if (value < 0) parlaklik = 0;
            //    else if (value > 100) parlaklik = 100;
            //    else parlaklik = value;
            //}
            set => parlaklik = value switch //switch expression
            {
                > 100 => 100,
                < 0 => 0,
                _ => value
            };
        }

        public OtomatikAyarModu OtomatikMod
        {
            get => otomatikMod;
            set
            {
                otomatikMod = value;
                AyarlariDosyadanOku();
            }
        }

        //record kullanımı
        public record Ayarlar(int Parlaklik, Renkler Renk, bool IsikDurumu);

        //expression-bodied constructor
        public AkilliIsik() => VarsayilanAyarlariYukle();

        public AkilliIsik(bool isikDurum) => IsikDurumu = isikDurum;


        private void VarsayilanAyarlariYukle()
        {
            if (!File.Exists(dosyaYolu))
            {
                var varsayilanAyarlar = new Dictionary<OtomatikAyarModu, Ayarlar>
                {
                    { OtomatikAyarModu.Gunduz, new(70, Renkler.SogukBeyaz,true) },
                    { OtomatikAyarModu.Okuma, new(100, Renkler.DogalBeyaz,true) },
                    { OtomatikAyarModu.Sinema, new(10, Renkler.KoyuMavi,true) },
                    { OtomatikAyarModu.Gece, new(30, Renkler.SicakBeyaz,true) }
                };

                using var sw = new StreamWriter(dosyaYolu);

                foreach (var ayar in varsayilanAyarlar)
                {
                    sw.WriteLine($"{ayar.Key};{ayar.Value.Parlaklik};{ayar.Value.Renk};{ayar.Value.IsikDurumu}");
                }

                Console.WriteLine("Ayarlar dosyası oluşturuldu");
            }
        }

        private void AyarlariDosyadanOku()
        {
            if (!File.Exists(dosyaYolu)) return;

            var satirlar = File.ReadAllLines(dosyaYolu);

            foreach (var satir in satirlar)
            {
                var parcalar = satir.Split(';');
                if (parcalar.Length == 4 && Enum.TryParse(parcalar[0], out OtomatikAyarModu mod) && mod == otomatikMod)
                {
                    Parlaklik = int.Parse(parcalar[1]);
                    Renk = Enum.Parse<Renkler>(parcalar[2]);
                    IsikDurumu = bool.Parse(parcalar[3]);
                    break;
                }
            }

            Console.WriteLine("Ayarlar dosyadan yüklendi");
        }

        public void AyarlariOzellestir(int yeniParlaklik, Renkler yeniRenk, bool yeniIsikDurumu)
        {
            Parlaklik = yeniParlaklik;
            Renk = yeniRenk;
            IsikDurumu = yeniIsikDurumu;
            AyarlariDosyayaKaydet();
        }

        private void AyarlariDosyayaKaydet()
        {
            var satirlar = File.ReadAllLines(dosyaYolu);
            using var sw = new StreamWriter(dosyaYolu);

            foreach (var satir in satirlar)
            {
                var parcalar = satir.Split(';');
                if (parcalar.Length == 4 && Enum.TryParse(parcalar[0], out OtomatikAyarModu mod) && mod == otomatikMod)
                {
                    sw.WriteLine($"{otomatikMod};{Parlaklik};{Renk};{IsikDurumu}");
                }
                else
                {
                    sw.WriteLine(satir);
                }
            }

            Console.WriteLine("Yeni ayarlar dosyaya kaydedildi.");
        }

        //public void OtomatikModAyarla(OtomatikAyarModu otomatikAyar)
        //{
        //    switch (otomatikAyar)
        //    {
        //        case OtomatikAyarModu.Gunduz:
        //            Parlaklik = 70;
        //            Renk = Renkler.SogukBeyaz;
        //            IsikDurumu = true;
        //            OtomatikMod = OtomatikAyarModu.Gunduz;
        //            break;
        //        case OtomatikAyarModu.Gece:
        //            Parlaklik = 30;
        //            Renk = Renkler.SicakBeyaz;
        //            IsikDurumu = true;
        //            OtomatikMod = OtomatikAyarModu.Gece;
        //            break;
        //        case OtomatikAyarModu.Sinema:
        //            Parlaklik = 10;
        //            Renk = Renkler.KoyuMavi;
        //            IsikDurumu = true;
        //            OtomatikMod = OtomatikAyarModu.Sinema;
        //            break;
        //        case OtomatikAyarModu.Okuma:
        //            Parlaklik = 100;
        //            Renk = Renkler.DogalBeyaz;
        //            IsikDurumu = true;
        //            OtomatikMod = OtomatikAyarModu.Okuma;
        //            break;
        //        default:
        //            Parlaklik = 100;
        //            Renk = Renkler.SogukBeyaz;
        //            IsikDurumu = true;
        //            break;
        //    }
        //}

        //public void IsikAyarlariniGoster() => Console.WriteLine(ToString());

        public override string ToString()
        {
            return $"Otomatik mod: {OtomatikMod}, " +
                $"Işık durumu: {(IsikDurumu ? "Açık" : "Kapalı")}," +
                $" Parlaklık: {Parlaklik}, Renk: {Renk}";
        }
    }
}
