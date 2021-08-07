using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun) //ne eklemek istediğini parametre olarak belirt!
        {
            Console.WriteLine("Sepete eklendi : " + urun.Adi);
        }
    }
}
