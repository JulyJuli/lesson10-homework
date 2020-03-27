namespace Homework10
{
    public class Banana : Warehouse
    {
        public Banana(
            BaseProduct baseProduct,
            string productName,
            double price) : 
            base(productName, 30, baseProduct.CreationDate, 4)
        {
            BaseProduct = baseProduct;
        }
        public override string Name => "Banana";
        public BaseProduct BaseProduct { get; set; }
    }
}
