using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasitKrediManager:ICreditManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Taşıt Kredisi Ödeme Planı Hesaplandı!");
        }

        public void BiseyYap()
        {
            throw new NotImplementedException();
        }
    }
}
