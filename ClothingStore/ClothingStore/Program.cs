using System;
using System.Collections;
using System.Collections.Generic;

namespace ClothingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            var someClothing = new Clothing()
            {
                Name = "Fresh pants",
                Brand = "Benetton",
                Size = ClothingSize.Medium,
                Color = "Ligh green",
                Price = 180
            };
            var niceShirt = new Shirt()
            {
                Name = "Elegant shirt",
                Brand = "Polo",
                Size = ClothingSize.Small,
                Color = "Dark red",
                ButtonType = "Mate rounded buttons",
                Price = 245
            };
            var niceTShirt = new TShirt()
            {
                Name = "Casual Tshirt",
                Brand = "Toto",
                Size = ClothingSize.ExtraLarge,
                Color = "Blue",
                NeckType = "V neck",
                Price = 100
            };
            var someAccesorie = new Accesorie()
            {
                Name = "Wooden wrist band",
                Brand = "Some brand",
                Color = "Dark brown",
                Material = "Wood",
                Price = 95
            };
            var goldenNecklace = new Necklace()
            {
                Name = "Golden fantasy necklace",
                Brand = "Jewel",
                Color = "Golden",
                Material = "Gold",
                DetailsMaterial = "Fantasy",
                Price = 300
            };

            products.Add(someClothing);
            products.Add(niceShirt);
            products.Add(niceTShirt);
            products.Add(someAccesorie);
            products.Add(goldenNecklace);

            //Polimorfism example
            var index = 0;
            foreach (Product product in products)
            {
                Console.WriteLine($"----------PRODUCT #{index} ----------");
                product.TryOn();
                Console.WriteLine();
                index++;
            }
        }
    }
}
