using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingStore
{
    class Shirt : Clothing, IButtonUp
    {
        public void ButtonUp()
        {
            Console.WriteLine("A shirt is buttoned up from the front and the sleves");
        }
    }
}
