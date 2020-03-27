namespace Storage_DLL
{
    public interface IProduct
    {
        string Name { get; set; }
        int Price { get; set; }
        BaseProduct BaseProduct { get; set; }
    }
}
