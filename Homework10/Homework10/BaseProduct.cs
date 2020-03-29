using System;
namespace Homework10
{
    public class BaseProduct
    {
        public BaseProduct(DateTime creationDate, TimeSpan shelLife)
        {
            
            CreationDate = creationDate;
            ShelLife = shelLife;
        }
        public DateTime CreationDate { get; set; }
        public TimeSpan ShelLife { get; set; } 
    }
}
