using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class FoodProducts : Product
    {
        public string Type { get; set; }

        public FoodProducts(int id , string name , int price ,string type):base(id, name ,price) 
            //base tell this.id of parent is same for this child
        {
            this.Type = type;
        }

    }
}
