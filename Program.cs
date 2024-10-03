using System;
using System.Collections.Generic;

namespace Ecommerce.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parent class (for Product)
            Product product1 = new Product(1, "Radio", 1500);
            Product product2 = new Product(2, "Brush", 100);
            Product product3 = new Product(3, "Nail Paint", 50);
            Product product4 = new Product(4, "Multi Color Pen", 75);

            //Derived class (of Product)
            FoodProducts fp = new FoodProducts(11, "Noodles", 20 , "Veg");
            Stationery stationery = new Stationery(21, "Books", 500, "S_1001");

            Order order1 = new Order(7, new List<Product> { product1, product2 , fp});
            Order order2 =new Order(9, new List<Product>() { product3, product4 , stationery });

            Customer customer = new Customer(3, "Ram", new List<Order> { order1 , order2 });

            //display object details
            //you can also add console based on product type later
            Console.WriteLine($"Customer ID: {customer.CustomerId}");
            Console.WriteLine($"Customer Name: {customer.Name}");
            foreach (var ord in customer.Orders)
            {
                Console.WriteLine($"\nOrder ID: {ord.OrderId}");
                foreach (var prod in ord.Products)
                {
                    Console.WriteLine($"Product: {prod.Name}, Price: {prod.Price}");
                }
            }

            // Testing Encapsulation
            //customer.name = "Shyam"; // is not accessible as it is encapsulated , is private access
            customer.Name = "Shyam"; // Name is accessible as it has used Public , get and set
            Console.WriteLine($"\nUpdated Customer Name: {customer.Name}");
            //customer.Name = " "; //doesnt match with validation rule from 'Set' , so error

            //but if we need to access Order which has not applied the encapsulation , it can be accessed through public properties , directly
            order1.OrderId = 77;
            Console.WriteLine(order1.OrderId);

            //update Product Details
             product1.Name = "Phone"; //okay
             //product1.Price = -500;//give error as against set rule , but if there was no encapsulation , this would have been allowed 
        
        }
    }

}
