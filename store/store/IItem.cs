namespace store
{
    public interface IItem
    {
        string Type { get; }
        
        string ItemName { get; }
        
        int Price { get; }
        
        int Amount { get; }
        
        int ExpirationDays { get; }

        bool IsExpired(int days);
    }
}