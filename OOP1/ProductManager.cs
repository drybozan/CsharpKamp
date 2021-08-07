using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager:Product //iş kodları bu classta yazılır.
    {
       
        //encapsualtion -->burda elli tane ürün özelliği atamak yerine classını parametre gösteririm.
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
    }
}
