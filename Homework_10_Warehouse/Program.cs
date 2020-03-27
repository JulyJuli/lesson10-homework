using System;
using Warehouse_library;
using static Warehouse_library.DelegateHolder;

namespace Homework_10_Warehouse
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Setting global delegates.
            SetShowMessageHandler(Message);
            SetInputHandler(ReadString);

            // Warehouse init.
            Warehouse myWarehouse = new Warehouse(6);

            // Constructor & delegate testing.
            showMessage("Warehouse filling info.\n");
            Dairy milk = new Dairy("Slov'anochka", 20);
            Product alc1 = new Alcohol("Bulleit", 640);

            // Prefilling warehouse.
            // Product auto input.
            myWarehouse.Add(milk);
            myWarehouse.Add(alc1);
            myWarehouse.Add(new Alcohol("Svitle", 15));
            myWarehouse.Add(new Alcohol("Temne", 17));

            // Product custom input.
            myWarehouse.Add(new Dairy());
            myWarehouse.Add(new Alcohol());

            //View expire dates for products in the warehouse.         
            showMessage("\nProducts expiration dates info.\n");
            myWarehouse.GetWarehouseExpireInfo();

            Console.WriteLine("\n\nGood bye!");
            Console.ReadKey();
        }
        private static void Message(string str)
        {
            Console.Write(str);
        }
        private static string ReadString()
        {
            return Console.ReadLine();
        }
    }
}