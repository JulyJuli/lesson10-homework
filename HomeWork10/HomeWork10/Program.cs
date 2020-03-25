using System;
using System.Collections.Generic;
using MarketWarehouseLibrary;

namespace HomeWork10
{
    class Program
    {
        static void Main(string[] args)
        {

            var products = new List<Product>
            { new Product("Milk",34.0,new BaseProduct(new DateTime(2020, 04,12)),15),
            new Product("Bread",25.50,new BaseProduct(new DateTime(2020, 03,26)),10),
            new Product("Flour",18.0,new BaseProduct(new DateTime(2020, 04,20)),22),
            new Product("Cookies",53.0,new BaseProduct(new DateTime(2020, 04,12)),8),
            new Product("Yogurt",11.20,new BaseProduct(new DateTime(2020, 03,30)),9),
            new Product("Buckwheat",22.0,new BaseProduct(new DateTime(2020, 05,22)),10),
            new Product("Sugar",44.0,new BaseProduct(new DateTime(2020, 04,15)),19),
            new Product("Cheese",55.0,new BaseProduct(new DateTime(2020, 03,28)),16),
            new Product("Butter",32.10,new BaseProduct(new DateTime(2020, 03,28)),13),
            new Product("Icecream",11.10,new BaseProduct(new DateTime(2020, 04,14)),18)
            };

            foreach (var item in products)
            {
                Console.WriteLine(item.ToString());
            }

            var warehouse = new Warehouse();


            Console.Write($"\nPlease, enter capacity of the warehouse (items). Min capacity: 40 items, Max capacity:150 items:");

            string warehouseCapacityString = Console.ReadLine();
            Warehouse.warehouseCapacity = ValidationInput(warehouseCapacityString);

            Warehouse.Distribusion(warehouse, products, Warehouse.warehouseCapacity);
            Console.Clear();
            Console.WriteLine($"The state of the warehouse on {DateTime.Now.ToShortDateString()}");
            warehouse.PrintInfo();

            Console.WriteLine("\nPlease, enter date of day to view warehouse status (Format of date: DD.MM.YYYY)\n");
            string inputDate = Console.ReadLine();
            DateTime currentDate = DateValidation(inputDate);

            List<Product> expiredItems = new List<Product>();
            Warehouse.WerificationOfExpiredGoods(ref warehouse, currentDate, out expiredItems);

            Console.WriteLine($"Warehouse status on the selected day {currentDate.ToShortDateString()}");
            warehouse.PrintInfo();

            Console.WriteLine("\nDiscarded goods:\n");
            foreach (var item in expiredItems)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }

        public static int ValidationInput(string input)
        {
            int minValueOfCapacity = 40;
            int maxValueOfCapacity = 150;
            int number;
            while (!int.TryParse(input, out number) || number < 0||number< minValueOfCapacity || number> maxValueOfCapacity)
            {
                Console.WriteLine("Incorretct! Input number!");
                input = Console.ReadLine();
            }
            return number;
        }

        public static DateTime DateValidation(string input)
        {
            DateTime dateTime;
            while (!DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine("Incorretct! Input correct date!");
                input = Console.ReadLine();
            }
            return dateTime;
        }
    }
}
