using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class DigitalProduct : Product
    {
        public string AccessUrl { get; set; } 

        public DigitalProduct(int id, string name, int price, string accessLink) : base(id, name, price)
        {
            this.AccessUrl = accessLink;
        }

        // Overriding the shipping cost calculation
        public override decimal CalculateShippingCost()
        {
            return 0; // No shipping cost for digital products
        }
    }
}
