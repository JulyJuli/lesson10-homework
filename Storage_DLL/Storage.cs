using System;
using System.Collections.Generic;
using System.Text;

namespace Storage_DLL
{
    public class Storage
    {
        private int _maxNumOfProducts = 0;
        private List<Product> _productList;
        public int MaxNumOfProducts
        {
            get => _maxNumOfProducts;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid number of products!");
                }
                else
                {
                    _maxNumOfProducts = value;
                }
            }
        }
        public List<Product> ProductList
        {
            get => _productList;
            set
            {
                if (value.Count > MaxNumOfProducts)
                {
                    Console.WriteLine("Storage limit exceeded!");
                }
                else
                {
                    _productList = value;
                }
            }
        }

        public Storage(int maxNumOfProducts)
        {
            this.MaxNumOfProducts = maxNumOfProducts;
        }

        public override string ToString()
        {
            var storageString = new StringBuilder();

            foreach (Product product in ProductList)
            {
                storageString.AppendLine(product.ToString());
            }

            return storageString.ToString();
        }

    }
}
