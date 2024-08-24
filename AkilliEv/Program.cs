
using AkilliEv;

AkilliIsik isik = new() { OdaIsikSeviyesi = 75 };
//Target-typed new expression kullanımı

//AkilliIsik isik = new AkilliIsik
//{
//    IsikDurumu = true,
//    OdaIsikSeviyesi = 67
//};

//AkilliIsik isik = new AkilliIsik(true)
//{
//    IsikDurumu = true,
//    OdaIsikSeviyesi = 67
//};

//AkilliIsik isik = new AkilliIsik();
//isik.IsikDurumu = true;

//isik.OtomatikModAyarla(AkilliIsik.OtomatikAyarModu.Gunduz);
isik.OtomatikMod = AkilliIsik.OtomatikAyarModu.Gunduz;
Console.WriteLine(isik.ToString());
//isik.IsikAyarlariniGoster();

//isik.OtomatikModAyarla(AkilliIsik.OtomatikAyarModu.Okuma);
isik.OtomatikMod = AkilliIsik.OtomatikAyarModu.Okuma;
Console.WriteLine(isik.ToString());

//isik.OtomatikModAyarla(AkilliIsik.OtomatikAyarModu.Sinema); 
isik.OtomatikMod = AkilliIsik.OtomatikAyarModu.Sinema;

Console.WriteLine(isik.ToString());

//isik.OtomatikModAyarla(AkilliIsik.OtomatikAyarModu.Gece);
isik.OtomatikMod = AkilliIsik.OtomatikAyarModu.Gece;
Console.WriteLine(isik.ToString());

isik.AyarlariOzellestir(50, AkilliIsik.Renkler.HafifSari, true);