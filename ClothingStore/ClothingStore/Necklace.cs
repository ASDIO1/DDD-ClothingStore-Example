using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingStore
{
    class Necklace : Accesorie, IButtonUp
    {
        public string DetailsMaterial { get; set; }

        public override void TryOn()
        {
            Console.WriteLine("Customer tries on the Necklace");
            ButtonUp();
        }
        public void ButtonUp()
        {
            Console.WriteLine("A necklace is buttoned up from behind the neck");
        }
    }
}
