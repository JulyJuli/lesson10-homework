namespace Homework10
{
    public class Bread : Warehouse
    {
        public Bread(
            BaseProduct baseProduct,
            string productName,
            double price) : 
            base(productName, 7, baseProduct.CreationDate, 5)
        {
            BaseProduct = baseProduct;
        }
        public override string Name => "Bread";
        public BaseProduct BaseProduct { get; set; }
    }
}
