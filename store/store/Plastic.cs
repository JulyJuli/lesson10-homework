namespace store
{
    public class Plastic : Item
    {
        public override string ItemName { get; }
        public override int Amount { get; }
        public override string Type => "Plastic";
        public override int Price { get; } = 0;
        
        public Plastic(string name, int amount, int price, int expirationDays) : base(expirationDays)
        {
            ItemName = name;
            Amount = amount;
            Price = price;
        }
    }
}