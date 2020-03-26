using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Nechaiev
{
    public class BasicProduct:Product
    {
        public BasicProduct(DateTime deliveryDate, int shelfLife, string nameOfProguct, decimal price) :base(nameOfProguct, price)
        {
            DeliveryDate = deliveryDate;
            ShelfLife = shelfLife;
        }

        public DateTime DeliveryDate { get; set; }
        public int ShelfLife { get; set; }

        public override string ToString()
        {
            return base.ToString()+$"Date of Delivery: {DeliveryDate.ToShortDateString()}, ShelfLife: {ShelfLife} days\n";
        }
    }
}
