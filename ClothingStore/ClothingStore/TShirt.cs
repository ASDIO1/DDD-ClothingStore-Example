using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingStore
{
    class TShirt : Clothing
    {
        public string NeckType { get; set; }

        public override void TryOn()
        {
            Console.WriteLine("Customer tries on the T-Shirt");
        }
    }
}
