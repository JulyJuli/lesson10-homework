using System;


namespace HomeWork10
{
    class Tomato : IProduct
    {
        public virtual string Name => "Tomato";

        public virtual int Price => 40;
        public virtual BasicProduct BasicProduct { get; set; }
        public virtual DateTime DateOfDeliver { get; set; }

        public Tomato(BasicProduct basicProduct, DateTime dateOfDeliver)
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
