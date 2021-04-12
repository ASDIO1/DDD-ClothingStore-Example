using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingStore
{
    class Shirt : Clothing, IButtonUp
    {
        public string ButtonType { get; set; }
        public override void TryOn()
        {
            Console.WriteLine("Customer tries on the Shirt");
            ButtonUp();
        }
        public void ButtonUp()
        {
            Console.WriteLine("A shirt is buttoned up from the front and the sleves");
        }
    }
}
