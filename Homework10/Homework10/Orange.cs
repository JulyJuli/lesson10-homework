namespace Homework10
{
    public class Orange : Product
    {
        public Orange(
            BaseProduct baseProduct,
            string productName,
            double price) : 
            base(productName, 30.5, baseProduct.CreationDate, 4)
        {
            BaseProduct = baseProduct;
        }
        public BaseProduct BaseProduct { get; set; }
    }
}
