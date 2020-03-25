using System;

namespace HW2_2_Goods_Store_
{
     public interface IAvailable
    {
        DateTime ReleaseDate { get; }
        TimeSpan TermForSale { get; set; }
        DateTime GetFinalTerm();
    }
}
