using System;
using System.Collections.Generic;

namespace HW2_2_Goods_Store_
{
    public static class Library
    {
        public static Store RemoveOverdueProd(Store store)//удаление просроченных товаров со склада
        {
            var listStore = store.GetList();

            for (int i = 0; i < listStore.Count; i++)
            {
                var finalDateforSale = listStore[i].Availability.GetFinalTerm();
                if (listStore[i].Availability.GetTermForFinalDateSale(finalDateforSale) < 0)
                {
                    listStore.Remove(listStore[i]);
                }
            }
            return store;
        }

        public static List<Product> GetOverdueProducts(Store store)//список просроченных товаров
        {
            List<Product> allOverdueProdacts = new List<Product>();
            var listStore = store.GetList();

            for (int i = 0; i < listStore.Count; i++)
            {
                var finalDateforSale = listStore[i].Availability.GetFinalTerm();
                if (listStore[i].Availability.GetTermForFinalDateSale(finalDateforSale) < 0)
                {
                    allOverdueProdacts.Add(listStore[i]);
                }
            }
            return allOverdueProdacts;
        }

        public static List<Product> GetProdWithLittleTerm(Store store)//список товаров cо скорым
                                                                      //окончанием срока годности
        {
            List<Product> allOverdueProdacts = new List<Product>();
            var listStore = store.GetList();

            for (int i = 0; i < listStore.Count; i++)
            {
                var finalDateforSale = listStore[i].Availability.GetFinalTerm();
                if (listStore[i].Availability.GetTermForFinalDateSale(finalDateforSale) <= 0 ||
                    listStore[i].Availability.GetTermForFinalDateSale(finalDateforSale) <= 2)
                {
                    allOverdueProdacts.Add(listStore[i]);
                }
            }
            return allOverdueProdacts;
        }

        public static void PrintInfo(List<Product> all)
        {
            foreach (var items in all)
                Console.WriteLine(items);
        }

        public static void ToSaleProduct(Store store, string ProdName)//продажа товара по названию
        {
            var listStore = store.GetList();
            bool IsOutOfStore = true;
            for (int i = 0; i < listStore.Count; i++)
            {
                if (listStore[i].ProdName.Equals(ProdName))
                {
                    if (listStore[i].Availability.CountOfProd > 0)
                    {
                        var count = --listStore[i].Availability.CountOfProd;
                        PrintSaleMessage(ProdName, count);
                        IsOutOfStore = false;
                    }
                }
            }
            if (IsOutOfStore == true)
            {
                PrintOutOfStoreMessage(ProdName);
            }
        }

        private static void PrintOutOfStoreMessage(string ProdName)
        {
            Console.WriteLine($"Sorry, {ProdName} isn't on the store now!");
        }

        private static void PrintSaleMessage(string ProdName, int count)
        {
            Console.WriteLine($"{ProdName} has sold, stock balance is {count}");
        }

    }
}
