using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            //customer.Orders = new List<Order>();
            customer.Id = 1;
            customer.Name = "Alice";

            var order = new Order();
            customer.Orders.Add(order);

            var secondCustomer = new Customer("Bob");
            var secondOrder = new Order();
            secondCustomer.Orders.Add(secondOrder);
        }
    }
}
