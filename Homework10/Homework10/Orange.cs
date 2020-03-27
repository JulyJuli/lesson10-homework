namespace Homework10
{
    public class Orange : Warehouse, IThing
    {
        public Orange(
            BaseProduct baseProduct,
            string productName,
            double price) : 
            base(productName, 30.5, baseProduct.CreationDate, 4)
        {
            BaseProduct = baseProduct;
        }
        public override string Name => "Orange";
        public BaseProduct BaseProduct { get; set; }
    }
}
