using System;

namespace Homework10
{
    public class Product : Warehouse, IThing
    {
        public Product(string productName, double price, DateTime creationDate, int shelfLife)
        {
            ProductName = productName;
            Price = price;
            CreationDate = creationDate;
            ShelLife = shelfLife;
        }

        public string Name => "Product";

        public string ProductName { get; set; }
        public double Price { get; set; }
        public DateTime CreationDate { get; set; }
        public int ShelLife { get; set; }

        public override string ToString()
        {
            return $"Name: {ProductName}, Price: {Price}, Shelf life: {ShelLife}";
        }
    }
}
