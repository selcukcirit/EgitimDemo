using EgitimDemo.Inheritance;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static EgitimDemo.CustomExceptions;

namespace EgitimDemo
{
    public partial class Form1 : Form
    {
        enum HaftaninGunleri
        {
            Pazartesi,
            Sali,
            Carsamba,
            Persembe,
            Cuma,
            Cumartesi,
            Pazar
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 5;
            long y;
            y = x;

            int z;
            z = (int)y;

            int sonuc;
            if (int.TryParse(textBox1.Text, out sonuc))
            {
                MessageBox.Show(sonuc.ToString());
            }
            else
            {
                MessageBox.Show("Girdiğiniz rakam hatalı");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int yil;
            if (int.TryParse(textBox1.Text, out yil))
            {
                MessageBox.Show((DateTime.Now.Year - yil).ToString());
            }
            else
            {
                MessageBox.Show("Girdiğiniz rakam hatalı");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double tutar = 100;

            MessageBox.Show("Const komisyon tutarı: " + (ParaTransferi.Komisyon.komisyonOraniConst / 100d * tutar).ToString());
            MessageBox.Show("ReadOnly komisyon tutarı: " + (ParaTransferi.Komisyon.komisyonOraniReadOnly / 100d * tutar).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x = 0;
            //x = x + 8;
            x += 8;
            x *= 5;

            x++;
            ++x;

            int sayi = 5;
            //int sonuc = sayi++ * 5 + (10 + 6 / 2);

            //int sonuc = sayi++ * 5 + (10 + 3);
            //int sonuc = sayi++ * 5 + 13;
            //int sonuc = 25 + 13;
            //int sonuc = 38;
            //sayi = 6;

            int sonuc = ++sayi * 5 + (10 + 6 / 2);
            //int sonuc = ++sayi * 5 + (10 + 6 / 2);
            //sayi = 6;
            //int sonuc = ++sayi * 5 + (10 + 3);
            //int sonuc = ++sayi * 5 + 13;
            //int sonuc = ++sayi * 5 + 13;
            //int sonuc = 30 + 13;
            //int sonuc = 43;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int currentYear = DateTime.Now.Year;
            int sonuc;

            //if (currentYear % 2 == 0)
            //{
            //    sonuc = ParaTransferi.Komisyon.komisyonOraniReadOnly;
            //}
            //else
            //{
            //    sonuc = ParaTransferi.Komisyon.komisyonOraniReadOnly + 1;
            //}

            sonuc = (currentYear % 2 == 0) ? ParaTransferi.Komisyon.komisyonOraniReadOnly
                : ((currentYear == 2025) ? 5 : ParaTransferi.Komisyon.komisyonOraniReadOnly + 1);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[] dizi = new int[6];
            int[] dizi2 = { 1, 2, 3, 4, 5, 6 };

            int[] ilkDizi = { 19, 2, 3, 35, 7, 21, 9 };

            int[] sonDizi = new int[ilkDizi.Length + 3];

            // ilkDizi.CopyTo(sonDizi, 4);

            Array.Copy(ilkDizi, 3, sonDizi, 4, 4);

            Array.Sort(sonDizi);
            Array.Reverse(sonDizi);

            string[] stringDizi = { "ali", "veli", "ayşe", "ahmet", "ayşe" };
            bool[] boolDizi = { true, false, false, true, true };

            //for (int i = 0; i < stringDizi.Length; i++)
            //{
            //    MessageBox.Show(stringDizi[i]);
            //}
            //foreach (var item in stringDizi)
            //{
            //    MessageBox.Show(item);
            //}

            int arananIndex = Array.IndexOf(stringDizi, "ayşe");

            if (arananIndex > -1)
            {
                stringDizi[arananIndex] = "yasemin";
            }


            int[,] ikiBoyutluDizi = { { 1, 2 }, { 2, 3 }, { 3, 4 }, { 4, 5 }, { 5, 6 }, { 6, 7 }, { 7, 8 } };

            int[,,] ucBoyutluDizi = { { { 1, 2 }, { 3, 4 } },
                                    { { 5, 6 }, { 7, 8 } },
                                    { { 9, 10 }, { 11, 12 } } };

            MessageBox.Show(ikiBoyutluDizi.Rank.ToString());

            int[,,] ucBoyutlu2 = new int[3, 2, 2];
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int daireNumarasi;

            Random rnd = new Random();
            daireNumarasi = 1;
            //rnd.Next(1, 6);

            switch (daireNumarasi)
            {
                case 1:

                case 2:
                    MessageBox.Show("Serhat");
                    break;
                case 3:

                case 4:
                    MessageBox.Show("Mehmet");
                    break;
                case 5:
                    MessageBox.Show("Merve");
                    break;
                default:
                    MessageBox.Show("Kapıcı");
                    break;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //c# 8 ile gelen yeni switch expression örneği
            //var (a, b, islem) = (10, 6, "+");

            //var sonuc = islem switch
            //{
            //    "+" => a + b,
            //    "-" => a - b,
            //    _ => a * b
            //};


            //var deger = 30;

            //int sonuc2 = deger switch
            //{
            //    _ when deger > 10 => 0,
            //    _ when deger <= 10 => 1
            //};
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double tutar = 100D;
            double faizOrani = 22.5D;

            double hedefTutar = 1000D;

            int yil = 0;

            while (tutar <= hedefTutar)
            {
                tutar *= (faizOrani / 100) + 1;
                yil++;
            }

            //MessageBox.Show("Toplam yıl: " + yil + " Toplam tutar: " + tutar);
            MessageBox.Show($"Toplam yıl: {yil} Toplam tutar: {tutar}");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ParaTransferi.Havale havale = new ParaTransferi.Havale();

            ParaTransferi.Havale havale2 = new ParaTransferi.Havale(30);

            havale.Gonder(10, 85);

            havale2.Gonder(10.85m);
        }

        int Topla(params string[] rakamlar)
        {
            int toplam = 0;
            foreach (var rakamString in rakamlar)
            {
                int rakamInt = 0;
                if (int.TryParse(rakamString, out rakamInt))
                {
                    toplam += rakamInt;
                }
            }

            return toplam;
        }



        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Topla(txtToplanacakRakamlar.Text.Split(',')).ToString());
        }

        void DosyaIslemi()
        {
            FileStream file = null;
            try
            {
                //using( var sw= new StreamWriter("./test.txt"))
                //{
                //    sw.WriteLine("Merhaba");
                //}


                FileInfo fileInfo = new FileInfo("C:/abc/dosya.txt");

                file = fileInfo.OpenWrite();
                file.WriteByte(0xF);
            }

            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Dosya bulunamadı");
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show("Klasör bulunamadı");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Dosya işlemlerinde hata oluştu");
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Dosyaya erişim yetkisi yok");
            }


            catch (Exception)
            {
                throw;
            }
            finally
            {
                file?.Close();
            }

        }

