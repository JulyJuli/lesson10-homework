using System;

namespace store
{
    public class Item : IItem
    {
        private int _expirationDays = 0;

        public virtual string Type { get; }
        public virtual string ItemName { get; }
        public virtual int Price { get; }
        public virtual int Amount { get; }

        public int ExpirationDays
        {
            get => _expirationDays;
            set {
                if (value > 0)
                {
                    _expirationDays = value;
                }
                else
                {
                    Console.WriteLine("Wrong value = {0} !", value);
                }
            }
        }

        public bool IsExpired(int days)
        {
            return ExpirationDays >= days;
        }

        public Item(int expirationDays)
        {
            ExpirationDays = expirationDays;
        }
    }
}