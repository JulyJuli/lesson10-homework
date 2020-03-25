namespace MarketWarehouseLibrary
{
    public class Product
    {
        double maxPrice = 500.0;
        int maxQuantity = 30;

        public Product(string nameOfProduct, double price, BaseProduct baseProduct, int quantity)
        {
            NameOfProduct = nameOfProduct;
            Price = price;
            BaseProduct = baseProduct;
            Quantity = quantity;
        }

        private string _nameOfProduct;
        public string NameOfProduct
        {
            get => _nameOfProduct;
            set
            {
                _nameOfProduct = NameValidation(value);
            }
        }

        private double _price;
        public double Price
        {
            get => _price;
            set
            {
                _price = PriceValidation(value);
            }
        }
        public BaseProduct BaseProduct { get; set; }

        private int _quantity;

        public int Quantity
        {
            get => _quantity;
            set
            {
                _quantity = QuantityValidation(value);
            }
        }

        private string NameValidation(string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                return input;
            }

            return $"Incorrect! Input value!";
        }
        private double PriceValidation(double input)
        {
            if (input > 0 && input < maxPrice)
            {
                return input;
            }
            return 0;
        }
        private int QuantityValidation(int input)
        {
            if (input > 0 && input < maxQuantity)
            {
                return input;
            }
            return 0;
        }
        public override string ToString()
        {
            return $"Product: {NameOfProduct,10}|\tPrice: {Price,5}|\tQuantity:{Quantity,5} items|\t" + BaseProduct.ToString();
        }
    }
}
