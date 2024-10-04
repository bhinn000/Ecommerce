using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Product
    {
        //private
        private int productId;
        private string name;
        private int price;

        //public
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                //also add to be started with ABC__
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Empty name");
                }
                name = value;
            }
        }

        public int Price
        {
            get { return price; }
            set
            {
                if (price < 0)
                {
                    throw new ArgumentException("Price cant be negative");
                }
                price = value;

            }
        }

        public Product(int id, string name , int price) 
        {
            this.ProductId = id;
            this.Name = name;
            this.Price = price;
        }

      
      
    }
}
