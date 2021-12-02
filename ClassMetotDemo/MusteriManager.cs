using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi+musteri.Soyadi+" isimli müşteri sisteme eklenmiştir.");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.HesapNumarasi + " numaralı hesaba ait bilgiler: \n"+
                "Müşteri Adı: "+ musteri.Adi + "\n" +
                "Müşteri Soyadı: "+ musteri.Soyadi + "\n" +
                "Müşteri TC'si: " + musteri.Tc + "\n");
            }
            
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + musteri.Soyadi + " isimli müşteri sistemden silinmiştir.");
        }
    }
}
