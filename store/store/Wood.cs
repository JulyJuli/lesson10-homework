namespace store
{
    public class Wood : Item
    {
        public override string ItemName { get; }
        public override int Amount { get; }
        public override string Type => "Wood";
        public override int Price { get; } = 0;

        public Wood(string name, int amount, int price, int expirationDays) : base(expirationDays)
        {
            ItemName = name;
            Amount = amount;
            Price = price;
        }
    }
}