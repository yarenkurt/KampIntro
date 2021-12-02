using System;

namespace ProductClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Sırt Çantası";
            urun1.UrunAciklamasi = "13inc Bilgisayar Sığabilen,sırt destekli sırt çantası";
            urun1.UrunMiktari = 2;
            urun1.UrunFiyati = 89.99;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "NoteBook";
            urun2.UrunAciklamasi = "13inc intel Core i5 işlemcili asus bilgisayar";
            urun2.UrunMiktari = 3;
            urun2.UrunFiyati = 7999.99;

            Urun[] urunler = new Urun[] {urun1, urun2};
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].UrunAdi + " : " + urunler[i].UrunAciklamasi);
                Console.WriteLine("Ürün Miktarı: " + urunler[i].UrunMiktari);
                Console.WriteLine("Ürün Fiyatı: " + urunler[i].UrunFiyati);
            }

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.UrunAdi + " : " + urun.UrunAciklamasi);
                Console.WriteLine("Ürün Miktarı: " + urun.UrunMiktari);
                Console.WriteLine("Ürün Fiyatı: " + urun.UrunFiyati);
            }

            int j = 0;
            while (j < urunler.Length)
            {
                Console.WriteLine(urunler[j].UrunAdi + " : " + urunler[j].UrunAciklamasi);
                Console.WriteLine("Ürün Miktarı: " + urunler[j].UrunMiktari);
                Console.WriteLine("Ürün Fiyatı: " + urunler[j].UrunFiyati);
                j++;
            }
        }
    }

    class Urun
    {
        public string UrunAdi { get; set; }
        public string UrunAciklamasi { get; set; }
        public int UrunMiktari { get; set; }
        public double UrunFiyati { get; set; }
    }
}
  

