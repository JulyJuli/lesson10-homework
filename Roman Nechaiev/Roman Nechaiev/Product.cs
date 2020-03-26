using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Nechaiev
{
    public class Product
    {
        public Product(string nameOfProguct, decimal price)
        {
            NameOfProguct = nameOfProguct;
            Price = price;            
        }

        public string NameOfProguct { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Name:{NameOfProguct}, Price: {Price},";
        }
    }
}
