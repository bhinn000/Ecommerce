using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Stationery: Product
    {
        //its added new properties
        public string CompartmentId {  get; set; }

        //constructor should/can add other variables (from parent)
        public Stationery(int id, string name, int price , string compartmentId): base(id, name, price)
        { 
            this.CompartmentId = compartmentId;
        }


    }
}