        int DegeriVer(int[] dizi, int index)
        {
            int sonuc = 0;
            try
            {
                sonuc = dizi[index];
            }
            catch (IndexOutOfRangeException ex) when (index < 0)
            {
                throw new IndexSifirdanKucukException("Erişilmek istenen index sıfırdan küçük olmamalı", ex);
                //sonuc = 0;
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new IndexDizininBoyutundanBuyukException("Erişilmek istenen index dizinin boyutundan daha büyük", ex);
                //sonuc = 0;
            }
            catch (Exception ex)
            {
                sonuc = -999;
            }
            finally
            {

            }

            return sonuc;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                int[] dizi = { 3, 8, 12, 9, 4, 1 };
                MessageBox.Show(DegeriVer(dizi, (int)numericUpDown1.Value).ToString());
            }
            catch (Exception ex) when (LogException.Logla(ex))
            {
                MessageBox.Show(ex.Message);
            }

            //DosyaIslemi();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            HaftaninGunleri secilenGun;
            if (Enum.TryParse(comboBox1.SelectedItem.ToString(), out secilenGun))
            {
                switch (secilenGun)
                {
                    case HaftaninGunleri.Pazartesi:
                    case HaftaninGunleri.Sali:
                    case HaftaninGunleri.Carsamba:
                    case HaftaninGunleri.Persembe:
                    case HaftaninGunleri.Cuma:
                        MessageBox.Show($"Seçilen gün haftaiçi: {secilenGun}");
                        break;
                    case HaftaninGunleri.Cumartesi:
                    case HaftaninGunleri.Pazar:
                        MessageBox.Show($"Seçilen gün haftasonu: {secilenGun}");
                        break;
                    default:
                        MessageBox.Show("Hatalı bir değer girdiniz");
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(HaftaninGunleri));
            cmbCinsiyet.DataSource = Enum.GetValues(typeof(Ogrenci.Cinsiyet));
            cmbFakulte.DataSource = Enum.GetValues(typeof(Ogrenci.Fakulte));
            cmbPisirmeYontemleri.Items.Add("Kızartma");
            cmbPisirmeYontemleri.Items.Add("Fırında Pişirme");
            cmbPisirmeYontemleri.Items.Add("Buharda Pişirme");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.adiSoyadi = "Selçuk Cirit";
            ogrenci.fakulte = Ogrenci.Fakulte.Muhendislik;

            //ogrenci.kimlikBilgileri.SiraNo = 102;
            ogrenci.kimlikBilgileri = new Ogrenci.KimlikBilgileri(1, 45, 234, DateTime.Now, "34324324234");

            Ogrenci ogrenci2 = new Ogrenci("Ahmet", Ogrenci.Cinsiyet.Erkek);

            Ogrenci ogrenci3 = new Ogrenci("Fatma");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Ogrenci ogrenci = new Ogrenci();

                if (!Enum.TryParse(cmbFakulte.SelectedItem.ToString(), out ogrenci.fakulte))
                {
                    MessageBox.Show("Fakülte hatalı");
                }

                if (!Enum.TryParse(cmbCinsiyet.SelectedItem.ToString(), out ogrenci.cinsiyet))
                {
                    MessageBox.Show("Cinsiyet hatalı");
                }

                ogrenci.YasEkle((int)nmrDogumYili.Value);

                ogrenci.adiSoyadi = txtAdSoyad.Text;
                ogrenci.TCKN = txtTCKN.Text;

                Ogrenci.OgrenciEkle();
                MessageBox.Show($"Yeni Öğrenci Sayısı: {Ogrenci.ogrenciSayisi}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Öğrenci kaydedilirken hata alındı. Hata detayı: {ex.Message}");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();

            int? x = 5;
            x = null;

            if (x != null)
            {

            }

            if (x.HasValue)
            {
            }

            //null coalescing operator
            Ogrenci ogrenci1 = ogrenci ?? new Ogrenci();
            //ogrenci1 = ogrenci != null ? ogrenci : new Ogrenci();

            //if (ogrenci != null)
            //{
            //    ogrenci1 = ogrenci;
            //}
            //else
            //{
            //    ogrenci1 = new Ogrenci();
            //}


            //null coalescing assignment operator
            //ogrenci1 ??= new Ogrenci();
            //if (ogrenci1 is null)
            //{
            //    ogrenci1 = new Ogrenci();
            //}

            Ogrenci ogrenci2 = new Ogrenci();
            Ogrenci ogrenci3 = ogrenci ?? ogrenci1 ?? ogrenci2;

            //ogrenci3 ??= ogrenci2 ??= ogrenci1;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ParaTransferi.Havale banka = new ParaTransferi.Havale();
            banka.Gonder(100);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.yasi = 22;
            ogrenci.adiSoyadi = "Ahmet Mehmet";
            ogrenci.cinsiyet = Ogrenci.Cinsiyet.Erkek;
            ogrenci.TCKN = "11122334455";

            MessageBox.Show(ogrenci.Yaslandir(3).ToString());

            int x = 5;
            x = x.Arttir();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            EnBeyazYakaliStajer enBeyazYakaliStajer = new EnBeyazYakaliStajer("Selçuk Cirit");


            //var calisanlar = new Calisan[] //List<Calisan>
            //{
            //    //new Calisan(),
            //    new BeyazYakali(),
            //    //new MaviYakali(),
            //    //new Yonetici(),
            //    new BeyazYakaliStajer(),
            //    new EnBeyazYakaliStajer()
            //};

            //foreach (var calisan in calisanlar)
            //{
            //    calisan.MasrafFormuDoldur();
            //    calisan.PrimHesapla();
            //}

            //Calisan calisan = new Calisan();
            //calisan.PrimHesapla();

            //BeyazYakali beyazYakali = new BeyazYakali();
            //beyazYakali.PrimHesapla();
            //beyazYakali.MasrafFormuDoldur();

            //MaviYakali maviYakali = new MaviYakali();
            //maviYakali.PrimHesapla();
            //maviYakali.MasrafFormuDoldur();

            //Yonetici yonetici = new Yonetici();
            //yonetici.PrimHesapla();

            //beyazYakali = calisan as BeyazYakali;
            //calisan = maviYakali;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                var arananString = txtIndexer.Text;

                Ogrenciler ogrenciler = new Ogrenciler();

                var bulunanOgrenci = ogrenciler[arananString];

                MessageBox.Show($"Bulunan Öğrenci: {bulunanOgrenci.adiSoyadi}; {bulunanOgrenci.fakulte}; " +
                    $"{bulunanOgrenci.cinsiyet}; {bulunanOgrenci.yasi}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluştu: {ex.Message}");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.adiSoyadi = "Selçuk Cirit";
            ogrenci.fakulte = Ogrenci.Fakulte.Ziraat;
            ogrenci.yasi = 30;

            ogrenci = ogrenci + 5;

            ogrenci -= 3;

            ogrenci = 50 - ogrenci;

            ogrenci = 2 + ogrenci;
        }

