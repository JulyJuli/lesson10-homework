using System;
using System.Collections.Generic;

namespace HW2_2_Goods_Store_
{
    public class Store : IPrint
    {
        public static List<Product> storage = new List<Product>();
        private int _quantityAllGoodsInStore = 0;
        public int QuantityAllGoodsInStore
        {
            get { return _quantityAllGoodsInStore; }
            set
            {
                value = CalculateAllGoodsInStore();
                _quantityAllGoodsInStore = value;
            }
        }
        public static void AddProdToStore(Product item)
        {
            storage.Add(item);
        }

        public static void AddRangeToStore(List<Product> newItems)
        {
            foreach (var item in newItems)
                AddProdToStore(item);
        }

        public List<Product> GetList()
        {
            return storage;
        }

        public int CalculateAllGoodsInStore()
        {
            int calcAllGoodsInStore = 0;
            for (int i = 0; i < storage.Count; i++)
            {
                calcAllGoodsInStore += storage[i].Availability.CountOfProd;
            }

            return calcAllGoodsInStore;
        }

        public void PrintInfo()
        {
            foreach (var items in storage)
                Console.WriteLine(items);
        }
    }
}
