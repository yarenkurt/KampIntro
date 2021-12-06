using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(ICreditManager creditManager,List< ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //
            creditManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
        }

        public void KrediOnBilgilendirmeYap(List<ICreditManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
