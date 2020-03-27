using System;


namespace HomeWork10
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductStorage Meal = new ProductStorage();
            Meal.productsStorage.Add(new Cucumber(new BasicProduct ("Vegatable", 7), DateTime.Parse("03/21/2020 07:22:16")));
            Meal.productsStorage.Add(new Tomato(new BasicProduct("Vegatable", 7), DateTime.Parse("03/24/2020 07:22:16")));
            Meal.productsStorage.Add(new Meat(new BasicProduct("NotVegan", 3), DateTime.Parse("03/26/2020 07:22:16")));
            Meal.productsStorage.Add(new Cucumber(new BasicProduct("Vegatable", 7), DateTime.Parse("03/22/2020 07:22:16")));
            Meal.productsStorage.Add(new Porridge(new BasicProduct("Cereals", 30), DateTime.Parse("03/25/2020 07:22:16")));

            Console.WriteLine(Meal);
            Console.ReadKey();
        }
    }
}
