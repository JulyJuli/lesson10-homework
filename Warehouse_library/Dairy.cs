using static Warehouse_library.DelegateHolder;

namespace Warehouse_library
{
    public class Dairy : Product
    {
        public override double ExpirationTerm { get; protected set; } = 4;

        public Dairy() : base() { }
        public Dairy(string name, decimal price) : base(name, price) { }
    }
}
