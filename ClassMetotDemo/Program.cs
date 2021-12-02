using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.Adi = "Yaren";
            m1.Soyadi = "Kurt";
            m1.Tc = 11111111111;
            m1.HesapNumarasi = 1234567890;

            Musteri m2 = new Musteri();
            m2.Adi = "Abdi";
            m2.Soyadi = "Kurt";
            m2.Tc = 22222222222;
            m2.HesapNumarasi = 123453890;

            Musteri m3 = new Musteri();
            m3.Adi = "Engin";
            m3.Soyadi = "Demiroğ";
            m3.Tc = 33333333333;
            m3.HesapNumarasi = 1239167890;


            Console.WriteLine("-------------EKLEME-----------");
            MusteriManager manager = new MusteriManager();
            manager.Ekle(m1);
            manager.Ekle(m2);
            manager.Ekle(m3);
            Console.WriteLine("\n -------------LİSTELEME-----------");
            Musteri[] musteriler = new Musteri[] {m1, m2, m3};
            manager.Listele(musteriler);
            Console.WriteLine("-------------SİLME-----------");
            manager.Silme(m1);
        }
    }
}
