using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmeni = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.KursunEgitmeni = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;




            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursunEgitmeni);

            Kurs[] kurslar = new Kurs[]{kurs1, kurs2, kurs3};

            foreach (var kurs in kurslar)
            {
               // Console.WriteLine(kurs.KursAdi + " : " + kurs.KursunEgitmeni);
            }

            //for (int i = 0; i < kurslar.Length; i++)
            //{
            //    Console.WriteLine(kurslar[i].KursAdi + " : " + kurslar[i].KursunEgitmeni);
            //}

            int i = 0;
            while (i < kurslar.Length)
            {
                Console.WriteLine(kurslar[i].KursAdi + " : " + kurslar[i].KursunEgitmeni);
                i++;
            }

            //Console.WriteLine(kurs1.KursAdi);
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
