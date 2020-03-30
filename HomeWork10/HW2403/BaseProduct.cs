using System;

namespace HW2403
{
    public class BaseProduct
    {
        public BaseProduct(DateTime limitationProduct)
        {
            LimitationProduct = limitationProduct;
        }
        public DateTime LimitationProduct { get; set; }

        public override string ToString()
        {
            return $"Limitation: {LimitationProduct.ToShortDateString()}";
        }

    }
}
