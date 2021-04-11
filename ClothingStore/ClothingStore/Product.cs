using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingStore
{
    abstract class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }

        public void sellProduct()
        {
            // Sells the product
        }
        abstract public void TryOn(); //Every product is tried on differently 
    }
}
