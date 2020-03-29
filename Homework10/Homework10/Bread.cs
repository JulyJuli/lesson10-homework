namespace Homework10
{
    public class Bread : Product
    {
        public Bread(
            BaseProduct baseProduct,
            string productName,
            double price) : 
            base(productName, 7, baseProduct.CreationDate, 5)
        {
            BaseProduct = baseProduct;
        }
        public BaseProduct BaseProduct { get; set; }
    }
}
