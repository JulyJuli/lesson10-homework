using System;
using System.Collections.Generic;
using System.Linq;


namespace HomeWork10
{
    public class ProductStorage
    {
        private int maxQuantityOfProd = 10;
        public int Quantity {            
            get => productsStorage.Count();
        } 
        public List<IProduct> productsStorage = new List<IProduct>();

        public void AddProduct (IProduct newProduct)
        {
            if (productsStorage.Count() < maxQuantityOfProd) 
            { 
                this.productsStorage.Add(newProduct);
            }
            else
            {
                Console.WriteLine("The Storage full, check the products on expiration date before adding new one");
            }
        }

        public override string ToString()
        {
            string str = $"Quantity of products in the storage: {Quantity}\n" ;
            
            foreach (IProduct product in productsStorage)
            {
                str += $"Name: {product.Name}, Price: {product.Price}, date of expiration: {(product.CheckOnExpiration()).ToString()} \n";
            }
            return str;

        }


    }
}
