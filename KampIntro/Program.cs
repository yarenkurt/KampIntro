using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //KategoriEtiketi bir değer tutucudur.(alias)
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOranı = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış oku");
            }else if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış oku");
            }
            else
            {
                Console.WriteLine("Eşit Oku");
            }

            //if (sistemeGirisYapmisMi == true)
            //{
            //    Console.WriteLine(" Kullanıcı Ayarları butonu");
            //}
            //else
            //{
            //    Console.WriteLine(" Giriş Yap butonu");
            //}

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
