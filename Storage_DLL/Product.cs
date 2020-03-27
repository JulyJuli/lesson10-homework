using System;

namespace Storage_DLL
{
    public class Product : IProduct
    {
        private int _price;
        public string Name { get; set; }
        public int Price
        {
            get => _price;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    _price = value;
                }
            }
        }
        public BaseProduct BaseProduct { get; set; }
        public bool IsExpired { get; set; }
        public DateTime ExpirationDate { get; set; }

        public Product(string name, int price, BaseProduct baseProduct)
        {
            this.Name = name;
            this.Price = price;
            this.BaseProduct = baseProduct;
        }

        public DateTime FindExpirationDate(DateTime shipmentDate)
        {
            var prodDaysToExp = TimeSpan.FromDays(this.BaseProduct.DaysToExpiration);
            DateTime expirationDate = shipmentDate.Add(prodDaysToExp);

            return expirationDate;
        }

        public override string ToString()
        {
            if (this.IsExpired)
            {
                return $"{Name} {BaseProduct.ProductType}, expires on {ExpirationDate.ToString("dd MMMM yyyy")} ***EXPIRED***";
            }
            else
            {
                return $"{Name} {BaseProduct.ProductType}, expires on {ExpirationDate.ToString("dd MMMM yyyy")}";
            }
        }
    }
}
