namespace Homework10
{
    public class Banana : Product
    {
        public Banana(
            BaseProduct baseProduct,
            string productName,
            double price) : 
            base(productName, 30, baseProduct.CreationDate, 4)
        {
            BaseProduct = baseProduct;
        }
        public BaseProduct BaseProduct { get; set; }
    }
}
