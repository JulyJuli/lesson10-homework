using System;

namespace Homework10
{
    public class Paper : IThing
    {
        public Paper(BaseProduct bp)
        {
            BaseProduct = bp;
            CreationDate = BaseProduct.CreationDate;
        }

        public string Name => "Paper";
        public void PrintInfo()
        {
            Console.WriteLine(Name);
        }
        public BaseProduct BaseProduct { get; set; }
        public double Price => 80;
        public int ShelLife => 900;
        public DateTime CreationDate { get; set; }

    }
}