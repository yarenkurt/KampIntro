using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ICreditManager tasitKrediManager = new TasitKrediManager();
            ICreditManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            //  basvuruManager.BasvuruYap(ihtiyacKrediManager, new DatabaseLoggerService());

            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService>{ new DatabaseLoggerService(), new SmsLoggerService() });

            List<ICreditManager> krediler = new List<ICreditManager>(){ihtiyacKrediManager,tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmeYap(krediler);
        }
    }
}
