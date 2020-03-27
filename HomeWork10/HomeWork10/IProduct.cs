using System;


namespace HomeWork10
{
    public interface IProduct
    {
        DateTime DateOfDeliver { get; set; }
        string Name { get; }
        int Price { get; }
        BasicProduct BasicProduct { get; set; }
        DateTime CheckOnExpiration();

    }
}
