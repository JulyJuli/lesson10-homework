namespace Storage_DLL
{
    public class BaseProduct
    {
        public ProductTypes ProductType { get; set; }
        public int DaysToExpiration { get; set; }

        public BaseProduct(ProductTypes productType)
        {
            this.ProductType = productType;

            switch (ProductType)
            {
                case ProductTypes.Burger:
                    DaysToExpiration = 5;
                    break;
                case ProductTypes.Pizza:
                    DaysToExpiration = 3;
                    break;
                case ProductTypes.Roll:
                    DaysToExpiration = 2;
                    break;
            }
        }
    }
}
