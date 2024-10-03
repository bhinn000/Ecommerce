using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; } 

        public Customer(int customerId , string name , List<Order> orders) 
        {
            this.CustomerId= customerId;
            this.Name = name;
            this.Orders = orders ?? new List<Order>(); //initializes if the order is empty

        }
    }
}
