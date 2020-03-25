namespace store
{
    public class Steel : Item
    {
        public override string ItemName { get; }
        public override int Amount { get; }
        public string Color { get; }
        public override string Type => "Steel";
        public override int Price { get; } = 0;
        
        public Steel(string name, int amount, int price, string color, int expirationDays) : base(expirationDays)
        {
            ItemName = name;
            Amount = amount;
            Price = price;
            Color = color;
        }
    }
}