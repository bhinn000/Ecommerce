using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(int id, string name , int price) 
        {
            this.ProductId = id;
            this.Name = name;
            this.Price = price;
        }
    }
}
