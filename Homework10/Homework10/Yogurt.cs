namespace Homework10
{
    public class Yogurt : Product
    {
        public Yogurt(
            BaseProduct baseProduct,
            string productName,
            double price) : 
            base(productName, 28, baseProduct.CreationDate, 7)
        {
            BaseProduct = baseProduct;
        }
        public BaseProduct BaseProduct { get; set; }
    }
}
