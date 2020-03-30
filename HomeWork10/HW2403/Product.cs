using System;

namespace HW2403
{
    public class Product
    {    
        public Product(string name, double price, BaseProduct baseProduct)
        {
            Name = name;
            Price = price;
            BaseProduct = baseProduct;
        }
        public string Name { get; set; }
        public double Price { get; set; }
        public BaseProduct BaseProduct { get; set; }    
                
        public override string ToString ()
        {
            return $"Name: {Name}\nPrice: {Price}\n" + BaseProduct.ToString();
        }        
    }
}
