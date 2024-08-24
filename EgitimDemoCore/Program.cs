//lambda expression örneği
//örnek-1: delegelerle kullanım
//Func<string, string> tersveBuyukHarfeCevir = x =>
//{
//    char[] charArray = x.ToCharArray();
//    Array.Reverse(charArray);
//    string tersMetin = new string(charArray);

//    return tersMetin.ToUpper();
//};

//Console.Write("Bir metin girin: ");
//string girilenMetin = Console.ReadLine();

//string sonuc = tersveBuyukHarfeCevir(girilenMetin);

//Console.WriteLine($"İşlenmiş metin: {sonuc}");

//örnek-2 matematiksel işlemler
Func<int,int,int> carpma = (x, y) => x * y;
int sonuc = carpma(4, 5);

//örnek-3: koşul belirleme
Func<int,bool> ciftMi = x=> x%2 == 0;
Console.WriteLine("4 çift mi? " + ciftMi(4));
Console.WriteLine("7 çift mi? " + ciftMi(7));

//örnek-4: Birden fazla işlem zincirleme
Func<int, int> ikiKatiniAl = x => x * 2;
Func<int, int> karesiniAl = x => x * x;
Func<int, int> ikiKatiniAlSonraKaresiniAl = x => karesiniAl(ikiKatiniAl(x));
Console.WriteLine(ikiKatiniAlSonraKaresiniAl(3));