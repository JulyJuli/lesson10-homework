using System;

namespace MarketWarehouseLibrary
{
    public class BaseProduct
    {
        public BaseProduct(DateTime productExpiration)
        {
            ProductExpiration = productExpiration;
        }

        public DateTime ProductExpiration { get; set; }

        public override string ToString()
        {
            return $"Deadline for implementation:{ProductExpiration.ToShortDateString(),5}|";
        }
    }
}