        public delegate void PisirmeYontemi(string yemek);

        private PisirmeYontemi pisirmeYontemi;

        public void Kizartma(string yemek)
        {

            if (lstPismeDurumlari.InvokeRequired)
            {
                lstPismeDurumlari.BeginInvoke((MethodInvoker)delegate
                {
                    lstPismeDurumlari.Items.Add($"{DateTime.Now.Minute}:{DateTime.Now.Second} {yemek} kızartılıyor.");
                });
            }
            else
            {
                lstPismeDurumlari.Items.Add($"{DateTime.Now.Minute}:{DateTime.Now.Second} {yemek} kızartılıyor.");
            }

            //MessageBox.Show($"{yemek} kızartılıyor...");
            System.Threading.Thread.Sleep(4000);
        }

        public void FirindaPisme(string yemek)
        {
            if (lstPismeDurumlari.InvokeRequired)
            {
                lstPismeDurumlari.BeginInvoke((MethodInvoker)delegate
                {
                    lstPismeDurumlari.Items.Add($"{DateTime.Now.Minute}:{DateTime.Now.Second} {yemek} fırında pişiriliyor.");
                });
            }
            else
            {
                lstPismeDurumlari.Items.Add($"{DateTime.Now.Minute}:{DateTime.Now.Second} {yemek} fırında pişiriliyor.");
            }

            //MessageBox.Show($"{yemek} fırında pişiriliyor...");
            System.Threading.Thread.Sleep(10000);
        }

