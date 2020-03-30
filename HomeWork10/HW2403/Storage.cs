using System;
using System.Collections.Generic;

namespace HW2403
{
    public class Storage
    {
        public static List<Product> productsList = new List<Product>();
        public List<Product> Products { get; set; }

        public static void AddProduct(Product product)
        {
            productsList.Add(product);
        }
        public Storage(List<Product> products, int capacity)
        {
            Products = products;
            Capacity = capacity;
        }
        public int Capacity {get; set;}

        public static string PositionProduct(int i)
        {
            int number = i + 1;
            return $"\n{Convert.ToString(number)}) ";
        }
        public static void PrintAll()
        {
            for (int i = 0; i < productsList.Count; i++)
            {

                Console.WriteLine(PositionProduct(i) + productsList[i].ToString());
            }
        }
        public static void DeleteProductOfStore(Storage stor, int index)
        {
            stor.Products.RemoveAt(index);
        }
        public static void CheckLimitation(Storage store, DateTime dateTime)
        {
            for (int i = 0; i < store.Products.Count; i++)
            {
                if (store.Products[i].BaseProduct.LimitationProduct < dateTime)
                {
                    Console.WriteLine($"\nDelete product: \n{store.Products[i].ToString()}");
                    DeleteProductOfStore(store, i);
                    store.Capacity--;                                      
                }              
            }           
        }
        public static void PrintStorage(Storage store)
        {
            Console.WriteLine(store.ToString());
            for (int i = 0; i < store.Products.Count; i++)
            {
                Console.WriteLine(PositionProduct(i)  + store.Products[i].ToString());
            }            
        }

        public override string ToString()
        {
            return $"\nAll product in storege: {Capacity} qty\n";
        }
    }   
}
