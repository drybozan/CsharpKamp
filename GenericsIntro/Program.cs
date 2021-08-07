using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            // MyList<int> isimler2 = new MyList<int>();
            isimler.Add("derya");
            Console.WriteLine(isimler.Length);

            isimler.Add("kerem");
            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }


        }
    }
}
