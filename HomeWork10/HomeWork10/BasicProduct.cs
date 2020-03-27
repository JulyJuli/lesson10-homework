

namespace HomeWork10
{
    public class  BasicProduct
    {
        public string ProductName { get; set; }
        public  double DaysOfLife { get; set; }
        
        public BasicProduct( string productName, double daysOfLife)
        {
            ProductName = productName;
            DaysOfLife = daysOfLife;
        }
    }
}
