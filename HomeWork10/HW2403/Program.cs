using System;
using System.Linq;

namespace HW2403
{
    class Program
    {
        static void Main(string[] args)
        {            
            string again;
            do
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");                
                double price = MainMethods.ValidationStr(Console.ReadLine());

                Console.Write("Data YYYY.MM.DD: ");
                DateTime UserDataTime1 = Convert.ToDateTime(Console.ReadLine());
                
                var prod = new Product(name, price, new BaseProduct(UserDataTime1));

                Storage.AddProduct(prod);

                Console.Write("\nAdd more? Press y or any key to commplete: ");
                again = Console.ReadLine();

            } while (again.Equals("y") || again.Equals("Y"));

            Console.Clear();

            int capacity = Storage.productsList.Count();

            var stor = new Storage(Storage.productsList, capacity);

            Storage.PrintAll();

            Console.Write("\nEnter your date YYYY.MM.DD: ");

            DateTime UserDataTime = Convert.ToDateTime(Console.ReadLine());

            Storage.CheckLimitation(stor, UserDataTime);

            Storage.PrintStorage(stor);

            Console.Read();
        }
    }
}