        public void BuhardaPisme(string yemek)
        {
            //MessageBox.Show($"{yemek} buharda pişiriliyor...");
            if (lstPismeDurumlari.InvokeRequired)
            {
                lstPismeDurumlari.BeginInvoke((MethodInvoker)delegate
                {
                    lstPismeDurumlari.Items.Add($"{DateTime.Now.Minute}:{DateTime.Now.Second} {yemek} buharda pişiriliyor.");
                });
            }
            else
            {
                lstPismeDurumlari.Items.Add($"{DateTime.Now.Minute}:{DateTime.Now.Second} {yemek} buharda pişiriliyor.");
            }

            System.Threading.Thread.Sleep(8000);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            PisirmeYontemi pisir = null;
            pisir += BuhardaPisme;
            pisir += FirindaPisme;
            pisir += new PisirmeYontemi(Kizartma);

            pisir -= FirindaPisme;

            //anonymous method
            pisir += new PisirmeYontemi(delegate (string yemek)
            {
                if (lstPismeDurumlari.InvokeRequired)
                {
                    lstPismeDurumlari.BeginInvoke((MethodInvoker)delegate
                    {
                        lstPismeDurumlari.Items.Add($"{DateTime.Now.Minute}:{DateTime.Now.Second} {yemek} haşlanıyor.");
                    });
                }
                else
                {
                    lstPismeDurumlari.Items.Add($"{DateTime.Now.Minute}:{DateTime.Now.Second} {yemek} haşlanıyor.");
                }

                System.Threading.Thread.Sleep(8000);
            });

            ////senkron çağırma
            //pisir("Patates");

            foreach (var item in pisir.GetInvocationList())
            {
                var yontem = (PisirmeYontemi)item;
                yontem?.BeginInvoke("Patates", PisirmeTamamlandi, yontem);
            }

        }

