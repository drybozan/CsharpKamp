using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // T her türden tip demek,sınırlama yok
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0]; //0 elemanlı bir list oluşturur
        }

        public void Add(T item)
        {
            T[] tempArray = items; //referans numarasını tempArray e tutturuyorum,önceki verileri kaybetmemek için
            items = new T[items.Length + 1]; //dizimin eleman sayısını 1 artırdım
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // verilerini temparraydan geri alıyor
            }

            items[items.Length - 1] = item; //yukarıdan gelen itemi son boşluğa yerleştir.
        }
        public int Length //dizi uzunluğunu görürüm
        {
            get { return items.Length; }
        }
        public T[] Items//elemanları görürüm
        {
            get { return items; }
        }
    }
}
