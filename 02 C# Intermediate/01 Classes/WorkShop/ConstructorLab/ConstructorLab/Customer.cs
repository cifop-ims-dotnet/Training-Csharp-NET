using System;
using System.Collections.Generic;

namespace ConstructorLab
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;
        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(string name)
            :this()
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(name);

            this.Name = name;
        }
        public Customer(int id, string name)
            :this(name)
        {
            this.Id = id;
        }
    }
}
