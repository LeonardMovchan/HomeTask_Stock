using System;
using StockLibrary;

namespace HomeTask_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product = new Product("wire", 22.44m, "2020,08,30");
            Console.WriteLine($"Name: {product.Name}\nPrice: {product.Price}\nDelivery Date: {product.DeliveryDate}");

            Console.WriteLine();

            Product product2 = new Product("sand", 33.55m, "2020,08,23");
            Console.WriteLine($"Name: {product2.Name}\nPrice: {product2.Price}\nDelivery Date: {product2.DeliveryDate}");

            Console.WriteLine();

            Product product3 = new Product("iron", 120, "2020,08,25");
            Console.WriteLine($"Name: {product3.Name}\nPrice: {product3.Price}\nDelivery Date: {product3.DeliveryDate}");
          
            Stock.Add(product);
            Stock.Add(product2);
            Stock.Add(product3);
            
            Console.WriteLine();

            string expirationDate = product.ExpirationDateEmulator("2020,08,29");
            Console.WriteLine($"The expiration date of the {product.Name} is {expirationDate}");

            expirationDate = product2.ExpirationDateEmulator("2020,01,29");
            Console.WriteLine($"The expiration date of the {product2.Name} is {expirationDate}");

            expirationDate = product3.ExpirationDateEmulator("2019/02/22");
            Console.WriteLine($"The expiration date of the {product3.Name} is {expirationDate}");

            foreach (var item in Stock.GetProdcuts())
            {
                Console.WriteLine($"\n{item}");
            }

            Console.ReadKey();

        }
    }
}