        private void btnPisirmeYontemiEkle_Click(object sender, EventArgs e)
        {
            var secilenYontem = cmbPisirmeYontemleri.SelectedItem.ToString();

            if (!lstSecilenPisirmeYontemleri.Items.Contains(secilenYontem))
            {
                lstSecilenPisirmeYontemleri.Items.Add(secilenYontem);

                switch (secilenYontem)
                {
                    case "Kızartma":
                        pisirmeYontemi += Kizartma;
                        break;
                    case "Fırında Pişirme":
                        pisirmeYontemi += FirindaPisme;
                        break;
                    case "Buharda Pişirme":
                        pisirmeYontemi += BuhardaPisme;
                        break;
                }
            }

        }

        private void btnPisirmeYontemiCikart_Click(object sender, EventArgs e)
        {
            var secilenYontem = cmbPisirmeYontemleri.SelectedItem.ToString();

            if (lstSecilenPisirmeYontemleri.Items.Contains(secilenYontem))
            {
                lstSecilenPisirmeYontemleri.Items.Remove(secilenYontem);

                switch (secilenYontem)
                {
                    case "Kızartma":
                        pisirmeYontemi -= Kizartma;
                        break;
                    case "Fırında Pişirme":
                        pisirmeYontemi -= FirindaPisme;
                        break;
                    case "Buharda Pişirme":
                        pisirmeYontemi -= BuhardaPisme;
                        break;
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            lstPismeDurumlari.Items.Clear();
            var yemek = txtYemek.Text;

            //senkron çalıştırma
            ////pisirmeYontemi(yemek);
            //pisirmeYontemi?.Invoke(yemek);

            //asenkron çalıştırma
            foreach (var item in pisirmeYontemi.GetInvocationList())
            {
                var yontem = (PisirmeYontemi)item;
                yontem?.BeginInvoke(yemek, PisirmeTamamlandi, yontem);
            }
        }

        private void PisirmeTamamlandi(IAsyncResult ar)
        {
            var yontem = (PisirmeYontemi)ar.AsyncState;
            yontem.EndInvoke(ar);

            if (lstPismeDurumlari.InvokeRequired)
            {
                lstPismeDurumlari.BeginInvoke((MethodInvoker)delegate
                {
                    lstPismeDurumlari.Items.Add($"{DateTime.Now.Minute}:{DateTime.Now.Second} {yontem.Method.Name} işlemi tamamlandı.");
                });
            }
            else
            {
                lstPismeDurumlari.Items.Add($"{DateTime.Now.Minute}:{DateTime.Now.Second} {yontem.Method.Name} işlemi tamamlandı.");
            }
            //MessageBox.Show($"{yontem.Method.Name} işlemi tamamlandı.");
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList()
            {
                3, 5, 67, false, "Selçuk", 6.8m, new Ogrenci()
            };

            al.Add(DateTime.Now);
            al.Add(9);

            al.Remove(5);
            al.RemoveAt(3);

            int index = al.IndexOf(6.8m);

            foreach (var item in al)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            SortedList sl = new SortedList();
            sl.Add("ad", "selçuk");
            sl.Add("5", DateTime.Now);
            sl.Add("c", "cirit");

            if (sl.ContainsValue("ahmet"))
            {
                MessageBox.Show("ahmet zaten var");
            }
            else
            {
                sl.Add("a", "ahmet");
            }
            MessageBox.Show(sl["c"].ToString());

            foreach (var key in sl.Keys)
            {
                listBox1.Items.Add($"{key}: {sl[key]}");
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Hashtable sl = new Hashtable();
            sl.Add("ad", "selçuk");
            sl.Add("5", DateTime.Now);
            sl.Add("c", "cirit");

            if (sl.ContainsValue("ahmet"))
            {
                MessageBox.Show("ahmet zaten var");
            }
            else
            {
                sl.Add("a", "ahmet");
            }
            MessageBox.Show(sl["c"].ToString());

            foreach (var key in sl.Keys)
            {
                listBox1.Items.Add($"{key}: {sl[key]}");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);

            var cikarilan = (int)q.Dequeue();
            MessageBox.Show(cikarilan.ToString());

            foreach (var item in q)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);

            var cikarilan = (int)s.Pop();
            MessageBox.Show(cikarilan.ToString());

            foreach (var item in s)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci()
                {
                    adiSoyadi ="Emre",
                    cinsiyet =  Ogrenci.Cinsiyet.Erkek,
                    yasi = 26,
                    fakulte = Ogrenci.Fakulte.FenEdebiyat
                },
                new Ogrenci()
                {
                    adiSoyadi ="Merve",
                    cinsiyet =  Ogrenci.Cinsiyet.Kadın,
                    yasi = 28,
                    fakulte = Ogrenci.Fakulte.Ziraat
                },
                new Ogrenci()
                {
                    adiSoyadi ="Ali",
                    cinsiyet =  Ogrenci.Cinsiyet.Erkek,
                    yasi = 34,
                    fakulte = Ogrenci.Fakulte.Tip
                }
            };

            ogrenciler.Add(new Ogrenci()
            {
                adiSoyadi = "Ahmet",
                cinsiyet = Ogrenci.Cinsiyet.Erkek,
                yasi = 38,
                fakulte = Ogrenci.Fakulte.Muhendislik
            });

            Ogrenci ogrenci = new Ogrenci()
            {
                adiSoyadi = "Ayşe",
                cinsiyet = Ogrenci.Cinsiyet.Kadın,
                yasi = 22,
                fakulte = Ogrenci.Fakulte.Muhendislik
            };

            ogrenciler.Add(ogrenci);

            var ogrenciIsimleri = ogrenciler.Select(x => x.adiSoyadi).ToList();

            var anonimTip = ogrenciler.Select(x => new
            {
                Adi = x.adiSoyadi,
                Yas = x.yasi,
                Cinsiyet = x.cinsiyet
            });

            var muhendislikOgrencileri = ogrenciler.Where(x => x.fakulte == Ogrenci.Fakulte.Muhendislik && x.yasi > 26)
                .OrderByDescending(x => x.yasi)
                .ThenBy(x => x.adiSoyadi)
                .Select(x => new
                {
                    Adi = x.adiSoyadi,
                    Yas = x.yasi,
                    Fakulte = x.fakulte
                })
                //.FirstOrDefault();
                //.SingleOrDefault()
                .ToList();

            var ortalamaYas = ogrenciler.Average(x => x.yasi);
            var enKucukYas = ogrenciler.Min(x => x.yasi);
            var enBuyukYas = ogrenciler.Max(x => x.yasi);
        }

        delegate string IslemYap<T>(T p1, T p2);

        public string RakamTopla(int rakam1, int rakam2)
        {
            return (rakam1 + rakam2).ToString();
        }

        public string RakamTopla(double rakam1, double rakam2)
        {
            return (rakam1 + rakam2).ToString();
        }

        void CiktiAl<T>(T cikti)
        {
            MessageBox.Show(cikti.ToString());
        }

        private void button30_Click(object sender, EventArgs e)
        {
            //IslemYap<double> islemYap = null;

            //islemYap += RakamTopla;

            //MessageBox.Show(islemYap(3d, 5d));

            CiktiAl("Merhaba");

            CiktiAl(5);

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.adiSoyadi = "Selçuk Cirit";
            ogrenci.cinsiyet = Ogrenci.Cinsiyet.Erkek;
            ogrenci.fakulte = Ogrenci.Fakulte.Muhendislik;
            ogrenci.yasi = 30;

            CiktiAl(ogrenci);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            BeyazYakali<int> beyazYakali = new BeyazYakali<int>();
            beyazYakali.SicilNo = 21321;

            BeyazYakali<string> beyazYakali1 = new BeyazYakali<string>();
            beyazYakali1.SicilNo = "adadasd";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            dynamic x;
            x = "fss";
            int y = x + 5;
        }
    }
}
