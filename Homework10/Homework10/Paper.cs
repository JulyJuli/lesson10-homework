using System;

namespace Homework10
{
    public class Paper : Product
    {
        public Paper(BaseProduct bp, string productName) :
            base(productName, 80, bp.CreationDate, 150)
        {
            BaseProduct = bp;
            CreationDate = BaseProduct.CreationDate;
            ProductName = productName;
        }
        public BaseProduct BaseProduct { get; set; }
        public new DateTime CreationDate { get; set; }

    }
}