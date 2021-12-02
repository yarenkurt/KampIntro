using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.Stok = 3;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun1.Stok = 3;

            Urun[] urunler = new Urun[] { urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + " : " + urun.Aciklama);
                Console.WriteLine("Urun Fiyatı: "+urun.Fiyati);
                Console.WriteLine("---------------------------");
            }


            Console.WriteLine("-----------METOTLAR----------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2); 

            sepetManager.Ekle2("Elma","Yeşil ELma",12,2);
            sepetManager.Ekle2("Armut", "Sarı Armut", 10,3);
            sepetManager.Ekle2("Vişne", "Çekirdekli Vişne", 12,4);

        }
    }
}


