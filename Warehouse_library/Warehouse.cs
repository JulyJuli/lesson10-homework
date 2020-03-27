using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static Warehouse_library.DelegateHolder;

namespace Warehouse_library
{
    public class Warehouse
    {
        protected int _capacity;
        protected List<Product> Storage { get; set; }


        public Warehouse(int capacity)
        {
            _capacity = capacity;
            Storage = new List<Product>();
            Storage.Capacity = capacity;
        }


        public void Add(Product product)
        {
            if (Storage.Count < _capacity)
            {
                Storage.Add(product);
                showMessage($"Item \"{product.Name}\" has been stored. Stock fullness: {((double)Storage.Count() / Storage.Capacity) * 100:F2}%\n");
            }
            else
            {
                showMessage($"No more space in this warehouse. Item \"{product.Name}\" hasn't been stored.");
            }
        }

        public void GetWarehouseExpireInfo()
        {
            foreach (var item in Storage)
            {
                item.GetExpireInfo();
            }
        }

        public void ExpireDateInfo()
        {
            int maxNameLength = Storage.GetRange(0, Storage.Count - 2).Max(i => i.Name.Length);
            showMessage("Expire date info for stored goods.");
            foreach (var item in Storage)
            {
                string res = $"Product \"{item.Name}\" is fresh till \" {item.ExpireDate,20} \".";
                showMessage(res);
            }
        }
    }
}
