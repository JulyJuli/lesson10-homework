using static Warehouse_library.DelegateHolder;

namespace Warehouse_library
{
    public class Alcohol : Product
    {
        public override double ExpirationTerm { get; protected set; } = 8;
        public Alcohol() : base() {}
        public Alcohol(string name, decimal price) : base(name, price) { }
    }
}
