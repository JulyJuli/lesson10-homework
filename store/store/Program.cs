using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using ConsoleTableLibrary;

namespace store
{
    public class Program
    {
        private const int XDays = 5;
        private const int YDays = 15;
        
        static void Main(string[] args)
        {
            var Storage = new List<IItem>
            {
                new Wood("Tables", 25, 120, 10),
                new Wood("Сhairs", 5, 50, 4),
                new Plastic("Plates", 100, 3, 25),
                new Plastic("Glasses", 130, 4, 35),
                new Steel("Nails", 1500, 1, "red", 12),
                new Steel("Batteries", 8, 830, "white", 3),
            };

            ShopSystem(Storage);
        }
        
        public static void ShopSystem(List<IItem> Storage)
        {
            Console.Clear();
            bool exit = false;

            // navigation

            Console.WriteLine("Store Storage: \n");
            Console.WriteLine("1) View Storage.");
            Console.WriteLine($"2) View Storage after {XDays} days.");
            Console.WriteLine($"3) View Storage after {YDays} days.");
            Console.WriteLine("4) Exit.");

            char key = Console.ReadKey(true).KeyChar;

            Console.Clear();
            switch (key)
            {
                case (char)Navigation.ViewStorage:

                    ViewStorage(Storage, 0);
                    break;

                case (char)Navigation.ViewStorageAfterXDays:

                    ViewStorage(Storage, XDays);
                    break;

                case (char)Navigation.ViewStorageAfterYDays:

                    ViewStorage(Storage, YDays);
                    break;
                
                case (char)Navigation.Exit:
                    // Exit

                    exit = true;
                    break;

                default:
                    ShopSystem(Storage);
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("Press any key.");
                Console.ReadKey();
                ShopSystem(Storage);
            }
        }

        public static void ViewStorage(List<IItem> Storage, int days)
        {
            Console.WriteLine(days > 0 ? $"Items table after {days} days:" : "Items table:");
            
            ConsoleTable table = new ConsoleTable(
                new List<string> { "ID", "Name", "Type", "Amount", "Price", "Expiration Days" },
                new List<int> {2, 12, 12, 6, 5, 20}
            );

            foreach (IItem item in Storage)
            {
                if (item.IsExpired(days))
                {
                    table.Add(new string[]{
                        (Storage.IndexOf(item) + 1).ToString(),
                        item.ItemName,
                        item.Type,
                        item.Amount.ToString(),
                        item.Price.ToString(),
                        item.ExpirationDays.ToString()
                    });
                } 
            }

            Console.WriteLine(table.ToString());
        }
    }
}