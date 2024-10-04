using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class PhysicalProduct : Product
    {
        public int Weight { get; set; } 

        public PhysicalProduct(int id, string name, int price, int weight): base(id, name, price)
        {
            this.Weight = weight;
        }

        // Overriding the shipping cost calculation 
        public override decimal CalculateShippingCost()
        {
            return Weight * 0.5m; 
        }
    }
}
