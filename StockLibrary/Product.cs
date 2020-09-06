using System;
using System.Collections.Generic;

namespace StockLibrary
{
    public class Stock
    {
        private static int volume = 5;

        private static List<Product> stock = new List<Product>(new Product[volume]);

        public static void Add(Product product)
        {
            stock.Add(product);
        }

        public static Product[] GetProdcuts()
        {
            return stock.ToArray();
        }
    }
    public class Product
    {
        public Product(string name, decimal price, string deliveryDate)
        {
            this.Name = name;
            this.Price = price;
            this.deliveryDate = deliveryDate;
            this.ExpiryDate = ExpiryDate;
        }

        private string name;

        private decimal price;
            
        private string deliveryDate;

        private DateTime expirydate;

        public string Name { get { return name; } set { name = value; } }
        public decimal Price { get { return price; } set { price = value; } }
        public string DeliveryDate { get { return deliveryDate; } set { deliveryDate = value; } }
    
        public DateTime ExpiryDate
        {
            get
            {
                if (name == "sand")
                {

                    return expirydate = DateTime.Parse(deliveryDate).AddDays(5);
                }
                if (name == "wire")
                {

                    return expirydate = DateTime.Parse(deliveryDate).AddDays(3);
                }

                if (name == "iron")
                {
                    return expirydate = DateTime.Parse(deliveryDate).AddDays(10);
                }


                return expirydate;
            }
            set
            {
                if (DateTime.Now > ExpiryDate)
                {
                    Console.WriteLine($"Product has expired");
                }

                else
                {
                    expirydate = value;
                }

            }

        }
        public override string ToString()
        {
            return $"Name:{this.Name}\nPrice: {this.Price}\nDelivery Date: {this.deliveryDate}\nExpiration Date {ExpiryDate}";
        }

        public string ExpirationDateEmulator(string date)
        {
            string expiration = "";

            if (Name == "sand")
            {
                expiration = (DateTime.Parse(date).AddDays(5)).ToString();
            }
            else if (Name == "wire")
            {
                expiration = (DateTime.Parse(date).AddDays(3)).ToString();
            }
            else if (Name == "iron")
            {
                expiration = (DateTime.Parse(date).AddDays(10)).ToString();
            }

            return expiration;
        }

    }


}
