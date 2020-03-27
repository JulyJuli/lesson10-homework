using System;

namespace Homework10
{
    public class Warehouse : IThing
    {
        public Warehouse(string productName, double price, DateTime creationDate, int shelfLife)
        {
            ProductName = productName;
            Price = price;
            CreationDate = creationDate;
            ShelLife = shelfLife;
        }

        public virtual string Name => "Product";

        public string ProductName { get; set; }
        public double Price { get; set; }
        public DateTime CreationDate { get; set; }
        public int ShelLife { get; set; }


        public void PrintInfo()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return $"Name: {ProductName}, Price: {Price}, Shelf life: {ShelLife}";
        }
    }
}
