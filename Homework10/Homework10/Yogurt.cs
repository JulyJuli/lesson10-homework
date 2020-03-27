namespace Homework10
{
    public class Yogurt : Warehouse
    {
        public Yogurt(
            BaseProduct baseProduct,
            string productName,
            double price) : 
            base(productName, 28, baseProduct.CreationDate, 7)
        {
            BaseProduct = baseProduct;
        }
        public override string Name => "Yogurt";
        public BaseProduct BaseProduct { get; set; }
    }
}
