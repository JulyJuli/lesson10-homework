using System;


namespace HomeWork10
{
   public class Cucumber : IProduct
    {
        public virtual string Name => "Cucumber";

        public virtual int Price => 10;
        public virtual BasicProduct BasicProduct { get ; set ; }
        public virtual DateTime DateOfDeliver { get ; set; }
        

        public Cucumber(BasicProduct basicProduct, DateTime dateOfDeliver) {
            DateOfDeliver = dateOfDeliver;
            BasicProduct = basicProduct;
        }

        public virtual DateTime CheckOnExpiration( )
        {
            return DateOfDeliver.AddDays(BasicProduct.DaysOfLife);
        }
    }
}
