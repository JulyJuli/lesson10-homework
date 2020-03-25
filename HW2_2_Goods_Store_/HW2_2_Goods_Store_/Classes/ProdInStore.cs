using System;

namespace HW2_2_Goods_Store_
{
    public class ProdInStore : IAvailable, IPrint
    {
        public int CountOfProd { get; set; }
        public DateTime ReleaseDate { get; set; }//дата производства
        public TimeSpan TermForSale { get; set; }//срок годности в днях

        public ProdInStore(int count, DateTime releaseDate, TimeSpan termForSale)
        {
            CountOfProd = count;
            ReleaseDate = releaseDate;
            TermForSale = termForSale;
        }

        public DateTime GetFinalTerm()//дата конечной реализации
        {
            DateTime finalDateforSale = ReleaseDate + (TermForSale - new TimeSpan(1, 0, 0, 0));//потому что прибавляет срок реализации
            //как временный интервал и получается на 1 день больше(н.п. 20.03.2020+15 дней=04.04.2020, а нужно 03.04.2020)
            return finalDateforSale;
        }

        //public string FinalTerm()
        //{
        //    DateTime finalDateforSale = ReleaseDate + TermForSale;
        //    string a = finalDateforSale.ToString("dd/MM/yy");// ("yy-MM-dd");
        //    return a;
        //}

        public int GetTermForFinalDateSale(DateTime finalDateforSale)
        //количество дней до окончания срока годности
        {
            TimeSpan daysForEnd = finalDateforSale - DateTime.Now;

            return daysForEnd.Days;
        }
        public override string ToString()
        {
            return $"Quantity: {CountOfProd,4}|FinalDateforSale: {GetFinalTerm().ToString("dd/MM/yy"),8}|"
                + $"TermForFinalSale: {GetTermForFinalDateSale(GetFinalTerm()),5}| ";
        }

        public void PrintInfo()
        {
            Console.WriteLine(ToString());
        }
    }
}
