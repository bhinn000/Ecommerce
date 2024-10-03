using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Customer
    {
        //Private fields
        //We could not access below variable hence from main class , to access name , we need to access it Name
        private int customerId;
        private string name;
        private List<Order> orders;
        
        //public properties
        public int CustomerId
        {
            get { return customerId; }
            private set { customerId = value; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                  
                    throw new ArgumentException("Name cant be empty");
                name = value;
            }
        }

        public List<Order> Orders
        {
            get { return orders; }
            set
            {
                orders = value ?? new List<Order>(); //initializes if the order is empty
            }
        }

        public Customer(int customerId , string name , List<Order> orders) 
        {
            this.CustomerId= customerId;
            this.Name = name  ;
            this.Orders = orders ;

        }
    }
}
