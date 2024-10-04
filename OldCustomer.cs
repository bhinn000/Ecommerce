using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class OldCustomer : Customer
    {
        public OldCustomer(int customerId, string name, List<Order> orders):base(customerId , name , orders)
        {

        }

        public override void DisplayMessage()
        {
            Console.WriteLine($"Customer ID: {CustomerId}, Name: {Name}");
            Console.WriteLine("Enjoy exclusive discounts . You are our precious client , you had been supporting us since opening!");
        }
    }
}
