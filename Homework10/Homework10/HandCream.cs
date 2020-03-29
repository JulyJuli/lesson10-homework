using System;

namespace Homework10
{
    public class HandCream : Product
    {
        public HandCream(BaseProduct baseProduct, string productName) :
            base(productName, 200, baseProduct.CreationDate, 30)
        {
            BaseProduct = baseProduct;
            CreationDate = BaseProduct.CreationDate;
        }
        public BaseProduct BaseProduct { get; set; }

    }
}