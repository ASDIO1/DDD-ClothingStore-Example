using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingStore
{
    class Necklace : Accesorie, IButtonUp
    {
        public void ButtonUp()
        {
            Console.WriteLine("A necklace is buttoned up from behind the neck");
        }
    }
}
