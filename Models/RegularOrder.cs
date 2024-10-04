using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class RegularOrder : Order
    {
        public RegularOrder(int orderId, List<Product> products)
        : base(orderId, products)
        { }

        //overriding abstract methods from parent class
        public override void CalcDeliveryDays()
        {
            Console.WriteLine("I need atleast 2 days for delivery inside valley and 5 days for outside");
        }
    }
}
