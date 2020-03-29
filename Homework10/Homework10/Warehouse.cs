using System;
using System.Collections.Generic;
using System.Text;

namespace Homework10
{
    public class Warehouse
    {
        public List<IThing> Products { get; set; }

        public static int warehouseCapacity;

        public Warehouse()
        {
            Products = new List<IThing>();
        }
        public void PrintInfo()
        {
            foreach (var item in Products)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
    }
      
}
