using System;


namespace HomeWork10
{
    class Porridge : IProduct
    {
        public virtual string Name => "Porridge";

        public virtual int Price => 50;
        public virtual BasicProduct BasicProduct { get; set; }
        public virtual DateTime DateOfDeliver { get; set; }

        public Porridge(BasicProduct basicProduct, DateTime dateOfDeliver)
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
