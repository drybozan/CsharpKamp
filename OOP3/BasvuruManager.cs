using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //kredi hesaplama

            /*
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla(); 
            dersem gelen tüm kredi hesaplamalarında konut krediyi hesaplamış olurum. Oysaki tüm krediler hesaplanmalı
            Bunun yerine her kredinin referansını tutan interfacem vardı onu parametre göstermeliyim.(anne-çocuk ilişkisi)
            */
            krediManager.Hesapla();
            //loglama
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) //aynı veri türünden birden fazla sayıda veri göndereceksem List kullanacam.
        { 
            // birden fazla kredinin hesabını yapacağım
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
