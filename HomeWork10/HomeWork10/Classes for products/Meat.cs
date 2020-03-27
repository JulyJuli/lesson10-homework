using System;


namespace HomeWork10
{
    public class Meat : IProduct
    {
        public virtual string Name => "Meat";

        public virtual int Price => 200;
        public virtual BasicProduct BasicProduct { get; set; }
        public virtual DateTime DateOfDeliver { get; set; }

        public Meat(BasicProduct basicProduct, DateTime dateOfDeliver)
        {
            DateOfDeliver = dateOfDeliver;
            BasicProduct = basicProduct;
        }

        public virtual DateTime CheckOnExpiration()
        {
            return DateOfDeliver.AddDays(BasicProduct.DaysOfLife);
        }
    }
}
