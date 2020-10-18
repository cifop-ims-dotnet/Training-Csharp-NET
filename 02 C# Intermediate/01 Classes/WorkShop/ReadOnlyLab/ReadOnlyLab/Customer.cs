using System.Collections.Generic;

namespace ReadOnlyLab
{
    public class Customer
    {
        public readonly List<Order> Orders = new List<Order>();
        public Customer()
        {
        }

        public void ApplyReduction()
        {
            // ... 
            Orders = new List<Order>();
        }
    }
}
