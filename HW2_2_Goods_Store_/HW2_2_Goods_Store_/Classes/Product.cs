using System;

namespace HW2_2_Goods_Store_
{
    public class Product : IProduct, IPrint
    {
        private decimal _price;
        private string _prodName;
        public EnumKindProd KindProd { get; set; }

        public Product(EnumKindProd kind, string name, decimal price, ProdInStore avaibility)
        {
            KindProd = kind;
            ProdName = name;
            Price = price;
            Availability = avaibility;
        }


        public string ProdName
        {
            get
            { return _prodName; }
            set
            {
                if (!string.IsNullOrEmpty(value.ToString()))
                {
                    _prodName = value;
                }
                else
                    PrintValidMessage("ProdName", value.ToString());
            }
        }
        public decimal Price
        {
            get
            { return _price; }
            set
            {
                if (value < 0 && !Decimal.TryParse(value.ToString(), out value))//понимаю, что хардкодом и
                    //не запишешь в значение строку, но хоть попробовала))
                    PrintValidMessage("Price", value.ToString());
                else
                    _price = value;
            }
        }
        public ProdInStore Availability { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine(ToString());
        }

        protected void PrintValidMessage(string propertyName, string value)
        {
            Console.WriteLine($"{propertyName} {value} is invalid. Try again.");
        }

        public override string ToString()
        {
            return $"Kind: {KindProd,10}| Product: {ProdName,22}| price: {Price,5}|" + Availability.ToString();
        }
    }
}
