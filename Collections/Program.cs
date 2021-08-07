using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "engin", "kerem", "halil", "murat" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            //eleman eklemek isteyince sıkıntı yaşarım new leyip yeni bir dizi elde etmiş olurum ve önceki veriler önceki dizide kalır.
            isimler = new string[5];
            isimler[4] = "ilker";
            Console.WriteLine(isimler[4]); //ilker sonucu verir
            Console.WriteLine(isimler[0]);  //boş string [ , , , , ilker]

            //**********LIST ************
            List<string> isimler2 = new List<string> { "engin", "murat", "kerem", "halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]); //ilker
            Console.WriteLine(isimler2[0]); //engin









        }
    }
}
