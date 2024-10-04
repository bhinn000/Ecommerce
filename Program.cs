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

            //3) Implementing Inheritance (base class features along with child class feature and also added in 'Order' list which expects 'Product'
            //Derived class (of Product) 
            FoodProducts fp = new FoodProducts(11, "Noodles", 20 , "Veg");
            Stationery stationery = new Stationery(21, "Books", 500, "S_1001");

            //4) Abstraction
            //As order class is abstract , you cant use it to instantiate
            //Order order1 = new Order(7, new List<Product> { product1, product2 , fp});
            //Order order2 =new Order(9, new List<Product>() { product3, product4 , stationery });

            //So this , abstraction
            //"Order" is abstract class and 'CustomisedOrder' and 'RegularOrder' is concrete class
            Order order1 = new CustomisedOrder(7, new List<Product> { product1, product2, fp });
            Order order2 = new RegularOrder(9, new List<Product>() { product3, product4 , stationery });


            Customer customer1 = new Customer(3, "Ram", new List<Order> { order1 , order2 });
            Customer customer2 = new Customer(4, "Sita", new List<Order> { order1, order2 }); 
            Customer customer3 = new OldCustomer(5, "Rita_Old", new List<Order> { order1, order2 });// for polymorphism , here is using abstraction concept too

            //display object details
            //you can also add console based on product type later
            Console.WriteLine($"Customer ID: {customer1.CustomerId}");
            Console.WriteLine($"Customer Name: {customer1.Name}");
            foreach (var ord in customer1.Orders)
            {
                Console.WriteLine($"\nOrder ID: {ord.OrderId}");
                foreach (var prod in ord.Products)
                {
                    Console.WriteLine($"Product: {prod.Name}, Price: {prod.Price}");
                }
                //this will also give different methods process
                Console.WriteLine("**Abstraction**");
                ord.CalcDeliveryDays();
            }

            // 1)  Testing Encapsulation
            //customer.name = "Shyam"; // is not accessible as it is encapsulated , is private access
            customer1.Name = "Shyam"; // Name is accessible as it has used Public , get and set
            Console.Write("\n**Encapsulation");
            Console.WriteLine($"\nUpdated Customer Name: {customer1.Name}");
            //customer.Name = " "; //doesnt match with validation rule from 'Set' , so error

            //but if we need to access Order which has not applied the encapsulation , it can be accessed through public properties , directly
            order1.OrderId = 77;
            Console.WriteLine(order1.OrderId);

            //update Product Details
             product1.Name = "Phone"; //okay
            //product1.Price = -500;//give error as against set rule , but if there was no encapsulation , this would have been allowed 

            //2) now to show polymorphism 
            List<Customer> customers = new List<Customer>
            {
                customer3,
                customer2
            };

            Console.WriteLine("\n**Polymorphism here**");
            foreach (var people in customers)
            {
                people.DisplayMessage(); // call the respective method based on the object type
            }

            //according to the task
            List<Product> products = new List<Product>
            {
                new PhysicalProduct(31, "Book", 700, 1), // Weight in kg
                new DigitalProduct(32, "Paid Podcast", 100, "www.imspodcast.com")
            };

            // Calculate shipping costs for each product (will give respective function)
            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.Name}, Shipping Cost: {product.CalculateShippingCost()}");
            }

        }
    }

}
