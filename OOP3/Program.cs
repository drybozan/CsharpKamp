using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ihtiyacKrediManager.Hesapla();

            IhtiyacKrediManager ihtiyacKrediManager2 = new IhtiyacKrediManager();  //ikisi de aynı işlevi görür.Çünkü interface de implement edilidği classın referans numarsını tuttar.
            ihtiyacKrediManager2.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();

            Console.WriteLine("----------------method injection&&Loglama---------------------");

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            databaseLoggerService.Log();

            ILoggerService fileLoggerService = new FileLoggerService();
            fileLoggerService.Log();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() }; //birden fazla loglama yapmak istiyorum


            BasvuruManager basvuruManager = new BasvuruManager(); //referansı aldık
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), loggers); //istediğim krediyi yollayabilirim method injection sayesinde
            basvuruManager.BasvuruYap(new IhtiyacKrediManager(), loggers);
            basvuruManager.BasvuruYap(new KonutKrediManager(), loggers);

            Console.WriteLine("--------------liste şeklinde veri gönderme------------------------");
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager }; //birden fazla kredimi hesaplatmaya gönderceğim

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
