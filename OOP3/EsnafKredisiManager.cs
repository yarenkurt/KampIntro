using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafKredisiManager : ICreditManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Esnaf Kredisi Ödeme Planı Hesaplandı!");
        }

        public void BiseyYap()
        {
            throw new NotImplementedException();
        }
    }
}
