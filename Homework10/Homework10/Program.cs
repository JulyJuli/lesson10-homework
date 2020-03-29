using System;
using System.Collections.Generic;
using System.Threading;

namespace Homework10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var products = new List<IThing>

            {
                new Bread(
                    new BaseProduct(DateTime.Now, new TimeSpan(5,0,0,0)),
                    "Bread",
                    7),
                new Orange(
                    new BaseProduct(DateTime.Now, new TimeSpan(6,0,0,0)),
                    "Orange",
                    28),
                new Yogurt(
                    new BaseProduct(DateTime.Now, new TimeSpan(10,0,0,0)),
                    "Yogurt",
                    33),
                new Banana(
                    new BaseProduct(DateTime.Now, new TimeSpan(7,0,0,0)),
                    "Banana",
                    23),
                new HandCream(new BaseProduct(DateTime.Now, new TimeSpan(20,0,0,0)),"Lambre"),
                new Paper(new BaseProduct(DateTime.Now, new TimeSpan(80,0,0,0)),"AB")

            };

            foreach (IThing product in products)
            {
                Console.WriteLine(product.ProductName + 
                    $"\nPrice:  {product.Price}; " +
                    $"ShelLife:   { product.ShelLife}\n");
            }
            var warehouse = new Warehouse();

            TimerCallback tm = new TimerCallback(CheckShelDate);
            Timer timer = new Timer(tm, 0, 0, 1000);
            Console.ReadLine();
        }
        public static void CheckShelDate(object _products)
        {
            var products = (List<IThing>)_products;

            foreach (IThing product in products)
            {
                DateTime Delete = product.CreationDate + new TimeSpan(product.ShelLife, 0, 0, 0);
                DateTime Delete2 = Delete + new TimeSpan(1, 0, 0, 0);

                product.CreationDate += new TimeSpan(1, 0, 0, 0);

                if (product.CreationDate < Delete2)
                    Console.WriteLine($"Date: {product.CreationDate}");
                else
                {
                    products.Remove(product);
                    Console.WriteLine($"Food {product.ProductName} bad and deleted\n {Delete2}");
                }
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }

    }
}