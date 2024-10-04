using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class CustomisedOrder: Order
    {
        public CustomisedOrder(int orderId, List<Product> products)
        : base(orderId, products)
        { }

        //overriding abstract methods from parent class
        public override void CalcDeliveryDays()
        {
            Console.WriteLine("I need atleast 5 days for delivery inside valley and 9 days for outside");
        }
    }
}
