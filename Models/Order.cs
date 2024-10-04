using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public abstract class Order
    {
        public int OrderId { get; set; }
        public List<Product> Products { get; set; }

        public Order(int orderId , List<Product> products)
        {
            this.OrderId = orderId;
            this.Products = products ?? new List<Product>();
        }

        //abstract method for calculating delivery days
        public abstract void CalcDeliveryDays();
    }
}
