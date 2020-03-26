using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Nechaiev
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<BasicProduct>
            {
                new BasicProduct(DateTime.Now,5,"Stone",40),
                new BasicProduct(DateTime.Now,34,"Computer",3743),
                new BasicProduct(DateTime.Now,53,"Book",7570),
                new BasicProduct(DateTime.Now,522,"Umbrella",470),
                new BasicProduct(DateTime.Now,45,"SwimingPool",40660),
                new BasicProduct(DateTime.Now,3,"Send", 35)
            };
            foreach(var item in products)
            {
                Console.WriteLine(item);
            }
           
            int count = products.Count;
            Console.WriteLine($"Number of products in storage: {count}");

            Console.ReadKey();
        }       
    }
}
