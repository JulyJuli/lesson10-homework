using System;

namespace Homework10
{
    public class HandCream : IThing
    {
        public HandCream(BaseProduct bp)
        {
            BaseProduct = bp;
            CreationDate = BaseProduct.CreationDate;
        }

        public string Name => "Hand cream";

        public void PrintInfo()
        {
            Console.WriteLine(Name);
        }
        public double Price => 170;

        public int ShelLife => 20;
        public BaseProduct BaseProduct { get; set; }
        public DateTime CreationDate { get; set; }

    }
}