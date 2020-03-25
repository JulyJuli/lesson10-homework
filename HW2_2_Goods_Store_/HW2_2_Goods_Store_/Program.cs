using System;
using System.Collections.Generic;

namespace HW2_2_Goods_Store_
{
    public class Program
    {
        static void Main(string[] args)
        {

            var storage = new Store();

            Store.AddRangeToStore(new List<Product>
            {
                new Product(EnumKindProd.Milk, "Milk\"Korovkino\"", 25.80M,
                new ProdInStore(5, new DateTime(2020,03,20), new TimeSpan(15,0,0,0))),
                new Product(EnumKindProd.Milk, "Jojurt\"Korovkino\"", 19.56M,
                new ProdInStore(7, new DateTime(2020,03,13), new TimeSpan(15,0,0,0))),
                new Product(EnumKindProd.Bread, "White bread", 10.00M,
                new ProdInStore(3, new DateTime(2020,03,24), new TimeSpan(2,0,0,0))),
                new Product(EnumKindProd.Bread, "Brown bread", 20.00M,
                new ProdInStore(3, new DateTime(2020,03,23), new TimeSpan(3,0,0,0))),
                new Product(EnumKindProd.Sweets, "chokolate \"Alenka\"", 78.60M,
                new ProdInStore(5, new DateTime(2020,02,14), new TimeSpan(60,0,0,0))),
                new Product(EnumKindProd.Sweets, "chokolate \"Alenka\"", 78.60M,
                new ProdInStore(5, new DateTime(2020,01,10), new TimeSpan(60,0,0,0))),
                new Product(EnumKindProd.Vegetables, "Cabbage", 7.50M,
                new ProdInStore(4,new DateTime(2020,03,12), new TimeSpan(20,0,0,0))),
                new Product(EnumKindProd.Other, "Soap\"Strawberry\"", 6.80M,
                new ProdInStore(4, new DateTime(2020,02,01), new TimeSpan(360,0,0,0))),
                new Product(EnumKindProd.Other, "Toothpaste\"Aquafresh\"", 36.80M,
                new ProdInStore(1, new DateTime(2019,04,01), new TimeSpan(360,0,0,0))),
                new Product(EnumKindProd.Other, "Plastic plate", 5.80M,
                new ProdInStore(4, new DateTime(2020, 02, 01), new TimeSpan(10000,0,0,0))),
            });

            int origWidth = Console.WindowWidth;
            int newConsoleWidth = origWidth + 20;
            int origHeight = Console.WindowHeight;
            int newConsoleHeight = origHeight + 20;
            Console.SetWindowSize(newConsoleWidth, newConsoleHeight);

            Console.WriteLine("\t\tBalace of the store now:");
            storage.PrintInfo();

            var allGoods = storage.CalculateAllGoodsInStore();
            Console.WriteLine($"\n\tQuantity all goods in the store: {allGoods}\n");

            Console.WriteLine("\n\t\tSale of goods (Cake \"Kijevskij\", Soap\"Strawberry\"-1 piece):\n");
            Library.ToSaleProduct(storage, "Cake \"Kijevskij\"");
            Library.ToSaleProduct(storage, "Soap\"Strawberry\"");

            Console.WriteLine("\n\t Overdue products:\n");
            var allOverdueProdacts = Library.GetOverdueProducts(storage);
            Library.PrintInfo(allOverdueProdacts); //foreach (var item in allOverdueProdacts)// Console.WriteLine(item);
            Console.WriteLine();

            Console.WriteLine("\n\t  Products in store after remove overdue products:\n");
            Library.RemoveOverdueProd(storage).PrintInfo();

            Console.WriteLine("\n\t  Products in store with short term of sale:\n");
            var prodWithLittleTerm = Library.GetProdWithLittleTerm(storage);
            Library.PrintInfo(prodWithLittleTerm);

            Console.WriteLine($"\n\tQuantity all goods in the store: {storage.CalculateAllGoodsInStore()}\n");
                
        }
    }
}
