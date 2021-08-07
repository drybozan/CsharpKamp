using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Cilek";
            string fiyati = "45";
            string aciklama = "topraktan doğal sofranıza";

            string[] meyveler = new string[] { urunAdi, fiyati, aciklama };

            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 80;
            urun1.Aciklama = "Topraktan sofranıza";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 15;
            urun2.Aciklama = "Topraktan sofranıza diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type safe--tip güveni
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------");

            }

            Console.WriteLine("------------METOTLAR-------------");

            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


        }
    }
}
