
namespace HW2_2_Goods_Store_
{
    public interface IProduct
    {
        EnumKindProd KindProd { get; }
        string ProdName { get; set; }
        decimal Price { get; set; }
        ProdInStore Availability { get; set; }
    }
}
