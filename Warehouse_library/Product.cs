using System;
using static Warehouse_library.DelegateHolder;

namespace Warehouse_library
{
    public abstract class Product
    {
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }
        public DateTime DateOfManufacture { get; } = DateTime.Today;
        public string ExpireDate { get; protected set; }
        public abstract double ExpirationTerm { get; protected set; }


        public Product()
        {
            showMessage($"\nCustom {GetType().Name.ToLower()} input. \n");
            showMessage("  Input product's name: ");
            Name = readString();

            showMessage("  Input product's price: ");
            Price = DecimalValidation();

            ExpireDate = DateOfManufacture.AddDays(ExpirationTerm).ToShortDateString();

            decimal DecimalValidation()
            {
                if ((decimal.TryParse(readString(), out decimal res)) && (res > 0))
                {
                    return res;
                }
                else
                {
                    showMessage("  Please, input a number > \"0\": ");
                    return DecimalValidation();
                }
            }
        }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
            ExpireDate = DateOfManufacture.AddDays(ExpirationTerm).ToShortDateString();
        }


        public virtual void GetExpireInfo()
        {
            showMessage($"\n  Product: {GetType().Name.ToLower()} \"{Name}\"\n  Price: {Price}\n  Expire date: {ExpireDate}.\n");
        }
    }
}
