using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingStore
{
    class Accesorie : Product
    {
        //public string k { get; set; }

        public override void TryOn()
        {
            Console.WriteLine("Customer tries on the accessorie");
        }
    }
}
