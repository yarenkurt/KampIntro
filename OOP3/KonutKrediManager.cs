using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager :ICreditManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut Kredisi Ödeme Planı Hesaplandı!");
        }

        public void BiseyYap()
        {
            throw new NotImplementedException();
        }
    }
}
