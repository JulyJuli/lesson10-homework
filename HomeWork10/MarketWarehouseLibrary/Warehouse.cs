using System;
using System.Collections.Generic;

namespace MarketWarehouseLibrary
{
    public class Warehouse
    {
        public List<Product> Products { get; set; }

        public static int warehouseCapacity;

        public Warehouse()
        {
            Products = new List<Product>();
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

        public static Warehouse Distribusion(Warehouse warehouse, List<Product> products, int warehouseCapacity)
        {
            int indexOfCurrentProduct = 0;
            int sumOfProducts = 0;
            sumOfProducts += products[indexOfCurrentProduct].Quantity;
            while (sumOfProducts < warehouseCapacity)
            {
                warehouse.AddProduct(products[indexOfCurrentProduct]);                
                sumOfProducts += products[indexOfCurrentProduct].Quantity;
                indexOfCurrentProduct++;
            }
            return warehouse;
        }

        public static void WerificationOfExpiredGoods(ref Warehouse warehouse, DateTime datetime, out List<Product> expiredItems)
        {
            expiredItems = new List<Product>();
            for (int i = 0; i < warehouse.Products.Count; i++)
            {
                if (warehouse.Products[i].BaseProduct.ProductExpiration < datetime)
                {
                    expiredItems.Add(warehouse.Products[i]);
                    warehouse.Products.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
