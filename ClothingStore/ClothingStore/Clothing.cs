using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingStore
{
    public enum ClothingSize
    {
        ExtraSmall,
        Small,
        Medium,
        Large,
        ExtraLarge
    }
    class Clothing : Product
    {
        public ClothingSize Size { get; set; }

        public override void TryOnProduct()
        {
            Console.WriteLine("Customer tries on the clothing");
        }
    }
}
