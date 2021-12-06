using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager:ICreditManager
    {
        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı Hesaplandı!");
        }

        public void BiseyYap()
        {
            throw new NotImplementedException();
        }
    }
}
