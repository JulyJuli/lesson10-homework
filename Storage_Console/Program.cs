using System;
using System.Collections.Generic;
using Storage_DLL;

namespace Storage_Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the date of shipment: ");
            var shipmentDate = DateInputValidation(Console.ReadLine());

            var currentDate = shipmentDate;
            int daysAfterShipment = 0;

            var storage = new Storage(5);

            storage.ProductList = new List<Product>
            {
                new Product("Pepperoni", 100, new BaseProduct(ProductTypes.Pizza)),
                new Product("Double Cheese", 70, new BaseProduct(ProductTypes.Burger)),
                new Product("Vegan", 60, new BaseProduct(ProductTypes.Roll)),
                new Product("Margarita", 90, new BaseProduct(ProductTypes.Pizza)),
                new Product("Vegan", 100, new BaseProduct(ProductTypes.Pizza))
            };

            foreach (Product product in storage.ProductList)
            {
                product.ExpirationDate = product.FindExpirationDate(shipmentDate);
            }

            string input;

            do
            {
                Console.WriteLine($"Days after shipment: {daysAfterShipment}");
                Console.WriteLine();

                Console.WriteLine("======================= MENU =======================");
                Console.WriteLine("Enter 'view' to view the list of products in storage today.");
                Console.WriteLine("Enter 'skip' to move 1 day forward.");
                Console.WriteLine("Enter 'end' to finish working with the app.");

                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "view":
                        Console.WriteLine(currentDate.ToString("dd MMMM yyyy"));
                        Console.WriteLine();
                        Console.WriteLine(storage.ToString());
                        break;

                    case "skip":
                        daysAfterShipment++;
                        currentDate = currentDate.AddDays(1);

                        UpdateExpiryList(storage.ProductList, daysAfterShipment);

                        Console.WriteLine();
                        break;

                    case "end":
                        return;

                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            } while (input.Equals("end") == false);

        }

        public static DateTime DateInputValidation(string input)
        {
            DateTime shipmentDate;

            while (DateTime.TryParse(input, out shipmentDate) == false)
            {
                Console.Write("Invalid date specified, please try again: ");
                input = Console.ReadLine();
            }

            return shipmentDate;
        }

        public static void UpdateExpiryList(List<Product> productList, int daysAfterShipment)
        {
            foreach (Product product in productList)
            {
                if (daysAfterShipment > product.BaseProduct.DaysToExpiration)
                {
                    product.IsExpired = true;
                }
            }
        }
    }
}
